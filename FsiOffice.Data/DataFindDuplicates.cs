using System;
using System.Collections.Generic;

namespace FSImark.Data
{
    [Serializable]
    public class DataFindDuplicates
    {
        public DataFindDuplicates()
        {
            ExcelSheetNames = new List<string>();
            ExcelColumns = new ExcelColumnList();
        }

        public string ExcelFilePath { get; set; }
        public bool IsExcelFileLoaded { get; set; }

        public string ExcelCurrentSheetName { get; set; }
        public List<string> ExcelSheetNames { get; }
        public bool IsExcelSheetLoaded { get; set; }
        /// <summary>
        /// List of wrapper of the Excel сolumns 
        /// </summary>
        public ExcelColumnList ExcelColumns { get; }
    }

    /// <summary>
    /// Wrapper of the Excel сolumn
    /// </summary>
	[Serializable]
    public sealed class ExcelColumn
    {
        public ExcelColumn(string name)
        {
            Name = name;
        }
        public string Name { get; }
        /// <summary>
        /// Indicates whether the column is involved in the duplicate search
        /// </summary>
		public bool IsKey { get; set; }
        /// <summary>
        /// Indicates whether to mark duplicates in the output Excel worksheet
        /// </summary>
		public bool IsMarkedCell { get; set; }
        /// <summary>
        /// Deviations within which two distinct numbers are considered equal
        /// </summary>
        public double DeviationValue { get; set; }
    }
    /// <summary>
    /// List of wrapper of the Excel сolumns 
    /// </summary>
    [Serializable]
    public sealed class ExcelColumnList : List<ExcelColumn>
    {
        public ExcelColumn this[string name]
        {
            get
            {
                foreach (var col in this)
                    if (col.Name == name) return col;

                return null;
            }
        }
    }
}
