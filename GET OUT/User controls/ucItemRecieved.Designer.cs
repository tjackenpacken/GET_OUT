namespace GET_OUT.Classes
{
    partial class ucItemRecieved
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
            this.cmdAccept = new System.Windows.Forms.Button();
            this.picRecievedItem = new System.Windows.Forms.PictureBox();
            this.lblRecievedItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRecievedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAccept
            // 
            this.cmdAccept.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdAccept.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdAccept.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdAccept.Location = new System.Drawing.Point(106, 214);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(231, 77);
            this.cmdAccept.TabIndex = 11;
            this.cmdAccept.Text = "Accept ";
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // picRecievedItem
            // 
            this.picRecievedItem.Location = new System.Drawing.Point(191, 110);
            this.picRecievedItem.Name = "picRecievedItem";
            this.picRecievedItem.Size = new System.Drawing.Size(63, 75);
            this.picRecievedItem.TabIndex = 12;
            this.picRecievedItem.TabStop = false;
            // 
            // lblRecievedItem
            // 
            this.lblRecievedItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRecievedItem.ForeColor = System.Drawing.Color.White;
            this.lblRecievedItem.Location = new System.Drawing.Point(3, 20);
            this.lblRecievedItem.Name = "lblRecievedItem";
            this.lblRecievedItem.Size = new System.Drawing.Size(452, 87);
            this.lblRecievedItem.TabIndex = 13;
            this.lblRecievedItem.Text = "Give Character Item";
            this.lblRecievedItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucItemRecieved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblRecievedItem);
            this.Controls.Add(this.picRecievedItem);
            this.Controls.Add(this.cmdAccept);
            this.Name = "ucItemRecieved";
            this.Size = new System.Drawing.Size(458, 327);
            ((System.ComponentModel.ISupportInitialize)(this.picRecievedItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.PictureBox picRecievedItem;
        private System.Windows.Forms.Label lblRecievedItem;
    }
}
