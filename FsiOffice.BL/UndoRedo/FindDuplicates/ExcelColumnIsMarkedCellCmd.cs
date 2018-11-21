using FSImark.BL;
using FSImark.Data;

namespace FSImark.UndoRedo.FindDuplicates
{
	public class ExcelColumnIsMarkedCellCmd : ICommand
	{
		public ExcelColumnIsMarkedCellCmd(ModelFindDuplicates model, ExcelColumn column, bool value)
		{
			this.model = model;
			this.column = column;
            prevValue = column.IsMarkedCell;
			this.value = value;
		}

        private ModelFindDuplicates model;
        private ExcelColumn column;
		private readonly bool value;
		private readonly bool prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => $"Подсвечивать ли ячейки в столбце '{column.Name}'"; } 

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
            column.IsMarkedCell = value;
            model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
            column.IsMarkedCell = prevValue;
            model.OnChanged();
		}
	}
}