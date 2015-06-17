namespace Pong_v3._0_Justin_Lee
{
    partial class MouseEasy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseEasy));
            this.picPaddleBot = new System.Windows.Forms.PictureBox();
            this.picPaddleHero = new System.Windows.Forms.PictureBox();
            this.labelBot = new System.Windows.Forms.Label();
            this.labelHero = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.picBall = new Pong_v3._0_Justin_Lee.OvalPictureBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.labelstart = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Timer(this.components);
            this.time2 = new System.Windows.Forms.Timer(this.components);
            this.time1 = new System.Windows.Forms.Timer(this.components);
            this.timeSTART = new System.Windows.Forms.Timer(this.components);
            this.timercount = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddleBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddleHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // picPaddleBot
            // 
            this.picPaddleBot.BackColor = System.Drawing.Color.White;
            this.picPaddleBot.Location = new System.Drawing.Point(1248, 373);
            this.picPaddleBot.Name = "picPaddleBot";
            this.picPaddleBot.Size = new System.Drawing.Size(20, 100);
            this.picPaddleBot.TabIndex = 1;
            this.picPaddleBot.TabStop = false;
            // 
            // picPaddleHero
            // 
            this.picPaddleHero.BackColor = System.Drawing.Color.White;
            this.picPaddleHero.Location = new System.Drawing.Point(76, 202);
            this.picPaddleHero.Name = "picPaddleHero";
            this.picPaddleHero.Size = new System.Drawing.Size(20, 100);
            this.picPaddleHero.TabIndex = 3;
            this.picPaddleHero.TabStop = false;
            // 
            // labelBot
            // 
            this.labelBot.Font = new System.Drawing.Font("LCD Solid", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBot.ForeColor = System.Drawing.Color.White;
            this.labelBot.Location = new System.Drawing.Point(695, 22);
            this.labelBot.Name = "labelBot";
            this.labelBot.Size = new System.Drawing.Size(153, 85);
            this.labelBot.TabIndex = 29;
            this.labelBot.Text = "0";
            this.labelBot.MouseEnter += new System.EventHandler(this.labelBot_MouseEnter);
            // 
            // labelHero
            // 
            this.labelHero.Font = new System.Drawing.Font("LCD Solid", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHero.ForeColor = System.Drawing.Color.White;
            this.labelHero.Location = new System.Drawing.Point(540, 22);
            this.labelHero.Name = "labelHero";
            this.labelHero.Size = new System.Drawing.Size(127, 85);
            this.labelHero.TabIndex = 30;
            this.labelHero.Text = "0";
            this.labelHero.MouseEnter += new System.EventHandler(this.labelHero_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(652, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 38);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // picRight
            // 
            this.picRight.BackColor = System.Drawing.Color.White;
            this.picRight.Location = new System.Drawing.Point(1317, -5);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(27, 892);
            this.picRight.TabIndex = 45;
            this.picRight.TabStop = false;
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.Color.White;
            this.picTop.Location = new System.Drawing.Point(-1, -5);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(1409, 18);
            this.picTop.TabIndex = 46;
            this.picTop.TabStop = false;
            // 
            // picLeft
            // 
            this.picLeft.BackColor = System.Drawing.Color.White;
            this.picLeft.Location = new System.Drawing.Point(-2, -33);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(26, 952);
            this.picLeft.TabIndex = 47;
            this.picLeft.TabStop = false;
            // 
            // picDown
            // 
            this.picDown.BackColor = System.Drawing.Color.White;
            this.picDown.Location = new System.Drawing.Point(-1, 856);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(1430, 28);
            this.picDown.TabIndex = 48;
            this.picDown.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.White;
            this.pictureBox27.Location = new System.Drawing.Point(652, 812);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(15, 38);
            this.pictureBox27.TabIndex = 69;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.White;
            this.pictureBox28.Location = new System.Drawing.Point(652, 744);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(15, 38);
            this.pictureBox28.TabIndex = 70;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.White;
            this.pictureBox29.Location = new System.Drawing.Point(652, 663);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(15, 38);
            this.pictureBox29.TabIndex = 71;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.White;
            this.pictureBox30.Location = new System.Drawing.Point(652, 578);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(15, 38);
            this.pictureBox30.TabIndex = 72;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.White;
            this.pictureBox31.Location = new System.Drawing.Point(652, 494);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(15, 38);
            this.pictureBox31.TabIndex = 73;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.White;
            this.pictureBox32.Location = new System.Drawing.Point(652, 411);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(15, 38);
            this.pictureBox32.TabIndex = 74;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.White;
            this.pictureBox33.Location = new System.Drawing.Point(652, 327);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(15, 38);
            this.pictureBox33.TabIndex = 75;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.White;
            this.pictureBox34.Location = new System.Drawing.Point(652, 243);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(15, 38);
            this.pictureBox34.TabIndex = 76;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.White;
            this.pictureBox35.Location = new System.Drawing.Point(652, 166);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(15, 38);
            this.pictureBox35.TabIndex = 77;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackColor = System.Drawing.Color.White;
            this.pictureBox36.Location = new System.Drawing.Point(652, 94);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(15, 38);
            this.pictureBox36.TabIndex = 78;
            this.pictureBox36.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.Location = new System.Drawing.Point(832, 166);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(131, 103);
            this.picBall.TabIndex = 79;
            this.picBall.TabStop = false;
            // 
            // lab1
            // 
            this.lab1.Font = new System.Drawing.Font("LCD Solid", 95F);
            this.lab1.ForeColor = System.Drawing.Color.White;
            this.lab1.Location = new System.Drawing.Point(288, 177);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(134, 157);
            this.lab1.TabIndex = 82;
            this.lab1.Text = "1";
            // 
            // lab2
            // 
            this.lab2.Font = new System.Drawing.Font("LCD Solid", 95F);
            this.lab2.ForeColor = System.Drawing.Color.White;
            this.lab2.Location = new System.Drawing.Point(288, 179);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(147, 155);
            this.lab2.TabIndex = 81;
            this.lab2.Text = "2";
            // 
            // lab3
            // 
            this.lab3.Font = new System.Drawing.Font("LCD Solid", 95F);
            this.lab3.ForeColor = System.Drawing.Color.White;
            this.lab3.Location = new System.Drawing.Point(280, 179);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(155, 155);
            this.lab3.TabIndex = 80;
            this.lab3.Text = "3";
            // 
            // labelstart
            // 
            this.labelstart.Font = new System.Drawing.Font("LCD Solid", 75F);
            this.labelstart.ForeColor = System.Drawing.Color.Transparent;
            this.labelstart.Location = new System.Drawing.Point(113, 125);
            this.labelstart.Name = "labelstart";
            this.labelstart.Size = new System.Drawing.Size(605, 144);
            this.labelstart.TabIndex = 83;
            this.labelstart.Text = "START!";
            // 
            // time3
            // 
            this.time3.Tick += new System.EventHandler(this.time3_Tick);
            // 
            // time2
            // 
            this.time2.Tick += new System.EventHandler(this.time2_Tick);
            // 
            // time1
            // 
            this.time1.Tick += new System.EventHandler(this.time1_Tick);
            // 
            // timeSTART
            // 
            this.timeSTART.Tick += new System.EventHandler(this.timeSTART_Tick);
            // 
            // timercount
            // 
            this.timercount.Tick += new System.EventHandler(this.timercount_Tick);
            // 
            // MouseEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1327, 866);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.labelstart);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.picDown);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHero);
            this.Controls.Add(this.labelBot);
            this.Controls.Add(this.picPaddleHero);
            this.Controls.Add(this.picPaddleBot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MouseEasy";
            this.Text = "Singleplayer - Mouse        Difficulty: Easy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.MouseEasy_Load);
            this.MouseEnter += new System.EventHandler(this.formSingMouse_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.formSingMouse_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddleBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddleHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaddleBot;
        private System.Windows.Forms.PictureBox picPaddleHero;
        private System.Windows.Forms.Label labelBot;
        private System.Windows.Forms.Label labelHero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox pictureBox36;
        private OvalPictureBox picBall;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label labelstart;
        private System.Windows.Forms.Timer time3;
        private System.Windows.Forms.Timer time2;
        private System.Windows.Forms.Timer time1;
        private System.Windows.Forms.Timer timeSTART;
        private System.Windows.Forms.Timer timercount;
    }
}