using FSImark.BL;

namespace FSImark.UndoRedo.SumDuplicates
{
	public class IsMarkingDuplicatesCmd : ICommand
	{
		public IsMarkingDuplicatesCmd(ModelSumDuplicates model, bool value)
		{
			this.model = model;
			prevValue = model.Data.IsMarkingDuplicates;
			this.value = value;
		}

		private ModelSumDuplicates model;
		private readonly bool value;
		private readonly bool prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => "Выделять/не выделять дубликаты в файле Excel"; } 

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
			model.Data.IsMarkingDuplicates = value;

			model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
			model.Data.IsMarkingDuplicates = prevValue;

			model.OnChanged();
		}
	}
}