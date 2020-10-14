namespace GET_OUT
{
    partial class ucGiveItem
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
            this.lblGiveItem = new System.Windows.Forms.Label();
            this.cmdYes = new System.Windows.Forms.Button();
            this.cmdNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGiveItem
            // 
            this.lblGiveItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiveItem.ForeColor = System.Drawing.Color.White;
            this.lblGiveItem.Location = new System.Drawing.Point(-4, 0);
            this.lblGiveItem.Name = "lblGiveItem";
            this.lblGiveItem.Size = new System.Drawing.Size(369, 63);
            this.lblGiveItem.TabIndex = 8;
            this.lblGiveItem.Text = "Give Character Item";
            this.lblGiveItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdYes
            // 
            this.cmdYes.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdYes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdYes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdYes.Location = new System.Drawing.Point(29, 66);
            this.cmdYes.Name = "cmdYes";
            this.cmdYes.Size = new System.Drawing.Size(138, 43);
            this.cmdYes.TabIndex = 9;
            this.cmdYes.Text = "Yes";
            this.cmdYes.UseVisualStyleBackColor = false;
            this.cmdYes.Click += new System.EventHandler(this.cmdYes_Click);
            // 
            // cmdNo
            // 
            this.cmdNo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdNo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdNo.Location = new System.Drawing.Point(183, 66);
            this.cmdNo.Name = "cmdNo";
            this.cmdNo.Size = new System.Drawing.Size(138, 43);
            this.cmdNo.TabIndex = 10;
            this.cmdNo.Text = "No";
            this.cmdNo.UseVisualStyleBackColor = false;
            this.cmdNo.Click += new System.EventHandler(this.cmdNo_Click);
            // 
            // ucGiveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cmdNo);
            this.Controls.Add(this.cmdYes);
            this.Controls.Add(this.lblGiveItem);
            this.Name = "ucGiveItem";
            this.Size = new System.Drawing.Size(365, 135);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGiveItem;
        private System.Windows.Forms.Button cmdYes;
        private System.Windows.Forms.Button cmdNo;
    }
}
