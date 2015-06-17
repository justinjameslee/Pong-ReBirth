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
    public partial class HelpMenu : Form
    {
        const int SCREEN_WIDTH = 915; //WIDTH
        const int SCREEN_HEIGHT = 600; //HEIGHT

        public bool helpOpen;
        public HelpMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //PREVENTS RESIZING
            this.StartPosition = FormStartPosition.CenterScreen;//opens the form in center of the screen
            this.Width = SCREEN_WIDTH; //SETS WIDTH
            this.Height = SCREEN_HEIGHT; //SETS HEIGHT
        }

        private void button3_Click(object sender, EventArgs e)  //RETURN TO MAINMENU
        {
            helpOpen = true;
            this.Close();
        }

        private void HelpMenu_FormClosed(object sender, FormClosedEventArgs e) //FORM CLOSED
        {
            this.Hide();
            Music f = new Music();
            Form2 form2 = new Form2();
            
            form2.Show();
        }

        private void butMulti_Click(object sender, EventArgs e)  //MULTIPLAYER CONTROLS CLICKED
        {
            this.Hide();
            Controls multic = new Controls();
            multic.Show();
        }

        private void button1_Click(object sender, EventArgs e)  //SINGLE PLAYER CONTROLS CLICKED
        {
            this.Hide();
            SinglePlayerControls sing = new SinglePlayerControls();
            sing.Show();
        }

        private void button4_Click(object sender, EventArgs e)  //CREDITS CLICKED
        {
            CreditsReal cred = new CreditsReal();
            cred.ShowDialog();
        }
    }
}
