using FSImark.BL;

namespace FSImark.UndoRedo.ExcelToWord
{
	public class OutputFolderPathCmd : ICommand
	{
		public OutputFolderPathCmd(ModelExcelToWord model, string value)
		{
			this.model = model;
			prevValue = model.Data.OutputFolderPath;
			this.value = value;
		}

		private ModelExcelToWord model;
		private readonly string value;
		private readonly string prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => "Выбор папки для сохранения результатов"; }

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
			model.Data.OutputFolderPath = value;

			model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
			model.Data.OutputFolderPath = prevValue;

			model.OnChanged();
		}
	}
}