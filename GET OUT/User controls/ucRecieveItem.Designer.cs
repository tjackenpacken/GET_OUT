namespace GET_OUT.Classes
{
    partial class ucRecieveItem
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
            this.picRecievedItem = new System.Windows.Forms.PictureBox();
            this.lblRecievedItem = new System.Windows.Forms.Label();
            this.cmdAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRecievedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // picRecievedItem
            // 
            this.picRecievedItem.Location = new System.Drawing.Point(160, 114);
            this.picRecievedItem.Name = "picRecievedItem";
            this.picRecievedItem.Size = new System.Drawing.Size(50, 60);
            this.picRecievedItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRecievedItem.TabIndex = 18;
            this.picRecievedItem.TabStop = false;
            // 
            // lblRecievedItem
            // 
            this.lblRecievedItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRecievedItem.ForeColor = System.Drawing.Color.White;
            this.lblRecievedItem.Location = new System.Drawing.Point(18, 31);
            this.lblRecievedItem.Name = "lblRecievedItem";
            this.lblRecievedItem.Size = new System.Drawing.Size(331, 69);
            this.lblRecievedItem.TabIndex = 17;
            this.lblRecievedItem.Text = "Item recieved";
            this.lblRecievedItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdAccept
            // 
            this.cmdAccept.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdAccept.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdAccept.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdAccept.Location = new System.Drawing.Point(41, 207);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(292, 65);
            this.cmdAccept.TabIndex = 15;
            this.cmdAccept.Text = "Accept Item";
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // ucRecieveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.picRecievedItem);
            this.Controls.Add(this.lblRecievedItem);
            this.Controls.Add(this.cmdAccept);
            this.Name = "ucRecieveItem";
            this.Size = new System.Drawing.Size(369, 333);
            ((System.ComponentModel.ISupportInitialize)(this.picRecievedItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRecievedItem;
        private System.Windows.Forms.Label lblRecievedItem;
        private System.Windows.Forms.Button cmdAccept;
    }
}
