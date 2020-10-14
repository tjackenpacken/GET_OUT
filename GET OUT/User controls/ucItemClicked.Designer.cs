namespace GET_OUT
{
    partial class ucItemClicked
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
            this.lblItemClicked = new System.Windows.Forms.Label();
            this.cmdUseItem = new System.Windows.Forms.Button();
            this.cmdAddToInventory = new System.Windows.Forms.Button();
            this.picClickedItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClickedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdItemClickedExit
            // 
            this.cmdItemClickedExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmdItemClickedExit.ForeColor = System.Drawing.Color.Transparent;
            this.cmdItemClickedExit.Location = new System.Drawing.Point(290, 11);
            this.cmdItemClickedExit.Name = "cmdItemClickedExit";
            this.cmdItemClickedExit.Size = new System.Drawing.Size(30, 28);
            this.cmdItemClickedExit.TabIndex = 9;
            this.cmdItemClickedExit.Text = "X";
            this.cmdItemClickedExit.UseVisualStyleBackColor = true;
            this.cmdItemClickedExit.Click += new System.EventHandler(this.cmdItemClickedExit_Click);
            // 
            // lblItemClicked
            // 
            this.lblItemClicked.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblItemClicked.ForeColor = System.Drawing.Color.White;
            this.lblItemClicked.Location = new System.Drawing.Point(1, 23);
            this.lblItemClicked.Name = "lblItemClicked";
            this.lblItemClicked.Size = new System.Drawing.Size(331, 63);
            this.lblItemClicked.TabIndex = 7;
            this.lblItemClicked.Text = "Item Action";
            this.lblItemClicked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdUseItem
            // 
            this.cmdUseItem.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdUseItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdUseItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdUseItem.Location = new System.Drawing.Point(24, 285);
            this.cmdUseItem.Name = "cmdUseItem";
            this.cmdUseItem.Size = new System.Drawing.Size(292, 65);
            this.cmdUseItem.TabIndex = 2;
            this.cmdUseItem.Text = "Use item";
            this.cmdUseItem.UseVisualStyleBackColor = false;
            this.cmdUseItem.Click += new System.EventHandler(this.cmdUseItem_Click);
            // 
            // cmdAddToInventory
            // 
            this.cmdAddToInventory.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdAddToInventory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdAddToInventory.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdAddToInventory.Location = new System.Drawing.Point(24, 198);
            this.cmdAddToInventory.Name = "cmdAddToInventory";
            this.cmdAddToInventory.Size = new System.Drawing.Size(292, 65);
            this.cmdAddToInventory.TabIndex = 1;
            this.cmdAddToInventory.Text = "Add item to inventory";
            this.cmdAddToInventory.UseVisualStyleBackColor = false;
            this.cmdAddToInventory.Click += new System.EventHandler(this.cmdAddToInventory_Click);
            // 
            // picClickedItem
            // 
            this.picClickedItem.Location = new System.Drawing.Point(77, 98);
            this.picClickedItem.Name = "picClickedItem";
            this.picClickedItem.Size = new System.Drawing.Size(184, 85);
            this.picClickedItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClickedItem.TabIndex = 8;
            this.picClickedItem.TabStop = false;
            // 
            // ucItemClicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cmdItemClickedExit);
            this.Controls.Add(this.picClickedItem);
            this.Controls.Add(this.lblItemClicked);
            this.Controls.Add(this.cmdUseItem);
            this.Controls.Add(this.cmdAddToInventory);
            this.Location = new System.Drawing.Point(790, 351);
            this.Name = "ucItemClicked";
            this.Size = new System.Drawing.Size(337, 380);
            ((System.ComponentModel.ISupportInitialize)(this.picClickedItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdItemClickedExit;
        private System.Windows.Forms.PictureBox picClickedItem;
        private System.Windows.Forms.Label lblItemClicked;
        private System.Windows.Forms.Button cmdUseItem;
        private System.Windows.Forms.Button cmdAddToInventory;
    }
}
