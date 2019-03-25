using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameWindow : Form
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

        Board board;
        bool isGameOver = false;

        public GameWindow(string levelFile)
        {
            InitializeComponent();
            InitializeBoardFromLevelFile(levelFile);
        }

        private void InitializeBoardFromLevelFile(string levelFile)
        {
            try
            {
                const int BOARD_HEIGHT = 32;
                const int BOARD_WIDTH = 32;
                List<string> filePayload = new List<string>();
                foreach (string line in File.ReadLines(levelFile, Encoding.UTF8))
                {
                    filePayload.Add(line);
                }
                snakeSpeed.Interval = Int32.Parse(filePayload[0]);
                int necessaryNumberOfFood = Int32.Parse(filePayload[1]);
                string[] coordinates = filePayload[2].Split(' ');
                Point snakeStartingPoint = new Point(Int32.Parse(coordinates[0]), Int32.Parse(coordinates[1]));
                Direction snakeStartingDirection = (Direction)Int32.Parse(filePayload[3]);
                BoardComponents[,] map = new BoardComponents[BOARD_WIDTH, BOARD_HEIGHT];
                for (int row = 0; row < BOARD_WIDTH; ++row)
                {
                    string currentLine = filePayload[4 + row];
                    string[] boardComponents = currentLine.Split(' ');
                    for (int col = 0; col < BOARD_HEIGHT; ++col)
                        map[col, row] = (BoardComponents)Int32.Parse(boardComponents[col]);
                }

                board = new Board(snakeStartingPoint, snakeStartingDirection, necessaryNumberOfFood, map);
                visualBoard.Refresh();
                snakeSpeed.Enabled = true;
            }
            catch
            {
                eatToBeatCount.Hide();
                eatToBeatPb.Hide();
                couldntLoadFilePb.Show();
                visualBoard.Dispose();
            }
        }

        private void gameAdvance()
        {
            if (board.isGameOverBySnakeAdvancing())
            {
                isGameOver = true;
                if (board.HasWon)
                {
                    if (Settings.Instance.IsSoundsOn)
                    {
                        SoundPlayer winningSound = new SoundPlayer(Properties.Resources.claps);
                        winningSound.Play();
                    }
                    WinningWindow winningWindow = new WinningWindow();
                    winningWindow.ShowDialog();
                    Close();
                }
                else
                {
                    LosingWindow losingWindow = new LosingWindow();
                    losingWindow.ShowDialog();
                    Close();
                }
            }
            else
            {
                eatToBeatCount.Text = board.RemainingFood.ToString();
            }
            visualBoard.Refresh();
        }

        // exit events
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        // ~exit events

        // GameWindow events
        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameOver)
                return;
            snakeSpeed.Enabled = false;
            switch (e.KeyCode)
            {
                case Keys.W: board.changeSnakeDirection(Direction.NORTH); break;
                case Keys.S: board.changeSnakeDirection(Direction.SOUTH); break;
                case Keys.A: board.changeSnakeDirection(Direction.WEST); break;
                case Keys.D: board.changeSnakeDirection(Direction.EAST); break;
            }
            gameAdvance();
            snakeSpeed.Enabled = true;
        }
        // ~GameWindow events

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

        // snakeSppeed events
        private void snakeSpeed_Tick(object sender, EventArgs e)
        {
            if (isGameOver)
            {
                snakeSpeed.Enabled = false;
                return;
            }
            gameAdvance();
        }
        // ~snakeSpeed events

        // visualBoard events
        private void visualBoard_Paint(object sender, PaintEventArgs e)
        {
            board.drawBoardOnGraphics(e.Graphics);
        }
        // ~visualBoard events
    }
}
