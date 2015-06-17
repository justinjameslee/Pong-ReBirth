using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pong_v3._0_Justin_Lee.Properties;

namespace Pong_v3._0_Justin_Lee
{
    public partial class User_Name : Form
    {
        public static string username;
        public bool characters;

        public User_Name()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            label_Char.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen; //opens the form in center of the screen
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textUser.TextLength > 10)
            {
                label_Char.Visible = true;
                characters = true;
            }
            else if (textUser.TextLength <= 10)
            {
                label_Char.Visible = false;
                characters = false;
            }
            
        }

        private void User_Name_Load(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            labelUser_1.Text = Settings.Default.Setting_User;
            labelUser_2.Text = Settings.Default.Setting_User_2;
            Settings.Default.Setting_User_On = false;
            Settings.Default.Setting_User_On_2 = false;
            Settings.Default.Setting_User_On_3 = false;
            frm.user_1 = false;
            frm.user_2 = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            Form2 frm = new Form2();
            if (characters == true)
            {
                textUser.Text = "";
                characters = false;
                label_Char.Visible = false;
            }
            else if (characters == false)
            {
                if (labelUser_1.Text == "Empty")
                {
                    frm.user_1 = true;
                    frm.user_2 = false;
                    frm.not_saved = false;
                    Settings.Default.Setting_User_On = true;
                    Settings.Default.Setting_User = textUser.Text;
                    this.Hide();
                    frm.Show();
                }
                else if (labelUser_2.Text == "Empty")
                {
                    frm.user_2 = true;
                    frm.user_1 = false;
                    frm.not_saved = false;
                    Settings.Default.Setting_User_On_2 = true;
                    Settings.Default.Setting_User_2 = textUser.Text;
                    this.Hide();
                    frm.Show();
                }
                else if(textUser.Text == "")
                {
                    MessageBox.Show("You have not entered a username");
                }
                else
                {
                    result = MessageBox.Show("All Users full... this User will not be saved", "WARNING", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        textUser.Text = "";
                    }
                    if (result == DialogResult.Yes)
                    {
                        frm.not_saved = true;
                        Settings.Default.Setting_User_On_3 = true;
                        Settings.Default.Setting_User_Not = textUser.Text;
                        this.Hide();
                        frm.Show();
                    }
                }
                
            }
        }

        private void User_Name_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void User_Name_FormClosing(object sender, FormClosingEventArgs e)
        {
            labelUser_1.Text = Settings.Default.Setting_User;
            labelUser_2.Text = Settings.Default.Setting_User_2;
            Settings.Default.Setting_User_On_2 = false;
            Settings.Default.Setting_User_On = false;
            Settings.Default.Setting_User_On_3 = false;
            Settings.Default.Save();
        }

        private void textUser_KeyDown(object sender, KeyEventArgs e)
        {
            DialogResult result;
            Form2 frm = new Form2();
            if (e.KeyCode == Keys.Enter)
            {
                if(characters == false)
                {
                    if (labelUser_1.Text == "Empty")
                    {
                        frm.user_1 = true;
                        frm.user_2 = false;
                        frm.not_saved = false;
                        Settings.Default.Setting_User_On = true;
                        Settings.Default.Setting_User = textUser.Text;
                        this.Hide();
                        frm.Show();
                    }
                    else if (labelUser_2.Text == "Empty")
                    {
                        frm.user_2 = true;
                        frm.user_1 = false;
                        frm.not_saved = false;
                        Settings.Default.Setting_User_On_2 = true;
                        Settings.Default.Setting_User_2 = textUser.Text;
                        this.Hide();
                        frm.Show();
                    }
                    else if (textUser.Text == "")
                    {
                        MessageBox.Show("You have not entered a username");
                    }
                    else
                    {
                        result = MessageBox.Show("All Users full... this User will not be saved","WARNING",MessageBoxButtons.YesNo);
                        if(result == DialogResult.No)
                        {
                            textUser.Text = "";
                        }
                        if(result == DialogResult.Yes)
                        {
                            frm.not_saved = true;
                            Settings.Default.Setting_User_On_3 = true;
                            Settings.Default.Setting_User_Not = textUser.Text;
                            this.Hide();
                            frm.Show();
                        }
                        
                    }
                }
                else if (characters == true)
                {
                    e.SuppressKeyPress = true;
                }
                
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (labelUser_1.Text != "Empty")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    labelUser_1.Text = "Empty";
                    Settings.Default.Setting_User = labelUser_1.Text;
                }
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("No user to delete");
            }
        }

        private void button_Choose_Click(object sender, EventArgs e)
        {
            if(labelUser_1.Text == "Empty")
            {
                MessageBox.Show("There is no USER here!");
            }
            else
            {
                Form2 frm = new Form2();
                frm.user_1 = true;
                frm.user_2 = false;
                Settings.Default.Setting_User_On = true;
                Settings.Default.Setting_User = labelUser_1.Text;
                this.Hide();
                frm.Show();
            }
        }
        public string Label_User_1
        {
            get
            {
                return this.labelUser_1.Text;
            }
            set
            {
                this.labelUser_1.Text = value;
            }
        }
        public string Label_User_2
        {
            get
            {
                return this.labelUser_2.Text;
            }
            set
            {
                this.labelUser_2.Text = value;
            }
        }

        private void button_Delete_2_Click(object sender, EventArgs e)
        {
            if (labelUser_2.Text != "Empty")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    labelUser_2.Text = "Empty";
                    Settings.Default.Setting_User_2 = labelUser_2.Text;
                }
                else if(result == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("No user to delete");
            }
        }

        private void button1_Choose_2_Click(object sender, EventArgs e)
        {
            if (labelUser_2.Text == "Empty")
            {
                MessageBox.Show("There is no USER here!");
            }
            else
            {
                Form2 frm = new Form2();
                frm.user_2 = true;
                frm.user_1 = true;
                Settings.Default.Setting_User_On_2 = true;
                Settings.Default.Setting_User_2 = labelUser_2.Text;
                this.Hide();
                frm.Show();
            }
        }
    }
}
