using System.Windows.Forms;
using FSImark.Help.UI;

namespace FSImark.Help.Excel
{
	[HelpPanel("Поиск дубликатов в EXCEL")]
	public class HelpFindDuplicates : UserControl, IHelpPanel
	{
		public HelpFindDuplicates()
		{
			InitializeComponent();
		}

		private Label label1;
		private Label label8;
		private PictureBox pictureBox5;
		private Label label2;
		private Label label4;
		private Label lbExcelFile;
		private Label label10;
		private Label label5;
		private PictureBox pictureBox4;
		private Label label12;
		private Label label6;
		private Label label7;
		private Label label11;
		private PictureBox pictureBox1;
		private Label label13;
		private PictureBox pictureBox2;
		private Label label18;
		private Label label14;
		private Label label15;
		private PictureBox pictureBox3;
		private Label label16;
		private PictureBox pictureBox6;
		private Label label17;
		private Label lbEmpty;
		private Label lbExcelSheets;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpFindDuplicates));
			this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
			this.lbHeader = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbExcelFile = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label13 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label16 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label17 = new System.Windows.Forms.Label();
			this.lbEmpty = new System.Windows.Forms.Label();
			this.lbExcelSheets = new System.Windows.Forms.Label();
			this.pnMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// pnMain
			// 
			this.pnMain.AutoSize = true;
			this.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnMain.Controls.Add(this.lbHeader);
			this.pnMain.Controls.Add(this.label1);
			this.pnMain.Controls.Add(this.label8);
			this.pnMain.Controls.Add(this.label3);
			this.pnMain.Controls.Add(this.pictureBox5);
			this.pnMain.Controls.Add(this.label2);
			this.pnMain.Controls.Add(this.label4);
			this.pnMain.Controls.Add(this.lbExcelFile);
			this.pnMain.Controls.Add(this.lbExcelSheets);
			this.pnMain.Controls.Add(this.label10);
			this.pnMain.Controls.Add(this.label5);
			this.pnMain.Controls.Add(this.pictureBox4);
			this.pnMain.Controls.Add(this.label12);
			this.pnMain.Controls.Add(this.label6);
			this.pnMain.Controls.Add(this.label7);
			this.pnMain.Controls.Add(this.label11);
			this.pnMain.Controls.Add(this.pictureBox1);
			this.pnMain.Controls.Add(this.label13);
			this.pnMain.Controls.Add(this.pictureBox2);
			this.pnMain.Controls.Add(this.label18);
			this.pnMain.Controls.Add(this.label14);
			this.pnMain.Controls.Add(this.label15);
			this.pnMain.Controls.Add(this.pictureBox3);
			this.pnMain.Controls.Add(this.label16);
			this.pnMain.Controls.Add(this.pictureBox6);
			this.pnMain.Controls.Add(this.label17);
			this.pnMain.Controls.Add(this.lbEmpty);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnMain.Location = new System.Drawing.Point(10, 10);
			this.pnMain.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(881, 1945);
			this.pnMain.TabIndex = 2;
			// 
			// lbHeader
			// 
			this.lbHeader.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbHeader, true);
			this.lbHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
			this.lbHeader.Location = new System.Drawing.Point(10, 10);
			this.lbHeader.Margin = new System.Windows.Forms.Padding(10);
			this.lbHeader.Name = "lbHeader";
			this.lbHeader.Size = new System.Drawing.Size(250, 25);
			this.lbHeader.TabIndex = 15;
			this.lbHeader.Text = "Поиск дубликатов в EXCEL";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label1, true);
			this.label1.Location = new System.Drawing.Point(5, 55);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(606, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "Функция позволяет производить поиск строк, совпадающих по одному и более параметр" +
    "у";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label8, true);
			this.label8.Location = new System.Drawing.Point(5, 92);
			this.label8.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(485, 17);
			this.label8.TabIndex = 19;
			this.label8.Text = "Например, вам нужно найти людей с одинаковыми именами и возрастом";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label3, true);
			this.label3.Location = new System.Drawing.Point(5, 129);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(868, 34);
			this.label3.TabIndex = 2;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// pictureBox5
			// 
			this.pnMain.SetFlowBreak(this.pictureBox5, true);
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(3, 176);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(241, 190);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 20;
			this.pictureBox5.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label2, true);
			this.label2.Location = new System.Drawing.Point(5, 379);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(234, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Запустите настоящее приложение";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label4, true);
			this.label4.Location = new System.Drawing.Point(5, 416);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(306, 17);
			this.label4.TabIndex = 22;
			this.label4.Text = "Выберите опцию «Поиск дубликатов в Excel»";
			// 
			// lbExcelFile
			// 
			this.lbExcelFile.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbExcelFile, true);
			this.lbExcelFile.Location = new System.Drawing.Point(5, 453);
			this.lbExcelFile.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.lbExcelFile.Name = "lbExcelFile";
			this.lbExcelFile.Size = new System.Drawing.Size(830, 34);
			this.lbExcelFile.TabIndex = 23;
			this.lbExcelFile.Text = "По нажатию на фразу «Файл не загружен» или по кнопке справа от этой фразы выберит" +
    "е файл EXCEL, в котором сохранена таблица.";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label10, true);
			this.label10.Location = new System.Drawing.Point(5, 544);
			this.label10.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(335, 17);
			this.label10.TabIndex = 24;
			this.label10.Text = "Укажите Имя и Возраст в качестве ключа поиска. ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label5, true);
			this.label5.Location = new System.Drawing.Point(5, 581);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(653, 17);
			this.label5.TabIndex = 25;
			this.label5.Text = "При необходимости заливки фоном поставьте галочку в строке с соответствующим пара" +
    "метром.";
			// 
			// pictureBox4
			// 
			this.pnMain.SetFlowBreak(this.pictureBox4, true);
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(5, 613);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(24, 24);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 30;
			this.pictureBox4.TabStop = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label12, true);
			this.label12.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.label12.Location = new System.Drawing.Point(5, 655);
			this.label12.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(606, 17);
			this.label12.TabIndex = 29;
			this.label12.Text = "Параметры, используемые в качестве ключа, заливаются зеленым цветом при совпадени" +
    "и.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label6, true);
			this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.label6.Location = new System.Drawing.Point(5, 692);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(637, 17);
			this.label6.TabIndex = 31;
			this.label6.Text = "Параметры, не используемые в качестве ключа, заливаются красным цветом при расхож" +
    "дении.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label7, true);
			this.label7.Location = new System.Drawing.Point(5, 729);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(341, 17);
			this.label7.TabIndex = 32;
			this.label7.Text = "Для числовых параметров можно указать допуск. ";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label11, true);
			this.label11.Location = new System.Drawing.Point(5, 766);
			this.label11.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(650, 17);
			this.label11.TabIndex = 33;
			this.label11.Text = "Если разница двух значений отличается не более допуска, то значения считаются оди" +
    "наковыми.";
			// 
			// pictureBox1
			// 
			this.pnMain.SetFlowBreak(this.pictureBox1, true);
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(5, 798);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 35;
			this.pictureBox1.TabStop = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label13, true);
			this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.label13.Location = new System.Drawing.Point(5, 837);
			this.label13.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(870, 34);
			this.label13.TabIndex = 34;
			this.label13.Text = resources.GetString("label13.Text");
			// 
			// pictureBox2
			// 
			this.pnMain.SetFlowBreak(this.pictureBox2, true);
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 884);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(732, 564);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 36;
			this.pictureBox2.TabStop = false;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label18, true);
			this.label18.Location = new System.Drawing.Point(5, 1461);
			this.label18.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(185, 17);
			this.label18.TabIndex = 37;
			this.label18.Text = "Пример заполнения формы";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label14, true);
			this.label14.Location = new System.Drawing.Point(5, 1498);
			this.label14.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(422, 17);
			this.label14.TabIndex = 38;
			this.label14.Text = "После заполнения формы нажмите кнопку «Найти дубликаты»";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label15, true);
			this.label15.Location = new System.Drawing.Point(5, 1535);
			this.label15.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(780, 17);
			this.label15.TabIndex = 39;
			this.label15.Text = "В исходном файле Excel будет создан лист «Поиск дубликатов», в котором будет отоб" +
    "ражен следующий результат:";
			// 
			// pictureBox3
			// 
			this.pnMain.SetFlowBreak(this.pictureBox3, true);
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(3, 1565);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(794, 142);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 40;
			this.pictureBox3.TabStop = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label16, true);
			this.label16.Location = new System.Drawing.Point(5, 1720);
			this.label16.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(676, 68);
			this.label16.TabIndex = 41;
			this.label16.Text = resources.GetString("label16.Text");
			// 
			// pictureBox6
			// 
			this.pnMain.SetFlowBreak(this.pictureBox6, true);
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(5, 1803);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(24, 24);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 43;
			this.pictureBox6.TabStop = false;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label17, true);
			this.label17.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.label17.Location = new System.Drawing.Point(5, 1842);
			this.label17.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(871, 51);
			this.label17.TabIndex = 42;
			this.label17.Text = resources.GetString("label17.Text");
			// 
			// lbEmpty
			// 
			this.lbEmpty.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbEmpty, true);
			this.lbEmpty.Location = new System.Drawing.Point(5, 1908);
			this.lbEmpty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 20);
			this.lbEmpty.Name = "lbEmpty";
			this.lbEmpty.Size = new System.Drawing.Size(12, 17);
			this.lbEmpty.TabIndex = 44;
			this.lbEmpty.Text = " ";
			// 
			// lbExcelSheets
			// 
			this.lbExcelSheets.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbExcelSheets, true);
			this.lbExcelSheets.Location = new System.Drawing.Point(6, 510);
			this.lbExcelSheets.Margin = new System.Windows.Forms.Padding(6, 13, 6, 7);
			this.lbExcelSheets.Name = "lbExcelSheets";
			this.lbExcelSheets.Size = new System.Drawing.Size(465, 17);
			this.lbExcelSheets.TabIndex = 47;
			this.lbExcelSheets.Text = "В выпадающем списке выберите лист, в котором находится таблица.";
			// 
			// HelpFindDuplicates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.Controls.Add(this.pnMain);
			this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.Gainsboro;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "HelpFindDuplicates";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(901, 544);
			this.pnMain.ResumeLayout(false);
			this.pnMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel pnMain;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbHeader;
	}
}
