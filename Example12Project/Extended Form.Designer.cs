namespace Example12Project
{
    partial class Extended_Form
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
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblExtendedCounter = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.NumericUpDown();
            this.lblStep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtStep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(493, 263);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(92, 54);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(253, 263);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(103, 54);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblExtendedCounter
            // 
            this.lblExtendedCounter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExtendedCounter.Location = new System.Drawing.Point(345, 133);
            this.lblExtendedCounter.Name = "lblExtendedCounter";
            this.lblExtendedCounter.Size = new System.Drawing.Size(117, 63);
            this.lblExtendedCounter.TabIndex = 3;
            this.lblExtendedCounter.Text = "0";
            this.lblExtendedCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(362, 283);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(120, 22);
            this.txtStep.TabIndex = 6;
            this.txtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(376, 252);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(35, 16);
            this.lblStep.TabIndex = 7;
            this.lblStep.Text = "Step";
            // 
            // Extended_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblExtendedCounter);
            this.Name = "Extended_Form";
            this.Text = "Extended_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Extended_Form_FormClosing);
            this.Enter += new System.EventHandler(this.Extended_Form_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.txtStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblExtendedCounter;
        private System.Windows.Forms.NumericUpDown txtStep;
        private System.Windows.Forms.Label lblStep;
    }
}