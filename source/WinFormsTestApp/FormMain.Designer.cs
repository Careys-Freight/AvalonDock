namespace AvalonDock.WinFormsTestApp
{
    partial class FormMain
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
			dockingManagerHost = new System.Windows.Forms.Integration.ElementHost();
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			menuItemVS2010 = new System.Windows.Forms.ToolStripMenuItem();
			menuItemMetro = new System.Windows.Forms.ToolStripMenuItem();
			menuItemGeneric = new System.Windows.Forms.ToolStripMenuItem();
			menuItemExpressionDark = new System.Windows.Forms.ToolStripMenuItem();
			menuItemExpressionLight = new System.Windows.Forms.ToolStripMenuItem();
			menuItemVs2013 = new System.Windows.Forms.ToolStripMenuItem();
			menuItemVS2013Dark = new System.Windows.Forms.ToolStripMenuItem();
			menuItemVS2013Blue = new System.Windows.Forms.ToolStripMenuItem();
			menuItemAero = new System.Windows.Forms.ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dockingManagerHost
			// 
			dockingManagerHost.Dock = System.Windows.Forms.DockStyle.Fill;
			dockingManagerHost.Location = new System.Drawing.Point(0, 30);
			dockingManagerHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			dockingManagerHost.Name = "dockingManagerHost";
			dockingManagerHost.Size = new System.Drawing.Size(898, 658);
			dockingManagerHost.TabIndex = 0;
			dockingManagerHost.Text = "elementHost1";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { themeToolStripMenuItem });
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
			menuStrip1.Size = new System.Drawing.Size(898, 30);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// themeToolStripMenuItem
			// 
			themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItemVS2010, menuItemMetro, menuItemGeneric, menuItemExpressionDark, menuItemExpressionLight, menuItemVs2013, menuItemVS2013Dark, menuItemVS2013Blue, menuItemAero });
			themeToolStripMenuItem.Name = "themeToolStripMenuItem";
			themeToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
			themeToolStripMenuItem.Text = "Theme";
			// 
			// menuItemVS2010
			// 
			menuItemVS2010.Name = "menuItemVS2010";
			menuItemVS2010.Size = new System.Drawing.Size(199, 26);
			menuItemVS2010.Text = "VS2010";
			menuItemVS2010.Click += menuItemVS2010_Click;
			// 
			// menuItemMetro
			// 
			menuItemMetro.Name = "menuItemMetro";
			menuItemMetro.Size = new System.Drawing.Size(199, 26);
			menuItemMetro.Text = "Metro";
			menuItemMetro.Click += menuItemMetro_Click;
			// 
			// menuItemGeneric
			// 
			menuItemGeneric.Name = "menuItemGeneric";
			menuItemGeneric.Size = new System.Drawing.Size(199, 26);
			menuItemGeneric.Text = "Generic";
			menuItemGeneric.Click += menuItemGeneric_Click;
			// 
			// menuItemExpressionDark
			// 
			menuItemExpressionDark.Name = "menuItemExpressionDark";
			menuItemExpressionDark.Size = new System.Drawing.Size(199, 26);
			menuItemExpressionDark.Text = "Expression Dark";
			menuItemExpressionDark.Click += menuItemExpressionDark_Click;
			// 
			// menuItemExpressionLight
			// 
			menuItemExpressionLight.Name = "menuItemExpressionLight";
			menuItemExpressionLight.Size = new System.Drawing.Size(199, 26);
			menuItemExpressionLight.Text = "Expression Light";
			menuItemExpressionLight.Click += menuItemExpressionLight_Click;
			// 
			// menuItemVs2013
			// 
			menuItemVs2013.Checked = true;
			menuItemVs2013.CheckState = System.Windows.Forms.CheckState.Checked;
			menuItemVs2013.Name = "menuItemVs2013";
			menuItemVs2013.Size = new System.Drawing.Size(199, 26);
			menuItemVs2013.Text = "VS2013";
			menuItemVs2013.Click += vS2013ToolStripMenuItem_Click;
			// 
			// menuItemVS2013Dark
			// 
			menuItemVS2013Dark.Name = "menuItemVS2013Dark";
			menuItemVS2013Dark.Size = new System.Drawing.Size(199, 26);
			menuItemVS2013Dark.Text = "VS 2013 Dark";
			menuItemVS2013Dark.Click += menuItemAero_Vs2013Dark;
			// 
			// menuItemVS2013Blue
			// 
			menuItemVS2013Blue.Name = "menuItemVS2013Blue";
			menuItemVS2013Blue.Size = new System.Drawing.Size(199, 26);
			menuItemVS2013Blue.Text = "VS 2013 Blue";
			menuItemVS2013Blue.Click += menuItemAero_Vs2013Blue;
			// 
			// menuItemAero
			// 
			menuItemAero.Name = "menuItemAero";
			menuItemAero.Size = new System.Drawing.Size(199, 26);
			menuItemAero.Text = "Aero";
			menuItemAero.Click += menuItemAero_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(898, 688);
			Controls.Add(dockingManagerHost);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			Name = "FormMain";
			Text = "Form1";
			Load += FormMain_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Integration.ElementHost dockingManagerHost;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemVS2013Dark;
        private System.Windows.Forms.ToolStripMenuItem menuItemVS2013Blue;
        private System.Windows.Forms.ToolStripMenuItem menuItemVS2010;
        private System.Windows.Forms.ToolStripMenuItem menuItemGeneric;
        private System.Windows.Forms.ToolStripMenuItem menuItemExpressionDark;
        private System.Windows.Forms.ToolStripMenuItem menuItemMetro;
        private System.Windows.Forms.ToolStripMenuItem menuItemExpressionLight;
        private System.Windows.Forms.ToolStripMenuItem menuItemVs2013;
        private System.Windows.Forms.ToolStripMenuItem menuItemAero;
    }
}

