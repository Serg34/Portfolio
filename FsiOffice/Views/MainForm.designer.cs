namespace FSImark.UI
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelItem = new System.Windows.Forms.Panel();
			this.treeViewMenu = new System.Windows.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pnTreeView = new System.Windows.Forms.Panel();
			this.pnMenu = new System.Windows.Forms.FlowLayoutPanel();
			this.btAboutProgram = new System.Windows.Forms.Button();
			this.btHelp = new System.Windows.Forms.Button();
			this.btAllApps = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnTreeView.SuspendLayout();
			this.pnMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelItem
			// 
			this.panelItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelItem.Location = new System.Drawing.Point(254, 0);
			this.panelItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panelItem.Name = "panelItem";
			this.panelItem.Size = new System.Drawing.Size(730, 562);
			this.panelItem.TabIndex = 1;
			// 
			// treeViewMenu
			// 
			this.treeViewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.treeViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewMenu.ForeColor = System.Drawing.Color.Gainsboro;
			this.treeViewMenu.FullRowSelect = true;
			this.treeViewMenu.HideSelection = false;
			this.treeViewMenu.Location = new System.Drawing.Point(0, 28);
			this.treeViewMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.treeViewMenu.Name = "treeViewMenu";
			this.treeViewMenu.ShowLines = false;
			this.treeViewMenu.Size = new System.Drawing.Size(250, 534);
			this.treeViewMenu.TabIndex = 0;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.splitter1.Location = new System.Drawing.Point(250, 0);
			this.splitter1.MinExtra = 400;
			this.splitter1.MinSize = 100;
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(4, 562);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// pnTreeView
			// 
			this.pnTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.pnTreeView.Controls.Add(this.treeViewMenu);
			this.pnTreeView.Controls.Add(this.pnMenu);
			this.pnTreeView.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnTreeView.Location = new System.Drawing.Point(0, 0);
			this.pnTreeView.Name = "pnTreeView";
			this.pnTreeView.Size = new System.Drawing.Size(250, 562);
			this.pnTreeView.TabIndex = 12;
			// 
			// pnMenu
			// 
			this.pnMenu.AutoSize = true;
			this.pnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnMenu.Controls.Add(this.btAboutProgram);
			this.pnMenu.Controls.Add(this.btHelp);
			this.pnMenu.Controls.Add(this.btAllApps);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.pnMenu.Location = new System.Drawing.Point(0, 0);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(250, 28);
			this.pnMenu.TabIndex = 6;
			// 
			// btAboutProgram
			// 
			this.btAboutProgram.AutoSize = true;
			this.btAboutProgram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btAboutProgram.FlatAppearance.BorderSize = 0;
			this.btAboutProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAboutProgram.Image = global::FSImark.Properties.Resources.InfoIcon;
			this.btAboutProgram.Location = new System.Drawing.Point(225, 3);
			this.btAboutProgram.Name = "btAboutProgram";
			this.btAboutProgram.Size = new System.Drawing.Size(22, 22);
			this.btAboutProgram.TabIndex = 4;
			this.toolTip.SetToolTip(this.btAboutProgram, "О программе");
			this.btAboutProgram.UseVisualStyleBackColor = true;
			this.btAboutProgram.Click += new System.EventHandler(this.btAboutProgram_Click);
			// 
			// btHelp
			// 
			this.btHelp.AutoSize = true;
			this.btHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btHelp.FlatAppearance.BorderSize = 0;
			this.btHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btHelp.Image = global::FSImark.Properties.Resources.HelpIcon;
			this.btHelp.Location = new System.Drawing.Point(197, 3);
			this.btHelp.Name = "btHelp";
			this.btHelp.Size = new System.Drawing.Size(22, 22);
			this.btHelp.TabIndex = 3;
			this.toolTip.SetToolTip(this.btHelp, "Справка");
			this.btHelp.UseVisualStyleBackColor = true;
			this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
			// 
			// btAllApps
			// 
			this.btAllApps.AutoSize = true;
			this.btAllApps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btAllApps.FlatAppearance.BorderSize = 0;
			this.btAllApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAllApps.Image = global::FSImark.Properties.Resources.DownloadIcon16;
			this.btAllApps.Location = new System.Drawing.Point(169, 3);
			this.btAllApps.Name = "btAllApps";
			this.btAllApps.Size = new System.Drawing.Size(22, 22);
			this.btAllApps.TabIndex = 5;
			this.toolTip.SetToolTip(this.btAllApps, "Все продукты");
			this.btAllApps.UseVisualStyleBackColor = true;
			this.btAllApps.Click += new System.EventHandler(this.btAllApps_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(984, 562);
			this.Controls.Add(this.panelItem);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.pnTreeView);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.Gainsboro;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FSI Office";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.pnTreeView.ResumeLayout(false);
			this.pnTreeView.PerformLayout();
			this.pnMenu.ResumeLayout(false);
			this.pnMenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelItem;
		private System.Windows.Forms.TreeView treeViewMenu;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pnTreeView;
		private System.Windows.Forms.FlowLayoutPanel pnMenu;
		private System.Windows.Forms.Button btHelp;
		private System.Windows.Forms.Button btAboutProgram;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btAllApps;
	}
}