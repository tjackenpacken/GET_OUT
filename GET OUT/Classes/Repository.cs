using GET_OUT.Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GET_OUT
{
    public static class Repository
    {
        public static Room StartingRoom { get; set; }
        public static ContainerItem Briefcase { get; set; }
        //
        // CREATE ROOMS METHOD
        //
        public static void CreateRooms()
        {
            //
            // ROOM LIST
            //
            List<Room> roomList = new List<Room>();
            //
            // ROOMS
            //
            Room room1 = new Room { Name = "Room 1", 
                                    Image = GET_OUT.Properties.Resources.Room1, ThinkImage = GET_OUT.Properties.Resources.ThinkBubble,
                                    PlayerLocation = new int[] { 251, 298 }, ThinkingLocation =  new Point(460, 84),
                                    ItemList = new List<Item>(), DoorList = new List<Door>(),
                                    CharacterList = new List<Character>()};

            Room room2 = new Room { Name = "Room 2", 
                                    Image = GET_OUT.Properties.Resources.Room2, ThinkImage = GET_OUT.Properties.Resources.ThinkBubbleRoom2,
                                    PlayerLocation = new int[] { 490, 330 }, ThinkingLocation = new Point(320, 54),
                                    ItemList = new List<Item>(), DoorList = new List<Door>(),
                                    CharacterList = new List<Character>()};

            Room room3 = new Room { Name = "Room 3", 
                                    Image = GET_OUT.Properties.Resources.Room3, ThinkImage = GET_OUT.Properties.Resources.ThinkBubbleRoom2,
                                    PlayerLocation = new int[] { 490, 330 }, ThinkingLocation = new Point(320, 54),
                                    ItemList = new List<Item>(), DoorList = new List<Door>(),
                                    CharacterList = new List<Character>()};

            Room endPoint = new Room { Name = "End point", 
                                    Image = GET_OUT.Properties.Resources.Room1, ThinkImage = GET_OUT.Properties.Resources.ThinkBubble,
                                    PlayerLocation = new int[] { 300, 330 }, ThinkingLocation =  new Point(460, 84),
                                    ItemList = new List<Item>(), DoorList = new List<Door>(),
                                    CharacterList = new List<Character>()};
            //
            //
            //------------------------------------------------------------------------------------------------
            // 
            // ITEMS
            //
            //------------------------------------------------------------------------------------------------
            //
            //
            Item alarmClock = new Item(
                "Alarm clock", "Check time",
                "Perfectly fine working alarm",
                GET_OUT.Properties.Resources.AlarmClock,
                new int[] { 50, 60 },
                true, false, null);

            Item burningAlarmClock = new Item(
                "Burning alarm clock", "Put out fire",
                "Cant tell the time when burning and broken",
                GET_OUT.Properties.Resources.BurningAlarmClock,
                new int[] { 50, 60 },
                false, false, null);

            burningAlarmClock.TransformsTo = alarmClock;

            Item glassEmpty = new Item(
                "Empty glass", "Fill",
                "An empty glass. Ready to be filled and emptied again",
                GET_OUT.Properties.Resources.EmptyGlass,
                new int[] { 50, 60 },
                true, false, null);

            Item glassFilledWater = new Item(
                "Water filled glass", "Empty",
                "Glass and water. Name a more iconic duo.",
                GET_OUT.Properties.Resources.FilledGlassWater,
                new int[] { 50, 60 },
                true, false, null);

            glassEmpty.TransformsTo = glassFilledWater;
            glassFilledWater.TransformsTo = glassEmpty;

            burningAlarmClock.UsableItemPair = glassFilledWater;

            Item tape = new Item(
                "Tape", "Use",
                "My life is the only thing not repairable with this fantastic tape",
                GET_OUT.Properties.Resources.Tape,
                new int[] { 50, 60 },
                true, false, null);

            Item apple = new Item(
                "Apple", "Eat",
                "This apple looks tasty", 
                GET_OUT.Properties.Resources.Apple,
                new int[] { 50, 60 },
                true, false, null);
            //
            // CONTAINER ITEMS
            //
            ContainerItem cabinet = new ContainerItem(
                "Cabinet", "Cabinet",
                "Just an ordinary cabinet", false,
                GET_OUT.Properties.Resources.CabinetOpen,
                new int[] { 380, 190 },
                new List<ItemSlot> { new ItemSlot { Position = new int[] { 85, 75 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] { 145, 75 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] { 205, 75 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] { 265, 75 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] { 325, 75 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] { 85, 145 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] { 145, 145 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] { 205, 145 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] { 265, 145 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] { 325, 145 },
                                                    SlottedItem = apple},});

                ContainerItem fridge = new ContainerItem(
                "Frigde", "Fridge",
                "Cold things to eat", false,
                GET_OUT.Properties.Resources.FridgeOpen,
                new int[] { 300, 519 },
                new List<ItemSlot> { new ItemSlot { Position = new int[] {140, 250 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] {200, 250 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] {260, 250 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] {140, 340 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] {200, 340 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] {260, 340 },
                                                    SlottedItem = apple },
                                     new ItemSlot { Position = new int[] {140, 430 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] {200, 430 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] {260, 430 },
                                                    SlottedItem = apple },
                                     new ItemSlot { Position = new int[] {140, 520 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] {200, 520 },
                                                    SlottedItem = apple},
                                     new ItemSlot { Position = new int[] {260, 520 },
                                                    SlottedItem = apple}});

            //
            // KEYS
            //
            Key mainKey = new Key(
                "Main key", "End point",
                "This is what i need to GET OUT",
                GET_OUT.Properties.Resources.MainKey);
            Key cabinetKey = new Key(
                "Cabinet key", "Cabinet",
                "Looks like it should unlock a cabinet of some sort",
                GET_OUT.Properties.Resources.CabinetKey);
            Key door2Key = new Key(
                "Door key", "Door 2",
                "Regular door key. Open doors.",
                GET_OUT.Properties.Resources.DoorKey);
            //
            //
            //
            room2.ItemList.Add(fridge);

            Briefcase = new ContainerItem (
                "Briefcase", null,
                "A very fine briefcase", false,
                GET_OUT.Properties.Resources.BriefcaseOpen,
                new int[] { 75, 115 },
                new List<ItemSlot> {new ItemSlot { Position = new int[] { 80, 85 }},
                                    new ItemSlot { Position = new int[] { 190, 85 }},
                                    new ItemSlot { Position = new int[] { 80, 175 } },
                                    new ItemSlot { Position = new int[] { 190, 175 } },
                                    new ItemSlot { Position = new int[] { 80, 265 } },
                                    new ItemSlot { Position = new int[] { 190, 265 } },
                                    new ItemSlot { Position = new int[] { 330, 85 } },
                                    new ItemSlot { Position = new int[] { 440, 85 } },
                                    new ItemSlot { Position = new int[] { 330, 175 } },
                                    new ItemSlot { Position = new int[] { 440, 175 } },
                                    new ItemSlot { Position = new int[] { 330, 265 } },
                                    new ItemSlot { Position = new int[] { 440, 265 } }});
            //
            //
            //------------------------------------------------------------------------------------------------
            // 
            // CHARACTERS
            //
            //------------------------------------------------------------------------------------------------
            //
            //
            //
            // ELOISE
            //
            //
            Character eloise = new Character
            {
                Name = "Eloise",
                Description = "There is something eerie with the look on her face",
                ImageBox = new PictureBox
                {
                    Image = GET_OUT.Properties.Resources.Eloise,
                    BackColor = Color.Transparent,
                    Size = new Size(240, 471),
                    Location = new Point(1356, 270),
                    Visible = true
                },
                ReactionPanel = new PictureBox
                {
                    Image = GET_OUT.Properties.Resources.TalkBubble,
                    BackColor = Color.Transparent,
                    Size = new Size(300, 260),
                    Location = new Point(1156, 12),
                    Visible = true
                },
                ReactionLabel = new Label
                {
                    Size = new Size(280, 120),
                    Location = new Point(1166, 24),
                    BackColor = System.Drawing.Color.White,
                    Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Visible = true
                },
                WantsItem = apple,
                SatisfactionItem = door2Key,
                
                ItemList = new List<Item>()
            };
            //
            // RONNY
            //
            Character ronny = new Character
            {
                Name = "Ronny",
                Description = "That's one well shaped body, and what a handsome face.",
                WantsItem = apple,
                SatisfactionItem = mainKey,
                ItemList = new List<Item>(),
                CharacterItemSlot = new ItemSlot(),
                ImageBox = new PictureBox
                {
                    Image = GET_OUT.Properties.Resources.Ronny,
                    BackColor = Color.Transparent,
                    Size = new Size(369, 700),
                    Location = new Point(1022, 133),
                    Visible = true
                },
                ReactionPanel = new PictureBox
                {
                    Image = GET_OUT.Properties.Resources.TalkBubbleRonny,
                    BackColor = Color.Transparent,
                    Size = new Size(300, 260),
                    Location = new Point(1392, 3),
                    Visible = true
                },
                ReactionLabel = new Label
                {
                    Size = new Size(280, 120),
                    Location = new Point(1400, 15),
                    BackColor = System.Drawing.Color.White,
                    Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Visible = true
                },

            };
            eloise.ItemList.Add(door2Key);
            room2.CharacterList.Add(eloise);

            //
            //
            //------------------------------------------------------------------------------------------------
            //
            // ROOMS
            //
            //------------------------------------------------------------------------------------------------
            //
            //
            //-----------------------------------
            // ROOM 1
            //-----------------------------------
            //

            room1.ItemSlotList = new List<ItemSlot> { new ItemSlot { Position = new int[] { 1104, 611 }, SlottedItem = cabinet },
                                                      new ItemSlot  {Position = new int[] { 820, 903 }},
                                                      new ItemSlot  {Position = new int[] { 1020, 903 }},
                                                      new ItemSlot  {Position = new int[] { 1220, 903 }}};

            room1.DoorList = new List<Door> { new Door {FromRoom = room1, ToRoom = endPoint,
                                                        Position = new int[] { 692, 296 }, Size = new int[] { 241, 473},
                                                        IsLocked = true, ID = "End point" },
                                              new Door {FromRoom = room1, ToRoom = room2,
                                                        Position = new int[] { 1552, 288 }, Size = new int[] { 92, 541 },
                                                        IsLocked = false, ID = "Door 1" }};
            //
            //-----------------------------------
            // ROOM 2
            //-----------------------------------
            //
            room2.ItemSlotList = new List<ItemSlot> { new ItemSlot  {Position = new int[] { 208, 210 }, SlottedItem = fridge},
                                                      new ItemSlot  {Position = new int[] { 720, 470 },  SlottedItem = null},
                                                      new ItemSlot  {Position = new int[] { 800, 470 },  SlottedItem = glassEmpty},
                                                      new ItemSlot  {Position = new int[] { 1096, 470 },  SlottedItem = null},
                                                      new ItemSlot  {Position = new int[] { 1176, 470 },  SlottedItem = null}};
            ///
            /// DOOR LIST
            //
            room2.DoorList = new List<Door> { new Door {FromRoom    = room2, ToRoom = room1,
                                                        Position    = new int[] { 98, 192 }, 
                                                        Size        = new int[] { 82, 680},
                                                        IsLocked    = false, ID = null },
                                              new Door {FromRoom    = room2, ToRoom = room3,
                                                        Position    = new int[] { 1746, 197 }, 
                                                        Size        = new int[] { 80, 680 },
                                                        IsLocked    = true, ID = "Door 2"}};

            //
            //
            //-----------------------------------
            // ROOM 3
            //-----------------------------------
            //
            //
            room3.ItemSlotList = new List<ItemSlot> { new ItemSlot  {Position = new int[] { 1462, 629 }, SlottedItem = burningAlarmClock },
                                                      new ItemSlot  {Position = new int[] { 720, 750 }},
                                                      new ItemSlot  {Position = new int[] { 800, 750 }},
                                                      new ItemSlot  {Position = new int[] { 700, 850 }},
                                                      new ItemSlot  {Position = new int[] { 770, 850 }}};
            room3.DoorList = new List<Door> { new Door {FromRoom = room3, ToRoom = room2,
                                                        Position = new int[] { 161, 226 }, Size = new int[] { 120, 738},
                                                        IsLocked = false, ID = "Door 2" }};

            ronny.CharacterItemSlot = room3.ItemSlotList.Find(itemSlot => itemSlot.SlottedItem == burningAlarmClock);
            ronny.ItemList.Add(mainKey);
            room3.CharacterList.Add(ronny);

            //
            //
            //-----------------------------------
            // END POINT
            //-----------------------------------
            //
            //
            endPoint.ItemSlotList = new List<ItemSlot>();
            endPoint.DoorList = new List<Door>();
            //
            //
            //
            roomList.Add(room1);
            roomList.Add(room2);
            roomList.Add(room3);
            roomList.Add(endPoint);
            StartingRoom = room1;
            //return StartingRoom;
         }
        //
        // END OF CLASS
        //
    }
}
