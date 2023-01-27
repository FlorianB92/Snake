using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Game : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        
        int maxHight; 
        int maxWidth;
        int s = 0;

        Random rand = new Random();



        bool goLeft, goRight, goDown, goUp;

        public Game()
        {
            InitializeComponent();
            new Settings();
            StartGame();
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Application.ExitThread();
            }

            if(e.KeyCode == Keys.R)
            {
                Restart();
            }

            if(e.KeyCode == Keys.Left && Settings.direction != "right")
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right && Settings.direction != "left")
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Down && Settings.direction != "up")
            {
                goDown = true;
            }
            if(e.KeyCode == Keys.Up && Settings.direction != "down")
            {
                goUp = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void UpdateBoxGraphics(object sender, PaintEventArgs e)
        {
            //gibt Schlange und essen ihre Farbe
            Graphics canvas = e.Graphics;
            Brush SnakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if(i == 0)
                {
                    SnakeColour = Brushes.DarkGreen;
                }
                else
                {
                    SnakeColour = Brushes.Green;
                }
                canvas.FillEllipse(SnakeColour, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Height, Settings.Width));
            }

            canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Height, Settings.Width));
        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void EventTimer(object sender, EventArgs e)
        {
            EatFood();

            if (goLeft)
            {
                Settings.direction = "left";
            }
            if (goRight)
            {
                Settings.direction = "right";
            }
            if (goDown)
            {
                Settings.direction = "down";
            }
            if (goUp)
            {
                Settings.direction = "up";
            }

            //Steuerung für die Schlange
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }
                }
                else
                {
                    //aktuellesiert die Positionen der Körper
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            pictureBox1.Invalidate();
            GameOver();
        }

        private void StartGame()
        {
            maxHight = pictureBox1.Height / Settings.Height - 1;
            maxWidth = pictureBox1.Width / Settings.Width - 1;

            Circle head = new Circle { Y = pictureBox1.Height / Settings.Height / 2, X = pictureBox1.Width / Settings.Width / 2}; 
            Snake.Add(head);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHight) };
            for (int i = 0; i < 3; i++)
            {
                if (Snake.Count == 0)
                {
                    Circle body = new Circle { X = Snake[0].X, Y = Snake[0].Y +1};
                    Snake.Add(body);
                }
                else
                {
                    Circle body = new Circle { X = Snake[i].X, Y = Snake[i].Y +1};
                    Snake.Add(body);
                }
            }
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameOver()
        {
            for(int i = 1; i < Snake.Count; i++)
            {
                if (Snake[0].X == pictureBox1.Width / Settings.Width || Snake[0].Y == pictureBox1.Height / Settings.Height || Snake[0].X == -1 || Snake[0].Y == -1)
                {
                    timer1.Stop();
                    over.Text = "GameOver" + Environment.NewLine + "Score: " + s + Environment.NewLine + "Press R to Restart";

                }
                if (Snake[0].X == Snake[i].X && Snake[0].Y == Snake[i].Y)
                {
                    timer1.Stop();
                    over.Text = "GameOver" + Environment.NewLine + "Score: " + s + Environment.NewLine + "Press R to Restart";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Restart()
        {
            Snake.Clear();
            s = 0;
            txtScore.Text = "Score: " + s;
            over.Text = "";
            Settings.direction = "up";
            StartGame();
        }
        
        private void EatFood()
        {
            if (food.X == Snake[0].X && food.Y == Snake[0].Y)
            {
                int l = Snake.Count - 1;
                food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHight) };
                Circle body = new Circle { X = Snake[l].X, Y = Snake[l].Y };
                Snake.Add(body);
                s = s + 1;
                txtScore.Text = "Score: " + s;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
