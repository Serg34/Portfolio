using FSImark.Data;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace FSImark.BL
{
    public sealed class ModelExcelToWord : IDisposable
    {
        public ModelExcelToWord()
        {
            Data = new DataExcelToWord();
        }

        #region Fields
#if DEBUG
        private Word.Application wordApp;
#else
		private dynamic wordApp;
#endif
        #endregion

        #region Properties
        /// <summary>
        /// Data conteiner
        /// </summary>
        public DataExcelToWord Data { get; set; }
        /// <summary>
        /// <see cref="DataTable"/> from current Excel sheet
        /// </summary>
        public DataTable ExcelDataTable { get; private set; }

        /// <summary>
        /// The progress value of the main action for the taskbar icon
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
        /// Occurs when the progress of the <see cref="CopyExcelToWord"/> moving
        /// </summary>
        public event EventHandler ProgressChanged = delegate { };
        /// <summary>
        /// Occurs when the progress of the <see cref="CopyExcelToWord"/> completed
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
        public void ReloadWordFiles(string[] fileNames)
        {
            Data.WordFilePaths.Clear();
            if (fileNames != null) Data.WordFilePaths.AddRange(fileNames);
        }

        public void OnChanged() => Changed(this, EventArgs.Empty);
        #endregion

        #region Main action
        private void CreateWord()
        {
            ProgressValue = 0;
            ProgressMax = Data.WordFilePaths.Count * ExcelDataTable.Rows.Count;

#if DEBUG
            wordApp = new Word.Application { Visible = false };
#else
			wordApp = Activator.CreateInstance(Type.GetTypeFromProgID("Word.Application"));
			wordApp.Visible = false;
#endif
        }

        public void CopyExcelToWord()
        {
            try
            {
                CreateWord();

                float appVersion = float.Parse(wordApp.Version.ToString(), CultureInfo.InvariantCulture);

                foreach (var filePath in Data.WordFilePaths)
                    foreach (DataRow row in ExcelDataTable.Rows)
                    {
                        dynamic wordDoc;
                        object template = filePath;
                        wordDoc = wordApp.Documents.Add(ref template);

                        foreach (DataColumn col in ExcelDataTable.Columns)
                            for (int matchIndex = 0; matchIndex < Data.RepeatInWordCount; matchIndex++)
                                SetDataToWord(row, wordDoc, col, matchIndex);

                        var fileEnd = row[0].ToString();
                        fileEnd = fileEnd.Replace("\\", "_").Replace("/", "_");
                        fileEnd = Remove(fileEnd, new string[] { "\"", "|", ":", "?", "*", "<", ">" });
                        var fileFullPath = $"{Data.OutputFolderPath}\\{Path.GetFileNameWithoutExtension(filePath)}_{fileEnd}.doc";

                        if (appVersion < 14) wordDoc.SaveAs(fileFullPath, AddToRecentFiles: false);
                        else wordDoc.SaveAs2(fileFullPath, AddToRecentFiles: false);
                        wordDoc.Close();

                        ProgressValue++;
                        ProgressChanged(this, EventArgs.Empty);
                    }
            }
            finally
            {
                if (wordApp != null)
                {
                    wordApp.Quit();
                    ProgressCompleted(this, EventArgs.Empty);
                }
            }
        }

        private void SetDataToWord(DataRow row, dynamic wordDoc, DataColumn col, int matchIndex)
        {
            if (col.ColumnName.Contains("«") && col.ColumnName.Contains("»")
                && DateTime.TryParse(row[col].ToString(), out var date))
            {
                var name = col.ColumnName.Replace("«", "").Replace("»", "");
                if (matchIndex > 0) name += matchIndex.ToString();

				var ru = CultureInfo.GetCultureInfo("ru-RU");
                var day = date.Day.ToString("D2");
				var month = ru.DateTimeFormat.MonthGenitiveNames[date.Month];
                var year = date.Year.ToString();
                SetTextToWordBookmark(wordDoc, name, $"«{day}» {month} {year}г.");
            }
            else
            {
                var mark = col.ColumnName;
                if (matchIndex > 0) mark += matchIndex.ToString();
                var text = row[col].ToString();
                SetTextToWordBookmark(wordDoc, mark, text);
            }
        }

        private void SetTextToWordBookmark(Word.Document wordDoc, string bookmark, string text)
        {
            object mark = bookmark;
            try
            {
                Word.Range bookmarkRange = wordDoc.Bookmarks.get_Item(ref mark).Range;
                bookmarkRange.Text = text;
            }
            catch { }
        }

        private string Remove(string str, params string[] args)
        {
            foreach (var a in args) str = str.Replace(a, "");
            return str;
        }
        #endregion

        #region Service
        public void Dispose() => ExcelDataTable?.Dispose();
        #endregion
    }
}
