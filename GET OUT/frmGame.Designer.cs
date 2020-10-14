namespace GET_OUT
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.roomPanel = new System.Windows.Forms.Panel();
            this.picClothes = new System.Windows.Forms.PictureBox();
            this.picBriefcase = new System.Windows.Forms.PictureBox();
            this.lblPlayerThinking = new System.Windows.Forms.Label();
            this.playerReactionPanel = new System.Windows.Forms.PictureBox();
            this.cmdLightSwitch = new System.Windows.Forms.PictureBox();
            this.playerPanel = new System.Windows.Forms.PictureBox();
            this.cmdExitGame = new System.Windows.Forms.Button();
            this.panelDarkness = new System.Windows.Forms.PictureBox();
            this.roomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClothes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBriefcase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerReactionPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLightSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDarkness)).BeginInit();
            this.SuspendLayout();
            // 
            // roomPanel
            // 
            this.roomPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomPanel.BackgroundImage")));
            this.roomPanel.Controls.Add(this.picClothes);
            this.roomPanel.Controls.Add(this.picBriefcase);
            this.roomPanel.Controls.Add(this.lblPlayerThinking);
            this.roomPanel.Controls.Add(this.playerReactionPanel);
            this.roomPanel.Controls.Add(this.cmdLightSwitch);
            this.roomPanel.Controls.Add(this.playerPanel);
            this.roomPanel.Controls.Add(this.cmdExitGame);
            this.roomPanel.Controls.Add(this.panelDarkness);
            this.roomPanel.Location = new System.Drawing.Point(0, 0);
            this.roomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Size = new System.Drawing.Size(1920, 1080);
            this.roomPanel.TabIndex = 0;
            // 
            // picClothes
            // 
            this.picClothes.BackColor = System.Drawing.Color.Transparent;
            this.picClothes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClothes.Image = global::GET_OUT.Properties.Resources.ClothesDarkness;
            this.picClothes.Location = new System.Drawing.Point(1193, 582);
            this.picClothes.Name = "picClothes";
            this.picClothes.Size = new System.Drawing.Size(84, 48);
            this.picClothes.TabIndex = 15;
            this.picClothes.TabStop = false;
            this.picClothes.Click += new System.EventHandler(this.picClothes_Click);
            this.picClothes.MouseLeave += new System.EventHandler(this.picClothes_MouseLeave);
            this.picClothes.MouseHover += new System.EventHandler(this.picClothes_MouseHover);
            // 
            // picBriefcase
            // 
            this.picBriefcase.BackColor = System.Drawing.Color.Transparent;
            this.picBriefcase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBriefcase.Image = global::GET_OUT.Properties.Resources.BriefcaseDarkness;
            this.picBriefcase.Location = new System.Drawing.Point(1381, 521);
            this.picBriefcase.Name = "picBriefcase";
            this.picBriefcase.Size = new System.Drawing.Size(75, 115);
            this.picBriefcase.TabIndex = 13;
            this.picBriefcase.TabStop = false;
            this.picBriefcase.Click += new System.EventHandler(this.picBriefcase_Click);
            this.picBriefcase.MouseLeave += new System.EventHandler(this.picBriefcase_MouseLeave);
            this.picBriefcase.MouseHover += new System.EventHandler(this.picBriefcase_MouseHover);
            // 
            // lblPlayerThinking
            // 
            this.lblPlayerThinking.BackColor = System.Drawing.Color.White;
            this.lblPlayerThinking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerThinking.Location = new System.Drawing.Point(459, 84);
            this.lblPlayerThinking.Name = "lblPlayerThinking";
            this.lblPlayerThinking.Size = new System.Drawing.Size(229, 75);
            this.lblPlayerThinking.TabIndex = 9;
            this.lblPlayerThinking.Text = "label1";
            this.lblPlayerThinking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerThinking.Visible = false;
            // 
            // playerReactionPanel
            // 
            this.playerReactionPanel.Cursor = System.Windows.Forms.Cursors.No;
            this.playerReactionPanel.Image = global::GET_OUT.Properties.Resources.ThinkBubble;
            this.playerReactionPanel.Location = new System.Drawing.Point(425, 53);
            this.playerReactionPanel.Name = "playerReactionPanel";
            this.playerReactionPanel.Size = new System.Drawing.Size(300, 260);
            this.playerReactionPanel.TabIndex = 8;
            this.playerReactionPanel.TabStop = false;
            this.playerReactionPanel.MouseLeave += new System.EventHandler(this.playerReactionPanel_MouseLeave);
            this.playerReactionPanel.MouseHover += new System.EventHandler(this.playerReactionPanel_MouseHover);
            // 
            // cmdLightSwitch
            // 
            this.cmdLightSwitch.BackColor = System.Drawing.Color.Transparent;
            this.cmdLightSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLightSwitch.Image = global::GET_OUT.Properties.Resources.LightSwitchOff;
            this.cmdLightSwitch.Location = new System.Drawing.Point(957, 488);
            this.cmdLightSwitch.Name = "cmdLightSwitch";
            this.cmdLightSwitch.Size = new System.Drawing.Size(30, 46);
            this.cmdLightSwitch.TabIndex = 11;
            this.cmdLightSwitch.TabStop = false;
            this.cmdLightSwitch.Click += new System.EventHandler(this.cmdLightSwitch_Click);
            this.cmdLightSwitch.MouseLeave += new System.EventHandler(this.cmdLightSwitch_MouseLeave);
            this.cmdLightSwitch.MouseHover += new System.EventHandler(this.cmdLightSwitch_MouseHover);
            // 
            // playerPanel
            // 
            this.playerPanel.BackColor = System.Drawing.Color.Transparent;
            this.playerPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playerPanel.Image = global::GET_OUT.Properties.Resources.PlayerCharacterNakedDarkness;
            this.playerPanel.Location = new System.Drawing.Point(251, 298);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(170, 700);
            this.playerPanel.TabIndex = 2;
            this.playerPanel.TabStop = false;
            this.playerPanel.Click += new System.EventHandler(this.playerPanel_Click);
            this.playerPanel.MouseLeave += new System.EventHandler(this.playerPanel_MouseLeave);
            this.playerPanel.MouseHover += new System.EventHandler(this.playerPanel_MouseHover);
            // 
            // cmdExitGame
            // 
            this.cmdExitGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdExitGame.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cmdExitGame.FlatAppearance.BorderSize = 2;
            this.cmdExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExitGame.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cmdExitGame.Location = new System.Drawing.Point(1796, 14);
            this.cmdExitGame.Margin = new System.Windows.Forms.Padding(1);
            this.cmdExitGame.Name = "cmdExitGame";
            this.cmdExitGame.Size = new System.Drawing.Size(96, 48);
            this.cmdExitGame.TabIndex = 0;
            this.cmdExitGame.Text = "Exit game";
            this.cmdExitGame.UseVisualStyleBackColor = false;
            this.cmdExitGame.Click += new System.EventHandler(this.cmdExitGame_Click);
            // 
            // panelDarkness
            // 
            this.panelDarkness.BackColor = System.Drawing.Color.Transparent;
            this.panelDarkness.BackgroundImage = global::GET_OUT.Properties.Resources.Darkness;
            this.panelDarkness.Location = new System.Drawing.Point(0, 0);
            this.panelDarkness.Margin = new System.Windows.Forms.Padding(0);
            this.panelDarkness.Name = "panelDarkness";
            this.panelDarkness.Size = new System.Drawing.Size(1920, 1080);
            this.panelDarkness.TabIndex = 16;
            this.panelDarkness.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.roomPanel);
            this.Name = "frmGame";
            this.Text = "Form2";
            this.roomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClothes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBriefcase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerReactionPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLightSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDarkness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roomPanel;
        private System.Windows.Forms.Button cmdExitGame;
        public System.Windows.Forms.PictureBox playerPanel;
        private System.Windows.Forms.PictureBox playerReactionPanel;
        private System.Windows.Forms.Label lblPlayerThinking;
        public System.Windows.Forms.PictureBox cmdLightSwitch;
        public System.Windows.Forms.PictureBox picBriefcase;
        public System.Windows.Forms.PictureBox picClothes;
        private System.Windows.Forms.PictureBox panelDarkness;
        //
        // END OF CLASS
        //
    }
}