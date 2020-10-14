using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GET_OUT
{
    public class Room
    {
        //
        // PROPS
        //
        public string Name { get; set; }
        public Image Image { get; set; }
        public Image ThinkImage { get; set; }
        public int[] PlayerLocation { get; set; }
        public Point ThinkingLocation { get; set; }
        public List<Item> ItemList { get; set; }
        public List<Door> DoorList { get; set; }
        public List<Character> CharacterList { get; set; }
        public List<ItemSlot> ItemSlotList { get; set; }
        //
        // CTOR
        //
        public Room()
        { 
        }
        //
        // REMOVE/ADD ITEM METHODS
        //
        public bool RemoveItem(Room room, Item item)
        {
            foreach (ItemSlot roomSlot in room.ItemSlotList.Where(roomSlot => roomSlot.SlottedItem == item))
            {
                roomSlot.SlottedItem = null;
                room.ItemList.Remove(item);
                return true;
            }
            return false;
        }
        public bool AddItem(Room room, Item item)
        {
            foreach (ItemSlot freeSlot in room.ItemSlotList.Where(freeSlot => freeSlot.SlottedItem == null))
            {
                freeSlot.SlottedItem = item;
                room.ItemList.Add(item);
                return true;
            }
            return false;
        }
    }
}
