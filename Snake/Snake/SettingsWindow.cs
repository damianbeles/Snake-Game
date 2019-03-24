using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Snake
{
    public partial class SettingsWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool isSoundsOn = Settings.Instance.IsSoundsOn;
        private Color boardColor = Settings.Instance.BoardColor;
        private Color bodyColor = Settings.Instance.BodyColor;
        private Color headColor = Settings.Instance.HeadColor;
        private Color foodColor = Settings.Instance.FoodColor;
        private Color wallColor = Settings.Instance.WallColor;

        public SettingsWindow()
        {
            InitializeComponent();
            if (isSoundsOn)
                sounds.Image = (Image)Properties.Resources.ResourceManager.GetObject("soundson");
            else sounds.Image = (Image)Properties.Resources.ResourceManager.GetObject("soundsoff");
            boardColorPb.BackColor = boardColor;
            bodyColorPb.BackColor = bodyColor;
            headColorPb.BackColor = headColor;
            foodColorPb.BackColor = foodColor;
            wallColorPb.BackColor = wallColor;
        }

        private void SetColorFromDialog(PictureBox pictureBox, ref Color color)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                DialogResult dialogResult = colorDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    color = colorDialog.Color;
                    pictureBox.BackColor = color;
                }
            }

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

        // save events
        private void save_Click(object sender, EventArgs e)
        {
            Settings.Instance.IsSoundsOn = isSoundsOn;
            Settings.Instance.BoardColor = boardColor;
            Settings.Instance.BodyColor = bodyColor;
            Settings.Instance.HeadColor = headColor;
            Settings.Instance.FoodColor = foodColor;
            Settings.Instance.WallColor = wallColor;
            Close();
        }

        private void save_MouseEnter(object sender, EventArgs e)
        {
            save.Image = (Image)Properties.Resources.ResourceManager.GetObject("save_hover");
        }

        private void save_MouseLeave(object sender, EventArgs e)
        {
            save.Image = (Image)Properties.Resources.ResourceManager.GetObject("save");
        }
        // ~save events

        // sound events
        private void sounds_Click(object sender, EventArgs e)
        {
            if (isSoundsOn)
            {
                isSoundsOn = false;
                sounds.Image = (Image)Properties.Resources.ResourceManager.GetObject("soundsoff");
            }
            else
            {
                isSoundsOn = true;
                sounds.Image = (Image)Properties.Resources.ResourceManager.GetObject("soundson");
            }
        }
        // ~sound events

        // headColorPb events
        private void headColorPb_Click(object sender, EventArgs e)
        {
            SetColorFromDialog(headColorPb, ref headColor);
        }
        // ~headColorPb events

        // bodyColorPb events
        private void bodyColorPb_Click(object sender, EventArgs e)
        {
            SetColorFromDialog(bodyColorPb, ref bodyColor);
        }
        // ~bodyColorPb events

        // foodColorPb events
        private void foodColorPb_Click(object sender, EventArgs e)
        {
            SetColorFromDialog(foodColorPb, ref foodColor);
        }
        // ~foodColorPb events

        // wallColorPb events
        private void wallColorPb_Click(object sender, EventArgs e)
        {
            SetColorFromDialog(wallColorPb, ref wallColor);
        }
        // ~wallColorPb events

        // boardColorPb events
        private void boardColorPb_Click(object sender, EventArgs e)
        {
            SetColorFromDialog(boardColorPb, ref boardColor);
        }
        // ~boardColorPb events
    }
}
