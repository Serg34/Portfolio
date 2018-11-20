using FSImark.BL;

namespace FSImark.UndoRedo.ExcelToWord
{
	public class RepeatCountInWordCountCmd : ICommand
	{
		public RepeatCountInWordCountCmd(ModelExcelToWord model, int value)
		{
			this.model = model;
			prevValue = model.Data.RepeatCount;
			this.value = value;
		}

		private ModelExcelToWord model;
		private readonly int value;
		private readonly int prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => "Изменение количества повторов в файлах Word"; } 

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
			model.Data.RepeatCount = value;

			model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
			model.Data.RepeatCount = prevValue;
			
			model.OnChanged();
		}
	}
}