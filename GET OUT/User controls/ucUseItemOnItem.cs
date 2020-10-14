using System;
using System.Windows.Forms;

namespace GET_OUT
{
    public partial class ucUseItemOnItem : UserControl
    {
        public Player User { get; set; }
        public Room ActiveRoom { get; set; }
        public Item UseItem { get; set; }
        public Item UseOnItem { get; set; }
        public frmGame MainForm { get; set; }
        public Control MotherControl { get; set; }

        public ucUseItemOnItem(Player user, Room activeRoom, Item useItem, Item useOnItem, frmGame mainForm, Control motherControl)
        {
            InitializeComponent();
            User = user;
            ActiveRoom = activeRoom;
            UseItem = useItem;
            UseOnItem = useOnItem;
            MainForm = mainForm;
            MotherControl = motherControl;
            lblUseItem.Text = "Use " + useItem.Name + " on " + useOnItem.Name + "?";
            this.Left = (MainForm.Width - this.Width) / 2;
            this.Top = (MainForm.Height - this.Height) / 2;
        }

        private void cmdYes_Click(object sender, EventArgs e)
        {
            UseOnItem.ItemSlot.SlottedItem = UseOnItem.TransformsTo;
            UseItem.ItemSlot.SlottedItem = UseItem.TransformsTo;
            this.Hide();
            MotherControl.Hide();
            MainForm.OpenRoom(ActiveRoom);
        }

        private void cmdNo_Click(object sender, EventArgs e)
        {
            MotherControl.Show();
            this.Hide();
        }
    }
}
