using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class CreateWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        const int BOARD_WIDTH = 32;
        const int BOARD_HEIGHT = 32;
        const int TEXTURE_HEIGHT = 15;
        const int TEXTURE_WIDTH = 15;

        bool isDone = false;
        Point lastSnakeHead = new Point(-1, -1);
        BoardComponents[,] map = new BoardComponents[BOARD_WIDTH, BOARD_HEIGHT];

        public CreateWindow()
        {
            InitializeComponent();
            headPb.BackColor = Settings.Instance.HeadColor;
            wallPb.BackColor = Settings.Instance.WallColor;
            freeSquarePb.BackColor = Settings.Instance.BoardColor;
        }

        // boardCreator events
        private void boardCreator_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Brush brush = new SolidBrush(Settings.Instance.BoardColor);
            graphics.FillRegion(brush, graphics.Clip);
            brush = new SolidBrush(Settings.Instance.WallColor);
            for (int npos = 0; npos < 480; npos += TEXTURE_WIDTH)
            {
                graphics.FillRectangle(brush,
                    0, npos, 480, 1);
                graphics.FillRectangle(brush,
                    npos, 0, 1, 480);
            }
            for (int row = 0; row < BOARD_HEIGHT; ++row)
                for (int col = 0; col < BOARD_WIDTH; ++col)
                {
                    switch (map[row, col])
                    {
                        case BoardComponents.FOOD: brush = new SolidBrush(Settings.Instance.FoodColor); break;
                        case BoardComponents.SNAKE_BODYPART: brush = new SolidBrush(Settings.Instance.BodyColor); break;
                        case BoardComponents.SNAKE_HEAD: brush = new SolidBrush(Settings.Instance.HeadColor); break;
                        case BoardComponents.WALL: brush = new SolidBrush(Settings.Instance.WallColor); break;
                        default: brush = new SolidBrush(Settings.Instance.BoardColor); break;
                    }
                    graphics.FillRectangle(brush,
                        row * TEXTURE_HEIGHT + 1, col * TEXTURE_WIDTH + 1,
                        TEXTURE_WIDTH - 1, TEXTURE_HEIGHT - 1);
                }
        }
        // ~boardCreator events

        // CreateWindow events
        private void CreateWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (isDone)
                return;
            Point cursorPosition = PointToClient(Cursor.Position);
            cursorPosition.X -= 150;
            cursorPosition.Y -= 70;
            if (cursorPosition.X < 0 ||
                cursorPosition.Y < 0 ||
                cursorPosition.X > 480 ||
                cursorPosition.Y > 480)
                return;
            switch (e.KeyCode)
            {
                case Keys.W: map[cursorPosition.X / TEXTURE_WIDTH, cursorPosition.Y / TEXTURE_HEIGHT] = BoardComponents.WALL; break;
                case Keys.F: map[cursorPosition.X / TEXTURE_WIDTH, cursorPosition.Y / TEXTURE_HEIGHT] = BoardComponents.FREE_SQUARE; break;
                case Keys.P:
                    if (lastSnakeHead != new Point(-1, -1))
                    {
                        map[lastSnakeHead.X, lastSnakeHead.Y] = BoardComponents.FREE_SQUARE;
                    }
                    Point newSnakeHead = new Point(cursorPosition.X / TEXTURE_WIDTH, cursorPosition.Y / TEXTURE_HEIGHT);
                    map[newSnakeHead.X, newSnakeHead.Y] = BoardComponents.SNAKE_HEAD;
                    lastSnakeHead = newSnakeHead;
                    break;
                default: return;
            }
            boardCreator.Refresh();
        }
        // ~CreateWindow events

        // done events
        private void done_Click(object sender, EventArgs e)
        {
            if (lastSnakeHead == new Point(-1, -1))
                return;
            isDone = true;
            done.Visible = false;
            eatToBeatCount.Enabled = true;
            speed.Enabled = true;
            direction.Enabled = true;
            save.Visible = true;
        }

        private void done_MouseEnter(object sender, EventArgs e)
        {
            done.Image = (Image)Properties.Resources.ResourceManager.GetObject("done_hover");
        }

        private void done_MouseLeave(object sender, EventArgs e)
        {
            done.Image = (Image)Properties.Resources.ResourceManager.GetObject("done");
        }
        // ~done events

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

        // save events
        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Snake Level File|*.snake";
            saveFile.Title = "Save the level created!";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                List<string> lines = new List<string>();
                lines.Add(speed.Text);
                lines.Add(eatToBeatCount.Text);
                lines.Add(lastSnakeHead.X + " " + lastSnakeHead.Y);
                lines.Add(direction.SelectedIndex.ToString());
                for (int row = 0; row < BOARD_HEIGHT; ++row)
                {
                    string line = "";
                    for (int col = 0; col < BOARD_WIDTH; ++col)
                    {
                        line += (int)map[col, row] + " ";
                    }
                    lines.Add(line);
                }
                using (TextWriter textWriter = new StreamWriter(saveFile.FileName))
                {
                    foreach (string s in lines)
                        textWriter.WriteLine(s);
                }
            }
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
    }
}
