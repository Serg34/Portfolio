using FSImark.BL;

namespace FSImark.UndoRedo.SumDuplicates
{
	public class OutputColNameCmd : ICommand
	{
		public OutputColNameCmd(ModelSumDuplicates model, string value)
		{
			this.model = model;
			prevValue = model.Data.OutputColName;
			this.value = value;
		}

		private ModelSumDuplicates model;
		private readonly string value;
		private readonly string prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => "Выбор столбца с количеством"; } 

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
			model.Data.OutputColName = value;

			model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
			model.Data.OutputColName = prevValue;

			model.OnChanged();
		}
	}
}