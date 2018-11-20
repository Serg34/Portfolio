using System.Windows.Forms;
using FSImark.Help.UI;

namespace FSImark.Help.Excel
{
	[HelpPanel("Импорт данных из Excel в Word")]
	public class HelpExcelToWordView : UserControl, IHelpPanel
	{
		public HelpExcelToWordView()
		{
			InitializeComponent();
		}

		private Label lbEmpty;
		private Label label1;
		private Label label9;
		private Label lbExcelFile;
		private Label label8;
		private Label label11;
		private Label label14;
		private PictureBox pictureBox6;
		private PictureBox pictureBox5;
		private PictureBox pictureBox7;
		private PictureBox pictureBox8;
		private Label lbForm;
		private Label label12;
		private Label lbExcelSheets;
        private PictureBox pictureBox9;
        private Label label10;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpExcelToWordView));
            this.label2 = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbExcelFile = new System.Windows.Forms.Label();
            this.lbExcelSheets = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbForm = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbEmpty = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label2, true);
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 27, 6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(927, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Создайте в Excel таблицу с необходимыми данными на отдельном листе.              " +
    "                                                                                " +
    "    \r\n";
            // 
            // pnMain
            // 
            this.pnMain.AutoSize = true;
            this.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnMain.Controls.Add(this.lbHeader);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.pictureBox6);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.pictureBox5);
            this.pnMain.Controls.Add(this.label12);
            this.pnMain.Controls.Add(this.pictureBox7);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.label9);
            this.pnMain.Controls.Add(this.lbExcelFile);
            this.pnMain.Controls.Add(this.lbExcelSheets);
            this.pnMain.Controls.Add(this.label8);
            this.pnMain.Controls.Add(this.label11);
            this.pnMain.Controls.Add(this.pictureBox8);
            this.pnMain.Controls.Add(this.lbForm);
            this.pnMain.Controls.Add(this.label14);
            this.pnMain.Controls.Add(this.pictureBox4);
            this.pnMain.Controls.Add(this.label5);
            this.pnMain.Controls.Add(this.pictureBox3);
            this.pnMain.Controls.Add(this.label4);
            this.pnMain.Controls.Add(this.pictureBox1);
            this.pnMain.Controls.Add(this.label6);
            this.pnMain.Controls.Add(this.pictureBox2);
            this.pnMain.Controls.Add(this.label7);
            this.pnMain.Controls.Add(this.lbEmpty);
            this.pnMain.Controls.Add(this.pictureBox9);
            this.pnMain.Controls.Add(this.label10);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMain.Location = new System.Drawing.Point(12, 13);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1021, 2564);
            this.pnMain.TabIndex = 2;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.pnMain.SetFlowBreak(this.lbHeader, true);
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lbHeader.Location = new System.Drawing.Point(12, 13);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(296, 25);
            this.lbHeader.TabIndex = 15;
            this.lbHeader.Text = "Импорт данных из Excel в Word";
            // 
            // pictureBox6
            // 
            this.pnMain.SetFlowBreak(this.pictureBox6, true);
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(6, 113);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1103, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label3, true);
            this.label3.Location = new System.Drawing.Point(6, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 27, 6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(895, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox5
            // 
            this.pnMain.SetFlowBreak(this.pictureBox5, true);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(6, 303);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(800, 399);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label12, true);
            this.label12.Location = new System.Drawing.Point(6, 736);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 27, 6, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(993, 21);
            this.label12.TabIndex = 45;
            this.label12.Text = "Сохраните документ документ Word как шаблон : *.dot или *.dotx                   " +
    "                                                                                " +
    "                             ";
            // 
            // pictureBox7
            // 
            this.pnMain.SetFlowBreak(this.pictureBox7, true);
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(6, 771);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(800, 312);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 42;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label1, true);
            this.label1.Location = new System.Drawing.Point(6, 1103);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Запустите настоящее приложение";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label9, true);
            this.label9.Location = new System.Drawing.Point(6, 1150);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(381, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Выберите опцию «Импорт данных из Excel в Word»";
            // 
            // lbExcelFile
            // 
            this.lbExcelFile.AutoSize = true;
            this.pnMain.SetFlowBreak(this.lbExcelFile, true);
            this.lbExcelFile.Location = new System.Drawing.Point(6, 1197);
            this.lbExcelFile.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.lbExcelFile.Name = "lbExcelFile";
            this.lbExcelFile.Size = new System.Drawing.Size(959, 21);
            this.lbExcelFile.TabIndex = 26;
            this.lbExcelFile.Text = "По нажатию на фразу «Файл не загружен» или по кнопке справа от этой фразы выберит" +
    "е файл Excel, в котором сохранена таблица.";
            // 
            // lbExcelSheets
            // 
            this.lbExcelSheets.AutoSize = true;
            this.pnMain.SetFlowBreak(this.lbExcelSheets, true);
            this.lbExcelSheets.Location = new System.Drawing.Point(6, 1244);
            this.lbExcelSheets.Margin = new System.Windows.Forms.Padding(6, 13, 6, 7);
            this.lbExcelSheets.Name = "lbExcelSheets";
            this.lbExcelSheets.Size = new System.Drawing.Size(505, 21);
            this.lbExcelSheets.TabIndex = 46;
            this.lbExcelSheets.Text = "В выпадающем списке выберите лист, в котором находится таблица.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label8, true);
            this.label8.Location = new System.Drawing.Point(6, 1285);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(816, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "По нажатию на фразу «Шаблоны не загружены» или по кнопке справа от этой фразы выб" +
    "ерите шаблоны Word.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label11, true);
            this.label11.Location = new System.Drawing.Point(6, 1332);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(972, 42);
            this.label11.TabIndex = 28;
            this.label11.Text = "По нажатию на фразу «Папка не выбрана» или по кнопке справа от этой фразы выберит" +
    "е папку, в которой будут сохраняться новые файлы.";
            // 
            // pictureBox8
            // 
            this.pnMain.SetFlowBreak(this.pictureBox8, true);
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(6, 1394);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(831, 463);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // lbForm
            // 
            this.lbForm.AutoSize = true;
            this.pnMain.SetFlowBreak(this.lbForm, true);
            this.lbForm.Location = new System.Drawing.Point(5, 1874);
            this.lbForm.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(210, 21);
            this.lbForm.TabIndex = 44;
            this.lbForm.Text = "Пример заполнения формы";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label14, true);
            this.label14.Location = new System.Drawing.Point(5, 1915);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(415, 21);
            this.label14.TabIndex = 39;
            this.label14.Text = "После заполнения формы нажмите кнопку «Заполнить»";
            // 
            // pictureBox4
            // 
            this.pnMain.SetFlowBreak(this.pictureBox4, true);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 1953);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label5, true);
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(6, 2008);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(941, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "При помощи этой программы для каждого из выбранных шаблонов будет создано столько" +
    " копий, сколько строк в таблице Excel.";
            // 
            // pictureBox3
            // 
            this.pnMain.SetFlowBreak(this.pictureBox3, true);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 2063);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label4, true);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(6, 2101);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(996, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "Для различных типов бланков создайте отдельные столбцы, например, \"Название_для_д" +
    "оговора\" и \"Название_для_сметы\" и заполняйте несколько типов бланков в этой прог" +
    "рамме одновременно.\r\n";
            // 
            // pictureBox1
            // 
            this.pnMain.SetFlowBreak(this.pictureBox1, true);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 2177);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label6, true);
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(6, 2232);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(708, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Название нового файла составляется из названия шаблона Word и значения из первого" +
    " столбца.\r\n";
            // 
            // pictureBox2
            // 
            this.pnMain.SetFlowBreak(this.pictureBox2, true);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 2287);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label7, true);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(6, 2325);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1008, 63);
            this.label7.TabIndex = 7;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // lbEmpty
            // 
            this.lbEmpty.AutoSize = true;
            this.pnMain.SetFlowBreak(this.lbEmpty, true);
            this.lbEmpty.Location = new System.Drawing.Point(6, 2402);
            this.lbEmpty.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
            this.lbEmpty.Name = "lbEmpty";
            this.lbEmpty.Size = new System.Drawing.Size(14, 21);
            this.lbEmpty.TabIndex = 18;
            this.lbEmpty.Text = " ";
            // 
            // pictureBox9
            // 
            this.pnMain.SetFlowBreak(this.pictureBox9, true);
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(6, 2457);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 24);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 48;
            this.pictureBox9.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label10, true);
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(6, 2495);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(961, 84);
            this.label10.TabIndex = 47;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // HelpExcelToWordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HelpExcelToWordView";
            this.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Size = new System.Drawing.Size(1045, 725);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel pnMain;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbHeader;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
	}
}
