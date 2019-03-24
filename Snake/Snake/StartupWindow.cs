using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class StartupWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public StartupWindow()
        {
            InitializeComponent();
        }

        // create events
        private void create_MouseEnter(object sender, EventArgs e)
        {
            create.Image = (Image)Properties.Resources.ResourceManager.GetObject("create_hover");
        }

        private void create_MouseLeave(object sender, EventArgs e)
        {
            create.Image = (Image)Properties.Resources.ResourceManager.GetObject("create");
        }
        // ~create events

        // exit events
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        // ~exit events

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

        // minimize events
        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        // ~minimize events

        // play events
        private void play_MouseEnter(object sender, EventArgs e)
        {
            play.Image = (Image)Properties.Resources.ResourceManager.GetObject("play_hover");
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.Image = (Image)Properties.Resources.ResourceManager.GetObject("play");
        }
        // ~play events

        // settings events
        private void settings_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            var dialogResult = settingsWindow.ShowDialog();
        }
        // ~settings events
    }
}
