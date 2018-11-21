using FSImark.BL;
using FSImark.Data;
using FSImark.Services;

namespace FSImark.UndoRedo.FindDuplicates
{
	public class LoadDemoFileCmd : ICommand
	{
		public LoadDemoFileCmd(ModelFindDuplicates model, DataFindDuplicates value)
		{
			this.model = model;
			prevValue = serializer.DeepCopy(model.Data);
			this.value = serializer.DeepCopy(value);
		}

		/// <summary>
		/// Serializer for get and set data copy 
		/// </summary>
		private BinarySerializer serializer = new BinarySerializer();
		private ModelFindDuplicates model;
		private readonly DataFindDuplicates value;
		private readonly DataFindDuplicates prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => "Загрузка демо примера"; }

        /// <summary>
        /// Execute the command
        /// </summary>
        public void Execute()
        {
            model.LoadExcelFile(value.ExcelFilePath);
            model.LoadExcelSheet(value.ExcelCurrentSheetName);
            model.Data = serializer.DeepCopy(value);

            model.OnChanged();
        }
        /// <summary>
        /// UnExecute the command
        /// </summary>
        public void UnExecute()
        {
            model.LoadExcelFile(prevValue.ExcelFilePath);
            model.LoadExcelSheet(prevValue.ExcelCurrentSheetName);
            model.Data = serializer.DeepCopy(prevValue);

            model.OnChanged();
        }
    }
}