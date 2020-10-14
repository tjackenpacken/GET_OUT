using GET_OUT.Classes;
using System;
using System.Windows.Forms;

namespace GET_OUT
{
    public partial class ucGiveItem : UserControl
    {
        public Player User { get; set; }
        public Item ClickedItem { get; set; }
        public Character ClickedCharacter { get; set; }
        public frmGame MainForm { get; set; }
        public Control MotherControl { get; set; }

        private System.Delegate _delCharacterReaction;
        public Delegate CallingCharacterReaction
        {
            set { _delCharacterReaction = value; }
        }

        public ucGiveItem(Player user, Item item, Character character, frmGame mainForm, Control motherControl)
        {
            InitializeComponent();

            MainForm = mainForm;
            MotherControl = motherControl;
            User = user;
            ClickedItem = item;
            ClickedCharacter = character;
            this.Left = (MainForm.Width - this.Width) / 2;
            this.Top = (MainForm.Height - this.Height) / 2;
            lblGiveItem.Text = "Give " + item.Name.ToLower() + " to " + character.Name;
        }

        private void cmdYes_Click(object sender, EventArgs e)
        {
            var giveItem = ClickedItem.GiveToCharacter(User, ClickedCharacter, ClickedItem);
            MainForm.CharacterReaction(giveItem.Item1, ClickedCharacter);
            this.Hide();

            if (giveItem.Item2) 
            {
                MotherControl.Hide();
                this.Hide();
                ucRecieveItem recieveItemControl = new ucRecieveItem(User, ClickedCharacter, this, MainForm);
                ClickedCharacter.IsSatisfied = true;
                MainForm.Controls.Add(recieveItemControl);
                recieveItemControl.Show();
                recieveItemControl.BringToFront();
            }
            

        }

        private void cmdNo_Click(object sender, EventArgs e)
        {
            MotherControl.Show();
            this.Hide();
        }
    }
}
