namespace Pong_v3._0_Justin_Lee
{
    partial class formPause
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPause));
            this.butCont = new System.Windows.Forms.Button();
            this.butMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCont
            // 
            this.butCont.BackColor = System.Drawing.Color.Black;
            this.butCont.Font = new System.Drawing.Font("LCD Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCont.ForeColor = System.Drawing.Color.White;
            this.butCont.Location = new System.Drawing.Point(38, 91);
            this.butCont.Name = "butCont";
            this.butCont.Size = new System.Drawing.Size(378, 95);
            this.butCont.TabIndex = 0;
            this.butCont.Text = "Resume";
            this.butCont.UseVisualStyleBackColor = false;
            this.butCont.Click += new System.EventHandler(this.butCont_Click);
            this.butCont.MouseEnter += new System.EventHandler(this.butCont_MouseEnter);
            // 
            // butMenu
            // 
            this.butMenu.BackColor = System.Drawing.Color.Black;
            this.butMenu.Font = new System.Drawing.Font("LCD Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenu.ForeColor = System.Drawing.Color.White;
            this.butMenu.Location = new System.Drawing.Point(38, 348);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(378, 109);
            this.butMenu.TabIndex = 1;
            this.butMenu.Text = "Main Menu";
            this.butMenu.UseVisualStyleBackColor = false;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LCD Solid", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "PAUSED";
            // 
            // butHelp
            // 
            this.butHelp.BackColor = System.Drawing.Color.Black;
            this.butHelp.Font = new System.Drawing.Font("LCD Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHelp.ForeColor = System.Drawing.Color.White;
            this.butHelp.Location = new System.Drawing.Point(38, 215);
            this.butHelp.Name = "butHelp";
            this.butHelp.Size = new System.Drawing.Size(378, 105);
            this.butHelp.TabIndex = 4;
            this.butHelp.Text = "Reset Ball";
            this.butHelp.UseVisualStyleBackColor = false;
            this.butHelp.Click += new System.EventHandler(this.butHelp_Click);
            // 
            // formPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(457, 491);
            this.Controls.Add(this.butHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butMenu);
            this.Controls.Add(this.butCont);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPause";
            this.Text = "PAUSE MENU";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formPause_Load);
            this.MouseEnter += new System.EventHandler(this.formPause_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butCont;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butHelp;
    }
}