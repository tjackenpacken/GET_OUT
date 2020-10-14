using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GET_OUT
{
    public partial class frmStart : Form
    {
        public bool IsStarting { get; set; }
        public frmStart()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
        private void cmdExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private async void lblWakeUp_Click(object sender, EventArgs e)
        {
            if (!IsStarting)
            {
                IsStarting = true;
                panelStart.BackgroundImage = GET_OUT.Properties.Resources.WAKE_UP_2;
                await Task.Delay(2000);
                frmGame gameForm = new frmGame();
                gameForm.Show();
                panelStart.BackgroundImage = GET_OUT.Properties.Resources.WAKE_UP_1;
                IsStarting = false;
            }
        }
        private void lblWakeUp_MouseHover(object sender, EventArgs e)
        {
            lblWakeUp.Text = "WAKE UP";
            lblWakeUp.ForeColor = Color.Black;
        }


        private void lblWakeUp_MouseLeave(object sender, EventArgs e)
        {
            if (!IsStarting)
            {
            lblWakeUp.Text = "GET OUT";
            lblWakeUp.ForeColor = Color.Gray;
            }
        }
    }
}
