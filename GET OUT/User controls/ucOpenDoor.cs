using System;
using System.Windows.Forms;

namespace GET_OUT
{
    public partial class ucOpenDoor : UserControl
    {
        public Door ClickedDoor { get; set; }
        public Player User { get; set; }
        public string PlayerReaction { get; set; }
        public frmGame MainForm { get; set; }
        public ucOpenDoor(Door clickedDoor, Player user, frmGame mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            User = user;
            ClickedDoor = clickedDoor;
            this.Left = (MainForm.Width - this.Width) / 2;
            this.Top = (MainForm.Height - this.Height) / 2;
        }

        private void cmdItemClickedExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void cmdUnlockDoor_Click(object sender, EventArgs e)
        {
            if (User.HasBriefcase) MainForm.OpenItem(User, User.Briefcase, ClickedDoor);
            else MainForm.PlayerThinking("I dont have anything to keep all the keys i dont have.");
            this.Hide();
        }
    }
}
