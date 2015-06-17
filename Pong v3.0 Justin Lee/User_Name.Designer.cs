namespace Pong_v3._0_Justin_Lee
{
    partial class User_Name
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Name));
            this.labelTitle = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label_Char = new System.Windows.Forms.Label();
            this.labelExist = new System.Windows.Forms.Label();
            this.labelUser_1 = new System.Windows.Forms.Label();
            this.button_Choose = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.labelUser_2 = new System.Windows.Forms.Label();
            this.button1_Choose_2 = new System.Windows.Forms.Button();
            this.button_Delete_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("LCD Solid", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(23, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(341, 71);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Please enter an username";
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("LCD Solid", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(29, 117);
            this.textUser.Multiline = true;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(335, 35);
            this.textUser.TabIndex = 1;
            this.textUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textUser_KeyDown);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Black;
            this.buttonConfirm.Font = new System.Drawing.Font("LCD Solid", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(50, 177);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(282, 51);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "CONFIRM";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Char
            // 
            this.label_Char.AutoSize = true;
            this.label_Char.Font = new System.Drawing.Font("LCD Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Char.Location = new System.Drawing.Point(25, 155);
            this.label_Char.Name = "label_Char";
            this.label_Char.Size = new System.Drawing.Size(309, 19);
            this.label_Char.TabIndex = 3;
            this.label_Char.Text = "Too Many Characters!";
            // 
            // labelExist
            // 
            this.labelExist.AutoSize = true;
            this.labelExist.Font = new System.Drawing.Font("LCD Solid", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExist.Location = new System.Drawing.Point(45, 244);
            this.labelExist.Name = "labelExist";
            this.labelExist.Size = new System.Drawing.Size(292, 26);
            this.labelExist.TabIndex = 4;
            this.labelExist.Text = "Existing Users";
            // 
            // labelUser_1
            // 
            this.labelUser_1.Font = new System.Drawing.Font("LCD Solid", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser_1.Location = new System.Drawing.Point(12, 304);
            this.labelUser_1.Name = "labelUser_1";
            this.labelUser_1.Size = new System.Drawing.Size(145, 35);
            this.labelUser_1.TabIndex = 5;
            this.labelUser_1.Text = "Empty";
            // 
            // button_Choose
            // 
            this.button_Choose.BackColor = System.Drawing.Color.Black;
            this.button_Choose.Font = new System.Drawing.Font("LCD Solid", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Choose.ForeColor = System.Drawing.Color.White;
            this.button_Choose.Location = new System.Drawing.Point(153, 293);
            this.button_Choose.Name = "button_Choose";
            this.button_Choose.Size = new System.Drawing.Size(108, 35);
            this.button_Choose.TabIndex = 6;
            this.button_Choose.Text = "Choose";
            this.button_Choose.UseVisualStyleBackColor = false;
            this.button_Choose.Click += new System.EventHandler(this.button_Choose_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Black;
            this.button_Delete.Font = new System.Drawing.Font("LCD Solid", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(267, 293);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(110, 35);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // labelUser_2
            // 
            this.labelUser_2.Font = new System.Drawing.Font("LCD Solid", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser_2.Location = new System.Drawing.Point(12, 351);
            this.labelUser_2.Name = "labelUser_2";
            this.labelUser_2.Size = new System.Drawing.Size(145, 35);
            this.labelUser_2.TabIndex = 8;
            this.labelUser_2.Text = "Empty";
            // 
            // button1_Choose_2
            // 
            this.button1_Choose_2.BackColor = System.Drawing.Color.Black;
            this.button1_Choose_2.Font = new System.Drawing.Font("LCD Solid", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Choose_2.ForeColor = System.Drawing.Color.White;
            this.button1_Choose_2.Location = new System.Drawing.Point(153, 342);
            this.button1_Choose_2.Name = "button1_Choose_2";
            this.button1_Choose_2.Size = new System.Drawing.Size(108, 35);
            this.button1_Choose_2.TabIndex = 9;
            this.button1_Choose_2.Text = "Choose";
            this.button1_Choose_2.UseVisualStyleBackColor = false;
            this.button1_Choose_2.Click += new System.EventHandler(this.button1_Choose_2_Click);
            // 
            // button_Delete_2
            // 
            this.button_Delete_2.BackColor = System.Drawing.Color.Black;
            this.button_Delete_2.Font = new System.Drawing.Font("LCD Solid", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete_2.ForeColor = System.Drawing.Color.White;
            this.button_Delete_2.Location = new System.Drawing.Point(267, 342);
            this.button_Delete_2.Name = "button_Delete_2";
            this.button_Delete_2.Size = new System.Drawing.Size(110, 35);
            this.button_Delete_2.TabIndex = 10;
            this.button_Delete_2.Text = "Delete";
            this.button_Delete_2.UseVisualStyleBackColor = false;
            this.button_Delete_2.Click += new System.EventHandler(this.button_Delete_2_Click);
            // 
            // User_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(389, 393);
            this.Controls.Add(this.button_Delete_2);
            this.Controls.Add(this.button1_Choose_2);
            this.Controls.Add(this.labelUser_2);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Choose);
            this.Controls.Add(this.labelUser_1);
            this.Controls.Add(this.labelExist);
            this.Controls.Add(this.label_Char);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "User_Name";
            this.Text = "Username";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_Name_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_Name_FormClosed);
            this.Load += new System.EventHandler(this.User_Name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label_Char;
        private System.Windows.Forms.Label labelExist;
        private System.Windows.Forms.Label labelUser_1;
        private System.Windows.Forms.Button button_Choose;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label labelUser_2;
        private System.Windows.Forms.Button button1_Choose_2;
        private System.Windows.Forms.Button button_Delete_2;
    }
}