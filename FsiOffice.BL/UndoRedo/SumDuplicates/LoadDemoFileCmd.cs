using FSImark.BL;
using FSImark.Data;
using FSImark.Services;

namespace FSImark.UndoRedo.SumDuplicates
{
	public class LoadDemoFileCmd : ICommand
	{
		public LoadDemoFileCmd(ModelSumDuplicates model, DataSumDuplicates value)
		{
			this.model = model;
			prevValue = serializer.DeepCopy(model.Data);
            this.value = serializer.DeepCopy(value);
        }

		/// <summary>
		/// Serializer for get and set data copy 
		/// </summary>
		private BinarySerializer serializer = new BinarySerializer();
		private ModelSumDuplicates model;
		private readonly DataSumDuplicates value;
		private readonly DataSumDuplicates prevValue;

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