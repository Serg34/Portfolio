namespace FSImark.UI
{
	partial class ViewExcelToWord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExcelToWord));
            this.dgvExcelDataTable = new System.Windows.Forms.DataGridView();
            this.tpnMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbRepeat = new System.Windows.Forms.Label();
            this.btOutputFolder = new System.Windows.Forms.Button();
            this.lbOutputFolder = new System.Windows.Forms.Label();
            this.btLoadWordFiles = new System.Windows.Forms.Button();
            this.lbWordFiles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvWord = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilWord = new System.Windows.Forms.ImageList(this.components);
            this.lbExcelCurrentSheetName = new System.Windows.Forms.Label();
            this.btLoadExcelFile = new System.Windows.Forms.Button();
            this.lbExcelFile = new System.Windows.Forms.Label();
            this.cbExcelCurrentSheetName = new System.Windows.Forms.ComboBox();
            this.lbExcelFileName = new System.Windows.Forms.Label();
            this.lbOutputFolderTitle = new System.Windows.Forms.Label();
            this.nudRepeat = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).BeginInit();
            this.pnOk.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExcelDataTable
            // 
            this.dgvExcelDataTable.AllowUserToAddRows = false;
            this.dgvExcelDataTable.AllowUserToDeleteRows = false;
            this.dgvExcelDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvExcelDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvExcelDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tpnMain.SetColumnSpan(this.dgvExcelDataTable, 3);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExcelDataTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExcelDataTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvExcelDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgvExcelDataTable.Location = new System.Drawing.Point(3, 56);
            this.dgvExcelDataTable.MaximumSize = new System.Drawing.Size(0, 500);
            this.dgvExcelDataTable.Name = "dgvExcelDataTable";
            this.dgvExcelDataTable.ReadOnly = true;
            this.dgvExcelDataTable.RowHeadersVisible = false;
            this.dgvExcelDataTable.RowTemplate.Height = 28;
            this.dgvExcelDataTable.Size = new System.Drawing.Size(955, 200);
            this.dgvExcelDataTable.TabIndex = 4;
            this.dgvExcelDataTable.Visible = false;
            // 
            // tpnMain
            // 
            this.tpnMain.AutoSize = true;
            this.tpnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tpnMain.BackColor = System.Drawing.Color.Transparent;
            this.tpnMain.ColumnCount = 3;
            this.tpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnMain.Controls.Add(this.lbRepeat, 0, 6);
            this.tpnMain.Controls.Add(this.btOutputFolder, 2, 5);
            this.tpnMain.Controls.Add(this.lbOutputFolder, 1, 5);
            this.tpnMain.Controls.Add(this.btLoadWordFiles, 2, 3);
            this.tpnMain.Controls.Add(this.lbWordFiles, 1, 3);
            this.tpnMain.Controls.Add(this.label3, 0, 3);
            this.tpnMain.Controls.Add(this.lvWord, 0, 4);
            this.tpnMain.Controls.Add(this.dgvExcelDataTable, 0, 2);
            this.tpnMain.Controls.Add(this.lbExcelCurrentSheetName, 0, 1);
            this.tpnMain.Controls.Add(this.btLoadExcelFile, 2, 0);
            this.tpnMain.Controls.Add(this.lbExcelFile, 0, 0);
            this.tpnMain.Controls.Add(this.cbExcelCurrentSheetName, 1, 1);
            this.tpnMain.Controls.Add(this.lbExcelFileName, 1, 0);
            this.tpnMain.Controls.Add(this.lbOutputFolderTitle, 0, 5);
            this.tpnMain.Controls.Add(this.nudRepeat, 1, 6);
            this.tpnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.tpnMain.Location = new System.Drawing.Point(0, 48);
            this.tpnMain.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.tpnMain.Name = "tpnMain";
            this.tpnMain.RowCount = 6;
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnMain.Size = new System.Drawing.Size(961, 601);
            this.tpnMain.TabIndex = 3;
            // 
            // lbRepeat
            // 
            this.lbRepeat.AutoSize = true;
            this.lbRepeat.Location = new System.Drawing.Point(3, 578);
            this.lbRepeat.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lbRepeat.Name = "lbRepeat";
            this.lbRepeat.Size = new System.Drawing.Size(151, 17);
            this.lbRepeat.TabIndex = 1019;
            this.lbRepeat.Text = "Количество повторов";
            this.lbRepeat.Visible = false;
            // 
            // btOutputFolder
            // 
            this.btOutputFolder.AutoSize = true;
            this.btOutputFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btOutputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btOutputFolder.FlatAppearance.BorderSize = 0;
            this.btOutputFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOutputFolder.Image = global::FSImark.Properties.Resources.OpenFileIcon;
            this.btOutputFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOutputFolder.Location = new System.Drawing.Point(562, 546);
            this.btOutputFolder.Name = "btOutputFolder";
            this.btOutputFolder.Size = new System.Drawing.Size(22, 22);
            this.btOutputFolder.TabIndex = 0;
            this.btOutputFolder.UseVisualStyleBackColor = false;
            this.btOutputFolder.Click += new System.EventHandler(this.btOutputFolder_Click);
            // 
            // lbOutputFolder
            // 
            this.lbOutputFolder.AutoSize = true;
            this.lbOutputFolder.Location = new System.Drawing.Point(162, 550);
            this.lbOutputFolder.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lbOutputFolder.Name = "lbOutputFolder";
            this.lbOutputFolder.Size = new System.Drawing.Size(124, 17);
            this.lbOutputFolder.TabIndex = 1;
            this.lbOutputFolder.Text = "Папка не выбрана";
            this.lbOutputFolder.Click += new System.EventHandler(this.btOutputFolder_Click);
            // 
            // btLoadWordFiles
            // 
            this.btLoadWordFiles.AutoSize = true;
            this.btLoadWordFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLoadWordFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btLoadWordFiles.FlatAppearance.BorderSize = 0;
            this.btLoadWordFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btLoadWordFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadWordFiles.Image = global::FSImark.Properties.Resources.OpenFileIcon;
            this.btLoadWordFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLoadWordFiles.Location = new System.Drawing.Point(562, 262);
            this.btLoadWordFiles.Name = "btLoadWordFiles";
            this.btLoadWordFiles.Size = new System.Drawing.Size(22, 22);
            this.btLoadWordFiles.TabIndex = 0;
            this.btLoadWordFiles.UseVisualStyleBackColor = false;
            this.btLoadWordFiles.Click += new System.EventHandler(this.btLoadWordFiles_Click);
            // 
            // lbWordFiles
            // 
            this.lbWordFiles.AutoSize = true;
            this.lbWordFiles.Location = new System.Drawing.Point(162, 266);
            this.lbWordFiles.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lbWordFiles.Name = "lbWordFiles";
            this.lbWordFiles.Size = new System.Drawing.Size(162, 17);
            this.lbWordFiles.TabIndex = 1;
            this.lbWordFiles.Text = "Шаблоны не загружены";
            this.lbWordFiles.Click += new System.EventHandler(this.btLoadWordFiles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(3, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Шаблоны WORD";
            // 
            // lvWord
            // 
            this.lvWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lvWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colFolder});
            this.tpnMain.SetColumnSpan(this.lvWord, 3);
            this.lvWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvWord.ForeColor = System.Drawing.Color.Gainsboro;
            this.lvWord.FullRowSelect = true;
            this.lvWord.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvWord.LargeImageList = this.ilWord;
            this.lvWord.Location = new System.Drawing.Point(3, 290);
            this.lvWord.MaximumSize = new System.Drawing.Size(0, 250);
            this.lvWord.Name = "lvWord";
            this.lvWord.Size = new System.Drawing.Size(955, 250);
            this.lvWord.SmallImageList = this.ilWord;
            this.lvWord.TabIndex = 3;
            this.lvWord.UseCompatibleStateImageBehavior = false;
            this.lvWord.View = System.Windows.Forms.View.Details;
            this.lvWord.Visible = false;
            // 
            // colName
            // 
            this.colName.Text = "Имя файла";
            this.colName.Width = 250;
            // 
            // colFolder
            // 
            this.colFolder.Text = "Расположение";
            this.colFolder.Width = 300;
            // 
            // ilWord
            // 
            this.ilWord.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilWord.ImageStream")));
            this.ilWord.TransparentColor = System.Drawing.Color.Transparent;
            this.ilWord.Images.SetKeyName(0, "Microsoft_Word_DOC_file_icon_24x24.png");
            // 
            // lbExcelCurrentSheetName
            // 
            this.lbExcelCurrentSheetName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbExcelCurrentSheetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(231)))), ((int)(((byte)(124)))));
            this.lbExcelCurrentSheetName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbExcelCurrentSheetName.Location = new System.Drawing.Point(3, 28);
            this.lbExcelCurrentSheetName.Margin = new System.Windows.Forms.Padding(3, 0, 1, 1);
            this.lbExcelCurrentSheetName.Name = "lbExcelCurrentSheetName";
            this.lbExcelCurrentSheetName.Size = new System.Drawing.Size(155, 24);
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
            this.btLoadExcelFile.Location = new System.Drawing.Point(562, 3);
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
            this.lbExcelFile.Size = new System.Drawing.Size(155, 24);
            this.lbExcelFile.TabIndex = 1016;
            this.lbExcelFile.Text = "Файл EXCEL";
            this.lbExcelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbExcelCurrentSheetName
            // 
            this.cbExcelCurrentSheetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExcelCurrentSheetName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExcelCurrentSheetName.FormattingEnabled = true;
            this.cbExcelCurrentSheetName.Location = new System.Drawing.Point(159, 28);
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
            this.lbExcelFileName.Location = new System.Drawing.Point(162, 3);
            this.lbExcelFileName.Margin = new System.Windows.Forms.Padding(3);
            this.lbExcelFileName.Name = "lbExcelFileName";
            this.lbExcelFileName.Size = new System.Drawing.Size(124, 17);
            this.lbExcelFileName.TabIndex = 0;
            this.lbExcelFileName.Text = "Файл не загружен";
            this.lbExcelFileName.Click += new System.EventHandler(this.btLoadExcelFile_Click);
            // 
            // lbOutputFolderTitle
            // 
            this.lbOutputFolderTitle.AutoSize = true;
            this.lbOutputFolderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbOutputFolderTitle.Location = new System.Drawing.Point(3, 550);
            this.lbOutputFolderTitle.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lbOutputFolderTitle.Name = "lbOutputFolderTitle";
            this.lbOutputFolderTitle.Size = new System.Drawing.Size(153, 17);
            this.lbOutputFolderTitle.TabIndex = 3;
            this.lbOutputFolderTitle.Text = "Папка для сохранения";
            // 
            // nudRepeat
            // 
            this.nudRepeat.Location = new System.Drawing.Point(162, 574);
            this.nudRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRepeat.Name = "nudRepeat";
            this.nudRepeat.Size = new System.Drawing.Size(120, 24);
            this.nudRepeat.TabIndex = 1020;
            this.nudRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.nudRepeat, "Количество различных закладок в Word, соотвествующих одному столбцу Excel");
            this.nudRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRepeat.Visible = false;
            this.nudRepeat.ValueChanged += new System.EventHandler(this.nudMatchesValueInWord_ValueChanged);
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
            this.btOk.Size = new System.Drawing.Size(89, 29);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Заполнить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.AutoSize = true;
            this.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnMain.Controls.Add(this.tpnMain);
            this.pnMain.Controls.Add(this.menuMain);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnMain.Size = new System.Drawing.Size(978, 507);
            this.pnMain.TabIndex = 1019;
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
            this.menuMain.Size = new System.Drawing.Size(961, 38);
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
            // ViewExcelToWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnOk);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewExcelToWord";
            this.Size = new System.Drawing.Size(978, 544);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelDataTable)).EndInit();
            this.tpnMain.ResumeLayout(false);
            this.tpnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).EndInit();
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
		private System.Windows.Forms.ListView lvWord;
		private System.Windows.Forms.Button btLoadWordFiles;
		private System.Windows.Forms.Label lbWordFiles;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ImageList ilWord;
		private System.Windows.Forms.ComboBox cbExcelCurrentSheetName;
		private System.Windows.Forms.Button btLoadExcelFile;
		private System.Windows.Forms.DataGridView dgvExcelDataTable;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colFolder;
		private System.Windows.Forms.TableLayoutPanel tpnMain;
		private System.Windows.Forms.Label lbExcelCurrentSheetName;
		private System.Windows.Forms.Label lbExcelFile;
		private System.Windows.Forms.Label lbExcelFileName;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label lbOutputFolderTitle;
		private System.Windows.Forms.Label lbOutputFolder;
		private System.Windows.Forms.Button btOutputFolder;
		private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label lbRepeat;
        private System.Windows.Forms.NumericUpDown nudRepeat;
		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripSplitButton btUndo;
		private System.Windows.Forms.ToolStripSplitButton btRedo;
		private System.Windows.Forms.ToolStripMenuItem btDemoLoad;
	}
}

