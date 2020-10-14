using GET_OUT.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GET_OUT
{
    public class Character
    {
        //
        // PROP
        //
        public List<Item> ItemList { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PictureBox ImageBox { get; set; }
        public PictureBox ReactionPanel { get; set; }
        public Label ReactionLabel { get; set; }
        public Item WantsItem { get; set; }
        public Item SatisfactionItem { get; set; }
        public bool IsSatisfied { get; set; }
        public ItemSlot CharacterItemSlot { get; set; }
        //
        // NAKED CTOR
        //
        public Character()
        {

        }
        //
        // CLASS METHODS
        //
        public void Satisfaction(Player user, Character character, Item item, Control motherControl, Form mainForm)
        {
            if (character.Name == "Eloise")
            {
                ucItemRecieved itemRecievedControl = new ucItemRecieved(user, character, item, motherControl, mainForm);
                mainForm.Controls.Add(itemRecievedControl);
                itemRecievedControl.Show();
                itemRecievedControl.BringToFront();
            }
        }
        public void RemoveItem(Character character, Player user, Item item, Control motherControl, Form mainForm)
        {
            foreach (Item inventoryItem in character.ItemList.Where(inventoryItem => inventoryItem == item))
            {
                character.ItemList.Remove(item);

                if (item == character.WantsItem) Satisfaction(user, character, item, motherControl, mainForm);
                return;
            }
        }
        public Tuple<string, string> TalkToCharacter(Player user)
        {
            string userLine = "Hello, i need to get out. Can you help me?";
            string characterLine = "";

            if (this.Name == "Eloise")
            {
                var found = this.ItemList.Find(item => item.Name == "Apple");

                if (found == null) characterLine = "Me? No. But i bet whoever hides behind this door can. I could open the door, but im really hungry for an apple.";
                else characterLine = "I already gave you the key. How much do you want from me?";
            }
            if (this.Name == "Ronny")
            {
                var found = this.ItemList.Find(item => item.Name == "Apple");

                if (this.CharacterItemSlot.SlottedItem == null)
                    characterLine = "Where did you put my alarm clock? I want it back on my nightstand.";
                else if (this.CharacterItemSlot.SlottedItem.Name == "Burning alarm clock") 
                    characterLine = "I sure can, but first you need to help me with my alarm clock. It's burning you see.";
                else if (this.CharacterItemSlot.SlottedItem.Name != "Burning alarm clock" && this.CharacterItemSlot.SlottedItem.Name != "Alarm clock") 
                    characterLine = "Where did you put my alarm clock? I want it back on my nightstand.";
                else if (this.CharacterItemSlot.SlottedItem.Name == "Alarm clock" && found == null)
                    characterLine = "Hmm. I got really hungry from all this. Hand me an apple and i will help you.";
                else characterLine = "I already helped you. Now get out.";
            }
            var returnValues = new Tuple<string, string>(userLine, characterLine);
            return returnValues;
        }
        //
        // END OF CLASS
        //
    }
}
