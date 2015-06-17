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
using System.Drawing.Drawing2D;
using WMPLib;

namespace Pong_v3._0_Justin_Lee
{
    public partial class mouseHard : Form
    {

        Random rand1 = new Random(); //FIRST RAND FOR AI MOVEMENT
        Random rand2 = new Random(); //SECOND RAND FOR AI MOVEMENT

        const int SCREEN_WIDTH = 900; //WIDTH
        const int SCREEN_HEIGHT = 600; //HEIGHT

        //SIZES FOR PADDLES AND BALLS
        Size sizeHero = new Size(20, 100);
        Size sizeAI = new Size(20, 100);
        Size sizeBall = new Size(20, 20);
        Size sizeTop = new Size(900, 7);
        Size sizeDown = new Size(900, 16);
        Size sizeLeft = new Size(7, 600);
        Size sizeRight = new Size(9, 600);

        //BALL SPEED
        int ballSpeedX = 7;
        int ballSpeedY = 7;

        //TIMER INTERVAL
        public int gameTimeInterval = 1;

        //SCORE
        float player = 0;
        float player2 = 0;

        //COUNTDOWN BOOL
        bool flag = false;

        
        //CREATES TIMER
        public Timer gameTime = new Timer();//Initializes the Timer

        
        //BOOLS FOR PAUSE
        public bool pauseEnabled = false;
        public bool pauseDisabled = true;

        //THIRD RANDOM
        Random rnd = new Random();

        //INT FOR RAND
        int start;

        //MAKES A NEW INSTANCE OF OPTIONS
        formPause form = new formPause();


        //BOOLS
        public bool startx = false;

        public bool pausemenu = false;

        public bool pausepause = false;

        public bool resett = false;

        public bool times3 = true;

        public bool starta = false;

        Form2 f = new Form2();

        Music m = new Music();

        //BOOLS FOR KEYBOARD
        public bool Wpressed;
        public bool Spressed;
        public mouseHard()
        {
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed); //EVENT HANDLER FOR FORMCLOSED

            InitializeComponent();
            picBall.BringToFront(); //BRING THE BALL TO THE FRONT


            //HIDE BUTTONS
            buttonRestart.Visible = false;
            buttonMainMenu.Visible = false;


            //HIDE COUNTDOWN LABELS
            labelAI.Visible = false;
            lab3.Visible = false;
            lab2.Visible = false;
            lab1.Visible = false;
            labelstart.Visible = false;

            //BOOL MENU FALSE
            pausemenu = false;


            //RANDOM DISTANCE
            start = rnd.Next(1, 5);

            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown_1);


            //SETTING WIDTH AND HEIGHT
            this.Width = SCREEN_WIDTH;
            this.Height = SCREEN_HEIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;//opens the form in center of the screen

            gameTime.Enabled = true;//Enables the Timer
            gameTime.Interval = gameTimeInterval;//Set the timer's interval


            //INTERVALS
            timercount.Interval = 1;
            time3.Interval = 1000;
            time2.Interval = 2000;
            time1.Interval = 3000;
            timeSTART.Interval = 4000;

            gameTime.Tick += new EventHandler(gameTime_Tick);//Creates the Timer's Tick event


