using System.Windows.Forms;
using FSImark.Help.UI;

namespace FSImark.Help.ZZZ_Problem.EXCEL
{
	[HelpPanel("Не завершается процесс")]
	public class HelpNoFinish : UserControl, IHelpPanel
	{
		public HelpNoFinish()
		{
			InitializeComponent();
		}

		private Label lbReasons;
		private PictureBox pbReasons;
		private Label lbSolutions;
		private PictureBox pbSolutions;
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
			this.label2 = new System.Windows.Forms.Label();
			this.lbEmpty = new System.Windows.Forms.Label();
			this.pnMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReasons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSolutions)).BeginInit();
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
			this.lbHeader.Size = new System.Drawing.Size(512, 80);
			this.lbHeader.TabIndex = 0;
			this.lbHeader.Text = "Не завершается процесс.\r\nСообщения об ошибке не выдаются.";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label11, true);
			this.label11.Location = new System.Drawing.Point(6, 217);
			this.label11.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(1615, 96);
			this.label11.TabIndex = 13;
			this.label11.Text = "Сбой программы при  появлении диалогового окна Excel с предупреждением о несущест" +
    "венной потери точности при сохранении в формате Excel 97-2003 (.xls)\r\n ";
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
			this.pnMain.Controls.Add(this.label2);
			this.pnMain.Controls.Add(this.lbEmpty);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.pnMain.Location = new System.Drawing.Point(12, 13);
			this.pnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(1678, 498);
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
			this.lbReasons.TabIndex = 55;
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
			this.pbReasons.TabIndex = 57;
			this.pbReasons.TabStop = false;
			// 
			// lbSolutions
			// 
			this.lbSolutions.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbSolutions, true);
			this.lbSolutions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbSolutions.Location = new System.Drawing.Point(6, 327);
			this.lbSolutions.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbSolutions.Name = "lbSolutions";
			this.lbSolutions.Size = new System.Drawing.Size(121, 32);
			this.lbSolutions.TabIndex = 56;
			this.lbSolutions.Text = "Решение:";
			// 
			// pbSolutions
			// 
			this.pbSolutions.Image = global::FSImark.Properties.Resources.Check32;
			this.pbSolutions.Location = new System.Drawing.Point(6, 393);
			this.pbSolutions.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pbSolutions.Name = "pbSolutions";
			this.pbSolutions.Size = new System.Drawing.Size(24, 24);
			this.pbSolutions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbSolutions.TabIndex = 58;
			this.pbSolutions.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label2, true);
			this.label2.Location = new System.Drawing.Point(42, 393);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(685, 32);
			this.label2.TabIndex = 29;
			this.label2.Text = "Сохраните файл в формате Excel (.xlsx) и повторите попытку";
			// 
			// lbEmpty
			// 
			this.lbEmpty.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbEmpty, true);
			this.lbEmpty.Location = new System.Drawing.Point(6, 439);
			this.lbEmpty.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbEmpty.Name = "lbEmpty";
			this.lbEmpty.Size = new System.Drawing.Size(22, 32);
			this.lbEmpty.TabIndex = 59;
			this.lbEmpty.Text = " ";
			// 
			// HelpNoFinish
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.Controls.Add(this.pnMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.Gainsboro;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "HelpNoFinish";
			this.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
			this.Size = new System.Drawing.Size(1702, 800);
			this.pnMain.ResumeLayout(false);
			this.pnMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReasons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSolutions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbHeader;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.FlowLayoutPanel pnMain;
		private System.Windows.Forms.Label label2;
	}
}
