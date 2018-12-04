using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using FSImark.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace FSImark.BL
{
    public class ModelSumDuplicates : IDisposable
    {
        public ModelSumDuplicates()
        {
            Data = new DataSumDuplicates();
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
        #endregion

        #region Properties
        /// <summary>
        /// Name of output Excel sheet
        /// </summary>
        public string OutputSheetName { get => "Результат суммы дубликатов"; }

        /// <summary>
        /// Data conteiner
        /// </summary>
        public DataSumDuplicates Data { get; set; }

        /// <summary>
        /// <see cref="DataTable"/> from current Excel sheet
        /// </summary>
        public DataTable ExcelDataTable { get; private set; }

        /// <summary>
        ///  Value of the progress of the main action for taskbar icon
        /// </summary>
        public double ProgressValue { get; private set; }
        /// <summary>
        ///  Maximum of the progress of the main action for taskbar icon
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
        /// Occurs when the progress of the <see cref="SumDuplicates"/> moving
        /// </summary>
        public event EventHandler ProgressChanged = delegate { };
        /// <summary>
        /// Occurs when the progress of the <see cref="SumDuplicates"/> completed
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
            catch (Exception ex)
            {
                CloseExcelFile();
                throw ex;
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

                Data.ExcelColumnsNames.Clear();
                foreach (DataColumn col in ExcelDataTable.Columns)
                    Data.ExcelColumnsNames.Add(col.ColumnName);

                if (Data.ExcelColumnsNames.Count > 0) Data.OutputColName = Data.ExcelColumnsNames[0];
                else Data.OutputColName = "";

                Data.ExcelCurrentSheetName = sheetName;
                Data.IsExcelSheetLoaded = true;
            }
            catch (Exception ex)
            {
                Data.IsExcelSheetLoaded = false;
                throw ex;
            }
        }
        public void ClearExcelSheets()
        {
            Data.ExcelCurrentSheetName = "";
            Data.ExcelSheetNames.Clear();

            Data.OutputColName = "";
            Data.ExcelColumnsNames.Clear();

            ExcelDataTable?.Dispose();
            ExcelDataTable = null;

            Data.IsExcelSheetLoaded = false;
        }

        public void OnChanged() => Changed(this, EventArgs.Empty);
        #endregion

        #region Main action
        public void SumDuplicates()
        {
            try
            {
                CreateExcel();
                if (!TryCreateExcelOutputSheet()) return;

                bool[] isCompleted = new bool[ExcelDataTable.Rows.Count];
                int lastRowNum = 2;

                for (int row1Num = 0; row1Num < ExcelDataTable.Rows.Count; row1Num++)
                {
                    if (isCompleted[row1Num]) continue;
                    double sum = double.Parse(ExcelDataTable.Rows[row1Num][Data.OutputColName].ToString());
                    bool row1IsDuplicate = false;

                    for (int row2Num = row1Num + 1; row2Num < ExcelDataTable.Rows.Count; row2Num++)
                    {
                        if (isCompleted[row2Num] || !IsMatche(row1Num, row2Num)) continue;
                        if (!isCompleted[row1Num]) ProgressValue++;
                        if (!isCompleted[row2Num]) ProgressValue++;
                        row1IsDuplicate = true; isCompleted[row1Num] = isCompleted[row2Num] = true;
                        sum += double.Parse(ExcelDataTable.Rows[row2Num][Data.OutputColName].ToString());
                    }

                    SetValueToCell(lastRowNum, row1Num, sum, row1IsDuplicate);

                    isCompleted[row1Num] = true;
                    lastRowNum++;
                    ProgressChanged(this, EventArgs.Empty);
                }
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                if (excelBook != null) excelBook.Close(SaveChanges: false);
                if (excelApp != null)
                {
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelApp);
                }
                throw ex;
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

            for (int i = 0; i < ExcelDataTable.Columns.Count; i++)
            {
                var colName = ExcelDataTable.Columns[i].ColumnName;
                if (colName == Data.OutputColName) excelOutputSheet.Cells[1, i + 1] = $"Итоги по столбцу '{colName}'";
                else excelOutputSheet.Cells[1, i + 1] = colName;
            }
            ProgressValue = 0;
            ProgressMax = ExcelDataTable.Rows.Count;

            return true;
        }

        private bool IsMatche(int row1, int row2)
        {
            for (int col = 0; col < ExcelDataTable.Columns.Count; col++)
            {
                if (ExcelDataTable.Columns[col].ColumnName == Data.OutputColName) continue;
                if (!ExcelDataTable.Rows[row1][col].ToString().Equals(ExcelDataTable.Rows[row2][col].ToString()))
                    return false;
            }
            return true;
        }

        private void SetValueToCell(int lastRowNum, int row1Num, double sum, bool row1IsDuplicate)
        {
            for (int col = 0; col < ExcelDataTable.Columns.Count; col++)
            {
                Excel.Range cell = excelOutputSheet.Cells[lastRowNum, col + 1];

                if (ExcelDataTable.Columns[col].ColumnName == Data.OutputColName) cell.Value = sum;
                else cell.Value = ExcelDataTable.Rows[row1Num][col].ToString();

                //paint the cell if necessary
                if (row1IsDuplicate && Data.IsMarkingDuplicates) cell.Interior.Color = Color.FromArgb(120, 200, 120);
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
