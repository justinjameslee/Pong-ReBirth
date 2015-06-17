namespace Pong_v3._0_Justin_Lee
{
    partial class SinglePlayerControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinglePlayerControls));
            this.labelControls = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMouse = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControls
            // 
            this.labelControls.Font = new System.Drawing.Font("LCD Solid", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControls.Location = new System.Drawing.Point(114, 29);
            this.labelControls.Name = "labelControls";
            this.labelControls.Size = new System.Drawing.Size(1124, 112);
            this.labelControls.TabIndex = 0;
            this.labelControls.Text = "Singleplayer Controls";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("LCD Solid", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(398, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(485, 171);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMouse
            // 
            this.labelMouse.Font = new System.Drawing.Font("LCD Solid", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMouse.Location = new System.Drawing.Point(391, 141);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(660, 72);
            this.labelMouse.TabIndex = 2;
            this.labelMouse.Text = "Move with Mouse";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 235);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("LCD Solid", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(941, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 238);
            this.button3.TabIndex = 7;
            this.button3.Text = "OPTIONS MENU";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SinglePlayerControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 509);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMouse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SinglePlayerControls";
            this.Text = "Singleplayer Controls";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SinglePlayerControls_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelControls;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMouse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}