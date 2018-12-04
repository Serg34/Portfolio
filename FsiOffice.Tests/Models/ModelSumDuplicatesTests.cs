using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSImark.BL.Tests
{
    [TestClass()]
	public class ModelSumDuplicatesTests
	{
		[TestMethod()]
		public void CloseExcelFileTest()
		{
			var model = new ModelSumDuplicates();
			model.Data.IsExcelFileLoaded = true;
			model.Data.ExcelFilePath = "test";

			FillSheets(model);

			model.CloseExcelFile();
			Assert.IsFalse(model.Data.IsExcelFileLoaded);
			Assert.IsTrue(string.IsNullOrEmpty(model.Data.ExcelFilePath));

			CheckClearExcelSheets(model);
		}

		[TestMethod()]
		public void ClearExcelSheetsTest()
		{
			var model = new ModelSumDuplicates();
			FillSheets(model);

			model.ClearExcelSheets();
			CheckClearExcelSheets(model);
		}

		private void FillSheets(ModelSumDuplicates model)
		{
			model.Data.ExcelSheetNames.Add("Test");
			model.Data.ExcelCurrentSheetName = "Test";

			model.Data.OutputColName = "Test";
		}
		private void CheckClearExcelSheets(ModelSumDuplicates model)
		{
			Assert.IsFalse(model.Data.IsExcelSheetLoaded);

			Assert.IsTrue(model.Data.ExcelSheetNames.Count == 0);
			Assert.IsTrue(string.IsNullOrEmpty(model.Data.ExcelCurrentSheetName));

			Assert.IsTrue(model.Data.ExcelColumnsNames.Count == 0);
			Assert.IsTrue(string.IsNullOrEmpty(model.Data.OutputColName));
		}
	}
}