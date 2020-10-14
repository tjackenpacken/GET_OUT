using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GET_OUT
{
    public partial class ucCharacterClicked : UserControl
    {
        public Character ClickedCharacter { get; set; }
        public Player User { get; set; }
        public Room ActiveRoom { get; set; }
        public frmGame MainForm { get; set; }

        public ucCharacterClicked(Character character, Player user, Room activeRoom, frmGame mainForm)
        {
            InitializeComponent();
            ClickedCharacter = character;
            User = user;
            ActiveRoom = activeRoom;
            MainForm = mainForm;
            lblCharacterClicked.Text = ClickedCharacter.Name;
            cmdTalk.Text = "Talk to " + ClickedCharacter.Name;
            cmdGive.Text = "Give " + ClickedCharacter.Name + " an Item";
            this.Left = (MainForm.Width - this.Width) / 2;
            this.Top = (MainForm.Height - this.Height) / 2;

        }

        private async void cmdTalk_Click(object sender, EventArgs e)
        {
            this.Hide();
            var conversation = ClickedCharacter.TalkToCharacter(User);
            MainForm.PlayerSaying(conversation.Item1);
            await Task.Delay(2000);
            MainForm.CharacterReaction(conversation.Item2, ClickedCharacter);
        }

        private void cmdGive_Click(object sender, EventArgs e)
        {
            if (User.HasBriefcase)
            {
                MainForm.OpenItem(User, User.Briefcase, ClickedCharacter);
                this.Hide();
            }
            else MainForm.PlayerThinking("I dont even have something to put things in, how could i have something to give?");

        }

        private void cmdItemClickedExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
