using System.Windows.Forms;
using FSImark.Help.UI;

namespace FSImark.Help.Excel
{
	[HelpPanel("Суммировать дубликаты в EXCEL")]
	public class HelpSumDuplicates : UserControl, IHelpPanel
	{
		public HelpSumDuplicates()
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
		private PictureBox pictureBox2;
		private Label label18;
		private Label label14;
		private Label label15;
		private PictureBox pictureBox3;
		private Label lbEmpty;
		private Label lbExcelSheets;
        private Label label9;
        private Label label6;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpSumDuplicates));
            this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbExcelFile = new System.Windows.Forms.Label();
            this.lbExcelSheets = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbEmpty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.AutoSize = true;
            this.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnMain.Controls.Add(this.lbHeader);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.label9);
            this.pnMain.Controls.Add(this.label8);
            this.pnMain.Controls.Add(this.label6);
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
            this.pnMain.Controls.Add(this.pictureBox2);
            this.pnMain.Controls.Add(this.label18);
            this.pnMain.Controls.Add(this.label14);
            this.pnMain.Controls.Add(this.label15);
            this.pnMain.Controls.Add(this.pictureBox3);
            this.pnMain.Controls.Add(this.lbEmpty);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMain.Location = new System.Drawing.Point(10, 10);
            this.pnMain.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(847, 1540);
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
            this.lbHeader.Size = new System.Drawing.Size(309, 25);
            this.lbHeader.TabIndex = 15;
            this.lbHeader.Text = "Суммировать дубликаты в EXCEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label1, true);
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Функция формирует сводную таблицу, в которой собраны уникальные значения из диапа" +
    "зона исходных данных.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label9, true);
            this.label9.Location = new System.Drawing.Point(5, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(411, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "В отдельном столбце выводится итоговая сумма дубликатов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label8, true);
            this.label8.Location = new System.Drawing.Point(5, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(555, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Например, вам нужно сумму по возрасту людей с различными именем и фамилией.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label3, true);
            this.label3.Location = new System.Drawing.Point(5, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(836, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox5
            // 
            this.pnMain.SetFlowBreak(this.pictureBox5, true);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 267);
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
            this.label2.Location = new System.Drawing.Point(5, 470);
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
            this.label4.Location = new System.Drawing.Point(5, 507);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Выберите опцию «Суммировать дубликаты в EXCEL»";
            // 
            // lbExcelFile
            // 
            this.lbExcelFile.AutoSize = true;
            this.pnMain.SetFlowBreak(this.lbExcelFile, true);
            this.lbExcelFile.Location = new System.Drawing.Point(5, 544);
            this.lbExcelFile.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lbExcelFile.Name = "lbExcelFile";
            this.lbExcelFile.Size = new System.Drawing.Size(830, 34);
            this.lbExcelFile.TabIndex = 23;
            this.lbExcelFile.Text = "По нажатию на фразу «Файл не загружен» или по кнопке справа от этой фразы выберит" +
    "е файл EXCEL, в котором сохранена таблица.";
            // 
            // lbExcelSheets
            // 
            this.lbExcelSheets.AutoSize = true;
            this.pnMain.SetFlowBreak(this.lbExcelSheets, true);
            this.lbExcelSheets.Location = new System.Drawing.Point(6, 601);
            this.lbExcelSheets.Margin = new System.Windows.Forms.Padding(6, 13, 6, 7);
            this.lbExcelSheets.Name = "lbExcelSheets";
            this.lbExcelSheets.Size = new System.Drawing.Size(465, 17);
            this.lbExcelSheets.TabIndex = 47;
            this.lbExcelSheets.Text = "В выпадающем списке выберите лист, в котором находится таблица.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label10, true);
            this.label10.Location = new System.Drawing.Point(5, 635);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(340, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Укажите Имя и Фамилия в качестве ключа поиска. ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label5, true);
            this.label5.Location = new System.Drawing.Point(5, 672);
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
            this.pictureBox4.Location = new System.Drawing.Point(5, 704);
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
            this.label12.Location = new System.Drawing.Point(5, 743);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(834, 34);
            this.label12.TabIndex = 29;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // pictureBox2
            // 
            this.pnMain.SetFlowBreak(this.pictureBox2, true);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 790);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(587, 410);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label18, true);
            this.label18.Location = new System.Drawing.Point(5, 1213);
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
            this.label14.Location = new System.Drawing.Point(5, 1250);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(474, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "После заполнения формы нажмите кнопку «Суммировать дубликаты »";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label15, true);
            this.label15.Location = new System.Drawing.Point(5, 1287);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(834, 34);
            this.label15.TabIndex = 39;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // pictureBox3
            // 
            this.pnMain.SetFlowBreak(this.pictureBox3, true);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 1334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(346, 161);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // lbEmpty
            // 
            this.lbEmpty.AutoSize = true;
            this.pnMain.SetFlowBreak(this.lbEmpty, true);
            this.lbEmpty.Location = new System.Drawing.Point(5, 1503);
            this.lbEmpty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.lbEmpty.Name = "lbEmpty";
            this.lbEmpty.Size = new System.Drawing.Size(12, 17);
            this.lbEmpty.TabIndex = 44;
            this.lbEmpty.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.pnMain.SetFlowBreak(this.label6, true);
            this.label6.Location = new System.Drawing.Point(5, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(802, 34);
            this.label6.TabIndex = 49;
            this.label6.Text = "В сводной таблице не должно быть двух строчек с одинаковыми именем и фамилией, а " +
    "в столбце «Возраст» будет уже сумма возрастов всех людей с именем и фамилией, ук" +
    "азанных в соответствующих столбцах.\r\n";
            // 
            // HelpSumDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HelpSumDuplicates";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(867, 544);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel pnMain;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbHeader;
	}
}
