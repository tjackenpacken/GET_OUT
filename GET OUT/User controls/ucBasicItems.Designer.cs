namespace GET_OUT
{
    partial class ucBasicItems
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
            this.cmdClosePickUpPanel = new System.Windows.Forms.Button();
            this.cmdPickUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClosePickUpPanel
            // 
            this.cmdClosePickUpPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmdClosePickUpPanel.ForeColor = System.Drawing.Color.Transparent;
            this.cmdClosePickUpPanel.Location = new System.Drawing.Point(364, 20);
            this.cmdClosePickUpPanel.Name = "cmdClosePickUpPanel";
            this.cmdClosePickUpPanel.Size = new System.Drawing.Size(30, 28);
            this.cmdClosePickUpPanel.TabIndex = 6;
            this.cmdClosePickUpPanel.Text = "X";
            this.cmdClosePickUpPanel.UseVisualStyleBackColor = true;
            this.cmdClosePickUpPanel.Click += new System.EventHandler(this.cmdClosePickUpPanel_Click);
            // 
            // cmdPickUp
            // 
            this.cmdPickUp.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdPickUp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdPickUp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdPickUp.Location = new System.Drawing.Point(52, 64);
            this.cmdPickUp.Name = "cmdPickUp";
            this.cmdPickUp.Size = new System.Drawing.Size(292, 65);
            this.cmdPickUp.TabIndex = 0;
            this.cmdPickUp.Text = "Pick up item";
            this.cmdPickUp.UseVisualStyleBackColor = false;
            this.cmdPickUp.Click += new System.EventHandler(this.cmdPickUp_Click);
            // 
            // ucBasicItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cmdClosePickUpPanel);
            this.Controls.Add(this.cmdPickUp);
            this.Location = new System.Drawing.Point(750, 452);
            this.Name = "ucBasicItems";
            this.Size = new System.Drawing.Size(420, 175);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdClosePickUpPanel;
        private System.Windows.Forms.Button cmdPickUp;
    }
}
