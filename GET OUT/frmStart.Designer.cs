namespace GET_OUT
{
    partial class frmStart
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
            this.cmdExit = new System.Windows.Forms.Button();
            this.panelStart = new System.Windows.Forms.Panel();
            this.lblWakeUp = new System.Windows.Forms.Label();
            this.panelStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cmdExit.FlatAppearance.BorderSize = 2;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cmdExit.Location = new System.Drawing.Point(1748, 32);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(1);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(134, 48);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "Exit to desktop";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // panelStart
            // 
            this.panelStart.BackgroundImage = global::GET_OUT.Properties.Resources.WAKE_UP_1;
            this.panelStart.Controls.Add(this.lblWakeUp);
            this.panelStart.Location = new System.Drawing.Point(0, 0);
            this.panelStart.Margin = new System.Windows.Forms.Padding(0);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(1920, 1080);
            this.panelStart.TabIndex = 3;
            // 
            // lblWakeUp
            // 
            this.lblWakeUp.AutoSize = true;
            this.lblWakeUp.BackColor = System.Drawing.Color.Transparent;
            this.lblWakeUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWakeUp.Font = new System.Drawing.Font("Impact", 200F);
            this.lblWakeUp.ForeColor = System.Drawing.Color.Gray;
            this.lblWakeUp.Location = new System.Drawing.Point(888, 372);
            this.lblWakeUp.Name = "lblWakeUp";
            this.lblWakeUp.Size = new System.Drawing.Size(976, 325);
            this.lblWakeUp.TabIndex = 0;
            this.lblWakeUp.Text = "GET OUT";
            this.lblWakeUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWakeUp.Click += new System.EventHandler(this.lblWakeUp_Click);
            this.lblWakeUp.MouseLeave += new System.EventHandler(this.lblWakeUp_MouseLeave);
            this.lblWakeUp.MouseHover += new System.EventHandler(this.lblWakeUp_MouseHover);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GET_OUT.Properties.Resources.WAKE_UP_1;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.panelStart);
            this.Name = "frmStart";
            this.Text = "Form1";
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Label lblWakeUp;
    }
}

