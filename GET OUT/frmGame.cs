using GET_OUT.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GET_OUT
{
    public partial class frmGame : Form
    {
        //
        // PROPERTIES
        //
        public Player User { get; set; }
        public Image PlayerImage { get; set; }
        public Item ClickedItem { get; set; }
        public Room ActiveRoom { get; set; }
        public bool IsDark { get; set; }
        //
        // USER CONTOL PROPERTIES
        //
        public UserControl ItemOpen { get; set; }
        public UserControl ItemClick { get; set; }
        //
        // ROOM CONTROLS PROPERTIES
        //
        public List<Control> RoomControls { get; set; }
        public PictureBox CharacterReactionPanel { get; set; }
        public Label CharacterReactionLabel { get; set; }
        public PictureBox DarknessPanel { get; set; }
        public List<Control> DisableControlList { get; set; }
        //
        // START CONSTRUCTOR
        //
        public frmGame()
        {
            InitializeComponent();
            //
            // FULLSCREEN
            //
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            //
            // ANTI FLICKER
            //
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //
            // SETTING PROPERTY VALUES
            //
            User = new Player("Paul");
            IsDark = true;
            DarknessPanel = panelDarkness;
            DisableControlList = new List<Control>();
            RoomControls = new List<Control> { cmdLightSwitch, picBriefcase, picClothes };
            //
            // CREATE ROOMS
            //
            Repository.CreateRooms();
            ActiveRoom = Repository.StartingRoom;
            OpenRoom(ActiveRoom);
            //
            // ROOM 1 STARTING VALUES
            //
            playerReactionPanel.BackColor = Color.Transparent;
            playerReactionPanel.Hide();
            playerPanel.BackgroundImage = PlayerImage;
            playerPanel.BackColor = Color.Transparent;
            User.Briefcase = Repository.Briefcase;
        }
        //
        // Change room
        //
        public void OpenRoom(Room nextRoom)
        {
            if (nextRoom.Name == "End point") EndScene();
            else
            {
                foreach (Control control in RoomControls) 
                        control.Hide();
                ActiveRoom = nextRoom;
                RoomControls.Clear();
                roomPanel.BackgroundImage = nextRoom.Image;
                playerPanel.Location = new Point(nextRoom.PlayerLocation[0], nextRoom.PlayerLocation[1]);
                playerReactionPanel.Location = nextRoom.ThinkingLocation;
                playerReactionPanel.Image = nextRoom.ThinkImage;
                lblPlayerThinking.Location = new Point(playerReactionPanel.Left + 35 , playerReactionPanel.Top + 31);

                foreach (ItemSlot itemSlot in nextRoom.ItemSlotList.Where(itemSlot => itemSlot.SlottedItem != null)) // BUILDING ROOM ITEM PANELS
                {
                    itemSlot.SlottedItem.ItemSlot = itemSlot;
                    this.itemPanel = new System.Windows.Forms.PictureBox();
                    this.itemPanel.BackColor = System.Drawing.Color.Transparent;
                    this.itemPanel.Location = new System.Drawing.Point(itemSlot.Position[0], itemSlot.Position[1]);
                    this.itemPanel.Name = itemSlot.SlottedItem.Name.ToLower() + "Panel";
                    this.itemPanel.Size = new System.Drawing.Size(itemSlot.SlottedItem.Size[0], itemSlot.SlottedItem.Size[1]);
                    this.itemPanel.BackgroundImage = itemSlot.SlottedItem.Image;
                    this.itemPanel.TabIndex = 2;
                    this.itemPanel.TabStop = false;
                    this.itemPanel.Click += new System.EventHandler((sender, e) => itemPanel_Click(sender, e, itemSlot.SlottedItem));
                    this.itemPanel.MouseHover += new System.EventHandler((sender, e) => itemPanel_MouseHover(sender, e, itemSlot.SlottedItem));
                    this.itemPanel.MouseLeave += new System.EventHandler(this.itemPanel_MouseLeave);
                    this.itemPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                    itemSlot.SlottedItem.ItemControl = this.itemPanel;
                    this.roomPanel.Controls.Add(itemSlot.SlottedItem.ItemControl);
                    RoomControls.Add(itemSlot.SlottedItem.ItemControl);
                }

                foreach (Character character in nextRoom.CharacterList) // BUILDING ROOM CHARACTER PANELS
                {
                    this.characterPanel = new System.Windows.Forms.PictureBox();
                    this.characterPanel.Name = character.Name.ToLower() + "Panel";
                    this.characterPanel = character.ImageBox;
                    this.characterPanel.Click += new System.EventHandler((sender, e) => characterPanel_Click(sender, e, character));
                    this.characterPanel.MouseHover += new System.EventHandler((sender, e) => characterPanel_MouseHover(sender, e, character));
                    this.characterPanel.MouseLeave += new System.EventHandler(this.characterPanel_MouseLeave);
                    this.characterPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.roomPanel.Controls.Add(this.characterPanel);
                    this.characterPanel.Show();
                    RoomControls.Add(this.characterPanel);
                }

                foreach (Door door in nextRoom.DoorList) // BUILDING ROOM DOOR PANELS
                {
                    this.doorPanel = new System.Windows.Forms.Panel();
                    this.doorPanel.BackColor = System.Drawing.Color.Transparent;
                    this.doorPanel.Location = new System.Drawing.Point(door.Position[0], door.Position[1]);
                    this.doorPanel.Size = new System.Drawing.Size(door.Size[0], door.Size[1]);
                    this.doorPanel.TabIndex = 2;
                    this.doorPanel.TabStop = false;
                    this.doorPanel.Click += new System.EventHandler((sender, e) => doorPanel_Click(sender, e, door));
                    this.doorPanel.MouseHover += new System.EventHandler(this.doorPanel_MouseHover);
                    this.doorPanel.MouseLeave += new System.EventHandler(this.doorPanel_MouseLeave);
                    this.doorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.roomPanel.Controls.Add(this.doorPanel);
                    RoomControls.Add(this.doorPanel);
                }

                if (nextRoom.Name == "Room 1" || nextRoom.Name == "End point") // EXCEPTIONS FOR STARTING ROOM/END POINT
                {
                    cmdLightSwitch.Show();
                    if (!User.IsClothed) picClothes.Show();
                    if (!User.HasBriefcase) picBriefcase.Show();
                }
                else cmdLightSwitch.Hide();
            }

        }
        //
        // CHARACTER EVENT HANDLERS
        //
        private void characterPanel_Click(object sender, EventArgs e, Character character)
        {
            if (character != null)
            {
                PlayerThinking(character.Description);
                ucCharacterClicked characterControl = new ucCharacterClicked(character, User, ActiveRoom, this);
                this.roomPanel.Controls.Add(characterControl);
                characterControl.Show();
                characterControl.BringToFront();
            }
        }
        private void characterPanel_MouseHover(object sender, EventArgs e, Character character)
        {
            PlayerThinking(character.Description);
        }
        private void characterPanel_MouseLeave(object sender, EventArgs e)
        {

            HideThoughts();

        }
        //
        // ITEM EVENT HANDLERS
        //
        private void itemPanel_Click(object sender, EventArgs e, Item item)
        {
            if (item != null)
            {
                PlayerThinking(item.Description);
                ucItemClicked itemControl = new ucItemClicked(item, User, ActiveRoom, this);
                this.roomPanel.Controls.Add(itemControl);
                ItemClick = itemControl;
                itemControl.Show();
                itemControl.BringToFront();
            }
        }
        private void itemPanel_MouseHover(object sender, EventArgs e, Item item)
        {
            PlayerThinking(item.Description);
        }
        private void itemPanel_MouseLeave(object sender, EventArgs e)
        {
            HideThoughts();
        }
        // OPEN CONTAINER ITEM
        public void OpenItem(Player user, ContainerItem containerItem)
        {
            ucItemOpen itemOpenControl = new ucItemOpen(user, containerItem, ActiveRoom, this);
            this.roomPanel.Controls.Add(itemOpenControl);
            ItemOpen = itemOpenControl;
            itemOpenControl.Show();
            itemOpenControl.BringToFront();
        }
        // GIVE CHARACTER ITEM
        public void OpenItem(Player user, ContainerItem item, Character character)
        {
            ucItemOpen itemOpenControl = new ucItemOpen(user, item, ActiveRoom, this, character);
            this.roomPanel.Controls.Add(itemOpenControl);
            ItemOpen = itemOpenControl;
            itemOpenControl.Show();
            itemOpenControl.BringToFront();
        }
        // UNLOCK DOOR
        public void OpenItem(Player user, ContainerItem item, Door clickedDoor)
        {
            ucItemOpen itemOpenControl = new ucItemOpen(user, item, clickedDoor, this);
            this.roomPanel.Controls.Add(itemOpenControl);
            ItemOpen = itemOpenControl;
            itemOpenControl.Show();
            itemOpenControl.BringToFront();
        }
        //
        // DOOR EVENT HANDLERS
        //
        private void doorPanel_Click(object sender, EventArgs e, Door door)
        {
            PlayerThinking("A door... to somewhere");
            
            if (!door.IsLocked)
            {
                if (!User.IsClothed)
                {
                    HideThoughts();
                    PlayerThinking("No way im going out there naked");
                }
                else if (door.ToRoom.Name == "End point")
                {
                    EndScene();
                }
                else OpenRoom(door.ToRoom);
            }
            else
            {
            ucOpenDoor doorControl = new ucOpenDoor(door, User, this);
            doorControl.Location = new System.Drawing.Point(741, 434);
            this.roomPanel.Controls.Add(doorControl);
            doorControl.Show();
            doorControl.BringToFront();
            }
        }
        private void doorPanel_MouseHover(object sender, EventArgs e)
        {
            if (lblPlayerThinking.Text != "No way im going out there naked." || lblPlayerThinking.Text != "This door is locked.")
            {
                PlayerThinking("A door... to somewhere");
            }
        }
        private void doorPanel_MouseLeave(object sender, EventArgs e)
        {
            HideThoughts();
        }
        //
        // BASIC ITEMS 
        //
        public void BasicItems(Item item)
        {
            if (item.Name == "Briefcase")
            {
                User.HasBriefcase = true;
                picBriefcase.Hide();
                if (User.IsClothed) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterClothedBriefCase;
                else playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterNakedBriefCase;

            }
            if (item.Name == "Clothes")
            {
                User.IsClothed = true;
                picClothes.Hide();
                if (User.HasBriefcase) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterClothedBriefCase;
                else playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterClothed;
            }

        }
        public void picBriefcase_Click(object sender, EventArgs e)
        {

            if (!IsDark)
            {
                HideThoughts();
                PlayerThinking("Very fancy briefcase. Good for putting things in.");
                ClickedItem = Repository.Briefcase;
                ucBasicItems briefcaseControl = new ucBasicItems(ClickedItem, User, this);

                this.roomPanel.Controls.Add(briefcaseControl);
                briefcaseControl.Show();
                briefcaseControl.BringToFront();
             }

        }
        public void picClothes_Click(object sender, EventArgs e)
        {
            if (!IsDark)
            {
            HideThoughts();
            PlayerThinking("Nicely folded clothes. Nice.");
            ClickedItem = new Item ("Clothes", null, null, null, null, true, false, null);
            ucBasicItems clothesControl = new ucBasicItems(ClickedItem, User, this);
            this.roomPanel.Controls.Add(clothesControl);
            clothesControl.Show();
            clothesControl.BringToFront();
            }
        }
        private void picBriefcase_MouseHover(object sender, EventArgs e)
        {
            if (IsDark) PlayerThinking("Kinda hard to see in here...");
            else PlayerThinking("Very fancy briefcase. Good for putting things in.");
        }
        private void picClothes_MouseHover(object sender, EventArgs e)
        {
            if (IsDark) PlayerThinking("Kinda hard to see in here...");
            else PlayerThinking("Nicely folded clothes. Nice.");
        }
        private void picBriefcase_MouseLeave(object sender, EventArgs e)
        {
            if (ClickedItem == null) HideThoughts();
            else if (ClickedItem.Name != "Briefcase") HideThoughts();
        }
        private void picClothes_MouseLeave(object sender, EventArgs e)
        {
            if (ClickedItem == null) HideThoughts();
            else if (ClickedItem.Name != "Clothes") HideThoughts();
        }
        //
        //REACTION PANELS
        //
        public void CharacterReaction(string reaction, Character character)
        {
            character.ReactionLabel.Text = reaction;
            CharacterReactionPanel = character.ReactionPanel;
            CharacterReactionLabel = character.ReactionLabel;
            this.roomPanel.Controls.Add(CharacterReactionPanel);
            this.roomPanel.Controls.Add(CharacterReactionLabel);
            CharacterReactionPanel.Show();
            CharacterReactionPanel.BringToFront();
            CharacterReactionLabel.Show();
            CharacterReactionLabel.BringToFront();
        }
        public void PlayerThinking(string thought)
        {
            if (IsDark)
            {
                playerReactionPanel.Image = GET_OUT.Properties.Resources.ThinkBubbleDarkness;
                lblPlayerThinking.Text = thought;
                lblPlayerThinking.Show();
                playerReactionPanel.Show();
                playerReactionPanel.BringToFront();
                lblPlayerThinking.BringToFront();
            }
            else if (!playerReactionPanel.Visible)
            {
                if (ActiveRoom.Name == "Room 1") playerReactionPanel.Image = GET_OUT.Properties.Resources.ThinkBubble;
                if (ActiveRoom.Name == "Room 2") playerReactionPanel.Image = GET_OUT.Properties.Resources.ThinkBubbleRoom2;

                lblPlayerThinking.Text = thought;
                lblPlayerThinking.Show();
                playerReactionPanel.Show();
            }
        }
        public void PlayerSaying(string line)
        {
            playerReactionPanel.Image = GET_OUT.Properties.Resources.TalkBubble;
            lblPlayerThinking.Text = line;
            lblPlayerThinking.Show();
            playerReactionPanel.Show();
            playerReactionPanel.BringToFront();
            lblPlayerThinking.BringToFront();
        }
        public void HideThoughts()
        {
            lblPlayerThinking.Text = null;
            lblPlayerThinking.Hide();
            playerReactionPanel.Hide();

            if (CharacterReactionPanel!= null)
            {
            CharacterReactionLabel.Text = null;
            CharacterReactionPanel.Hide();
            CharacterReactionLabel.Hide();
            }
        }
        private void playerReactionPanel_MouseLeave(object sender, EventArgs e)
        {
            HideThoughts();
        }
        private void playerReactionPanel_MouseHover(object sender, EventArgs e)
        {
            PlayerThinking("Oh wow.We managed to capture our own thought...");
        }
        private void playerPanel_Click(object sender, EventArgs e)
        {
            if (User.HasBriefcase)
            {
                OpenItem(User, User.Briefcase);
            }

        }
        private void playerPanel_MouseHover(object sender, EventArgs e)
        {
            if (IsDark) PlayerThinking("The darkness in here makes up for my nakedness...");
            else if (!User.IsClothed) PlayerThinking("Not quite butt naked, but naked.");
            else PlayerThinking("Yes. This is me.\nI mean, you.\nThis is us, " + User.Name + ".");
        }
        private void playerPanel_MouseLeave(object sender, EventArgs e)
        {
            HideThoughts();
        }
        //
        // LIGHTSWITCH HANDLER 
        //
        private void cmdLightSwitch_Click(object sender, EventArgs e)
        {
            if (IsDark)
            {
                panelDarkness.Hide();
                cmdLightSwitch.Image = GET_OUT.Properties.Resources.LightSwitchOn;
                playerReactionPanel.Image = GET_OUT.Properties.Resources.ThinkBubble;
                lblPlayerThinking.Text = "Fiat lux.";

                if (User.HasBriefcase && !User.IsClothed) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterNakedBriefCase;
                else if (User.HasBriefcase && User.IsClothed) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterClothedBriefCase;
                else if (!User.HasBriefcase && User.IsClothed) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterClothed;
                else if (!User.HasBriefcase && !User.IsClothed) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterNaked;

                picBriefcase.Image = GET_OUT.Properties.Resources.Briefcase;
                picClothes.Image = GET_OUT.Properties.Resources.Clothes;

                IsDark = false;
            }
            else
            {
                panelDarkness.Show();
                cmdLightSwitch.Image = GET_OUT.Properties.Resources.LightSwitchOff;
                playerReactionPanel.Image = GET_OUT.Properties.Resources.ThinkBubbleDarkness;
                lblPlayerThinking.Text = "Hello Darkness my old friend.";

                if (User.HasBriefcase && !User.IsClothed) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterNakedBriefCaseDarkness;
                else if (User.HasBriefcase && User.IsClothed) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterClothedBriefCaseDarkness;
                else if (!User.HasBriefcase && User.IsClothed) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterClothedDarkness;
                else if (!User.HasBriefcase && !User.IsClothed) playerPanel.Image = GET_OUT.Properties.Resources.PlayerCharacterNakedDarkness;

                picBriefcase.Image = GET_OUT.Properties.Resources.BriefcaseDarkness;
                picClothes.Image = GET_OUT.Properties.Resources.ClothesDarkness;

                IsDark = true;
            }

        }
        private void cmdLightSwitch_MouseHover(object sender, EventArgs e)
        {
            if (lblPlayerThinking.Text != "Fiat lux" || lblPlayerThinking.Text != "Hello Darkness my old friend")
            {
                if (IsDark) PlayerThinking("Maybe this could shine some light over this.");
                else PlayerThinking("Yeah, let's go back to sleep already.");
            }
        }
        private void cmdLightSwitch_MouseLeave(object sender, EventArgs e)
        {
            HideThoughts();
        }
        //
        // END SCENE
        //
        public async void EndScene()
        {
            DisableControls(this);
            EnableControls(cmdExitGame);
            lblPlayerThinking.BringToFront();
            await Task.Delay(500);
            roomPanel.BackgroundImage = GET_OUT.Properties.Resources.OUT;
            await Task.Delay(200);
            PlayerThinking("It's done. We're out.");
            await Task.Delay(2500);
            playerPanel.Hide();
            HideThoughts();
            roomPanel.BackgroundImage = GET_OUT.Properties.Resources.OUT2;
            await Task.Delay(1500);
            DarknessPanel.BackgroundImage = GET_OUT.Properties.Resources.OUT_DARKNESS;
            DarknessPanel.Show();
            cmdLightSwitch.Image = GET_OUT.Properties.Resources.LightSwitchOff;
            await Task.Delay(1500);
            roomPanel.BackgroundImage = GET_OUT.Properties.Resources.OUT;
            await Task.Delay(2500);
            roomPanel.BackgroundImage = GET_OUT.Properties.Resources.OUT3;
            await Task.Delay(2500);
            roomPanel.BackgroundImage = GET_OUT.Properties.Resources.OUT;
            await Task.Delay(2500);
            DarknessPanel.BackgroundImage = GET_OUT.Properties.Resources.OUT_DARKNESS_2;
            roomPanel.BackgroundImage = GET_OUT.Properties.Resources.OUT4;
        }
        //
        // DISABLE/ENABLE CONTROLS
        //
        public void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            DisableControlList.Add(con);
            con.Enabled = false;
            EnableControls(cmdExitGame);
        }
        public void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }
        //
        //Close game
        //
        private void cmdExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // endregion
        //
        public System.Windows.Forms.PictureBox itemPanel;
        public System.Windows.Forms.PictureBox characterPanel;
        public System.Windows.Forms.PictureBox characterReactionPanel;
        public System.Windows.Forms.Label characterLabel;
        public System.Windows.Forms.Panel doorPanel;
        public System.Windows.Forms.UserControl doorControl;
        //
        //
        //
    }
}
