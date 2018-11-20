namespace FSImark.UI
{
	partial class AboutProgramForm
	{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgramForm));
			this.lbCopyRight = new System.Windows.Forms.Label();
			this.lbVersion = new System.Windows.Forms.Label();
			this.lbMail = new System.Windows.Forms.Label();
			this.pbTitle = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// lbCopyRight
			// 
			this.lbCopyRight.AutoSize = true;
			this.lbCopyRight.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbCopyRight.Location = new System.Drawing.Point(8, 168);
			this.lbCopyRight.Margin = new System.Windows.Forms.Padding(5);
			this.lbCopyRight.Name = "lbCopyRight";
			this.lbCopyRight.Padding = new System.Windows.Forms.Padding(3);
			this.lbCopyRight.Size = new System.Drawing.Size(281, 22);
			this.lbCopyRight.TabIndex = 1;
			this.lbCopyRight.Text = "© Фурманов С.И. Все права защищены 2016-2018";
			// 
			// lbVersion
			// 
			this.lbVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbVersion.Location = new System.Drawing.Point(8, 145);
			this.lbVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lbVersion.Name = "lbVersion";
			this.lbVersion.Size = new System.Drawing.Size(384, 23);
			this.lbVersion.TabIndex = 2;
			this.lbVersion.Text = "Версия 1.0.0.0";
			this.lbVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbMail
			// 
			this.lbMail.AutoSize = true;
			this.lbMail.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbMail.Location = new System.Drawing.Point(8, 190);
			this.lbMail.Margin = new System.Windows.Forms.Padding(5);
			this.lbMail.Name = "lbMail";
			this.lbMail.Padding = new System.Windows.Forms.Padding(3);
			this.lbMail.Size = new System.Drawing.Size(128, 22);
			this.lbMail.TabIndex = 4;
			this.lbMail.Text = "Serg34_85@mail.ru";
			// 
			// pbTitle
			// 
			this.pbTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbTitle.Image = global::FSImark.Properties.Resources.Fsi;
			this.pbTitle.Location = new System.Drawing.Point(8, 30);
			this.pbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbTitle.Name = "pbTitle";
			this.pbTitle.Size = new System.Drawing.Size(384, 115);
			this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTitle.TabIndex = 3;
			this.pbTitle.TabStop = false;
			// 
			// AboutProgramForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(400, 220);
			this.Controls.Add(this.lbVersion);
			this.Controls.Add(this.pbTitle);
			this.Controls.Add(this.lbCopyRight);
			this.Controls.Add(this.lbMail);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutProgramForm";
			this.Padding = new System.Windows.Forms.Padding(8, 30, 8, 8);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "О программе";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutProgramForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbCopyRight;
		private System.Windows.Forms.Label lbVersion;
		private System.Windows.Forms.PictureBox pbTitle;
		private System.Windows.Forms.Label lbMail;
	}
}