using System;
using System.Collections.Generic;

namespace FSImark.Data
{
    [Serializable]
    public class DataExcelToWord
    {
        public DataExcelToWord()
        {
            ExcelSheetNames = new List<string>();
            WordFilePaths = new List<string>();
            RepeatInWordCount = 1;
        }

        public string ExcelFilePath { get; set; }
        public bool IsExcelFileLoaded { get; set; }

        public string ExcelCurrentSheetName { get; set; }
        public List<string> ExcelSheetNames { get; }
        public bool IsExcelSheetLoaded { get; set; }

        public List<string> WordFilePaths { get; }
        public bool IsOutputFolder { get => !string.IsNullOrEmpty(OutputFolderPath); }
        public string OutputFolderPath { get; set; }
        /// <summary>
        /// Count of repeat value in Word
        /// </summary>
		public int RepeatInWordCount { get; set; }
    }
}
