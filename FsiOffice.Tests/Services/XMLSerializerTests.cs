using FSImark.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSImark.Services.Tests
{
    [TestClass()]
	public class XMLSerializerTests
	{
		private readonly XMLSerializer serializer = new XMLSerializer();
		[TestMethod()]
		public void SaveAndLoadTest()
		{
			var obj = new DataExcelToWord { ExcelFilePath = "Value" };

			var filePath = "test.xml";

			serializer.Save(filePath, obj);

			Assert.IsTrue(System.IO.File.Exists(filePath));

			var loadObj = serializer.Load<DataExcelToWord>(filePath);

			Assert.AreEqual(loadObj.ExcelFilePath, "Value");

			System.IO.File.Delete(filePath);
		}
	}
}