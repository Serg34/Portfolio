using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using FSImark.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace FSImark.BL
{
    public sealed class ModelFindDuplicates : IDisposable
    {
        public ModelFindDuplicates()
        {
            Data = new DataFindDuplicates();
        }

        #region Fields
#if DEBUG
        private Excel.Application excelApp;
        private Excel.Workbook excelBook;
        private Excel._Worksheet excelOutputSheet;
#else
		private dynamic excelApp;
		private dynamic excelBook;
		private dynamic excelOutputSheet;
#endif
        private readonly System.Drawing.Color keyColor = System.Drawing.Color.FromArgb(120, 200, 120);
        private readonly System.Drawing.Color diffColor = System.Drawing.Color.FromArgb(255, 64, 64);
        #endregion

        #region Properties
        /// <summary>
        /// Name of output Excel sheet
        /// </summary>
        public string OutputSheetName { get => "Результат поиска дубликатов"; }
        /// <summary>
        /// Data conteiner
        /// </summary>
        public DataFindDuplicates Data { get; set; }

        /// <summary>
        /// <see cref="DataTable"/> from current Excel sheet
        /// </summary>
        public DataTable ExcelDataTable { get; private set; }

        /// <summary>
        /// Value of the progress of the main action for taskbar icon
        /// </summary>
        public double ProgressValue { get; private set; }
        /// <summary>
        /// Maximum of the progress of the main action for taskbar icon
        /// </summary>
        public double ProgressMax { get; private set; }
        #endregion

        #region Events
        /// <summary>
        /// Occurs when data changes
        /// </summary>
        public event EventHandler Changed = delegate { };
        /// <summary>
        /// Occurs when need to rewrite output Excel sheet 
        /// </summary>
        public event CancelEventHandler RewritingOutputSheet = delegate { };

        /// <summary>
        /// Occurs when the progress of the <see cref="FindDuplicates"/> moving
        /// </summary>
        public event EventHandler ProgressChanged = delegate { };
        /// <summary>
        /// Occurs when the progress of the <see cref="FindDuplicates"/> completed
        /// </summary>
        public event EventHandler ProgressCompleted = delegate { };
        #endregion

        #region Set data from view
        public void LoadExcelFile(string filePath)
        {
            try
            {
                CloseExcelFile();
                if (string.IsNullOrEmpty(filePath)) return;

                Data.ExcelFilePath = filePath;

                var sheetNames = ExcelHelper.GetSheets(filePath);
                Data.ExcelSheetNames.AddRange(sheetNames);

                if (sheetNames.Count > 0) LoadExcelSheet(sheetNames[0]);
                else ClearExcelSheets();

                Data.IsExcelFileLoaded = true;
            }
            catch
            {
                CloseExcelFile();
                throw;
            }
        }
        public void CloseExcelFile()
        {
            Data.ExcelFilePath = "";
            Data.IsExcelFileLoaded = false;
            ClearExcelSheets();
        }

        public void LoadExcelSheet(string sheetName)
        {
            try
            {
                if (string.IsNullOrEmpty(sheetName)) { ClearExcelSheets(); return; }

                ExcelDataTable = ExcelHelper.GetTable(Data.ExcelFilePath, sheetName);

                Data.ExcelCurrentSheetName = sheetName;

                Data.ExcelColumns.Clear();
                foreach (DataColumn col in ExcelDataTable.Columns)
                    Data.ExcelColumns.Add(new ExcelColumn(col.ColumnName));

                Data.IsExcelSheetLoaded = true;
            }
            catch
            {
                Data.IsExcelSheetLoaded = false;
                throw;
            }
        }
        public void ClearExcelSheets()
        {
            Data.ExcelCurrentSheetName = "";
            Data.ExcelSheetNames.Clear();

            ExcelDataTable?.Dispose();
            ExcelDataTable = null;

            Data.IsExcelSheetLoaded = false;
        }

        public void OnChanged() => Changed(this, EventArgs.Empty);
        #endregion

        #region Main action
        public void FindDuplicates()
        {
            try
            {
                CreateExcel();
                if (!TryCreateExcelOutputSheet()) return;

                var columnCount = ExcelDataTable.Columns.Count;
                CreateFirstHeaders(columnCount);

                bool[] isCompleted = new bool[ExcelDataTable.Rows.Count];
                int lastRowNum = 2;

                for (int row1 = 0; row1 < ExcelDataTable.Rows.Count; row1++)
                {
                    if (isCompleted[row1]) continue;
                    for (int col = 0; col < columnCount; col++)
                        excelOutputSheet.Cells[lastRowNum, col + 1] = ExcelDataTable.Rows[row1][col].ToString();

                    int mathesCount = 1;
                    for (int row2 = row1 + 1; row2 < ExcelDataTable.Rows.Count; row2++)
                    {
                        if (isCompleted[row2]) continue;
                        bool isMatches = true;
                        for (int col = 0; col < columnCount; col++)
                        {
                            var column = Data.ExcelColumns[ExcelDataTable.Columns[col].ColumnName];
                            if (!column.IsKey) continue;

                            string text1 = ExcelDataTable.Rows[row1][col].ToString();
                            string text2 = ExcelDataTable.Rows[row2][col].ToString();
                            if (!IsMatches(text1, text2, column.DeviationValue)) { isMatches = false; break; }
                        }
                        if (!isMatches) continue;
                        isCompleted[row1] = isCompleted[row2] = true;

                        CreateHeaders(columnCount, mathesCount);
                        SetValue(columnCount, lastRowNum, row1, mathesCount, row2);
                        mathesCount++;
                    }
                    isCompleted[row1] = true;
                    lastRowNum++;

                    ProgressValue = isCompleted.Count(c => c);
                    ProgressChanged(this, EventArgs.Empty);
                }
                excelApp.Visible = true;
            }
            catch
            {
                if (excelBook != null) excelBook.Close(SaveChanges: false);
                if (excelApp != null)
                {
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelApp);
                }
                throw;
            }
            finally { ProgressCompleted(this, EventArgs.Empty); }
        }

        private void CreateExcel()
        {
#if DEBUG
            excelApp = new Excel.Application { Visible = false };
#else
			excelApp = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
			excelApp.Visible = false;
#endif
            excelBook = excelApp.Workbooks.Open(Data.ExcelFilePath);
        }
        private bool TryCreateExcelOutputSheet()
        {
            var isContainsOutputSheetName = false;

            for (int i = 1; i <= excelBook.Sheets.Count; i++)
            {
                var excelSheet = excelBook.Sheets[i].Name;
                if (excelSheet == OutputSheetName)
                {
                    var e = new CancelEventArgs();
                    RewritingOutputSheet(this, e);
                    if (e.Cancel) return false;
                    else
                    {
                        excelBook.Sheets[i].Cells.ClearContents();
                        excelBook.Sheets[i].Cells.ClearFormats();
                        isContainsOutputSheetName = true;
                        break;
                    }
                }
            }
            if (!isContainsOutputSheetName)
            {
                Excel.Worksheet sheet;
                sheet = (Excel.Worksheet)excelBook.Worksheets.Add();
                sheet.Name = OutputSheetName;
            }

            excelOutputSheet = excelBook.Sheets[OutputSheetName];

            ProgressValue = 0;
            ProgressMax = ExcelDataTable.Rows.Count;

            return true;
        }
        private void CreateFirstHeaders(int columnCount)
        {
            for (int col = 0; col < columnCount; col++)
            {
                var column = Data.ExcelColumns[ExcelDataTable.Columns[col].ColumnName];
                Excel.Range cell = excelOutputSheet.Cells[1, col + 1];
                cell.Value = column.Name;
                if (column.IsKey && column.IsMarkedCell) cell.Interior.Color = keyColor;
                else if (!column.IsKey && column.IsMarkedCell) cell.Interior.Color = diffColor;
            }
        }
        private void CreateHeaders(int columnCount, int mathesCount)
        {
            if (excelOutputSheet.Cells[1, 1 + mathesCount * (columnCount + 1)].Value == null)
                for (int col = 0; col < columnCount; col++)
                {
                    var column = Data.ExcelColumns[ExcelDataTable.Columns[col].ColumnName];
                    var columnIndex = col + 1 + mathesCount * (columnCount + 1);
                    Excel.Range cell = excelOutputSheet.Cells[1, columnIndex];

                    cell.Value = column.Name;
                    if (column.IsMarkedCell && column.IsKey) cell.Interior.Color = keyColor;
                    if (column.IsMarkedCell && !column.IsKey) cell.Interior.Color = diffColor;
                }
        }
        private bool IsMatches(string text1, string text2, double tolerance)
        {
            string dec_sep = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            text1 = text1.Replace(",", dec_sep).Replace(".", dec_sep);
            text2 = text2.Replace(",", dec_sep).Replace(".", dec_sep);

            if (double.TryParse(text1, out var num1) && double.TryParse(text2, out var num2))
                return Math.Abs(num1 - num2) <= tolerance;
            else return text1 == text2;
        }
        private void SetValue(int columnCount, int lastRowNum, int row1, int mathesCount, int row2)
        {
            for (int col = 0; col < columnCount; col++)
            {
                var column = Data.ExcelColumns[ExcelDataTable.Columns[col].ColumnName];
                Excel.Range cell2 = excelOutputSheet.Cells[lastRowNum, col + 1 + mathesCount * (columnCount + 1)];

                var text2 = ExcelDataTable.Rows[row2][col].ToString();
                cell2.Value = text2;

                if (column.IsMarkedCell)
                {
                    var cell1 = excelOutputSheet.Cells[lastRowNum, col + 1];
                    var text1 = ExcelDataTable.Rows[row1][col].ToString();

                    if (column.IsKey)
                        cell1.Interior.Color = cell2.Interior.Color = keyColor;
                    else if (!column.IsKey && !IsMatches(text1, text2, column.DeviationValue))
                        cell1.Interior.Color = cell2.Interior.Color = diffColor;
                }
            }
        }
        #endregion

        #region Service
        public void Dispose()
        {
            ExcelDataTable?.Dispose();
        }
        #endregion
    }
}
