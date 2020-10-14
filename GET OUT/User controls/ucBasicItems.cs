using System;
using System.Windows.Forms;

namespace GET_OUT
{
    public partial class ucBasicItems : UserControl
    {
        public Player User { get; set; }
        public Item ClickedItem { get; set; }
        public frmGame MainForm { get; set; }
        public ucBasicItems(Item item, Player user, frmGame mainForm)
        {
            InitializeComponent();
            User = user;
            ClickedItem = item;
            MainForm = mainForm;
            cmdPickUp.Text = "Pick up " + item.Name.ToLower();
        }

        private void cmdPickUp_Click(object sender, EventArgs e)
        {
            MainForm.BasicItems(ClickedItem);
            this.Hide();
        }

        private void cmdClosePickUpPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
