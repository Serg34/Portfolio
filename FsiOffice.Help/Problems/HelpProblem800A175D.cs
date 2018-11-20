using System.Windows.Forms;
using FSImark.Help.UI;

namespace FSImark.Help.ZZZ_Problem.Word
{
	[HelpPanel("Ошибка HRESULT: 0x800A175D")]
	public partial class HelpProblem800A175D : UserControl, IHelpPanel
	{
		public HelpProblem800A175D()
		{
			InitializeComponent();
		}

		private Label lbReasons;
		private PictureBox pbReasons;
		private Label lbSolutions;
		private PictureBox pbSolutions;
		private Label label2;
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
			this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
			this.lbReasons = new System.Windows.Forms.Label();
			this.pbReasons = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbSolutions = new System.Windows.Forms.Label();
			this.pbSolutions = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
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
			this.lbHeader.Size = new System.Drawing.Size(521, 50);
			this.lbHeader.TabIndex = 0;
			this.lbHeader.Text = "Тип ошибки: System.Runtime.InteropServices.COMException\r\nИсключение из HRESULT: 0" +
    "x800A175D";
			// 
			// pnMain
			// 
			this.pnMain.AutoSize = true;
			this.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnMain.Controls.Add(this.lbHeader);
			this.pnMain.Controls.Add(this.lbReasons);
			this.pnMain.Controls.Add(this.pbReasons);
			this.pnMain.Controls.Add(this.label2);
			this.pnMain.Controls.Add(this.lbSolutions);
			this.pnMain.Controls.Add(this.pbSolutions);
			this.pnMain.Controls.Add(this.label3);
			this.pnMain.Controls.Add(this.label4);
			this.pnMain.Controls.Add(this.label5);
			this.pnMain.Controls.Add(this.label6);
			this.pnMain.Controls.Add(this.label7);
			this.pnMain.Controls.Add(this.label8);
			this.pnMain.Controls.Add(this.label9);
			this.pnMain.Controls.Add(this.label10);
			this.pnMain.Controls.Add(this.lbEmpty);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnMain.Location = new System.Drawing.Point(12, 13);
			this.pnMain.Margin = new System.Windows.Forms.Padding(4);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(1638, 757);
			this.pnMain.TabIndex = 2;
			// 
			// lbReasons
			// 
			this.lbReasons.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbReasons, true);
			this.lbReasons.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbReasons.Location = new System.Drawing.Point(6, 83);
			this.lbReasons.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbReasons.Name = "lbReasons";
			this.lbReasons.Size = new System.Drawing.Size(179, 21);
			this.lbReasons.TabIndex = 59;
			this.lbReasons.Text = "Возможные причины:";
			// 
			// pbReasons
			// 
			this.pbReasons.Image = global::FSImark.Properties.Resources.WarningIcon;
			this.pbReasons.Location = new System.Drawing.Point(6, 138);
			this.pbReasons.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pbReasons.Name = "pbReasons";
			this.pbReasons.Size = new System.Drawing.Size(24, 24);
			this.pbReasons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbReasons.TabIndex = 61;
			this.pbReasons.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label2, true);
			this.label2.Location = new System.Drawing.Point(42, 138);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(539, 42);
			this.label2.TabIndex = 63;
			this.label2.Text = "В приложении Microsoft Office  включен режим защищенного просмотра\r\n ";
			// 
			// lbSolutions
			// 
			this.lbSolutions.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbSolutions, true);
			this.lbSolutions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbSolutions.Location = new System.Drawing.Point(6, 214);
			this.lbSolutions.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbSolutions.Name = "lbSolutions";
			this.lbSolutions.Size = new System.Drawing.Size(82, 21);
			this.lbSolutions.TabIndex = 60;
			this.lbSolutions.Text = "Решение:";
			// 
			// pbSolutions
			// 
			this.pbSolutions.Image = global::FSImark.Properties.Resources.Check32;
			this.pbSolutions.Location = new System.Drawing.Point(6, 269);
			this.pbSolutions.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pbSolutions.Name = "pbSolutions";
			this.pbSolutions.Size = new System.Drawing.Size(24, 24);
			this.pbSolutions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbSolutions.TabIndex = 62;
			this.pbSolutions.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label3, true);
			this.label3.Location = new System.Drawing.Point(42, 269);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(220, 21);
			this.label3.TabIndex = 37;
			this.label3.Text = "Открыть MS Word (MS Excel).";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label4, true);
			this.label4.Location = new System.Drawing.Point(6, 324);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(168, 21);
			this.label4.TabIndex = 38;
			this.label4.Text = "Войдите в Параметры";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label5, true);
			this.label5.Location = new System.Drawing.Point(6, 379);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(654, 21);
			this.label5.TabIndex = 39;
			this.label5.Text = "Нажмите Центр управления безопасностью, а затем нажмите кнопку Параметры центра.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label6, true);
			this.label6.Location = new System.Drawing.Point(6, 434);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(664, 21);
			this.label6.TabIndex = 40;
			this.label6.Text = "Нажмите параметры защищенного просмотра. Снимите галочку со следующих элементов:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label7, true);
			this.label7.Location = new System.Drawing.Point(6, 489);
			this.label7.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(605, 21);
			this.label7.TabIndex = 41;
			this.label7.Text = "- Включить режим защищенного просмотра для файлов, исходящих из Интернета.";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label8, true);
			this.label8.Location = new System.Drawing.Point(6, 544);
			this.label8.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(776, 21);
			this.label8.TabIndex = 42;
			this.label8.Text = "- Включить режим защищенного просмотра для файлов, расположенных в потенциально о" +
    "пасных местах.";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label9, true);
			this.label9.Location = new System.Drawing.Point(6, 599);
			this.label9.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(498, 21);
			this.label9.TabIndex = 43;
			this.label9.Text = "- Включить режим защищенного просмотра для вложений Outlook.";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.pnMain.SetFlowBreak(this.label10, true);
			this.label10.Location = new System.Drawing.Point(6, 654);
			this.label10.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(108, 21);
			this.label10.TabIndex = 44;
			this.label10.Text = "Выберите OK.";
			// 
			// lbEmpty
			// 
			this.lbEmpty.AutoSize = true;
			this.pnMain.SetFlowBreak(this.lbEmpty, true);
			this.lbEmpty.Location = new System.Drawing.Point(6, 709);
			this.lbEmpty.Margin = new System.Windows.Forms.Padding(6, 7, 6, 27);
			this.lbEmpty.Name = "lbEmpty";
			this.lbEmpty.Size = new System.Drawing.Size(14, 21);
			this.lbEmpty.TabIndex = 64;
			this.lbEmpty.Text = " ";
			// 
			// HelpProblem800A175D
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.Controls.Add(this.pnMain);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.Gainsboro;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "HelpProblem800A175D";
			this.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
			this.Size = new System.Drawing.Size(1662, 800);
			this.pnMain.ResumeLayout(false);
			this.pnMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReasons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSolutions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lbHeader;
		private FlowLayoutPanel pnMain;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
	}
}
