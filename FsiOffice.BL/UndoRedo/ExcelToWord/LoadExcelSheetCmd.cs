using FSImark.BL;

namespace FSImark.UndoRedo.ExcelToWord
{
	public class LoadExcelSheetCmd : ICommand
	{
		public LoadExcelSheetCmd(ModelExcelToWord model, string value)
		{
			this.model = model;
			prevValue = model.Data.ExcelCurrentSheetName;
			this.value = value;
		}

		private ModelExcelToWord model;
		private readonly string value;
		private readonly string prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => "Загрузка листа Excel"; } 

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
			if (string.IsNullOrEmpty(value)) model.ClearExcelSheets();
			else model.LoadExcelSheet(value);

			model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
			if (string.IsNullOrEmpty(prevValue)) model.ClearExcelSheets();
			else model.LoadExcelSheet(prevValue);

			model.OnChanged();
		}
	}
}