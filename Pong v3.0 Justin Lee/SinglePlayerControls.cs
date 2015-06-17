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
    public partial class SinglePlayerControls : Form
    {
        public SinglePlayerControls()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;//opens the form in center of the screen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mouseHard frm = new mouseHard();
            frm.Show();
        }

        private void SinglePlayerControls_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HelpMenu help = new HelpMenu();
            help.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpMenu help = new HelpMenu();
            help.Show();
        }
    }
}
