using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using Pong_v3._0_Justin_Lee.Properties;

namespace Pong_v3._0_Justin_Lee
{
    public partial class Form2 : Form
    {
        const int SCREEN_WIDTH = 915; //WIDTH
        const int SCREEN_HEIGHT = 600; //HEIGHT

        public SoundPlayer s = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.PongIntro); //INTRO MUSIC
        SoundPlayer m = new SoundPlayer(Pong_v3._0_Justin_Lee.Properties.Resources.mouseover); //HOVER OVER BUTTON
        public WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer(); //HOVER OVER BUTTON MUSIC
        public bool IntroPlaying;

        public bool user_1;
        public bool user_2;
        public bool not_saved;

        public Form2()
        {
            InitializeComponent();
            this.Width = SCREEN_WIDTH; //WIDTH
            this.Height = SCREEN_HEIGHT; //HEIGHT
            this.StartPosition = FormStartPosition.CenterScreen; //opens the form in center of the screen
            s.PlayLooping(); //LOOPS INTRO MUSIC
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            User_Name frm = new User_Name(); //USERNAME
            if((user_1 == true) || (Settings.Default.Setting_User_On == true))
            {
                label_username.Text = "Welcome: " + Settings.Default.Setting_User;
            }
            if ((user_2 == true) || (Settings.Default.Setting_User_On_2 == true))
            {
                label_username.Text = "Welcome: " + Settings.Default.Setting_User_2;
            }
            if((not_saved == true) || (Settings.Default.Setting_User_On_3 == true))
            {
                label_username.Text = "Welcome: " + Settings.Default.Setting_User_Not;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            playerDiff single = new playerDiff(); //NEW SINGLEPLAYER
            single.Show(); //SHOW DIFFICULTYS FOR SINGLEPLAYER
            this.Hide(); //HIDES THIS FORM
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //HIDES THIS FORM
            Controls multic = new Controls(); 
            multic.Show(); //SHOWS MULTIPLAYER
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //CLOSES FORM
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); //CLOSE FORM
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //HIDES FORM
            HelpMenu help = new HelpMenu();
            help.ShowDialog(); //SHOW OPTIONS
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Player.URL = "C:/Users/Justin/Documents/Visual Studio 2013/Projects/Pong v3.0 Justin Lee/Pong v3.0 Justin Lee/Resources/mouseover.wav";
            Player.controls.play(); //HOVER OVER BUTTON MUSIC
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Player.URL = "C:/Users/Justin/Documents/Visual Studio 2013/Projects/Pong v3.0 Justin Lee/Pong v3.0 Justin Lee/Resources/mouseover.wav";
            Player.controls.play();//HOVER OVER BUTTON MUSIC
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            Player.URL = "C:/Users/Justin/Documents/Visual Studio 2013/Projects/Pong v3.0 Justin Lee/Pong v3.0 Justin Lee/Resources/mouseover.wav";
            Player.controls.play();//HOVER OVER BUTTON MUSIC
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Player.URL = "C:/Users/Justin/Documents/Visual Studio 2013/Projects/Pong v3.0 Justin Lee/Pong v3.0 Justin Lee/Resources/mouseover.wav";
            Player.controls.play();//HOVER OVER BUTTON MUSIC
        }
    }
}
