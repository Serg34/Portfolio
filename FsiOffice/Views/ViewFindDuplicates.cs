using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FSImark.BL;
using FSImark.UndoRedo;
using FSImark.UndoRedo.FindDuplicates;

namespace FSImark.UI
{
    [MainPanel("Поиск дубликатов в EXCEL")]
    public partial class ViewFindDuplicates : UserControl
    {
        public ViewFindDuplicates()
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

                model = new ModelFindDuplicates();

                model.Changed += Rebuild;
                model.RewritingOutputSheet += TryRewritingOutputSheet;
                model.ProgressChanged += ProgressReportChange;
                model.ProgressCompleted += ProgressReportComplete;
            }
            catch (Exception ex) { messageService.ReportException(ex, isDebug); }
        }

        #region Fields
        private IMessageService messageService = new MessageService();

        private ModelFindDuplicates model;
        private UndoRedoManager undoManager = new UndoRedoManager();

        private bool isRebuilding = false;
        private readonly bool isDebug;
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

                    if (model.Data.IsExcelSheetLoaded && dgvColumnStatus.RowCount != model.Data.ExcelColumns.Count)
                    {
                        dgvColumnStatus.RowCount = 0;
                        dgvColumnStatus.RowCount = model.Data.ExcelColumns.Count;
                    }
                }
                else
                {
                    lbExcelFileName.Text = "Файл не загружен";
                    toolTip.SetToolTip(lbExcelFileName, "");
                }

                lbExcelCurrentSheetName.Visible = cbExcelCurrentSheetName.Visible = model.Data.IsExcelFileLoaded;

                cbExcelCurrentSheetName.DataSource = model.Data.ExcelSheetNames.ToArray();
                cbExcelCurrentSheetName.Text = model.Data.ExcelCurrentSheetName;

                dgvExcelDataTable.Visible = dgvColumnStatus.Visible = model.Data.IsExcelSheetLoaded;

                dgvExcelDataTable.DataSource = model.ExcelDataTable;
                SetAutoHeight(dgvExcelDataTable);

                dgvColumnStatus.Invalidate();
                SetAutoHeight(dgvColumnStatus);

                //RebuildUndo. (async for correct background of btUndo and btRedo)
                System.Threading.Tasks.Task.Factory.StartNew(() => Invoke(new Action(() => RebuildUndo())));
            }
            catch (Exception ex) { messageService.ReportException(ex, isDebug); }
            finally { isRebuilding = false; }
        }

        private void dgvColumnStatus_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (!dgvColumnStatus.Visible || model.Data.ExcelColumns.Count == 0) return;
            try
            {
                var column = model.Data.ExcelColumns[e.RowIndex];
                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = column.IsKey;
                        PaintRow(dgvColumnStatus.Rows[e.RowIndex], column.IsKey);
                        break;
                    case 1: e.Value = column.Name; break;
                    case 2: e.Value = column.IsMarkedCell; break;
                    case 3: if (column.DeviationValue != 0) e.Value = column.DeviationValue; break;
                }
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex) { messageService.ReportException(ex, isDebug); }
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

        private void dgvColumnStatus_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                var column = model.Data.ExcelColumns[e.RowIndex];
                switch (e.ColumnIndex)
                {
                    case 0:
                        {
                            var value = (bool)e.Value;
                            if (column.IsKey == value) return;
                            var cmd = new ExcelColumnIsKeyCmd(model, column, value);
                            undoManager.Execute(cmd);
                        }
                        break;
                    case 2:
                        {
                            var value = (bool)e.Value;
                            if (column.IsMarkedCell == value) return;
                            var cmd = new ExcelColumnIsMarkedCellCmd(model, column, value);
                            undoManager.Execute(cmd);
                        }
                        break;
                    case 3:
                        {
                            var value = ObjectToDouble(e.Value);
                            if (value <= 0)
                            {
                                messageService.ShowError("Введите положительное число");
                                return;
                            }
                            if (column.DeviationValue == value) return;
                            var cmd = new ExcelColumnDeviationValueCmd(model, column, value);
                            undoManager.Execute(cmd);
                        }
                        break;
                }
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex) { messageService.ReportException(ex, isDebug); }
        }

        private double ObjectToDouble(object obj)
        {
            if (obj == null) return 0;
            string value = obj.ToString();
            string dec_sep = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            value = value.Replace(",", dec_sep).Replace(".", dec_sep);

            if (double.TryParse(value.ToString(), out var result)) return result;

            return 0;
        }

        private void btDemoLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new Data.DataFindDuplicates
                {
                    ExcelFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Demo\\Demo for duplicates.xlsx"),
                    IsExcelFileLoaded = true,
                    ExcelCurrentSheetName = "Исходные данные",
                    IsExcelSheetLoaded = true,
                };
                data.ExcelSheetNames.Add("Исходные данные");
                data.ExcelColumns.Add(new Data.ExcelColumn("Имя") { IsKey = true, IsMarkedCell = true });
                data.ExcelColumns.Add(new Data.ExcelColumn("Фамилия") { IsMarkedCell = true });
                data.ExcelColumns.Add(new Data.ExcelColumn("Возраст") { IsKey = true, IsMarkedCell = true, DeviationValue = 5 });

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
                model.FindDuplicates();
            }
            catch (Exception ex)
            {
                if (ex.HResult != -2146777998) messageService.ReportException(ex, isDebug);
            }
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
        private void TryRewritingOutputSheet(object sender, System.ComponentModel.CancelEventArgs e)
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
        #endregion

        #region Service
        private void SetAutoHeight(DataGridView dgv)
        {
            var height = dgv.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dgv.ColumnHeadersHeight + 7;
            if (dgv.MaximumSize.Height > 0)
                dgv.Height = Math.Min(height, dgv.MaximumSize.Height);
            else dgv.Height = height;
        }
        private void PaintRow(DataGridViewRow row, bool value)
        {
            if (value)
            {
                row.DefaultCellStyle.BackColor =
                    row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(91, 210, 255);
                row.DefaultCellStyle.ForeColor =
                    row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            }
            else
            {
                row.DefaultCellStyle.BackColor =
                    row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
                row.DefaultCellStyle.ForeColor =
                    row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            }
        }
        #endregion
    }
}
