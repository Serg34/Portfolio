using System.Windows.Forms;
using FSImark.Help.UI;

namespace FSImark.Help.ZZZ_Problem.Word
{
	[HelpPanel("Ошибка HRESULT: 0x800A03EC")]
	public partial class HelpProblem800A03EC : UserControl, IHelpPanel
	{
		public HelpProblem800A03EC()
		{
			InitializeComponent();
		}

		private Label label11;
		private Label label5;
		private Label label6;
		private PictureBox pbReasons;
		private PictureBox pbSolutions;
		private PictureBox pbInfo;
		private PictureBox pictureBox4;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpProblem800A03EC));
			this.lbHeader = new System.Windows.Forms.Label();
			this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
			this.lbReasons = new System.Windows.Forms.Label();
			this.pbReasons = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbSolutions = new System.Windows.Forms.Label();
			this.pbSolutions = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.pbInfo = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbEmpty = new System.Windows.Forms.Label();
			this.pnMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReasons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSolutions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
			this.lbHeader.Size = new System.Drawing.Size(791, 80);
			this.lbHeader.TabIndex = 0;
			this.lbHeader.Text = "Тип ошибки: System.Runtime.InteropServices.COMException\r\nИсключение из HRESULT: 0" +
    "x800A03EC";
			// 
			// pnMain
			// 
			this.pnMain.AutoSize = true;
			this.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnMain.Controls.Add(this.lbHeader);
			this.pnMain.Controls.Add(this.lbReasons);
			this.pnMain.Controls.Add(this.pbReasons);
			this.pnMain.Controls.Add(this.label3);
			this.pnMain.Controls.Add(this.lbSolutions);
			this.pnMain.Controls.Add(this.pbSolutions);
			this.pnMain.Controls.Add(this.label11);
			this.pnMain.Controls.Add(this.label10);
			this.pnMain.Controls.Add(this.pbInfo);
			this.pnMain.Controls.Add(this.label5);
			this.pnMain.Controls.Add(this.pictureBox4);
			this.pnMain.Controls.Add(this.label6);
			this.pnMain.Controls.Add(this.lbEmpty);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnMain.Location = new System.Drawing.Point(12, 13);
			this.pnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(1678, 730);
			this.pnMain.TabIndex = 2;
			// 
			// lbReasons
			// 
			this.lbReasons.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbReasons, true);
			this.lbReasons.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbReasons.Location = new System.Drawing.Point(6, 113);
			this.lbReasons.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbReasons.Name = "lbReasons";
			this.lbReasons.Size = new System.Drawing.Size(266, 32);
			this.lbReasons.TabIndex = 36;
			this.lbReasons.Text = "Возможные причины:";
			// 
			// pbReasons
			// 
			this.pbReasons.Image = global::FSImark.Properties.Resources.WarningIcon;
			this.pbReasons.Location = new System.Drawing.Point(6, 179);
			this.pbReasons.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pbReasons.Name = "pbReasons";
			this.pbReasons.Size = new System.Drawing.Size(24, 24);
			this.pbReasons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbReasons.TabIndex = 48;
			this.pbReasons.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label3, true);
			this.label3.Location = new System.Drawing.Point(42, 179);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(319, 64);
			this.label3.TabIndex = 37;
			this.label3.Text = "Переполнение листа EXCEL\r\n ";
			// 
			// lbSolutions
			// 
			this.lbSolutions.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbSolutions, true);
			this.lbSolutions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbSolutions.Location = new System.Drawing.Point(6, 277);
			this.lbSolutions.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbSolutions.Name = "lbSolutions";
			this.lbSolutions.Size = new System.Drawing.Size(121, 32);
			this.lbSolutions.TabIndex = 38;
			this.lbSolutions.Text = "Решение:";
			// 
			// pbSolutions
			// 
			this.pbSolutions.Image = global::FSImark.Properties.Resources.Check32;
			this.pbSolutions.Location = new System.Drawing.Point(6, 343);
			this.pbSolutions.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pbSolutions.Name = "pbSolutions";
			this.pbSolutions.Size = new System.Drawing.Size(24, 24);
			this.pbSolutions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbSolutions.TabIndex = 49;
			this.pbSolutions.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label11, true);
			this.label11.Location = new System.Drawing.Point(42, 343);
			this.label11.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(1067, 32);
			this.label11.TabIndex = 45;
			this.label11.Text = "Убедитесь, что поставленная задача может выполниться в пределах пространства лист" +
    "а Excel.";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label10, true);
			this.label10.Location = new System.Drawing.Point(6, 409);
			this.label10.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(1657, 96);
			this.label10.TabIndex = 44;
			this.label10.Text = resources.GetString("label10.Text");
			// 
			// pbInfo
			// 
			this.pbInfo.Image = global::FSImark.Properties.Resources.info24;
			this.pbInfo.Location = new System.Drawing.Point(6, 539);
			this.pbInfo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pbInfo.Name = "pbInfo";
			this.pbInfo.Size = new System.Drawing.Size(24, 24);
			this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbInfo.TabIndex = 50;
			this.pbInfo.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label5, true);
			this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.label5.Location = new System.Drawing.Point(42, 539);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1021, 32);
			this.label5.TabIndex = 46;
			this.label5.Text = "В файлах формата Excel 97-2003 (.xls) максимально допустимое количество столбцов " +
    "256. ";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::FSImark.Properties.Resources.info24;
			this.pictureBox4.Location = new System.Drawing.Point(6, 605);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(24, 24);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 51;
			this.pictureBox4.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label6, true);
			this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.label6.Location = new System.Drawing.Point(42, 605);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(956, 32);
			this.label6.TabIndex = 47;
			this.label6.Text = "В файлах формата Excel (.xlsx) максимально допустимое количество столбцов 16384.";
			// 
			// lbEmpty
			// 
			this.lbEmpty.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbEmpty, true);
			this.lbEmpty.Location = new System.Drawing.Point(6, 671);
			this.lbEmpty.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbEmpty.Name = "lbEmpty";
			this.lbEmpty.Size = new System.Drawing.Size(22, 32);
			this.lbEmpty.TabIndex = 60;
			this.lbEmpty.Text = " ";
			// 
			// HelpProblem800A03EC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.Controls.Add(this.pnMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.Gainsboro;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "HelpProblem800A03EC";
			this.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
			this.Size = new System.Drawing.Size(1702, 800);
			this.pnMain.ResumeLayout(false);
			this.pnMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReasons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSolutions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lbHeader;
		private System.Windows.Forms.FlowLayoutPanel pnMain;
		private Label lbReasons;
		private Label label3;
		private Label lbSolutions;
		private Label label10;
	}
}
