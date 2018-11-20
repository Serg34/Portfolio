using System.Windows.Forms;
using FSImark.Help.UI;

namespace FSImark.Help.ZZZ_Problem
{
	[HelpPanel("Проблемы")]
	public class HelpProblem : UserControl, IHelpPanel
	{
		public HelpProblem()
		{
			InitializeComponent();
		}
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
			this.pnHeader = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
			this.label21 = new System.Windows.Forms.Label();
			this.pnMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnHeader
			// 
			this.pnHeader.AutoSize = true;
			this.pnMain.SetFlowBreak(this.pnHeader, true);
			this.pnHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.pnHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.pnHeader.Location = new System.Drawing.Point(10, 9);
			this.pnHeader.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.pnHeader.Name = "pnHeader";
			this.pnHeader.Size = new System.Drawing.Size(160, 40);
			this.pnHeader.TabIndex = 0;
			this.pnHeader.Text = "Проблемы";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label11, true);
			this.label11.ForeColor = System.Drawing.Color.Gainsboro;
			this.label11.Location = new System.Drawing.Point(5, 62);
			this.label11.Margin = new System.Windows.Forms.Padding(5, 4, 5, 18);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(1203, 24);
			this.label11.TabIndex = 13;
			this.label11.Text = "В данном разделе рассматриваются возможные проблемы в работе приложения и описыва" +
    "ются способы решения этих проблем";
			// 
			// pnMain
			// 
			this.pnMain.AutoSize = true;
			this.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnMain.Controls.Add(this.pnHeader);
			this.pnMain.Controls.Add(this.label11);
			this.pnMain.Controls.Add(this.label21);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnMain.Location = new System.Drawing.Point(10, 9);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(1420, 149);
			this.pnMain.TabIndex = 2;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label21, true);
			this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label21.Location = new System.Drawing.Point(5, 113);
			this.label21.Margin = new System.Windows.Forms.Padding(5, 9, 5, 4);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(15, 32);
			this.label21.TabIndex = 28;
			this.label21.Text = "\r\n";
			// 
			// HelpProblem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.Controls.Add(this.pnMain);
			this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.Gainsboro;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "HelpProblem";
			this.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.Size = new System.Drawing.Size(1440, 547);
			this.pnMain.ResumeLayout(false);
			this.pnMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pnHeader;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.FlowLayoutPanel pnMain;
		private System.Windows.Forms.Label label21;
	}
}
