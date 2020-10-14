using System;
using System.Windows.Forms;

namespace GET_OUT.Classes
{
    public partial class ucRecieveItem : UserControl
    {
        public Player User { get; set; }
        public Character RecievedFrom { get; set; }
        public Item RecievedItem { get; set; }
        public Control MotherControl { get; set; }
        public frmGame MainForm { get; set; }
        public ucRecieveItem(Player user, Character character, Control motherControl, frmGame mainForm)
        {
            InitializeComponent();

            User = user;
            RecievedFrom = character;
            RecievedItem = character.SatisfactionItem;
            MotherControl = motherControl;
            MainForm = mainForm;

            this.Left = (MainForm.Width - this.Width) / 2;
            this.Top = (MainForm.Height - this.Height) / 2;

            lblRecievedItem.Text = "Recieved " + RecievedItem.Name.ToLower() + "\nfrom " + RecievedFrom.Name;
            picRecievedItem.Image = RecievedItem.Image;
        }

        private void cmdAccept_Click(object sender, EventArgs e)
        {
            string result = RecievedItem.PutInInventory(User, RecievedFrom, RecievedItem, MotherControl, MainForm);

            if (result == "Yes")
            {

                MainForm.PlayerThinking(User.PlayerResponse(true, RecievedItem.Name));
                MotherControl.Hide();
                this.Hide();
            }
            else if (result == "No slots")
            {
                MainForm.PlayerThinking("I dont have any space in my inventory");
                MotherControl.Hide();
                this.Hide();
            }
        }
    }
}
