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
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;//opens the form in center of the screen
        }

        private void Controls_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multiplayer multi = new Multiplayer();
            multi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Controls_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HelpMenu help = new HelpMenu();
            help.Show();
        }
    }
}
