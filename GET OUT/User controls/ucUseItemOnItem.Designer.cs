namespace GET_OUT
{
    partial class ucUseItemOnItem
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
            this.cmdNo = new System.Windows.Forms.Button();
            this.cmdYes = new System.Windows.Forms.Button();
            this.lblUseItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdNo
            // 
            this.cmdNo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdNo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdNo.Location = new System.Drawing.Point(175, 87);
            this.cmdNo.Name = "cmdNo";
            this.cmdNo.Size = new System.Drawing.Size(138, 43);
            this.cmdNo.TabIndex = 13;
            this.cmdNo.Text = "No";
            this.cmdNo.UseVisualStyleBackColor = false;
            this.cmdNo.Click += new System.EventHandler(this.cmdNo_Click);
            // 
            // cmdYes
            // 
            this.cmdYes.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdYes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdYes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdYes.Location = new System.Drawing.Point(21, 87);
            this.cmdYes.Name = "cmdYes";
            this.cmdYes.Size = new System.Drawing.Size(138, 43);
            this.cmdYes.TabIndex = 12;
            this.cmdYes.Text = "Yes";
            this.cmdYes.UseVisualStyleBackColor = false;
            this.cmdYes.Click += new System.EventHandler(this.cmdYes_Click);
            // 
            // lblUseItem
            // 
            this.lblUseItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUseItem.ForeColor = System.Drawing.Color.White;
            this.lblUseItem.Location = new System.Drawing.Point(3, 0);
            this.lblUseItem.Name = "lblUseItem";
            this.lblUseItem.Size = new System.Drawing.Size(323, 84);
            this.lblUseItem.TabIndex = 11;
            this.lblUseItem.Text = "Give Character Item";
            this.lblUseItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucUseItemOnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cmdNo);
            this.Controls.Add(this.cmdYes);
            this.Controls.Add(this.lblUseItem);
            this.Name = "ucUseItemOnItem";
            this.Size = new System.Drawing.Size(326, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdNo;
        private System.Windows.Forms.Button cmdYes;
        private System.Windows.Forms.Label lblUseItem;
    }
}
