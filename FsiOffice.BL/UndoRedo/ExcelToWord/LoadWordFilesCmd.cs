using FSImark.BL;

namespace FSImark.UndoRedo.ExcelToWord
{
	public class LoadWordFilesCmd : ICommand
	{
		public LoadWordFilesCmd(ModelExcelToWord model, string[] value)
		{
			this.model = model;
			prevValue = model.Data.WordFilePaths?.ToArray();
			this.value = value;
		}

		private ModelExcelToWord model;
		private readonly string[] value;
		private readonly string[] prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => "Загрузка шаблонов Word"; } 

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
			model.ReloadWordFiles(value);

			model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
			model.ReloadWordFiles(prevValue);
						
			model.OnChanged();
		}
	}
}