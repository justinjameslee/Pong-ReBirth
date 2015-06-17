namespace Pong_v3._0_Justin_Lee
{
    partial class HelpMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.butMulti = new System.Windows.Forms.Button();
            this.butMain = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LCD Solid", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPTIONS  MENU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("LCD Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(102, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(523, 122);
            this.button1.TabIndex = 1;
            this.button1.Text = "Single Player Controls";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butMulti
            // 
            this.butMulti.BackColor = System.Drawing.Color.Black;
            this.butMulti.Font = new System.Drawing.Font("LCD Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMulti.ForeColor = System.Drawing.Color.White;
            this.butMulti.Location = new System.Drawing.Point(694, 372);
            this.butMulti.Name = "butMulti";
            this.butMulti.Size = new System.Drawing.Size(523, 122);
            this.butMulti.TabIndex = 2;
            this.butMulti.Text = "Multi Player Controls";
            this.butMulti.UseVisualStyleBackColor = false;
            this.butMulti.Click += new System.EventHandler(this.butMulti_Click);
            // 
            // butMain
            // 
            this.butMain.BackColor = System.Drawing.Color.Black;
            this.butMain.Font = new System.Drawing.Font("LCD Solid", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMain.ForeColor = System.Drawing.Color.White;
            this.butMain.Location = new System.Drawing.Point(694, 589);
            this.butMain.Name = "butMain";
            this.butMain.Size = new System.Drawing.Size(523, 133);
            this.butMain.TabIndex = 3;
            this.butMain.Text = "MAIN MENU";
            this.butMain.UseVisualStyleBackColor = false;
            this.butMain.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("LCD Solid", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(102, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(523, 137);
            this.button4.TabIndex = 4;
            this.button4.Text = "Credits";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("LCD Solid", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(665, 64);
            this.label2.TabIndex = 5;
            this.label2.Text = "PONG  ReBirth";
            // 
            // HelpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1365, 727);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.butMain);
            this.Controls.Add(this.butMulti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelpMenu";
            this.Text = "Options Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelpMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butMain;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butMulti;
    }
}