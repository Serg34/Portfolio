namespace FSImark.UI
{
	/// <summary>
	/// Helper for open and save Excel files
	/// </summary>
	public class ExcelDocumentInfo : IDocumentInfo
	{
		public string NewDocText { get => null; }
		public string Ext { get => null; }
		public string LowerDocText { get => "файл Excel"; }
		public bool MultiOpen { get => false; }

		public string Filter
		{
			get => "Файлы Excel (*.xls, *.xlsx, *.xlsm)|*.xls;*.xlsx;*.xlsm";
		}
	}
	/// <summary>
	/// Helper for open and save Word files
	/// </summary>
	public class WordDocumentInfo : IDocumentInfo
	{
		public string NewDocText { get => null; }
		public string Ext { get => null; }
		public string LowerDocText { get => "шаблоны Word"; }
		public bool MultiOpen { get => true; }

		public string Filter
		{
			get => "Шаблоны Word (*.dot, *.dotx)|*.dot;*.dotx";
		}
	}
}
