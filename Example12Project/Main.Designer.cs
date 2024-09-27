namespace Example12Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSimple = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExtended = new System.Windows.Forms.ToolStripMenuItem();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSimple,
            this.mnuExtended});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1100, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSimple
            // 
            this.mnuSimple.Name = "mnuSimple";
            this.mnuSimple.Size = new System.Drawing.Size(125, 24);
            this.mnuSimple.Text = "&Simple Counter";
            this.mnuSimple.Click += new System.EventHandler(this.mnuSimple_Click);
            // 
            // mnuExtended
            // 
            this.mnuExtended.Name = "mnuExtended";
            this.mnuExtended.Size = new System.Drawing.Size(141, 24);
            this.mnuExtended.Text = "&Extended Counter";
            this.mnuExtended.Click += new System.EventHandler(this.mnuExtended_Click);
            // 
            // stsBar
            // 
            this.stsBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stsBar.Location = new System.Drawing.Point(0, 762);
            this.stsBar.Name = "stsBar";
            this.stsBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stsBar.Size = new System.Drawing.Size(1100, 26);
            this.stsBar.TabIndex = 1;
            this.stsBar.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 20);
            this.lblStatus.Text = "Welcome";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 788);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Counter App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSimple;
        private System.Windows.Forms.ToolStripMenuItem mnuExtended;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

