namespace GET_OUT
{
    partial class ucOpenDoor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdItemClickedExit = new System.Windows.Forms.Button();
            this.cmdUnlockDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdItemClickedExit
            // 
            this.cmdItemClickedExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmdItemClickedExit.ForeColor = System.Drawing.Color.Transparent;
            this.cmdItemClickedExit.Location = new System.Drawing.Point(418, 10);
            this.cmdItemClickedExit.Name = "cmdItemClickedExit";
            this.cmdItemClickedExit.Size = new System.Drawing.Size(30, 30);
            this.cmdItemClickedExit.TabIndex = 14;
            this.cmdItemClickedExit.Text = "X";
            this.cmdItemClickedExit.UseVisualStyleBackColor = true;
            this.cmdItemClickedExit.Click += new System.EventHandler(this.cmdItemClickedExit_Click);
            // 
            // cmdUnlockDoor
            // 
            this.cmdUnlockDoor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdUnlockDoor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdUnlockDoor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdUnlockDoor.Location = new System.Drawing.Point(86, 52);
            this.cmdUnlockDoor.Name = "cmdUnlockDoor";
            this.cmdUnlockDoor.Size = new System.Drawing.Size(292, 65);
            this.cmdUnlockDoor.TabIndex = 11;
            this.cmdUnlockDoor.Text = "Unlock door with key...";
            this.cmdUnlockDoor.UseVisualStyleBackColor = false;
            this.cmdUnlockDoor.Click += new System.EventHandler(this.cmdUnlockDoor_Click);
            // 
            // ucOpenDoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cmdItemClickedExit);
            this.Controls.Add(this.cmdUnlockDoor);
            this.Name = "ucOpenDoor";
            this.Size = new System.Drawing.Size(461, 170);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdItemClickedExit;
        private System.Windows.Forms.Button cmdUnlockDoor;
    }
}
