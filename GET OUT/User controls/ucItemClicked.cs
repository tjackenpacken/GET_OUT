using GET_OUT.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GET_OUT
{
    public partial class ucItemClicked : UserControl
    {
        public frmGame MainForm { get; set; }
        public Player User { get; set; }
        public Room ActiveRoom { get; set; }
        public List<ItemSlot> ItemSlots { get; set; }
        public Item ClickedItem { get; set; }
        public UserControl MotherControl { get; set; }
        public ContainerItem MotherItem { get; set; }
        public bool IsBackpacked { get; set; }

        public ucItemClicked(Item item, Player user, Room activeRoom, frmGame mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            ClickedItem = item;
            User = user;
            ActiveRoom = activeRoom;
            ItemSlots = ActiveRoom.ItemSlotList;
            IsBackpacked = false;
            cmdAddToInventory.Text = "Put " + item.Name.ToLower() + " in inventory";
            picClickedItem.Image = item.Image;
            lblItemClicked.Text = item.Name;

            if (ClickedItem.Usage == "Unlock") cmdUseItem.Visible = false;

            cmdUseItem.Text = item.Usage + " " + item.Name.ToLower();
            this.Left = (MainForm.Width - this.Width) / 2;
            this.Top = (MainForm.Height - this.Height) / 2;
        }
        public ucItemClicked(Item item, Player user, List<ItemSlot> itemSlotList, Room activeRoom, frmGame mainForm, UserControl motherUserControl, ContainerItem motherItem)
        {
            InitializeComponent();
            MainForm = mainForm;
            MotherControl = motherUserControl;
            MotherItem = motherItem;
            ActiveRoom = activeRoom;
            ClickedItem = item;
            User = user;
            ItemSlots = itemSlotList;

            if (ClickedItem.Usage == "Unlock") cmdUseItem.Visible = false;

            this.Left = (MainForm.Width - this.Width) / 2;
            this.Top = (MainForm.Height - this.Height) / 2;

            if (MotherItem != null && MotherItem.Name == "Briefcase")
            {
                IsBackpacked = true;
                cmdAddToInventory.Text = "Drop " + item.Name.ToLower() + " from inventory";
            }
            picClickedItem.Image = item.Image;
            lblItemClicked.Text = item.Name;
            if (item.Usage == "Unlock") cmdUseItem.Text = "Unlock something with " + item.Name.ToLower();
            else cmdUseItem.Text = item.Usage + " " + item.Name.ToLower();
        }
        private void cmdAddToInventory_Click(object sender, EventArgs e)
        {
            //
            // ADDING ITEM TO INVENTORY
            //
            if (!IsBackpacked)
            {
                if (!User.HasBriefcase)
                {
                    MainForm.PlayerThinking("If i only had somewhere to put it.");
                }
                // if item is in container item
                else if (MotherControl != null)
                {
                    MotherControl.Hide();
                    if (ClickedItem.PutInInventory(User, MotherItem, ClickedItem) == "Yes")
                    {
                        MainForm.PlayerThinking(User.PlayerResponse(true, ClickedItem.Name));
                        Hide();
                        //MainForm.CloseControl(this);
                        ReopenPanel();
                    }
                    else
                    {
                        MainForm.PlayerThinking("My briefcase is full");
                        Hide();
                        //MainForm.CloseControl(this);
                    }
                }
                // if item is not in container item
                else 
                {
                    string isAdded = ClickedItem.PutInInventory(User, ActiveRoom, ClickedItem);
                    switch (isAdded)
                    {
                        case "Yes":
                            MainForm.PlayerThinking(User.PlayerResponse(true, ClickedItem.Name));
                            MainForm.OpenRoom(ActiveRoom);
                            Hide();
                            //MainForm.CloseControl(this);
                            break;
                        case "Not backpackable":
                            MainForm.PlayerThinking(User.PlayerResponse(false, ClickedItem.Name));
                            break;
                        case "No slots":
                            MainForm.PlayerThinking("Briefcase is full");
                            break;
                    }
                }
            }
                //
                // DROPPING ITEM FROM INVENTORY
                //
                else
                {
                    ClickedItem.DropFromInventory(User, ActiveRoom, ClickedItem, MainForm);
                    MainForm.OpenRoom(ActiveRoom);
                    if (MotherControl != null) MotherControl.Hide();
                    Hide();
                    //MainForm.CloseControl(this);
                }
            }

        private void cmdItemClickedExit_Click(object sender, EventArgs e) 
        {
            if (MotherControl != null) MotherControl.Show();
            Hide();
            //MainForm.CloseControl(this);
        }

        private void cmdUseItem_Click(object sender, EventArgs e)
        {

            ClickedItem.MethodUsage.DynamicInvoke(User, ActiveRoom, ClickedItem, MotherItem, MainForm);
            if (MotherControl != null) ReopenPanel();
            else MainForm.OpenRoom(ActiveRoom);
            Hide();
            //MainForm.CloseControl(this);
        }

            private void ReopenPanel()
        {
            if (MotherControl != null) MotherControl.Hide();
            MainForm.OpenItem(User, MotherItem);

        }
        //
        // END OF CLASS
        //
    }
}
