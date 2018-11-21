using FSImark.BL;
using FSImark.Data;

namespace FSImark.UndoRedo.FindDuplicates
{
	public class ExcelColumnIsKeyCmd : ICommand
	{
		public ExcelColumnIsKeyCmd(ModelFindDuplicates model, ExcelColumn column, bool value)
		{
			this.model = model;
			this.column = column;
            prevValue = column.IsKey;
			this.value = value;
		}

        private ModelFindDuplicates model;
        private ExcelColumn column;
		private readonly bool value;
		private readonly bool prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => $"Проверяется ли на соответствие значения из столбца '{column.Name}'"; } 

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
            column.IsKey = value;
            model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
            column.IsKey = prevValue;
            model.OnChanged();
		}
	}
}