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
    public partial class playerDiff : Form
    {
        const int SCREEN_WIDTH = 915;
        const int SCREEN_HEIGHT = 600;

        public playerDiff()
        {
            InitializeComponent();
            this.Width = SCREEN_WIDTH;
            this.Height = SCREEN_HEIGHT;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;//opens the form in center of the screen
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void playerDiff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Music f = new Music();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Music f = new Music();
            mouseHard frm = new mouseHard();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MouseEasy frm = new MouseEasy();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinglePlayerNormal frm = new SinglePlayerNormal();
            frm.Show();
        }
    }
}
