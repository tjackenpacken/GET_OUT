using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GET_OUT.Classes
{
    public class ContainerItem : Item
    {
        delegate void DelMethodOpen(Player User, Room room, ContainerItem containerItem, ContainerItem motherItem, frmGame mainForm);

        public Image OpenImage { get; set; }
        public List<ItemSlot> ItemSlots { get; set; }

        public ContainerItem(string name, string id, string description, bool isLocked, Image openImage, int[] size, List<ItemSlot> itemSlots)
        {
            Name = name;
            ID = id;
            Description = description;
            IsLocked = isLocked;
            OpenImage = openImage;
            ItemSlots = itemSlots;
            Size = size;
            Usage = "Open";

            DelMethodOpen delMethodUsage = new DelMethodOpen(Open);
            MethodUsage = delMethodUsage;
        }

        public void Open(Player User, Room room, ContainerItem containerItem, ContainerItem motherItem, frmGame mainForm)
        {
            if (containerItem.IsLocked) mainForm.PlayerThinking("This " + containerItem.Name.ToLower() + " is locked");
            else mainForm.OpenItem(User, containerItem);
        }

        public bool RemoveItem(Item item)
        {
            foreach (ItemSlot itemSlot in this.ItemSlots.Where(itemSlot => itemSlot.SlottedItem == item))
            {
                itemSlot.SlottedItem = null;
                return true;

            }
            return false;
        }
    }
}
