using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
#if DEBUG
using Excel = Microsoft.Office.Interop.Excel;
#else
using System;
#endif

namespace FSImark.BL
{
	public static class ExcelHelper
	{
		public static List<string> GetSheets(string excelFilePath)
		{
			#region Create Excel
#if DEBUG
			Excel.Application excelApp = null;
			Excel.Workbook excelBook = null;
			try
			{
				excelApp = new Excel.Application { Visible = false };
#else
			dynamic excelApp = null;
			dynamic excelBook = null;
			try
			{
				excelApp = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
				excelApp.Visible = false;
#endif
				#endregion
				excelBook = excelApp.Workbooks.Open(excelFilePath, ReadOnly: true);

				var result = new List<string>();
				for (int i = 1; i <= excelBook.Sheets.Count; i++)
					result.Add(excelBook.Sheets[i].Name);

				return result;
			}
			finally
			{
				if (excelBook != null) excelBook.Close(SaveChanges: false);
				if (excelApp != null)
				{
					excelApp.Quit();
					System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelApp);
				}
			}
		}

		public static DataTable GetTable(string excelFilePath, string sheetName)
		{
			DataTable result = null;
			#region Create Excel
#if DEBUG
			Excel.Application excelApp = null;
			Excel.Workbook excelBook = null;
			try
			{
				excelApp = new Excel.Application { Visible = false };
#else
			dynamic excelApp = null;
			dynamic excelBook = null;
			try
			{
				excelApp = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
				excelApp.Visible = false;
#endif
				#endregion
				excelBook = excelApp.Workbooks.Open(excelFilePath, ReadOnly: true);

				using (var cnnTC = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {excelFilePath};Extended Properties=\"Excel 12.0 Xml;HDR=YES\""))
				using (var dataADapter = new OleDbDataAdapter($"SELECT * FROM [{sheetName}$]", cnnTC))
				{
					result = new DataTable();
					dataADapter.Fill(result);
				}

				return result;
			}
			catch
			{
				result?.Dispose();
				throw;
			}
			finally
			{
				if (excelBook != null) excelBook.Close(SaveChanges: false);
				if (excelApp != null)
				{
					excelApp.Quit();
					System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelApp);
				}
			}
		}
	}
}
