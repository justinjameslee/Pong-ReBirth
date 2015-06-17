using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_v3._0_Justin_Lee
{

    public partial class formPause : Form
    {
        public bool menuPressed;
        public bool helpPressed;
        const int Screen_Width = 446;
        const int H = 404;

        Form2 m = new Form2();

        public formPause()
        {
            this.Width = Screen_Width;
            this.Height = H;
            InitializeComponent();
            this.BackColor = Color.FromArgb(64, 64, 64);
            this.Opacity = 0.7;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            
        }
        private void butCont_Click(object sender, EventArgs e)
        {
            mouseHard frm = new mouseHard();
            frm.pausepause = true;
            this.Close();
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            menuPressed = true;
            this.DialogResult = DialogResult.Cancel;
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            helpPressed = true;
            this.Close();
        }

        private void formPause_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void formPause_Load(object sender, EventArgs e)
        {
            this.Location = new Point(680, 200);
        }

        private void butCont_MouseEnter(object sender, EventArgs e)
        {
            //m.Player.URL = "C:/Users/Justin/Documents/Visual Studio 2013/Projects/Pong v3.0 Justin Lee/Pong v3.0 Justin Lee/Resources/mouseover.wav";
            //m.Player.controls.play();
        }
        
    }
}
