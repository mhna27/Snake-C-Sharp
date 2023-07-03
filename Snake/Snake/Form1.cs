using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    enum Rotate_Status { Up, Down, Left, Right }
    public partial class Form1 : Form
    {
        List<Button> _snake_Length;
        Rotate_Status _rotate_Status;
        int _step = 0;
        int _score = 0;
        bool _flag_Length;
        DateTime _last_KeyDown_Time;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan elapsed = now - _last_KeyDown_Time;
            if (elapsed.TotalMilliseconds < 400)
            {
                return;
            }
            _last_KeyDown_Time = now;

            switch (e.KeyCode)
            {
                case Keys.Down:
                    Change_Route(Rotate_Status.Down);
                    break;
                case Keys.Up:
                    Change_Route(Rotate_Status.Up);
                    break;
                case Keys.Left:
                    Change_Route(Rotate_Status.Left);
                    break;
                case Keys.Right:
                    Change_Route(Rotate_Status.Right);
                    break;
                default:
                    break;
            }
        }

        private void Change_Route(Rotate_Status rotate)
        {
            if ((_rotate_Status == Rotate_Status.Right && rotate == Rotate_Status.Left)
                || (_rotate_Status == Rotate_Status.Left && rotate == Rotate_Status.Right)
                || (_rotate_Status == Rotate_Status.Up && rotate == Rotate_Status.Down)
                || (_rotate_Status == Rotate_Status.Down && rotate == Rotate_Status.Up))
            {
                return;
            }
            timer1.Enabled = false;
            _rotate_Status = rotate;
            _step = 0;
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Snake.Left = 300;
            Snake.Top = 25;
            Tail.Left = 274;
            Tail.Top = 25;

            _snake_Length = new List<Button>();
            _snake_Length.Add(Snake);
            _snake_Length.Add(Tail);
            _rotate_Status = Rotate_Status.Right;
            Show_Apple();
            _last_KeyDown_Time = DateTime.Now;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = 0;
            bool game_Over = false;
            int top_Old = 0;
            int left_Old = 0;
            int top_Temp = 0;
            int left_Temp = 0;
            if (_flag_Length)
                Add_Snake_Length();
            _flag_Length = false;

            foreach (Button b in _snake_Length)
            {
                if (index == 0)
                {
                    top_Old = b.Top; left_Old = b.Left;
                    if (!Move_Snake(b, _rotate_Status))
                    {
                        game_Over = true;
                        break;
                    }
                }
                else
                {
                    top_Temp = b.Top; left_Temp = b.Left;

                    b.Top = top_Old; b.Left = left_Old;

                    top_Old = top_Temp; left_Old = left_Temp;
                }
                index++;
            }
            _step++;

            if (game_Over)
            {
                timer1.Enabled = false;
                MessageBox.Show("Game Over");
            }
        }

        private bool Move_Snake(Button btn, Rotate_Status rotate)
        {
            if (btn.Location.X >= panel2.Width || btn.Location.X < panel2.Left
                || btn.Location.Y >= panel2.Height || btn.Location.Y + 50 < panel2.Top)
            {
                return false;
            }

            if (btn.Left == Apple.Left && btn.Top == Apple.Top)
            {
                timer1.Enabled = false;
                _flag_Length = true;
                Show_Apple();
                timer1.Enabled = true;
            }
            
            bool founded = false;
            foreach (Control c in panel2.Controls)
            {
                if (c is Button && !c.Equals(btn) && c.Left == btn.Left && c.Top == btn.Top)
                {
                    founded = true;
                    break;
                }
            }
            if (founded) return false;

            switch (rotate)
            {
                case Rotate_Status.Up:
                    btn.Top -= 25;
                    Snake.BackgroundImage = Properties.Resources.Up;
                    break;

                case Rotate_Status.Down:
                    btn.Top += 25;
                    Snake.BackgroundImage = Properties.Resources.Down;
                    break;

                case Rotate_Status.Left:
                    btn.Left -= 25;
                    Snake.BackgroundImage = Properties.Resources.Left;
                    break;

                case Rotate_Status.Right:
                    btn.Left += 25;
                    Snake.BackgroundImage = Properties.Resources.Right;
                    break;
            }

            return true;
        }

        private void Show_Apple()
        {
            int boardTop = 50; // top coordinate of the chessboard
            int boardLeft = 0; // left coordinate of the chessboard
            int cellWidth = 25; // width of a cell in pixels
            int cellHeight = 25; // height of a cell in pixels

            Random rnd = new Random();
            int xCoordinate = rnd.Next(1, 19) * cellWidth; // x-coordinate of the point where you want to place Apple
            int yCoordinate = rnd.Next(1, 19) * cellHeight; // y-coordinate of the point where you want to place Apple

            int rowIndex = (yCoordinate - boardTop) / cellHeight;
            int columnIndex = (xCoordinate - boardLeft) / cellWidth;

            int apple_Top = boardTop + rowIndex * cellHeight;
            int apple_Left = boardLeft + columnIndex * cellWidth;

            foreach (Button b in _snake_Length)
            {
                if (b.Top == apple_Top || b.Left == apple_Left)
                {
                    xCoordinate = rnd.Next(1, 19) * cellWidth;
                    yCoordinate = rnd.Next(1, 19) * cellHeight;
                    rowIndex = (yCoordinate - boardTop) / cellHeight;
                    xCoordinate = (xCoordinate - boardLeft) / cellWidth;
                    xCoordinate = boardTop + rowIndex * cellHeight;
                    xCoordinate = boardLeft + columnIndex * cellWidth;
                }

            }
            Apple.Top = apple_Top; Apple.Left = apple_Left;
        }

        private void Add_Snake_Length()
        {
            Button btn = new Button();
            btn.Name = $"btn_{_snake_Length.Count + 1}";
            btn.Width = 25;
            btn.Height = 25;
            btn.BackColor = Color.LimeGreen;
            btn.Enabled = false;
            panel2.Controls.Add(btn);
            _snake_Length.Add(btn);
            _score++;
            if (_score % 5 == 0 && timer1.Interval > 100)
            { timer1.Interval -= 100; }
            lbl_Score.Text = _score.ToString();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
