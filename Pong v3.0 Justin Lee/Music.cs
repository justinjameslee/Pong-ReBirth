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
using WMPLib;

namespace Pong_v3._0_Justin_Lee
{
    public partial class Music : Form
    {
        public PictureBox testt;
        public bool introPlaying = false;
        public bool testtt;
        public WMPLib.WindowsMediaPlayer Player = null;

        public Music()
        {
            InitializeComponent();

            this.Controls.Add(testt);//adds the picture box to the form
            this.Visible = true;
            
        }

        private void Music_Load(object sender, EventArgs e)
        {
            testtt = true;
        }
        //    start();
        //}
        //private void start()
        //{
        //    Form2 f = new Form2();
        //    if (Player == null)
        //    {
        //        Player = new WMPLib.WindowsMediaPlayer();
        //    }
        //    introPlaying = !introPlaying;
        //    if (introPlaying)
        //    {
        //        Player.URL = "C:/Users/Justin/Documents/Visual Studio 2013/Projects/Pong v3.0 Justin Lee/Pong v3.0 Justin Lee/Resources/PongIntro.wav";
        //        Player.controls.play();
        //    }
        //    else
        //    {
        //        Player.controls.stop();
        //    }
                
        //}
    }
}
