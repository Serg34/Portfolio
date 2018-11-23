using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSImark.BL.Tests
{
    [TestClass()]
    public class ModelExcelToWordTests
    {
        [TestMethod()]
        public void CloseExcelFileTest()
        {
            using (var model = new ModelExcelToWord())
            {
                model.Data.IsExcelFileLoaded = true;
                model.Data.ExcelFilePath = "test";

                FillSheets(model);

                model.CloseExcelFile();
                Assert.IsFalse(model.Data.IsExcelFileLoaded);
                Assert.IsTrue(string.IsNullOrEmpty(model.Data.ExcelFilePath));

                CheckClearExcelSheets(model);
            }
        }

        [TestMethod()]
        public void ClearExcelSheetsTest()
        {
            using (var model = new ModelExcelToWord())
            {
                FillSheets(model);

                model.ClearExcelSheets();
                CheckClearExcelSheets(model);
            }
        }

        private void FillSheets(ModelExcelToWord model)
        {
            model.Data.ExcelSheetNames.Add("Test");
            model.Data.ExcelCurrentSheetName = "Test";
        }
        private void CheckClearExcelSheets(ModelExcelToWord model)
        {
            Assert.IsFalse(model.Data.IsExcelSheetLoaded);

            Assert.IsTrue(model.Data.ExcelSheetNames.Count == 0);
            Assert.IsTrue(string.IsNullOrEmpty(model.Data.ExcelCurrentSheetName));
        }
    }
}