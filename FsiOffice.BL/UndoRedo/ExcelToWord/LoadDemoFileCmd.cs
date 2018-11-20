using FSImark.BL;
using FSImark.Data;
using FSImark.Services;

namespace FSImark.UndoRedo.ExcelToWord
{
	public class LoadDemoFileCmd : ICommand
	{
		public LoadDemoFileCmd(ModelExcelToWord model, DataExcelToWord value)
		{
			this.model = model;
			prevValue = serializer.DeepCopy(model.Data);
            this.value = serializer.DeepCopy(value);
        }

		/// <summary>
		/// Serializer for get and set data copy 
		/// </summary>
		private BinarySerializer serializer = new BinarySerializer();
		private ModelExcelToWord model;
		private readonly DataExcelToWord value;
		private readonly DataExcelToWord prevValue;

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