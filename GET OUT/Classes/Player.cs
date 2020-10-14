using GET_OUT.Classes;
using System;
using System.Linq;

namespace GET_OUT
{
    public class Player
    {
        //
        // PROP
        //
        public string Name { get; set; }
        public bool IsClothed { get; set; }
        public bool HasBriefcase { get; set; }
        public ContainerItem Briefcase { get; set; }
        //
        // CTOR
        //
        public Player(string name)
        {
            Name = name;
        }
        //
        // ADD/REMOVE ITEM METHODS
        //
        public bool AddItem(Player user, Item item)
        {
            foreach(ItemSlot itemSlot in user.Briefcase.ItemSlots.Where(itemSlot => itemSlot.SlottedItem == null))
            {
                itemSlot.SlottedItem = item;
                //item.Slot = itemSlot;
                //user.Inventory.Add(item);
                return true;
            }
            return false;
        }
        public bool RemoveItem(Player user, Item item)
        {
            foreach (ItemSlot itemSlot in user.Briefcase.ItemSlots.Where(itemSlot => itemSlot.SlottedItem == item))
            {
                itemSlot.SlottedItem = null;
                return true;
            }
            return false;
        }
        //
        // RESPONSE METHODS
        //
        public string PlayerResponse(bool isPositive, string itemName)
        {
            Random ran = new Random();
            int response = ran.Next(1, 4);
            if (isPositive)
            {
                switch (response)
                {
                    case 1:
                        return ("I always wanted this " + itemName.ToLower());
                    case 2:
                        return ("Huh, a " + itemName.ToLower() + "? \nOk i guess.");
                    case 3:
                        return ("My precious " + itemName.ToLower() + "!");
                }
                return "Mine";
            }
            else
            {
                switch (response)
                {
                    case 1:
                        return ("I can't possibly fit this " + itemName.ToLower() + " in my briefcase.");
                    case 2:
                        return ("Are crazy? I can not take this " + itemName.ToLower() + " whith me.");
                    case 3:
                        return ("Nu-uh, im not taking that " + itemName.ToLower() + "!");
                }
                return "Not taking that";
            }
        }
        //
        // END OF CLASS
        //
    }
}
