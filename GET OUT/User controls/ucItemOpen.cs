using GET_OUT.Classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GET_OUT
{
    public partial class ucItemOpen : UserControl
    {
        public Player User { get; set; }
        public ContainerItem OpenContainerItem { get; set; }
        public frmGame MainForm { get; set; }
        public Room ActiveRoom { get; set; }
        public Character MotherCharacter { get; set; }
        public bool IsCharacterOpen { get; set; }
        public bool IsItemOpen { get; set; }
        public bool IsDoorOpen { get; set; }
        public Item MotherItem { get; set; }
        public Door ClickedDoor { get; set; }

        public ucItemOpen(Player user, ContainerItem containerItem, Room activeRoom, frmGame mainForm) // STANDARD CTOR
        {
            InitializeComponent();
            SetItems(containerItem, mainForm);
            MainForm = mainForm;
            User = user;
            OpenContainerItem = containerItem;
            ActiveRoom = activeRoom;
        }
        public ucItemOpen(Player user, ContainerItem containerItem, Door clickedDoor, frmGame mainForm) // UNLOCK DOOR CTOR
        {
            InitializeComponent();
            SetItems(containerItem, mainForm);
            MainForm = mainForm;
            User = user;
            OpenContainerItem = containerItem;
            ClickedDoor = clickedDoor;
            IsDoorOpen = true;
        }
        public ucItemOpen(Player user, ContainerItem containerItem, Room activeRoom, frmGame mainForm, Character character) // GIVE CHARACTER ITEM CTOR
        {
            InitializeComponent();
            SetItems(containerItem, mainForm);
            MainForm = mainForm;
            User = user;
            OpenContainerItem = containerItem;
            MotherCharacter = character;
            ActiveRoom = activeRoom;
            IsCharacterOpen = true;
        }

        public ucItemOpen(Player user, ContainerItem containerItem, Room activeRoom, frmGame mainForm, Item motherItem) // USE ITEM ON ITEM CTOR
        {
            InitializeComponent();
            SetItems(containerItem, mainForm);
            MainForm = mainForm;
            User = user;
            OpenContainerItem = containerItem;
            MotherItem = motherItem;
            ActiveRoom = activeRoom;
            IsItemOpen = true;
        }
        private void SetItems (ContainerItem containerItem, frmGame MainForm)
        {
            this.Width = containerItem.OpenImage.Width + 80;
            this.Height = containerItem.OpenImage.Height + 150;
            this.Left = (MainForm.Width - this.Width) / 2;
            this.Top = (MainForm.Height - this.Height) / 2;
            itemPanel.Size = containerItem.OpenImage.Size;
            itemPanel.Left = (this.Width - itemPanel.Width) / 2;
            itemPanel.Top = (this.Height - itemPanel.Height) / 2;
            itemPanel.BackgroundImage = containerItem.OpenImage;

            foreach (ItemSlot itemSlot in containerItem.ItemSlots.Where(itemSlot => itemSlot.SlottedItem != null))
            {
                itemSlot.SlottedItem.ItemSlot = itemSlot;
                this.pictureBox = new System.Windows.Forms.PictureBox();
                this.pictureBox.Size = new Size(50, 60);
                this.pictureBox.Location = new Point(itemSlot.Position[0], itemSlot.Position[1] - 60);
                this.pictureBox.BackColor = Color.Transparent;
                this.pictureBox.BackgroundImage = itemSlot.SlottedItem.Image;
                this.pictureBox.Click += new System.EventHandler((sender, e) => picturebox_Click(sender, e, itemSlot.SlottedItem));
                this.pictureBox.MouseHover += new System.EventHandler((sender, e) => picturebox_MouseHover(sender, e, itemSlot.SlottedItem));
                this.pictureBox.MouseLeave += new System.EventHandler(picturebox_MouseLeave);
                this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
                itemPanel.Controls.Add(this.pictureBox);
            }
        }


        private void picturebox_Click(object sender, EventArgs e, Item item)
        {
            if (item != null)
            {
                MainForm.PlayerThinking(item.Description);
                //
                // GIVING ITEM TO CHARACTER
                //
                if (IsCharacterOpen)
                {
                    this.Hide();
                    ucGiveItem giveItemControl = new ucGiveItem(User, item, MotherCharacter, MainForm, this);
                    MainForm.Controls.Add(giveItemControl);
                    giveItemControl.Show();
                    giveItemControl.BringToFront();
                }
                //
                // USING ON OTHER ITEM
                //
                else if (IsItemOpen)
                {
                    if (MotherItem.UsableItemPair.Name == item.Name)
                    {
                        this.Hide();
                        ucUseItemOnItem useItemOnItemControl = new ucUseItemOnItem(User, ActiveRoom, item, MotherItem, MainForm, this);
                        MainForm.Controls.Add(useItemOnItemControl);
                        useItemOnItemControl.Show();
                        useItemOnItemControl.BringToFront();
                    }

                    else
                    {
                        MainForm.HideThoughts();
                        MainForm.PlayerThinking("Cant use " + item.Name.ToLower() + " on " + MotherItem.Name.ToLower() + ".");
                    }
                }
                // 
                // UNLOCK DOOR
                //
                else if (IsDoorOpen)
                {
                    if (item is Key && item.ID == ClickedDoor.ID)
                    {
                        ClickedDoor.IsLocked = false;
                        MainForm.OpenRoom(ClickedDoor.ToRoom);
                        MainForm.HideThoughts();
                        MainForm.PlayerThinking("Love is the master key that opens the gates of happiness.");
                        this.Hide();
                    }
                    else if (item is Key && item.ID != ClickedDoor.ID)
                    {
                        MainForm.HideThoughts();
                        MainForm.PlayerThinking("This key goes somewhere else");
                    }
                    else if (item is Key == false)
                    {
                        MainForm.HideThoughts();
                        MainForm.PlayerThinking("This is not even a key");
                    }
                }
                //
                // STANDARD ITEM CLICK
                //
                //
                else
                {
                    ucItemClicked itemControl = new ucItemClicked(item, User, OpenContainerItem.ItemSlots, ActiveRoom, MainForm, this, OpenContainerItem);
                    this.Hide();
                    MainForm.Controls.Add(itemControl);
                    itemControl.Show();
                    itemControl.BringToFront();
                }
            }
        }
        private void picturebox_MouseHover(object sender, EventArgs e, Item item)
        {
            if (item!=null) MainForm.PlayerThinking(item.Description);
        }
        private void picturebox_MouseLeave(object sender, EventArgs e)
        {
            MainForm.HideThoughts();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //
        // END OF CLASS
        //
        public System.Windows.Forms.PictureBox pictureBox;
    }
}
