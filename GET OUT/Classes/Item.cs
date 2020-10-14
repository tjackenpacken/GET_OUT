using GET_OUT.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GET_OUT
{
    public class Item
    {
        //
        // DELEGATES
        //
        delegate void DelMethodUsage(Player User, Room room, Item item, ContainerItem containerItem, frmGame mainForm);
        //
        // MAIN PROP
        //
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemSlot ItemSlot { get; set; }
        //
        // PICTURE PROP
        //
        public Image Image { get; set; }
        public Image UseImage { get; set; }
        public int[] Size { get; set; }
        public Control ItemControl { get; set; }
        //
        // ACTION PROP
        //
        public string Usage { get; set; }
        public Delegate MethodUsage { get; set; }
        public bool IsBackpackable { get; set; }
        public string ID { get; set; }
        public bool IsLocked { get; set; }
        public Item UsableItemPair { get; set; }
        public Item TransformsTo { get; set; }
        //
        // CTOR
        //
        public Item(string name, string usage, string description, Image image, int[] size, bool isBackpackable, bool isLocked, string id)
        {
            Name = name;
            Description = description;
            Usage = usage;
            Image = image;
            Size = size;
            IsBackpackable = isBackpackable;
            IsLocked = isLocked;
            ID = id;
            //UsableItemPair = new Item();

            switch (Usage)
            {
                case "Eat":
                    DelMethodUsage delMethodUsage = new DelMethodUsage(Eat);
                    MethodUsage = delMethodUsage;
                    break;
                case "Fill":
                    DelMethodUsage delMethodFill = new DelMethodUsage(Fill);
                    MethodUsage = delMethodFill;
                    break;
                case "Check time":
                    DelMethodUsage delMethodCheckTime = new DelMethodUsage(CheckTime);
                    MethodUsage = delMethodCheckTime;
                    break;
                case "Drink":
                    DelMethodUsage delMethodDrink = new DelMethodUsage(Drink);
                    MethodUsage = delMethodDrink;
                    break;
                case "Put out fire":
                    DelMethodUsage delMethodPutOutFire = new DelMethodUsage(PutOutFire);
                    MethodUsage = delMethodPutOutFire;
                    break;
            }
        }
        //
        // CTOR NEEDED FOR SUBCLASS
        //
        public Item()
        {
        }
        //
        // USE METHODS
        //
        public void Eat(Player User, Room room, Item item, ContainerItem containerItem, frmGame mainForm)
        {
            if (!room.RemoveItem(room, item))
                DropFromContainer(item, containerItem);
            mainForm.PlayerThinking("Yummy.");
        }
        public void Fill (Player User, Room room, Item item, ContainerItem containerItem, frmGame mainForm)
        {
            if (room.Name != "Room 2") 
                mainForm.PlayerThinking("No faucet available in this room");
            else item.ItemSlot.SlottedItem = item.TransformsTo;
        }
        public void Drink(Player User, Room room, Item item, ContainerItem containerItem, frmGame mainForm)
        {
            item.ItemSlot.SlottedItem = item.TransformsTo;
        }
        public void CheckTime(Player User, Room room, Item item, ContainerItem containerItem, frmGame mainForm)
        {
            mainForm.PlayerThinking("Time is " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString()) ;
        }
        public void PutOutFire(Player User, Room room, Item item, ContainerItem containerItem, frmGame mainForm)
        {
            if (User.HasBriefcase)
            {
                ucItemOpen itemOpenControl = new ucItemOpen(User, User.Briefcase, room, mainForm, item);
                mainForm.Controls.Add(itemOpenControl);
                itemOpenControl.Show();
                itemOpenControl.BringToFront();
            }
            else mainForm.PlayerThinking("I dont have anything to use on this");
        }
        //
        // GIVE/DROP/PICK UP METHODS
        //
        public Tuple <string, bool> GiveToCharacter(Player user, Character character, Item item)
        {
            string characterLine = "I have no use for that.";
            bool isAccepted = false;
            if (character.Name == "Ronny" && character.CharacterItemSlot.SlottedItem == null) ;
            else if (character.Name == "Ronny" && character.CharacterItemSlot.SlottedItem.Name != "Alarm clock") ;
            else if (character.IsSatisfied) characterLine = "You already gave me what I want.";
            else if (item == character.WantsItem)
            {
                isAccepted = user.RemoveItem(user, item);
                if (isAccepted)
                {
                    character.IsSatisfied = true;
                    character.ItemList.Add(item);
                    characterLine = "Thanks buddy.";
                }
            }
            var returnValues = new Tuple<string, bool>(characterLine, isAccepted);
            return returnValues;
        }
        public string PutInInventory(Player user,Room room, Item item)
        {
            if (item.IsBackpackable)
            {
                bool isAdded = user.AddItem(user, item);
                if (isAdded)
                {
                    room.RemoveItem(room, item);
                    return "Yes";
                }
                return "No slots";
            }
            else return "Not backpackable";
        }
        public string PutInInventory(Player user, Character character, Item item, Control motherControl, Form mainForm)
        {
            if (item.IsBackpackable)
            {
                bool isAdded = user.AddItem(user, item);
                if (isAdded)
                {
                    character.RemoveItem(character, user, item, motherControl, mainForm);
                    return "Yes";
                }
                return "No slots";
            }
            else return "Not backpackable";
        }
        public string PutInInventory(Player user, ContainerItem containerItem, Item item)
        {
            if (item.IsBackpackable)
            {

                bool isAdded = user.AddItem(user, item);
                if (isAdded)
                {
                    if (DropFromContainer(item, containerItem)) return "Yes";
                }
                return "No slots";
            }
            else return "Not backpackable";
        }
        public bool DropFromContainer(Item droppedItem, ContainerItem containerItem)
        {
            foreach (ItemSlot containerSlot in containerItem.ItemSlots.Where(containerSlot => containerSlot.SlottedItem == droppedItem))
            {
                containerSlot.SlottedItem = null;
                return true;
            }
            return false;
        }
        public void DropFromInventory(Player user, Room room, Item item, frmGame mainForm)
        {
            bool isAdded = room.AddItem(room, item);
            if (isAdded)
            {
                user.RemoveItem(user, item);
            }
            else mainForm.PlayerThinking("There is no more space in this room");
        }
        //
        // END REGION
        //
        public System.Windows.Forms.PictureBox pictureBox;
        //
        //
        //
    }
}
