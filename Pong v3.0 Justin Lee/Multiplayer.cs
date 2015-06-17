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
    public partial class Multiplayer : Form
    {
        const int SCREEN_WIDTH = 900;
        const int SCREEN_HEIGHT = 600;

        Size size1 = new Size(20, 100);
        Size size2 = new Size(20, 100);
        Size sizeBall = new Size(18, 18);
        Size sizeTop = new Size(900, 7);
        Size sizeDown = new Size(900, 7);

        public Timer gameTime = new Timer();//Initializes the Timer

        int ballSpeedX = 3;
        int ballSpeedY = 3;
        int gameTimeInterval = 1;

        float player1 = 0;
        float player2 = 0;

        bool flag = false;

        bool end = true;
        bool endend = true;

        float speed = 0;

        bool Wpressed = false;
        bool Spressed = false;
        bool Ppressed = false;
        bool Lpressed = false;

        public bool picMulti1_last;
        public bool picMulti2_last;

        public bool starta = false;

        public bool pauseEnabled;

        SoundPlayer hit = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.pong_hit);
        SoundPlayer over = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.game_over);

        Form2 frm = new Form2();

        public Multiplayer()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.Multiplayer_KeyDown);
            label1.Text = player1.ToString();
            label1.Location = new Point(350, 25);

            this.Controls.Add(label1);
            label1.BringToFront();

            label2.Text = player2.ToString();
            label2.Location = new Point(475, 25);

            this.Controls.Add(label2);
            label2.BringToFront();

            picTop.Size = sizeTop;
            picTop.BackColor = Color.White;
            this.Controls.Add(picTop);

            Power_Up.Visible = false;
            Power_Up.Size = new Size(25, 25);
            Power_Up.Location = new Point(ClientSize.Width / 2 - Power_Up.Width / 2, ClientSize.Height / 2 - Power_Up.Height / 2);
            ovalBall.Visible = false;
            ovalBall.Size = new Size(18, 18);

            lab3.Visible = false;
            lab2.Visible = false;
            lab1.Visible = false;
            labelstart.Visible = false;

            timercount.Interval = 1;
            time3.Interval = 1000;
            time2.Interval = 2000;
            time1.Interval = 3000;
            timeSTART.Interval = 4000;

            //timerPower.Enabled = true;  still in development
            gameTime.Enabled = true;//Enables the Timer
            gameTime.Interval = gameTimeInterval;//Set the timer's interval

            gameTime.Tick += new EventHandler(gameTime_Tick);//Creates the Timer's Tick event

            this.Width = SCREEN_WIDTH;//sets the Form's Width
            this.Height = SCREEN_HEIGHT;//sets the Form's Height
            this.StartPosition = FormStartPosition.CenterScreen;//opens the form in center of the screen

            picMulti1.Size = size1;//sets the size of the picturebox
            picMulti1.Location = new Point(picMulti1.Width / 2 + 10, ClientSize.Height / 2 - picMulti1.Height / 2);//sets it's location (centered)
            picMulti1.BackColor = Color.White;//fills the picturebox with a color
            this.Controls.Add(picMulti1);//adds the picture box to the form

            picMulti2.Size = size2;
            picMulti2.Location = new Point(ClientSize.Width - (picMulti2.Width + picMulti2.Width / 2) - 10, ClientSize.Height / 2 - picMulti1.Height / 2);
            picMulti2.BackColor = Color.White;
            this.Controls.Add(picMulti2);

            picMultiBall.Size = sizeBall;
            picMultiBall.Location = new Point(ClientSize.Width / 2 - picMultiBall.Width / 2, ClientSize.Height / 2 - picMultiBall.Height / 2);
            picMultiBall.BackColor = Color.White;
            this.Controls.Add(picMultiBall);

        }
        void gameTime_Tick(object sender, EventArgs e)
        {
            if (starta)
            {
                label1.SendToBack();
                label2.SendToBack();
                picMultiBall.Location = new Point(picMultiBall.Location.X + ballSpeedX, picMultiBall.Location.Y + ballSpeedY);
                gameAreaCollisions();//Checks for collisions with the form's border
                padlleCollision();//Checks for collisions with the padlles\
                if (Wpressed) { picMulti1.Top -= 8; }
                if (Spressed) { picMulti1.Top += 8; }
                if (Ppressed) { picMulti2.Top -= 8; }
                if (Lpressed) { picMulti2.Top += 8; }
                pauseEnabled = false;
                Power_Up.Location = new Point(ClientSize.Width / 2 - Power_Up.Width / 2, ClientSize.Height / 2 - Power_Up.Height / 2);
            }
            if(!starta)
            {
                timerPower.Enabled = false;
                Power_Up.Visible = false;
                starta = true;
                reset();
            }
        }
        private void gameAreaCollisions()
        {
            if (picMultiBall.Location.Y > ClientSize.Height - picMultiBall.Height || picMultiBall.Location.Y < 0)
            {
              hit.Play();
              ballSpeedY = -ballSpeedY;
            }
            else if (picMultiBall.Location.X > ClientSize.Width)
            {
                Power_Up.Visible = false;
                timerPowerCheck.Stop();
                over.Play();
                gameTime.Stop();
                picMultiBall.Location = new Point(ClientSize.Width / 2 - picMultiBall.Width / 2, ClientSize.Height / 2 - picMultiBall.Height / 2);
                player1 = player1 + 1;
                label1.Text = player1.ToString();
                end = true;
                reset();
            }
            else if (picMultiBall.Location.X < 0)
            {
                timerPowerCheck.Stop();
                Power_Up.Visible = false;
                over.Play();
                gameTime.Stop();
                picMultiBall.Location = new Point(ClientSize.Width / 2 - picMultiBall.Width / 2, ClientSize.Height / 2 - picMultiBall.Height / 2);
                player2 = player2 + 1;
                label2.Text = player2.ToString();
                endend = true;
                reset();
            }
        }
        private void reset()
        {
            Power_Up.Visible = false;
            ballSpeedX = 3;
            ballSpeedY = 3;
            picMultiBall.Location = new Point(ClientSize.Width / 2 - picMultiBall.Width / 2, ClientSize.Height / 2 - picMultiBall.Height / 2);
            picMulti2.Location = new Point(ClientSize.Width - (picMulti2.Width + picMulti2.Width / 2) - 10, ClientSize.Height / 2 - picMulti1.Height / 2);
            picMulti1.Location = new Point(picMulti1.Width / 2 + 10, ClientSize.Height / 2 - picMulti1.Height / 2);//sets it's location (centered)
            gameTime.Enabled = false;
            timercount.Enabled = true;
            lab3.Visible = true;
            time3.Enabled = true;
            time2.Enabled = true;
            time1.Enabled = true;
            timeSTART.Enabled = true;
            //timerPower.Enabled = true;        COMMENTED OUT THE POWERUP *STILL IN WORK*
        }
        private void resetBall()
        {
            Wpressed = false;
            Spressed = false;
            Ppressed = false;
            Lpressed = false;
            ballSpeedX = 3;
            ballSpeedY = 3;
            ovalBall.Visible = false;
            
            end = true;
            endend = true;
        }
        private void padlleCollision()
        {
            if (picMultiBall.Bounds.IntersectsWith(picMulti2.Bounds))
            {
                picMulti2_last = true;
                picMulti1_last = false;
                hit.Play();
                if (ballSpeedX > 0)
                {
                    ballSpeedX = 8;
                    ballSpeedX = ballSpeedX * -1;
                    ballSpeedY = ((picMulti2.Top + 50) - (picMultiBall.Top + 11)) / -10;
                }
                else if (ballSpeedX < 0)
                {
                    ballSpeedX = -8;
                    ballSpeedX = ballSpeedX * -1;
                    ballSpeedY = ((picMulti2.Top + 50) - (picMultiBall.Top + 11)) / -10;
                }
            }

            if (picMultiBall.Bounds.IntersectsWith(picMulti1.Bounds))
            {
                picMulti1_last = true;
                picMulti2_last = false;
                hit.Play();
                if (ballSpeedX > 0)
                {
                    ballSpeedX = 8;
                    ballSpeedX = ballSpeedX * -1;
                    ballSpeedY = ((picMulti1.Top + 50) - (picMultiBall.Top + 11)) / -10;
                }
                else if (ballSpeedX < 0)
                {
                    ballSpeedX = -8;
                    ballSpeedX = ballSpeedX * -1;
                    ballSpeedY = ((picMulti1.Top + 50) - (picMultiBall.Top + 11)) / -10;
                }
            }
            if (picMulti1.Bounds.IntersectsWith(picTop.Bounds))
            {
                Wpressed = false;
            }
            if (picMulti2.Bounds.IntersectsWith(picTop.Bounds))
            {
                Ppressed = false;
            }
            if (picMulti1.Bounds.IntersectsWith(picDown.Bounds))
            {
                Spressed = false;
            }
            if (picMulti2.Bounds.IntersectsWith(picDown.Bounds))
            {
                Lpressed = false;
            }
        }
        private void speedadd()
        {
            speed++;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Multiplayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { Wpressed = true; }
            
            if (e.KeyCode == Keys.S)  { Spressed = true; }
            
            if (e.KeyCode == Keys.P) { Ppressed = true; }
            
            if (e.KeyCode == Keys.L) { Lpressed = true; }

            if ((e.KeyCode == Keys.Escape) || (e.KeyCode == Keys.Space)) { pause(); }
            
        } 
        private void Multiplayer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { Wpressed = false; }
            if (e.KeyCode == Keys.S) { Spressed = false; }
            if (e.KeyCode == Keys.P) { Ppressed = false; }
            if (e.KeyCode == Keys.L) { Lpressed = false; }
        }
        private void Multiplayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void pause()
        {
            
            if (pauseEnabled == false)
            {
                Cursor.Show();
                gameTime.Enabled = false;
                formPause frm = new formPause();
                frm.ShowDialog();
                if (frm.menuPressed == true)
                {
                    pauseEnabled = true;
                    this.Hide();
                    gameTime.Enabled = false;
                    Form2 forr = new Form2();
                    forr.Show();
                    Cursor.Show();
                }
                if (frm.helpPressed == true)
                {
                    this.Focus();
                    pauseEnabled = true;
                    gameTime.Enabled = false;
                    reset();
                }
                else
                {
                    this.Focus();
                    pauseEnabled = true;
                    gameTime.Enabled = true;
                    Cursor.Hide();
                }
            }
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
            picMultiBall.Location = new Point(ClientSize.Width / 2 - picMultiBall.Width / 2, ClientSize.Height / 2 - picMultiBall.Height / 2);
            timeSTART.Stop();
        }
        private void timercount_Tick(object sender, EventArgs e)
        {
            pauseEnabled = true;
        }

        private void Multiplayer_Load(object sender, EventArgs e)
        {
           frm.s.Stop();
        }

        private void timerPower_Tick(object sender, EventArgs e)
        {
            Power_Up.Visible = true;
            timerPowerCheck.Start();
            timerPower.Stop();
        }

        private void timerPowerCheck_Tick(object sender, EventArgs e)
        {
            if (picMultiBall.Bounds.IntersectsWith(Power_Up.Bounds))
            {
                Power_Up.Visible = false;
                if (picMulti1_last)
                {
                    picMulti1.Size = new Size(20, 150);
                    timerMulti1.Enabled = true;
                    ballSpeedX = 4;
                    ballSpeedY = 4;
                    timerPowerCheck.Stop();
                }
                if (picMulti2_last)
                {
                    pic2();
                    timerMulti2.Enabled = true;
                    timerPowerCheck.Stop();
                }
            }
        }
        private void pic2()
        {
            picMulti2.Size = new Size(20, 150);
            picMulti2.Width = 20;
            picMulti2.Height = 150;
        }

        private void timerMulti1_Tick(object sender, EventArgs e)
        {
            picMulti1.Size = new Size(20, 100);
            timerMulti1.Stop();
        }

        private void timerMulti1Off_Tick(object sender, EventArgs e)
        {
            timerMulti1.Stop();
            timerPowerCheck.Start();
            timerMulti1Off.Stop();
            gameTime.Enabled = true;
        }

        private void timerMulti2_Tick(object sender, EventArgs e)
        {
            picMulti2.Size = new Size(20, 100);
            timerMulti1.Stop();
        }

        private void timerMulti2Off_Tick(object sender, EventArgs e)
        {
            timerMulti2.Stop();
            timerPowerCheck.Start();
            timerMulti2Off.Stop();
            gameTime.Enabled = true;
        }

    }
}

