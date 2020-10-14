using System.Drawing;

namespace GET_OUT
{
    public class Key : Item
    {
        public Key(string name, string id, string description, Image image)
        {
            Name = name;
            Description = description;
            Usage = "Unlock";
            Image = image;
            Size = new int[] { 50, 60 };
            IsBackpackable = true;
            IsLocked = false;
            ID = id;
        }
    }
}
