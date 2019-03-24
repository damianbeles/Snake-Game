using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Snake
{
    public partial class WinningWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public WinningWindow()
        {
            InitializeComponent();
        }

        // header events
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // ~header events

        // ok events
        private void ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_MouseEnter(object sender, EventArgs e)
        {
            ok.Image = (Image)Properties.Resources.ResourceManager.GetObject("ok_hover");
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {
            ok.Image = (Image)Properties.Resources.ResourceManager.GetObject("ok");
        }
        // ~ok events
    }
}
