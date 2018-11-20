using System.Diagnostics;
using System.Windows.Forms;
using FSImark.Help.UI;

namespace FSImark.Help.ZZZ_Problem.EXCEL
{
	[HelpPanel("\"Microsoft.ACE.OLEDB.12.0\" не зарегистрирован")]
	public class HelpMicrosoftACEOLEDB : UserControl, IHelpPanel
	{
		public HelpMicrosoftACEOLEDB()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=13255");
		}

		private Label lbReasons;
		private PictureBox pbReasons;
		private Label lbSolutions;
		private PictureBox pbSolutions;
		private PictureBox pbInfo;
		private Label label3;
		private Label label1;
		private Label lbEmpty;

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
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbHeader = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
			this.lbReasons = new System.Windows.Forms.Label();
			this.pbReasons = new System.Windows.Forms.PictureBox();
			this.lbSolutions = new System.Windows.Forms.Label();
			this.pbSolutions = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.pbInfo = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbEmpty = new System.Windows.Forms.Label();
			this.pnMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReasons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSolutions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
			this.SuspendLayout();
			// 
			// lbHeader
			// 
			this.lbHeader.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbHeader, true);
			this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lbHeader.Location = new System.Drawing.Point(12, 13);
			this.lbHeader.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
			this.lbHeader.Name = "lbHeader";
			this.lbHeader.Size = new System.Drawing.Size(1171, 40);
			this.lbHeader.TabIndex = 0;
			this.lbHeader.Text = "Поставщик \"Microsoft.ACE.OLEDB.12.0\" не зарегистрирован на локальном компьютере";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label11, true);
			this.label11.Location = new System.Drawing.Point(42, 139);
			this.label11.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(1324, 64);
			this.label11.TabIndex = 13;
			this.label11.Text = "Не установлено дополнение «Microsoft Access Database Engine» для программного обр" +
    "ащения к данным Excel файла\r\n ";
			// 
			// pnMain
			// 
			this.pnMain.AutoSize = true;
			this.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnMain.Controls.Add(this.lbHeader);
			this.pnMain.Controls.Add(this.lbReasons);
			this.pnMain.Controls.Add(this.pbReasons);
			this.pnMain.Controls.Add(this.label11);
			this.pnMain.Controls.Add(this.lbSolutions);
			this.pnMain.Controls.Add(this.pbSolutions);
			this.pnMain.Controls.Add(this.label3);
			this.pnMain.Controls.Add(this.label1);
			this.pnMain.Controls.Add(this.linkLabel1);
			this.pnMain.Controls.Add(this.pbInfo);
			this.pnMain.Controls.Add(this.label2);
			this.pnMain.Controls.Add(this.lbEmpty);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnMain.Location = new System.Drawing.Point(12, 13);
			this.pnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(1678, 635);
			this.pnMain.TabIndex = 2;
			// 
			// lbReasons
			// 
			this.lbReasons.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbReasons, true);
			this.lbReasons.Location = new System.Drawing.Point(6, 73);
			this.lbReasons.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbReasons.Name = "lbReasons";
			this.lbReasons.Size = new System.Drawing.Size(260, 32);
			this.lbReasons.TabIndex = 51;
			this.lbReasons.Text = "Возможные причины:";
			// 
			// pbReasons
			// 
			this.pbReasons.Image = global::FSImark.Properties.Resources.WarningIcon;
			this.pbReasons.Location = new System.Drawing.Point(6, 139);
			this.pbReasons.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pbReasons.Name = "pbReasons";
			this.pbReasons.Size = new System.Drawing.Size(24, 24);
			this.pbReasons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbReasons.TabIndex = 53;
			this.pbReasons.TabStop = false;
			// 
			// lbSolutions
			// 
			this.lbSolutions.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbSolutions, true);
			this.lbSolutions.Location = new System.Drawing.Point(6, 237);
			this.lbSolutions.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbSolutions.Name = "lbSolutions";
			this.lbSolutions.Size = new System.Drawing.Size(119, 32);
			this.lbSolutions.TabIndex = 52;
			this.lbSolutions.Text = "Решение:";
			// 
			// pbSolutions
			// 
			this.pbSolutions.Image = global::FSImark.Properties.Resources.Check32;
			this.pbSolutions.Location = new System.Drawing.Point(6, 303);
			this.pbSolutions.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pbSolutions.Name = "pbSolutions";
			this.pbSolutions.Size = new System.Drawing.Size(24, 24);
			this.pbSolutions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbSolutions.TabIndex = 54;
			this.pbSolutions.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label3, true);
			this.label3.Location = new System.Drawing.Point(42, 303);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(817, 32);
			this.label3.TabIndex = 57;
			this.label3.Text = "Установите бесплатное дополнение «Microsoft Access Database Engine».";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label1, true);
			this.label1.Location = new System.Drawing.Point(6, 369);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(588, 32);
			this.label1.TabIndex = 56;
			this.label1.Text = "Скачать его можно с официального сайта Microsoft";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.pnMain.SetFlowBreak(this.linkLabel1, true);
			this.linkLabel1.LinkColor = System.Drawing.Color.DeepSkyBlue;
			this.linkLabel1.Location = new System.Drawing.Point(6, 435);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 13);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(725, 32);
			this.linkLabel1.TabIndex = 35;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://www.microsoft.com/en-us/download/details.aspx?id=13255\r\n";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// pbInfo
			// 
			this.pbInfo.Image = global::FSImark.Properties.Resources.info24;
			this.pbInfo.Location = new System.Drawing.Point(6, 487);
			this.pbInfo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pbInfo.Name = "pbInfo";
			this.pbInfo.Size = new System.Drawing.Size(24, 24);
			this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbInfo.TabIndex = 55;
			this.pbInfo.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label2, true);
			this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.label2.Location = new System.Drawing.Point(42, 487);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1167, 64);
			this.label2.TabIndex = 36;
			this.label2.Text = "Для 32-разрядной (х86) опреционной системы выберите для установки файл AccessData" +
    "baseEngine.exe\r\nДля 64-разрядной опреционной системы выберите AccessDatabaseEngi" +
    "ne_X64.exe";
			// 
			// lbEmpty
			// 
			this.lbEmpty.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbEmpty, true);
			this.lbEmpty.Location = new System.Drawing.Point(5, 583);
			this.lbEmpty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 20);
			this.lbEmpty.Name = "lbEmpty";
			this.lbEmpty.Size = new System.Drawing.Size(22, 32);
			this.lbEmpty.TabIndex = 58;
			this.lbEmpty.Text = " ";
			// 
			// HelpMicrosoftACEOLEDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.Controls.Add(this.pnMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.Gainsboro;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "HelpMicrosoftACEOLEDB";
			this.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
			this.Size = new System.Drawing.Size(1702, 800);
			this.pnMain.ResumeLayout(false);
			this.pnMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReasons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSolutions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbHeader;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.FlowLayoutPanel pnMain;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
	}
}
