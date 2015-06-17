namespace Pong_v3._0_Justin_Lee
{
    partial class Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelp1 = new System.Windows.Forms.Label();
            this.labelp2 = new System.Windows.Forms.Label();
            this.labelw = new System.Windows.Forms.Label();
            this.labels = new System.Windows.Forms.Label();
            this.labelp = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("LCD Solid", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(10, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(797, 48);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Multiplayer Controls!";
            // 
            // labelp1
            // 
            this.labelp1.AutoSize = true;
            this.labelp1.Font = new System.Drawing.Font("LCD Solid", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelp1.Location = new System.Drawing.Point(32, 122);
            this.labelp1.Name = "labelp1";
            this.labelp1.Size = new System.Drawing.Size(330, 21);
            this.labelp1.TabIndex = 1;
            this.labelp1.Text = "Player 1 (Left Side)";
            // 
            // labelp2
            // 
            this.labelp2.AutoSize = true;
            this.labelp2.Font = new System.Drawing.Font("LCD Solid", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelp2.Location = new System.Drawing.Point(450, 122);
            this.labelp2.Name = "labelp2";
            this.labelp2.Size = new System.Drawing.Size(346, 21);
            this.labelp2.TabIndex = 2;
            this.labelp2.Text = "Player 2 (Right Side)";
            // 
            // labelw
            // 
            this.labelw.AutoSize = true;
            this.labelw.Font = new System.Drawing.Font("LCD Solid", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelw.Location = new System.Drawing.Point(8, 206);
            this.labelw.Name = "labelw";
            this.labelw.Size = new System.Drawing.Size(282, 56);
            this.labelw.TabIndex = 3;
            this.labelw.Text = "UP = W";
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Font = new System.Drawing.Font("LCD Solid", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels.Location = new System.Drawing.Point(12, 343);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(368, 56);
            this.labels.TabIndex = 4;
            this.labels.Text = "DOWN = S";
            // 
            // labelp
            // 
            this.labelp.AutoSize = true;
            this.labelp.Font = new System.Drawing.Font("LCD Solid", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelp.Location = new System.Drawing.Point(517, 206);
            this.labelp.Name = "labelp";
            this.labelp.Size = new System.Drawing.Size(282, 56);
            this.labelp.TabIndex = 5;
            this.labelp.Text = "UP = P";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("LCD Solid", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(433, 343);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(368, 56);
            this.labelL.TabIndex = 6;
            this.labelL.Text = "DOWN = L";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("LCD Solid", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("LCD Solid", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(311, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 71);
            this.button2.TabIndex = 8;
            this.button2.Text = "OPTIONS MENU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(819, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelp);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.labelw);
            this.Controls.Add(this.labelp2);
            this.Controls.Add(this.labelp1);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Controls";
            this.Text = "Multiplayer Controls";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Controls_FormClosed);
            this.Load += new System.EventHandler(this.Controls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelp1;
        private System.Windows.Forms.Label labelp2;
        private System.Windows.Forms.Label labelw;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.Label labelp;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}