            //ALL THE PICTURE BOX SETTINGS DOWN BELOW 

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
        public void gameTime_Tick(object sender, EventArgs e) //MAIN TIMER
        {
            Cursor.Hide();
            if (starta == true)                 //AFTER FIRST START UP DO THIS
            {
                labelHero.SendToBack();
                picBall.BringToFront();
                labelBot.SendToBack();
                ball();
                gameAreaCollisions();//Checks for collisions with the form's border
                if (picBall.Bounds.IntersectsWith(picPaddleHero.Bounds)) //INTERACTIONS WITH PADDLES
                {
                    paddlehero();
                }
                else if (picBall.Bounds.IntersectsWith(picPaddleBot.Bounds))
                {
                    paddlebot();
                }
                playerMovement();
                aiMovement();//Updates the ai's position
                pauseEnabled = false;
                f.IntroPlaying = true;
                if (Wpressed) { picPaddleHero.Top -= 8; }
                if (Spressed) { picPaddleHero.Top += 8; }
            }
            if (starta == false)                                //FIRST START UP, DO THIS
            {
                Cursor.Hide();
                f.IntroPlaying = true;
                starta = true;
                resetBall();
            }
        }
        private void ball()
        {

            //RANDOM BALL STARTNG LOCATIONS
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

            //HIT SOUNDS FOR PADDLES AND BALLS AND BORDERS
            SoundPlayer hit1 = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.pong_hit);
            SoundPlayer over1 = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.game_over);
            if (picBall.Location.Y > ClientSize.Height - picBall.Height || picBall.Location.Y < 0)
            {
                ballSpeedY = -ballSpeedY;
                hit1.Play();
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
        private void botwin()
        {
            gameTime.Enabled = false;

        }
        private void resetBall()
        {

            //RESETTING THE BALL
            start = rnd.Next(1, 5);
            ballSpeedX = 6;
            ballSpeedY = 6;
            picBall.Location = new Point(ClientSize.Width / 2 - picBall.Width / 2, ClientSize.Height / 2 - picBall.Height / 2);
            picPaddleHero.Location = new Point(picPaddleHero.Width / 2 + 10, ClientSize.Height / 2 - picPaddleHero.Height / 2);//sets it's location (centered)
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
                
                flag = false;
                count = false;
            }
            if (count == false)
            {

                //MAIN COUNTDOWN
                if (player2 == 5)
                {
                    Cursor.Show();
                    labelAI.Visible = true;
                    botwin();
                    count = true;
                    gameTime.Enabled = false;
                    timercount.Enabled = false;
                    time3.Enabled = false;
                    time2.Enabled = false;
                    time1.Enabled = false;
                    timeSTART.Enabled = false;
                    if (gameTime.Enabled == false)
                    {
                        buttonMainMenu.BringToFront();
                        buttonRestart.BringToFront();
                        buttonMainMenu.Visible = true;
                        buttonRestart.Visible = true;
                    }
                    
                }
                else
                {
                    resetBall();
                }
                
            }
        }
        private void playerMovement()
        {

            //CODE FOR HERO PADDLE, FOLLOWS MOUSE
            if (this.PointToClient(MousePosition).Y >= picPaddleHero.Height / 2 && this.PointToClient(MousePosition).Y <= ClientSize.Height - picPaddleHero.Height / 2)
            {
                int playerX = picPaddleHero.Width / 2;
                int playerY = this.PointToClient(MousePosition).Y - picPaddleHero.Height / 2;

                picPaddleHero.Location = new Point(playerX + 10, playerY); //SETS THE NEW LOCATION EVERY TIME THE TIMER TICKS
            }
        }
        private void aiMovement()
        {
            //RANDOM AI MOVEMENT DEPENDING ON RAND NUMBERS

            if (picBall.Top + 20 > picPaddleBot.Top + 50)
            {
                int a = rand2.Next(3, 6);
                picPaddleBot.Top = picPaddleBot.Top + a;              
            }
            if(picBall.Top + 20 < picPaddleBot.Top + 50)
            {
                int a = rand2.Next(3, 6);
                picPaddleBot.Top = picPaddleBot.Top - a;    
            }
        }
        private void paddlehero()
        {

            //BALL HITS PADDLE COLLISION
            SoundPlayer hit1 = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.pong_hit);
            SoundPlayer over1 = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.game_over);
            hit1.Play();
            if (ballSpeedX > 0)
            {
                ballSpeedX = 12;
                ballSpeedX = ballSpeedX * -1;
                ballSpeedY = ((picPaddleHero.Top + 50) - (picBall.Top + 11)) / -10;
            }
            else if (ballSpeedX < 0)
            {
                ballSpeedX = -12;
                ballSpeedX = ballSpeedX * -1;
                ballSpeedY = ((picPaddleHero.Top + 50) - (picBall.Top + 11)) / -10;
            }
        }
        private void paddlebot()
        {

            //BALL HITS BOT COLLISION
            SoundPlayer hit1 = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.pong_hit);
            SoundPlayer over1 = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.game_over);
            hit1.Play();
            if (ballSpeedX > 0)
            {
                ballSpeedX = 12;
                ballSpeedX = ballSpeedX * -1;
                ballSpeedY = ((picPaddleBot.Top + 50) - (picBall.Top + 11)) / -10;
            }
            else if (ballSpeedX < 0)
            {
                ballSpeedX = -12;
                ballSpeedX = ballSpeedX * -1;
                ballSpeedY = ((picPaddleBot.Top + 50) - (picBall.Top + 11)) / -10;
            }
        }
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)     //KEY DOWN EVENT
        {
            if (e.KeyCode == Keys.Escape)
            {
                if(starta == false)
                {
                    pauseEnabled = true;
                }
                else if (starta == true)
                {
                    Cursor.Show();
                    pause();
                }
            }
            if (e.KeyCode == Keys.W) { Wpressed = true; }

            if (e.KeyCode == Keys.S) { Spressed = true; }
        }
        private void pause()                //PAUSE FUNCTION
        {
           
            SoundPlayer hit1 = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.pong_hit);
            SoundPlayer over1 = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.game_over);
            Cursor.Show();
            if (pauseEnabled == false)
            {
                Cursor.Show();
                gameTime.Enabled = false;
                formPause frm = new formPause();
                Music f = new Music();
                hit1.Stop();
                over1.Stop();
                frm.ShowDialog();           //SHOWS THE PAUSE FORM
                if(frm.menuPressed == true)     //GOES TO MAIN MENU
                {
                    pauseEnabled = true;

                    this.Hide();
                    
                    gameTime.Enabled = false;
                    hit1.Stop();
                    over1.Stop();
                    Form2 forr = new Form2();
                    
                    forr.Show();
                    Cursor.Show();
                }
                if (frm.helpPressed == true)    //RETURNS TO MAIN MENU
                {
                    this.Focus();
                    pauseEnabled = true;
                    gameTime.Enabled = false;
                    resetBall();
                }
                else          //RESUME THE GAME
                {
                    this.Focus();
                    Cursor.Hide();
                    pauseEnabled = true;
                    gameTime.Enabled = true;
                    Cursor.Hide();
                }
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)     //FORM CLOSED
        {
            Application.Exit();
        }
        private void formSingMouse_KeyUp(object sender, KeyEventArgs e) //KEY UP EVENT
        {
            if (e.KeyCode == Keys.Escape) { pauseEnabled = true; }
            if (e.KeyCode == Keys.W) { Wpressed = false; }
            if (e.KeyCode == Keys.S) { Spressed = false; }
        }

        private void formSingMouse_Load(object sender, EventArgs e) //LOAD EVENT
        {
            f.s.Stop();
        }

        private void formSingMouse_MouseEnter(object sender, EventArgs e)       //HIDE MOUSE
        {
            Cursor.Hide();
        }

        private void formSingMouse_MouseLeave(object sender, EventArgs e)       //SHOW MOUSE
        {
            Cursor.Show();
        }

        private void labelHero_MouseEnter(object sender, EventArgs e)           //HIDE MOUSE
        {
            Cursor.Hide();
        }

        private void labelBot_MouseEnter(object sender, EventArgs e)        //HIDE MOUSE
        {
            Cursor.Hide();
        }

        private void timercount_Tick(object sender, EventArgs e)        //COUNTDOWN TIMER
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
            playerMovement();
            aiMovement();//Updates the ai's position
            pauseEnabled = true;
        }

        private void time3_Tick(object sender, EventArgs e)     //TIMER FOR 3..
        {
            lab3.Visible = false;
            lab2.Visible = true;
            time3.Stop();
        }
        private void time2_Tick(object sender, EventArgs e) //TIMER FOR 2...
        {
            lab2.Visible = false;
            lab1.Visible = true;
            time2.Stop();
        }

        private void time1_Tick(object sender, EventArgs e) //TIMER FOR 1...
        {
            lab1.Visible = false;
            labelstart.Visible = true;
            time1.Stop();
        }

        private void timeSTART_Tick(object sender, EventArgs e) //TIMER FOR START!
        {
            labelstart.Visible = false;
            gameTime.Enabled = true;
            timercount.Enabled = false;
            timeSTART.Stop();
        }

        private void im1_Tick(object sender, EventArgs e) //TIMER TO SHOW CURSOR
        {
            Cursor.Show();
        }

        private void labelstart_MouseEnter(object sender, EventArgs e) //HIDE CURSOR
        {
            Cursor.Hide();
        }

        private void lab1_MouseEnter(object sender, EventArgs e)  //HIDE CURSOR
        {
            Cursor.Hide();
        }

        private void lab2_MouseEnter(object sender, EventArgs e) //HIDE CURSOR
        {
            Cursor.Hide();
        }

        private void lab3_MouseEnter(object sender, EventArgs e) //HIDE CURSOR
        {
            Cursor.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //BUTTON RESTART CLICKED, AT THE END OF THE GAME
        {
            player = player - player;
            player2 = player2 - player2;
            labelHero.Text = Convert.ToString(player);
            labelBot.Text = Convert.ToString(player2);
            buttonRestart.Visible = false;
            buttonMainMenu.Visible = false;
            labelAI.Visible = false;
            resetBall();
        }

        private void button2_Click(object sender, EventArgs e) //BUTTON MAIN MENU CLICKED, AT THE END OF THE GAME
        {
            this.Hide();
            Form2 h = new Form2();
            h.Show();
        }

        private void buttonRestart_MouseEnter(object sender, EventArgs e) //SHOW CURSOR 
        {
            Cursor.Show();
        }

        private void buttonRestart_MouseHover(object sender, EventArgs e) //SHOW CURSOR
        {
            Cursor.Show();
        }
    }



    public class AutoClosingMessageBox //AUTOCLOSING MESSAGE BOX CLASS
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            MessageBox.Show(text, caption);
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow(null, _caption);
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
    class OvalPictureBox : PictureBox       //OVAL PICTURE BOX CLASS
    {
        public OvalPictureBox()
        {
            this.BackColor = Color.White;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }
    }
}
