using System;
using System.Windows.Forms;

namespace GET_OUT.Classes
{
    public partial class ucItemRecieved : UserControl
    {
        public Player User { get; set; }
        public Character RecievedFrom { get; set; }
        public Item RecievedItem { get; set; }
        public Control MotherControl { get; set; }
        public Form MainForm { get; set; }
        public ucItemRecieved(Player user, Character character, Item item, Control motherControl, Form mainForm)
        {
            InitializeComponent();

            User = user;
            RecievedFrom = character;
            RecievedItem = item;
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
                MessageBox.Show("Got it");
                MotherControl.Hide();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Didnt get it");
                MotherControl.Hide();
                this.Hide();
            }
        }
    }
}
