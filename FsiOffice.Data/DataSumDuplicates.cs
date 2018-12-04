using System;
using System.Collections.Generic;

namespace FSImark.Data
{
	[Serializable]
	public class DataSumDuplicates
	{
		public DataSumDuplicates()
		{
			ExcelSheetNames = new List<string>();
			ExcelColumnsNames = new List<string>();
		}

		public string ExcelFilePath { get; set; }
		public bool IsExcelFileLoaded { get; set; }

		public string ExcelCurrentSheetName { get; set; }
		public List<string> ExcelSheetNames { get; }
		public bool IsExcelSheetLoaded { get; set; }

        /// <summary>
        /// Name of Excel output column
        /// </summary>
		public string OutputColName { get; set; }

        /// <summary>
        /// List of Excel column's names from current woorksheet for selecting <see cref="OutputColName"/>
        /// </summary>
		public List<string> ExcelColumnsNames { get; }
        /// <summary>
        /// Indicates whether to mark duplicates in output Excel woorksheet
        /// </summary>
		public bool IsMarkingDuplicates { get; set; }
	}
}
