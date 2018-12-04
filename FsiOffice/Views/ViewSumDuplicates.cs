using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FSImark.BL;
using FSImark.UndoRedo;
using FSImark.UndoRedo.SumDuplicates;

namespace FSImark.UI
{
	[MainPanel("Суммировать дубликаты в EXCEL")]
	public partial class ViewSumDuplicates : UserControl
	{
		public ViewSumDuplicates()
		{
			try
			{
#if DEBUG
				isDebug = true;
#else
				isDebug = false;
#endif
				InitializeComponent();

				LoadUndo();

				model = new ModelSumDuplicates();

				model.Changed += Rebuild;
				model.RewritingOutputSheet += TryRewriteDuplicateSheet;
				model.ProgressChanged += ProgressReportChange;
				model.ProgressCompleted += ProgressReportComplete;
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}

		#region Fields
		private IMessageService messageService = new MessageService();

		private ModelSumDuplicates model;
		private UndoRedoManager undoManager = new UndoRedoManager();

		private bool isRebuilding = false;
		private bool isDebug;
        #endregion

        #region Get data from model
        private void Rebuild(object sender, EventArgs e)
		{
			try
			{
				isRebuilding = true;

				if (model.Data.IsExcelFileLoaded)
				{
					lbExcelFileName.Text = System.IO.Path.GetFileNameWithoutExtension(model.Data.ExcelFilePath);
					toolTip.SetToolTip(lbExcelFileName, model.Data.ExcelFilePath);
				}
				else
				{
					lbExcelFileName.Text = "Файл не загружен";
					toolTip.SetToolTip(lbExcelFileName, "");
				}

				lbExcelCurrentSheetName.Visible = cbExcelCurrentSheetName.Visible = model.Data.IsExcelFileLoaded;

				cbExcelCurrentSheetName.DataSource = model.Data.ExcelSheetNames.ToArray();
				cbExcelCurrentSheetName.Text = model.Data.ExcelCurrentSheetName;

				dgvExcelDataTable.DataSource = model.ExcelDataTable;
				dgvExcelDataTable.Visible = model.Data.IsExcelSheetLoaded;
				SetAutoHeight(dgvExcelDataTable);
				
				lbNameColumnSumDuplicates.Visible = cbSumColName.Visible = model.Data.IsExcelFileLoaded;

				cbSumColName.DataSource = model.Data.ExcelColumnsNames.ToArray();
				cbSumColName.Text = model.Data.OutputColName;

				chbIsMarkingDuplicates.Checked = model.Data.IsMarkingDuplicates;
				chbIsMarkingDuplicates.Visible = model.Data.IsExcelSheetLoaded;

                //RebuildUndo. (async for correct background of btUndo and btRedo)
                System.Threading.Tasks.Task.Factory.StartNew(() => Invoke(new Action(() => RebuildUndo())));
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
			finally { isRebuilding = false; }
		}
        #endregion
        
        #region Set data to model
        private void btLoadExcelFile_Click(object sender, EventArgs e)
		{
			try
			{
				var fileManager = new FileManager(new ExcelDocumentInfo());
				var paths = fileManager.GetOpeningFilePathsByDialog();
				if (paths != null)
				{
					var fileName = paths[0];
					var cmd = new LoadExcelFileCmd(model, fileName);
					undoManager.Execute(cmd);
				}
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		private void cbExcelCurrentSheetName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isRebuilding) return;
			try
			{
				var value = cbExcelCurrentSheetName.Text;
				if (model.Data.ExcelCurrentSheetName == value) return;
				var cmd = new LoadExcelSheetCmd(model, value);
				undoManager.Execute(cmd);
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		private void cbSumColName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isRebuilding) return;
			try
			{
				var value = cbSumColName.Text;
				if (model.Data.OutputColName == value) return;
				var cmd = new OutputColNameCmd(model, value);
				undoManager.Execute(cmd);
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		private void chbIsMarkingDuplicates_CheckedChanged(object sender, EventArgs e)
		{
			if (isRebuilding) return;
			try
			{
				var value = !model.Data.IsMarkingDuplicates;
				var cmd = new IsMarkingDuplicatesCmd(model, value);
				undoManager.Execute(cmd);
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		
		private void btDemoLoad_Click(object sender, EventArgs e)
		{
			try
			{
				var data = new Data.DataSumDuplicates
				{
					ExcelFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Demo\\Demo for duplicates.xlsx"),
					IsExcelFileLoaded = true,
					ExcelCurrentSheetName = "Исходные данные",
					IsExcelSheetLoaded = true,
					OutputColName = "Возраст",
					IsMarkingDuplicates = true,
				};
				data.ExcelSheetNames.Add("Исходные данные");
				data.ExcelColumnsNames.Add("Возраст");

				var cmd = new LoadDemoFileCmd(model, data);
				undoManager.Execute(cmd);
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		#endregion

		#region UndoRedo
		private void LoadUndo()
		{
			btUndo.DropDownOpening += (s, e) => btUndo.Tag = false;
			btUndo.DropDownClosed += (s, e) => btUndo.Tag = true;

			btRedo.DropDownOpening += (s, e) => btRedo.Tag = false;
			btRedo.DropDownClosed += (s, e) => btRedo.Tag = true;

			btUndo.Click += (s, e) => { if (btUndo.Tag == null || (bool)btUndo.Tag) Undo(); };
			btRedo.Click += (s, e) => { if (btRedo.Tag == null || (bool)btRedo.Tag) Redo(); };
		}

		private void Undo()
		{
			try { undoManager.Undo(1); }
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		private void Redo()
		{
			try { undoManager.Redo(1); }
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		private void btUndo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			try
			{
				int count = btUndo.DropDownItems.IndexOf(e.ClickedItem) + 1;
				undoManager.Undo(count);
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		private void btRedo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			try
			{
				int count = btRedo.DropDownItems.IndexOf(e.ClickedItem) + 1;
				undoManager.Redo(count);
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}

		private void RebuildUndo()
		{
			btUndo.Enabled = undoManager.CanUndo;
			btRedo.Enabled = undoManager.CanRedo;

			RebuildUndoButton(btUndo, undoManager.UndoItems);
			RebuildUndoButton(btRedo, undoManager.RedoItems);
		}
		private void RebuildUndoButton(ToolStripSplitButton button, IEnumerable<string> items)
		{
			button.DropDownItems.Clear();

			foreach (string item in items)
			{
				var mi = new ToolStripMenuItem { Text = item, BackColor = SystemColors.Control };
				mi.MouseEnter += (s, e) => SelectUndoItems(button, button.DropDownItems.IndexOf(mi));
				button.DropDownItems.Add(mi);
			}
		}
		private void SelectUndoItems(ToolStripSplitButton button, int index)
		{
			foreach (ToolStripMenuItem item in button.DropDownItems)
				if (button.DropDownItems.IndexOf(item) > index) item.BackColor = SystemColors.Control;
				else item.BackColor = Color.FromArgb(213, 234, 255);
		}
		#endregion

		#region Main action
		private void btOk_Click(object sender, EventArgs e)
		{
			try
			{
				if (model.ExcelDataTable == null)
				{
					messageService.ShowError("Не выбран Excel файл или лист.\nПродолжение не возможно!");
					return;
				}
				if (string.IsNullOrEmpty(model.Data.OutputColName))
				{
					messageService.ShowError("Не выбран столбец для суммирования.\nПродолжение не возможно!");
					return;
				}
				model.SumDuplicates();

				messageService.ShowMessage($"Готово!\n\nРезультат находится в файле '{model.Data.ExcelFilePath}' в листе '{model.OutputSheetName}'");
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}

		private void ProgressReportChange(object sender, EventArgs e)
		{
			try
			{
				if (!Visible) return;
				IntPtr hwnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
				FSImark.Controls.TaskbarProgress.SetValue(hwnd, model.ProgressValue, model.ProgressMax);
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		private void ProgressReportComplete(object sender, EventArgs e)
		{
			try
			{
				if (!Visible) return;
				IntPtr hwnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
				FSImark.Controls.TaskbarProgress.Finish(hwnd);
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		private void TryRewriteDuplicateSheet(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				var question = $"Лист \"{model.OutputSheetName}\" уже содержится в книге. Перезаписать этот лист?";

				switch (messageService.ShowQuestion(question))
				{
					case DialogResult.Yes: e.Cancel = false; break;
					case DialogResult.No:
						messageService.ShowError("Продолжение невозможно!");
						e.Cancel = true;
						break;
					case DialogResult.Cancel: e.Cancel = true; break;
				}
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		#endregion

		#region Service
		private void SetAutoHeight(DataGridView dgv)
		{
			var height = dgv.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dgv.ColumnHeadersHeight + 7;
			if (dgv.MaximumSize.Height > 0) dgv.Height = Math.Min(height, dgv.MaximumSize.Height);
			else dgv.Height = height;
		}
		#endregion
	}
}
