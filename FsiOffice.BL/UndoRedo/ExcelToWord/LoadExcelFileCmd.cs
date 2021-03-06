﻿using FSImark.BL;

namespace FSImark.UndoRedo.ExcelToWord
{
	public class LoadExcelFileCmd : ICommand
	{
		public LoadExcelFileCmd(ModelExcelToWord model, string value)
		{
			this.model = model;
			prevValue = model.Data.ExcelFilePath;
			this.value = value;
		}

		private ModelExcelToWord model;
		private readonly string value;
		private readonly string prevValue;

		/// <summary>
		/// Name for MenuItem
		/// </summary>
		public string Name { get => "Загрузка файла Excel"; } 

		/// <summary>
		/// Execute the command
		/// </summary>
		public void Execute()
		{
			if (!string.IsNullOrEmpty(value)) model.LoadExcelFile(value);
			else model.CloseExcelFile();

			model.OnChanged();
		}
		/// <summary>
		/// UnExecute the command
		/// </summary>
		public void UnExecute()
		{
			if (!string.IsNullOrEmpty(prevValue)) model.LoadExcelFile(prevValue);
			else model.CloseExcelFile();
			
			model.OnChanged();
		}
	}
}