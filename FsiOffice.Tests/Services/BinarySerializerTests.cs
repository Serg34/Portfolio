using FSImark.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FSImark.Services.Tests
{
	[TestClass()]
	public class BinarySerializerTests
	{
		private readonly BinarySerializer serializer = new BinarySerializer();
		[TestMethod()]
		public void DeepCopyTest()
		{
			var obj = new DataExcelToWord { ExcelFilePath = "Value" };

			var copy = serializer.DeepCopy(obj);

			obj.ExcelFilePath = "New value";

			Assert.AreEqual(copy.ExcelFilePath, "Value");
		}

		[TestMethod()]
		public void SaveAndLoadTest()
		{
			var obj = new DataExcelToWord { ExcelFilePath = "Value" };

			var filePath = "test.bnr";

			serializer.Save(filePath, obj);

			Assert.IsTrue(System.IO.File.Exists(filePath));

			var loadObj = serializer.Load<DataExcelToWord>(filePath);

			Assert.AreEqual(loadObj.ExcelFilePath, "Value");

			System.IO.File.Delete(filePath);
		}
	}
}