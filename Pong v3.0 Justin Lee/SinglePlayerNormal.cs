using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pong_v3._0_Justin_Lee
{
    public partial class SinglePlayerNormal : Form
    {
        const int SCREEN_WIDTH = 900;
        const int SCREEN_HEIGHT = 600;

        Size sizeHero = new Size(20, 100);
        Size sizeAI = new Size(20, 100);
        Size sizeBall = new Size(18, 18);
        Size sizeTop = new Size(900, 7);
        Size sizeDown = new Size(900, 16);
        Size sizeLeft = new Size(7, 600);
        Size sizeRight = new Size(9, 600);

        int ballSpeedX = 7;
        int ballSpeedY = 7;
        public int gameTimeInterval = 1;

        float player = 0;
        float player2 = 0;

        bool flag = false;

        SoundPlayer hit = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.pong_hit);
        SoundPlayer over = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.game_over);

        public Timer gameTime = new Timer();//Initializes the Timer

        decimal n = 0.5m;

        public bool pauseEnabled = false;
        public bool pauseDisabled = true;

        Random rnd = new Random();

        int start;

        formPause form = new formPause();

        public bool startx = false;

        public bool pausemenu = false;

        public bool pausepause = false;

        public bool starta = false;

        public SinglePlayerNormal()
        {
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

            InitializeComponent();
            picBall.BringToFront();

            lab3.Visible = false;
            lab2.Visible = false;
            lab1.Visible = false;
            labelstart.Visible = false;

            timercount.Interval = 1;
            time3.Interval = 1000;
            time2.Interval = 2000;
            time1.Interval = 3000;
            timeSTART.Interval = 4000;

            pausemenu = false;

            start = rnd.Next(1, 5);

            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown_1);

            this.Width = SCREEN_WIDTH;
            this.Height = SCREEN_HEIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;//opens the form in center of the screen

            gameTime.Enabled = true;//Enables the Timer
            gameTime.Interval = gameTimeInterval;//Set the timer's interval

            gameTime.Tick += new EventHandler(gameTime_Tick);//Creates the Timer's Tick event

            picPaddleHero.Size = sizeHero;//sets the size of the picturebox
            picPaddleHero.Location = new Point(picPaddleHero.Width / 2 + 10, ClientSize.Height / 2 - picPaddleHero.Height / 2);//sets it's location (centered)
            picPaddleHero.BackColor = Color.White;//fills the picturebox with a color
            this.Controls.Add(picPaddleHero);//adds the picture box to the form

            picPaddleBot.Size = sizeAI;
            picPaddleBot.Location = new Point(ClientSize.Width - (picPaddleBot.Width + picPaddleBot.Width / 2) - 10, ClientSize.Height / 2 - picPaddleHero.Height / 2);
            picPaddleBot.BackColor = Color.White;
            this.Controls.Add(picPaddleBot);

            picBall.Size = sizeBall;
            picBall.Location = new Point(ClientSize.Width / 2 - picBall.Width / 2, ClientSize.Height / 2 - picBall.Height / 2);
            picBall.BackColor = Color.White;
            this.Controls.Add(picBall);

            picTop.Size = sizeTop;
            picTop.BackColor = Color.White;
            this.Controls.Add(picTop);

            picDown.Size = sizeDown;
            picDown.BackColor = Color.White;
            this.Controls.Add(picDown);

            picLeft.Size = sizeLeft;
            picLeft.BackColor = Color.White;
            this.Controls.Add(picLeft);

            picRight.Size = sizeRight;
            picRight.BackColor = Color.White;
            this.Controls.Add(picRight);
        }

        private void SinglePlayerNormal_Load(object sender, EventArgs e)
        {

        }
        public void gameTime_Tick(object sender, EventArgs e)
        {
            if (starta == true)
            {
                labelHero.SendToBack();
                picBall.BringToFront();
                labelBot.SendToBack();
                ball();
                gameAreaCollisions();//Checks for collisions with the form's border
                if (picBall.Bounds.IntersectsWith(picPaddleHero.Bounds))
                {
                    paddlehero();
                }
                else if (picBall.Bounds.IntersectsWith(picPaddleBot.Bounds))
                {
                    paddlebot();
                }
                padlleCollision();//Checks for collisions with the padlles\
                playerMovement();
                aiMovement();//Updates the ai's position
                pauseEnabled = false;

                //im1.Start();
                //im1.Interval = 1;
            }
            if (starta == false)
            {
                starta = true;
                resetBall();
            }
        }
        private void ball()
        {
            if (start == 1)
            {
                picBall.Location = new Point(picBall.Location.X + ballSpeedX, picBall.Location.Y - ballSpeedY);
                
            }
            if (start == 2)
            {
                picBall.Location = new Point(picBall.Location.X + ballSpeedX, picBall.Location.Y + ballSpeedY);
                
            }
            if (start == 3)
            {
                picBall.Location = new Point(picBall.Location.X - ballSpeedX, picBall.Location.Y + ballSpeedY);
                startx = true;
                
            }
            if (start == 4)
            {
                picBall.Location = new Point(picBall.Location.X - ballSpeedX, picBall.Location.Y - ballSpeedY);
                startx = true;
                
            }
        }
        private void gameAreaCollisions()
        {
            if (picBall.Location.Y > ClientSize.Height - picBall.Height || picBall.Location.Y < 0)
            {
                ballSpeedY = -ballSpeedY;
            }
            else if (picBall.Location.X > ClientSize.Width)
            {
                player = player + 1;
                labelHero.Text = Convert.ToString(player);
                countdown();
            }
            else if (picBall.Location.X < 0)
            {
                player2 = player2 + 1;
                labelBot.Text = Convert.ToString(player2);
                countdown();
            }
        }
        private void resetBall()
        {
            start = rnd.Next(1, 5);
            ballSpeedX = 6;
            ballSpeedY = 6;
            picBall.Location = new Point(ClientSize.Width / 2 - picBall.Width / 2, ClientSize.Height / 2 - picBall.Height / 2);
            gameTime.Enabled = false;
            timercount.Enabled = true;
            lab3.Visible = true;
            time3.Enabled = true;
            time2.Enabled = true;
            time1.Enabled = true;
            timeSTART.Enabled = true;

        }
        private void countdown()
        {
            bool count = true;
            if (flag == false)
            {
                flag = true;
                //
                flag = false;
                count = false;
            }
            if (count == false)
            {
                resetBall();
            }
        }
        private void playerMovement()
        {
            if (this.PointToClient(MousePosition).Y >= picPaddleHero.Height / 2 && this.PointToClient(MousePosition).Y <= ClientSize.Height - picPaddleHero.Height / 2)
            {
                int playerX = picPaddleHero.Width / 2;
                int playerY = this.PointToClient(MousePosition).Y - picPaddleHero.Height / 2;

                picPaddleHero.Location = new Point(playerX + 10, playerY);
            }
        }
        private void aiMovement()
        {
            if (picBall.Top + 20 > picPaddleBot.Top + 50)
            {
                Random ran = new Random();
                int a = ran.Next(3, 5);
                picPaddleBot.Top = picPaddleBot.Top + 3;
                //picPaddleBot.Location = new Point(ClientSize.Width - (picPaddleBot.Width + picPaddleBot.Width / 2), picBall.Location.Y - picPaddleBot.Height / 2);
            }
            if(picBall.Top + 20 < picPaddleBot.Top + 50)
            {
                Random ran = new Random();
                int a = ran.Next(3, 5);
                picPaddleBot.Top = picPaddleBot.Top - 3;    
            }
            //if (ballSpeedX < 0)
            //{
                //picPaddleBot.Location = new Point(ClientSize.Width - (picPaddleBot.Width + picPaddleBot.Width / 2), picBall.Location.Y - picPaddleBot.Height / 2);
            //}
        }
        private void paddlehero()
        {
            hit.Play();
            if (ballSpeedX > 0)
            {
                ballSpeedX = 10;
                ballSpeedX = ballSpeedX * -1;
                ballSpeedY = ((picPaddleHero.Top + 50) - (picBall.Top + 11)) / -10;
            }
            else if (ballSpeedX < 0)
            {
                ballSpeedX = -10;
                ballSpeedX = ballSpeedX * -1;
                ballSpeedY = ((picPaddleHero.Top + 50) - (picBall.Top + 11)) / -10;
            }
        }
        private void paddlebot()
        {
            hit.Play();
            if (ballSpeedX > 0)
            {
                ballSpeedX = 10;
                ballSpeedX = ballSpeedX * -1;
                ballSpeedY = ((picPaddleBot.Top + 50) - (picBall.Top + 11)) / -10;
            }
            else if (ballSpeedX < 0)
            {
                ballSpeedX = -10;
                ballSpeedX = ballSpeedX * -1;
                ballSpeedY = ((picPaddleBot.Top + 50) - (picBall.Top + 11)) / -10;
            }
        }
        private void padlleCollision()
        {
            if (picBall.Bounds.IntersectsWith(picDown.Bounds))
            {
                hit.Play();
            }
            else if (picBall.Bounds.IntersectsWith(picTop.Bounds))
            {
                hit.Play();
            }        

        }
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pause();
            }

        }
        private void pause()
        {
           Cursor.Show();
                gameTime.Enabled = false;
                formPause frm = new formPause();
                Music f = new Music();
                hit.Stop();
                over.Stop();
                frm.ShowDialog();
                if(frm.menuPressed == true)
                {
                    pauseEnabled = true;

                    this.Hide();
                    
                    gameTime.Enabled = false;
                    hit.Stop();
                    over.Stop();
                    Form2 forr = new Form2();
                    
                    forr.Show();
                    Cursor.Show();
                }
                if (frm.helpPressed == true)
                {
                    this.Focus();
                    pauseEnabled = true;
                    gameTime.Enabled = false;
                    resetBall();
                }
                else
                {
                    this.Focus();
                    Cursor.Hide();
                    pauseEnabled = true;
                    gameTime.Enabled = true;
                    Cursor.Hide();
                }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void formSingMouse_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { pauseEnabled = true; }
        }

        private void formSingMouse_Load(object sender, EventArgs e)
        {
        }

        private void formSingMouse_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void formSingMouse_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void labelHero_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void labelBot_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void time3_Tick(object sender, EventArgs e)
        {
            lab3.Visible = false;
            lab2.Visible = true;
            time3.Stop();
        }
        private void time2_Tick(object sender, EventArgs e)
        {
            lab2.Visible = false;
            lab1.Visible = true;
            time2.Stop();
        }

        private void time1_Tick(object sender, EventArgs e)
        {
            lab1.Visible = false;
            labelstart.Visible = true;
            time1.Stop();
        }

        private void timeSTART_Tick(object sender, EventArgs e)
        {
            labelstart.Visible = false;
            gameTime.Enabled = true;
            timercount.Enabled = false;
            timeSTART.Stop();
        }
        private void timercount_Tick(object sender, EventArgs e)
        {
            labelstart.SendToBack();
            labelHero.SendToBack();
            picBall.BringToFront();
            labelBot.SendToBack();
            gameAreaCollisions();//Checks for collisions with the form's border
            if (picBall.Bounds.IntersectsWith(picPaddleHero.Bounds))
            {
                paddlehero();
            }
            else if (picBall.Bounds.IntersectsWith(picPaddleBot.Bounds))
            {
                paddlebot();
            }
            padlleCollision();//Checks for collisions with the padlles\
            playerMovement();
            aiMovement();//Updates the ai's position
            pauseEnabled = true;
        }
    }
}
