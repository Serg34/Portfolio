using FSImark.BL;
using FSImark.Data;

namespace FSImark.UndoRedo.FindDuplicates
{
	public class ExcelColumnDeviationValueCmd : ICommand
	{
		public ExcelColumnDeviationValueCmd(ModelFindDuplicates model, ExcelColumn column, double value)
		{
			this.model = model;
			this.column = column;
            prevValue = column.DeviationValue;
			this.value = value;
		}

        private readonly ModelFindDuplicates model;
        private readonly ExcelColumn column;
		private readonly double value;
		private readonly double prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => $"Отклонения по столбцу '{column.Name}', в пределах которых два различных числа считаются равными"; } 

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
            column.DeviationValue = value;
            model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
            column.DeviationValue = prevValue;
            model.OnChanged();
		}
	}
}