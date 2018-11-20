using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FSImark.BL;
using FSImark.UndoRedo;
using FSImark.UndoRedo.ExcelToWord;

namespace FSImark.UI
{
	[MainPanel("Импорт данных из EXCEL в WORD")]
	public partial class ViewExcelToWord : UserControl
	{
		public ViewExcelToWord()
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

				model = new ModelExcelToWord();
				model.Changed += Rebuild;
				model.ProgressChanged += ProgressReportChange;
				model.ProgressCompleted += ProgressReportComplete;
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}

		#region Fields
		private IMessageService messageService = new MessageService();

		private ModelExcelToWord model;
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

				RebuildExcelFile();

				RebuildWordFiles();

				nudRepeat.Value = model.Data.RepeatInWordCount;
                lbRepeat.Visible = nudRepeat.Visible = model.Data.IsExcelSheetLoaded;

				if (model.Data.IsOutputFolder) lbOutputFolder.Text = Path.GetFileNameWithoutExtension(model.Data.OutputFolderPath);
				else lbOutputFolder.Text = "Папка не выбрана";
				toolTip.SetToolTip(lbOutputFolder, model.Data.OutputFolderPath);

				//RebuildUndo. (async for correct background of btUndo and btRedo)
				System.Threading.Tasks.Task.Factory.StartNew(() => Invoke(new Action(() => RebuildUndo())));
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
			finally { isRebuilding = false; }
		}

		private void RebuildExcelFile()
		{
			if (model.Data.IsExcelFileLoaded)
			{
				lbExcelFileName.Text = Path.GetFileNameWithoutExtension(model.Data.ExcelFilePath);
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
		}
		private void RebuildWordFiles()
		{
            if (model.Data.WordFilePaths.Count > 0)
            {
                lbWordFiles.Text = $"Шаблонов загружено: {model.Data.WordFilePaths.Count}";

                lvWord.Items.Clear();
                foreach (var wordFile in model.Data.WordFilePaths)
                {
                    var name = Path.GetFileNameWithoutExtension(wordFile);
                    var item = lvWord.Items.Add(name, 0);
                    var folder = Path.GetDirectoryName(wordFile);
                    item.SubItems.Add(folder);
                }
                colName.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                colFolder.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                SetAutoHeight(lvWord);

                lvWord.Visible = true;
            }
            else
            {
                lvWord.Visible = false;
                lbWordFiles.Text = "Шаблоны не загружены";
            }
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

		private void btLoadWordFiles_Click(object sender, EventArgs e)
		{
			try
			{
				var fileManager = new FileManager(new WordDocumentInfo());
				var value = fileManager.GetOpeningFilePathsByDialog();
				if (value != null)
				{
					var cmd = new LoadWordFilesCmd(model, value);
					undoManager.Execute(cmd);
				}
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}

		private void btOutputFolder_Click(object sender, EventArgs e)
		{
			try
			{
				var dialog = new OpenFolderDialog();
				if (dialog.ShowDialog(this) == DialogResult.OK)
				{
					var value = dialog.Folder;
					var cmd = new OutputFolderPathCmd(model, value);
					undoManager.Execute(cmd);
				}
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}

		private void nudMatchesValueInWord_ValueChanged(object sender, EventArgs e)
		{
			if (isRebuilding) return;
			try
			{
				var value = (int)nudRepeat.Value;
				if (model.Data.RepeatInWordCount == value) return;
				var cmd = new RepeatInWordCountCmd(model, value);
				undoManager.Execute(cmd);
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		
		private void btDemoLoad_Click(object sender, EventArgs e)
		{
			try
			{
				var demoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Demo");
				var data = new Data.DataExcelToWord
				{
					ExcelFilePath = Path.Combine(demoPath, "Demo for Excel to Word.xlsx"),
					IsExcelFileLoaded = true,
					ExcelCurrentSheetName = "Исходные данные",
					IsExcelSheetLoaded = true,
					OutputFolderPath = Path.Combine(demoPath, "Результаты"),
				};
				data.ExcelSheetNames.Add("Исходные данные");
				data.WordFilePaths.Add(Path.Combine(demoPath, "Договор.dot"));
				data.WordFilePaths.Add(Path.Combine(demoPath, "Акт приемки-передачи.dot"));

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
					messageService.ShowError("Не выбран Excel файл или лист.\nЗаполнение не возможно!");
					return;
				}
				if (model.Data.WordFilePaths.Count == 0)
				{
					messageService.ShowError("Не загружен ни один файл Word.\nЗаполнение не возможно!");
					return;
				}
				if (string.IsNullOrEmpty(model.Data.OutputFolderPath))
				{
					messageService.ShowError("Не выбрана папка для сохранения новых документов.\nЗаполнение не возможно!");
					return;
				}

				model.CopyExcelToWord();
				messageService.ShowMessage($"Готово!\n\nФайлы сохранены в папке '{model.Data.OutputFolderPath}'");
			}
			catch (Exception ex) { messageService.ReportException(ex, isDebug); }
		}
		private void ProgressReportChange(object sender, EventArgs e)
		{
			if (!Visible) return;
			IntPtr hwnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
			FSImark.Controls.TaskbarProgress.SetValue(hwnd, model.ProgressValue, model.ProgressMax);
		}
		private void ProgressReportComplete(object sender, EventArgs e)
		{
			if (!Visible) return;
			IntPtr hwnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
			FSImark.Controls.TaskbarProgress.Finish(hwnd);
		}
		#endregion

		#region Service
		private void SetAutoHeight(DataGridView dgv)
		{
			var height = dgv.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dgv.ColumnHeadersHeight + 7;
			if (dgv.MaximumSize.Height > 0)
				dgv.Height = Math.Min(height, dgv.MaximumSize.Height);
			else dgv.Height = height;
		}
		private void SetAutoHeight(ListView lv)
		{
			int height = 30;
			for (int i = 0; i < lv.Items.Count; i++)
				height += lv.GetItemRect(i).Height;

			if (lv.MaximumSize.Height > 0)
				lv.Height = Math.Min(height, lv.MaximumSize.Height);
			else lv.Height = height;
		}
		#endregion
	}
}
