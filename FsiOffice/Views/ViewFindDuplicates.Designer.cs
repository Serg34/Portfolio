namespace FSImark.UI
{
	partial class ViewFindDuplicates
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
				model?.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFindDuplicates));
            this.dgvExcelDataTable = new System.Windows.Forms.DataGridView();
            this.tpnMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvColumnStatus = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMark = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbColumnStatus = new System.Windows.Forms.Label();
            this.lbExcelCurrentSheetName = new System.Windows.Forms.Label();
            this.btLoadExcelFile = new System.Windows.Forms.Button();
            this.lbExcelFile = new System.Windows.Forms.Label();
            this.cbExcelCurrentSheetName = new System.Windows.Forms.ComboBox();
            this.lbExcelFileName = new System.Windows.Forms.Label();
            this.ilWord = new System.Windows.Forms.ImageList(this.components);
            this.pnOk = new System.Windows.Forms.FlowLayoutPanel();
            this.btOk = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.btUndo = new System.Windows.Forms.ToolStripSplitButton();
            this.btRedo = new System.Windows.Forms.ToolStripSplitButton();
            this.btDemoLoad = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelDataTable)).BeginInit();
            this.tpnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnStatus)).BeginInit();
            this.pnOk.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExcelDataTable
            // 
            this.dgvExcelDataTable.AllowUserToAddRows = false;
            this.dgvExcelDataTable.AllowUserToDeleteRows = false;
            this.dgvExcelDataTable.AllowUserToResizeRows = false;
            this.dgvExcelDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvExcelDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvExcelDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tpnMain.SetColumnSpan(this.dgvExcelDataTable, 3);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExcelDataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExcelDataTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvExcelDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgvExcelDataTable.Location = new System.Drawing.Point(3, 56);
            this.dgvExcelDataTable.MaximumSize = new System.Drawing.Size(0, 350);
            this.dgvExcelDataTable.Name = "dgvExcelDataTable";
            this.dgvExcelDataTable.ReadOnly = true;
            this.dgvExcelDataTable.RowHeadersVisible = false;
            this.dgvExcelDataTable.RowTemplate.Height = 28;
            this.dgvExcelDataTable.Size = new System.Drawing.Size(972, 150);
            this.dgvExcelDataTable.TabIndex = 4;
            this.dgvExcelDataTable.Visible = false;
            // 
            // tpnMain
            // 
            this.tpnMain.AutoSize = true;
            this.tpnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tpnMain.BackColor = System.Drawing.Color.Transparent;
            this.tpnMain.ColumnCount = 3;
            this.tpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnMain.Controls.Add(this.dgvColumnStatus, 0, 4);
            this.tpnMain.Controls.Add(this.lbColumnStatus, 0, 3);
            this.tpnMain.Controls.Add(this.dgvExcelDataTable, 0, 2);
            this.tpnMain.Controls.Add(this.lbExcelCurrentSheetName, 0, 1);
            this.tpnMain.Controls.Add(this.btLoadExcelFile, 2, 0);
            this.tpnMain.Controls.Add(this.lbExcelFile, 0, 0);
            this.tpnMain.Controls.Add(this.cbExcelCurrentSheetName, 1, 1);
            this.tpnMain.Controls.Add(this.lbExcelFileName, 1, 0);
            this.tpnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.tpnMain.Location = new System.Drawing.Point(0, 48);
            this.tpnMain.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.tpnMain.Name = "tpnMain";
            this.tpnMain.RowCount = 4;
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.Size = new System.Drawing.Size(978, 383);
            this.tpnMain.TabIndex = 3;
            // 
            // dgvColumnStatus
            // 
            this.dgvColumnStatus.AllowUserToAddRows = false;
            this.dgvColumnStatus.AllowUserToDeleteRows = false;
            this.dgvColumnStatus.AllowUserToResizeRows = false;
            this.dgvColumnStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColumnStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvColumnStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumnStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.colMark,
            this.Column4});
            this.tpnMain.SetColumnSpan(this.dgvColumnStatus, 3);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumnStatus.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColumnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvColumnStatus.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvColumnStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgvColumnStatus.Location = new System.Drawing.Point(3, 230);
            this.dgvColumnStatus.MaximumSize = new System.Drawing.Size(0, 350);
            this.dgvColumnStatus.Name = "dgvColumnStatus";
            this.dgvColumnStatus.RowHeadersVisible = false;
            this.dgvColumnStatus.RowTemplate.Height = 28;
            this.dgvColumnStatus.Size = new System.Drawing.Size(972, 150);
            this.dgvColumnStatus.TabIndex = 1022;
            this.dgvColumnStatus.VirtualMode = true;
            this.dgvColumnStatus.Visible = false;
            this.dgvColumnStatus.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvColumnStatus_CellValueNeeded);
            this.dgvColumnStatus.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvColumnStatus_CellValuePushed);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Ключ";
            this.Column1.Name = "Column1";
            this.Column1.ToolTipText = "Этот столбец содержит ключевые значения, по которым определяются дубликаты";
            this.Column1.Width = 49;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Столбец";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 70;
            // 
            // colMark
            // 
            this.colMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMark.HeaderText = "Подсветка";
            this.colMark.Name = "colMark";
            this.colMark.ToolTipText = "Подсветка ключевых ячеек или ячеек с расходящимися значениями";
            this.colMark.Width = 82;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Допуск";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.ToolTipText = "Допуск для числовых значений";
            // 
            // lbColumnStatus
            // 
            this.lbColumnStatus.AutoSize = true;
            this.tpnMain.SetColumnSpan(this.lbColumnStatus, 3);
            this.lbColumnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbColumnStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbColumnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbColumnStatus.Location = new System.Drawing.Point(3, 209);
            this.lbColumnStatus.Margin = new System.Windows.Forms.Padding(3, 0, 1, 1);
            this.lbColumnStatus.Name = "lbColumnStatus";
            this.lbColumnStatus.Size = new System.Drawing.Size(974, 17);
            this.lbColumnStatus.TabIndex = 1019;
            this.lbColumnStatus.Text = "Назначение столбцов";
            this.lbColumnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbColumnStatus.Visible = false;
            // 
            // lbExcelCurrentSheetName
            // 
            this.lbExcelCurrentSheetName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbExcelCurrentSheetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(231)))), ((int)(((byte)(124)))));
            this.lbExcelCurrentSheetName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbExcelCurrentSheetName.Location = new System.Drawing.Point(3, 28);
            this.lbExcelCurrentSheetName.Margin = new System.Windows.Forms.Padding(3, 0, 1, 1);
            this.lbExcelCurrentSheetName.Name = "lbExcelCurrentSheetName";
            this.lbExcelCurrentSheetName.Size = new System.Drawing.Size(146, 24);
            this.lbExcelCurrentSheetName.TabIndex = 1018;
            this.lbExcelCurrentSheetName.Text = "Лист EXCEL";
            this.lbExcelCurrentSheetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbExcelCurrentSheetName.Visible = false;
            // 
            // btLoadExcelFile
            // 
            this.btLoadExcelFile.AutoSize = true;
            this.btLoadExcelFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLoadExcelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btLoadExcelFile.FlatAppearance.BorderSize = 0;
            this.btLoadExcelFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btLoadExcelFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadExcelFile.Image = global::FSImark.Properties.Resources.OpenFileIcon;
            this.btLoadExcelFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLoadExcelFile.Location = new System.Drawing.Point(553, 3);
            this.btLoadExcelFile.Name = "btLoadExcelFile";
            this.btLoadExcelFile.Size = new System.Drawing.Size(22, 22);
            this.btLoadExcelFile.TabIndex = 0;
            this.btLoadExcelFile.UseVisualStyleBackColor = false;
            this.btLoadExcelFile.Click += new System.EventHandler(this.btLoadExcelFile_Click);
            // 
            // lbExcelFile
            // 
            this.lbExcelFile.BackColor = System.Drawing.Color.Transparent;
            this.lbExcelFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbExcelFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(231)))), ((int)(((byte)(124)))));
            this.lbExcelFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbExcelFile.Location = new System.Drawing.Point(3, 0);
            this.lbExcelFile.Margin = new System.Windows.Forms.Padding(3, 0, 1, 1);
            this.lbExcelFile.Name = "lbExcelFile";
            this.lbExcelFile.Size = new System.Drawing.Size(146, 24);
            this.lbExcelFile.TabIndex = 1016;
            this.lbExcelFile.Text = "Файл EXCEL";
            this.lbExcelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbExcelCurrentSheetName
            // 
            this.cbExcelCurrentSheetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExcelCurrentSheetName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExcelCurrentSheetName.FormattingEnabled = true;
            this.cbExcelCurrentSheetName.Location = new System.Drawing.Point(150, 28);
            this.cbExcelCurrentSheetName.Margin = new System.Windows.Forms.Padding(0);
            this.cbExcelCurrentSheetName.Name = "cbExcelCurrentSheetName";
            this.cbExcelCurrentSheetName.Size = new System.Drawing.Size(400, 24);
            this.cbExcelCurrentSheetName.TabIndex = 1;
            this.cbExcelCurrentSheetName.Visible = false;
            this.cbExcelCurrentSheetName.SelectedIndexChanged += new System.EventHandler(this.cbExcelCurrentSheetName_SelectedIndexChanged);
            // 
            // lbExcelFileName
            // 
            this.lbExcelFileName.AutoSize = true;
            this.lbExcelFileName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbExcelFileName.Location = new System.Drawing.Point(153, 3);
            this.lbExcelFileName.Margin = new System.Windows.Forms.Padding(3);
            this.lbExcelFileName.Name = "lbExcelFileName";
            this.lbExcelFileName.Size = new System.Drawing.Size(124, 17);
            this.lbExcelFileName.TabIndex = 0;
            this.lbExcelFileName.Text = "Файл не загружен";
            this.lbExcelFileName.Click += new System.EventHandler(this.btLoadExcelFile_Click);
            // 
            // ilWord
            // 
            this.ilWord.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilWord.ImageStream")));
            this.ilWord.TransparentColor = System.Drawing.Color.Transparent;
            this.ilWord.Images.SetKeyName(0, "Microsoft_Word_DOC_file_icon_24x24.png");
            // 
            // pnOk
            // 
            this.pnOk.AutoSize = true;
            this.pnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnOk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOk.Controls.Add(this.btOk);
            this.pnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOk.Location = new System.Drawing.Point(0, 507);
            this.pnOk.Name = "pnOk";
            this.pnOk.Size = new System.Drawing.Size(978, 37);
            this.pnOk.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.AutoSize = true;
            this.btOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.ForeColor = System.Drawing.Color.White;
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOk.Location = new System.Drawing.Point(3, 3);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(136, 29);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Найти дубликаты";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.Controls.Add(this.tpnMain);
            this.pnMain.Controls.Add(this.menuMain);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnMain.Size = new System.Drawing.Size(978, 507);
            this.pnMain.TabIndex = 4;
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.Transparent;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btUndo,
            this.btRedo,
            this.btDemoLoad});
            this.menuMain.Location = new System.Drawing.Point(0, 10);
            this.menuMain.Name = "menuMain";
            this.menuMain.ShowItemToolTips = true;
            this.menuMain.Size = new System.Drawing.Size(978, 38);
            this.menuMain.TabIndex = 5;
            // 
            // btUndo
            // 
            this.btUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btUndo.Enabled = false;
            this.btUndo.Image = global::FSImark.Properties.Resources.UndoIcon;
            this.btUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btUndo.Name = "btUndo";
            this.btUndo.Padding = new System.Windows.Forms.Padding(1);
            this.btUndo.Size = new System.Drawing.Size(34, 31);
            this.btUndo.ToolTipText = "Отменить действие";
            this.btUndo.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btUndo_DropDownItemClicked);
            // 
            // btRedo
            // 
            this.btRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRedo.Enabled = false;
            this.btRedo.Image = global::FSImark.Properties.Resources.RedoIcon;
            this.btRedo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btRedo.Name = "btRedo";
            this.btRedo.Padding = new System.Windows.Forms.Padding(1);
            this.btRedo.Size = new System.Drawing.Size(34, 31);
            this.btRedo.ToolTipText = "Повторить действие";
            this.btRedo.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btRedo_DropDownItemClicked);
            // 
            // btDemoLoad
            // 
            this.btDemoLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btDemoLoad.ForeColor = System.Drawing.Color.Black;
            this.btDemoLoad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.btDemoLoad.Name = "btDemoLoad";
            this.btDemoLoad.Size = new System.Drawing.Size(152, 19);
            this.btDemoLoad.Text = "Загрузить демо-пример";
            this.btDemoLoad.Click += new System.EventHandler(this.btDemoLoad_Click);
            // 
            // ViewFindDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnOk);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewFindDuplicates";
            this.Size = new System.Drawing.Size(978, 544);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelDataTable)).EndInit();
            this.tpnMain.ResumeLayout(false);
            this.tpnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnStatus)).EndInit();
            this.pnOk.ResumeLayout(false);
            this.pnOk.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel pnOk;
		private System.Windows.Forms.Button btOk;
		private System.Windows.Forms.ImageList ilWord;
		private System.Windows.Forms.ComboBox cbExcelCurrentSheetName;
		private System.Windows.Forms.Button btLoadExcelFile;
		private System.Windows.Forms.DataGridView dgvExcelDataTable;
		private System.Windows.Forms.TableLayoutPanel tpnMain;
		private System.Windows.Forms.Label lbExcelCurrentSheetName;
		private System.Windows.Forms.Label lbExcelFile;
		private System.Windows.Forms.Label lbExcelFileName;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Panel pnMain;
		private System.Windows.Forms.DataGridView dgvColumnStatus;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colMark;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.Label lbColumnStatus;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripSplitButton btUndo;
        private System.Windows.Forms.ToolStripSplitButton btRedo;
        private System.Windows.Forms.ToolStripMenuItem btDemoLoad;
    }
}

