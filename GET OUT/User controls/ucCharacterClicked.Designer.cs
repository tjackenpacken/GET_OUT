namespace GET_OUT
{
    partial class ucCharacterClicked
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
            this.lblCharacterClicked = new System.Windows.Forms.Label();
            this.cmdGive = new System.Windows.Forms.Button();
            this.cmdTalk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdItemClickedExit
            // 
            this.cmdItemClickedExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmdItemClickedExit.ForeColor = System.Drawing.Color.Transparent;
            this.cmdItemClickedExit.Location = new System.Drawing.Point(292, 26);
            this.cmdItemClickedExit.Name = "cmdItemClickedExit";
            this.cmdItemClickedExit.Size = new System.Drawing.Size(30, 28);
            this.cmdItemClickedExit.TabIndex = 14;
            this.cmdItemClickedExit.Text = "X";
            this.cmdItemClickedExit.UseVisualStyleBackColor = true;
            this.cmdItemClickedExit.Click += new System.EventHandler(this.cmdItemClickedExit_Click);
            // 
            // lblCharacterClicked
            // 
            this.lblCharacterClicked.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCharacterClicked.ForeColor = System.Drawing.Color.White;
            this.lblCharacterClicked.Location = new System.Drawing.Point(3, 15);
            this.lblCharacterClicked.Name = "lblCharacterClicked";
            this.lblCharacterClicked.Size = new System.Drawing.Size(331, 104);
            this.lblCharacterClicked.TabIndex = 12;
            this.lblCharacterClicked.Text = "Character Action";
            this.lblCharacterClicked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdGive
            // 
            this.cmdGive.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdGive.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdGive.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdGive.Location = new System.Drawing.Point(21, 209);
            this.cmdGive.Name = "cmdGive";
            this.cmdGive.Size = new System.Drawing.Size(292, 65);
            this.cmdGive.TabIndex = 11;
            this.cmdGive.Text = "Give Character Item";
            this.cmdGive.UseVisualStyleBackColor = false;
            this.cmdGive.Click += new System.EventHandler(this.cmdGive_Click);
            // 
            // cmdTalk
            // 
            this.cmdTalk.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cmdTalk.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdTalk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdTalk.Location = new System.Drawing.Point(21, 122);
            this.cmdTalk.Name = "cmdTalk";
            this.cmdTalk.Size = new System.Drawing.Size(292, 65);
            this.cmdTalk.TabIndex = 10;
            this.cmdTalk.Text = "Talk to Character";
            this.cmdTalk.UseVisualStyleBackColor = false;
            this.cmdTalk.Click += new System.EventHandler(this.cmdTalk_Click);
            // 
            // ucCharacterClicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cmdItemClickedExit);
            this.Controls.Add(this.lblCharacterClicked);
            this.Controls.Add(this.cmdGive);
            this.Controls.Add(this.cmdTalk);
            this.Location = new System.Drawing.Point(790, 351);
            this.Name = "ucCharacterClicked";
            this.Size = new System.Drawing.Size(337, 308);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdItemClickedExit;
        private System.Windows.Forms.Label lblCharacterClicked;
        private System.Windows.Forms.Button cmdGive;
        private System.Windows.Forms.Button cmdTalk;
    }
}
