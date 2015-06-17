namespace Pong_v3._0_Justin_Lee
{
    partial class Music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.WMPIntro = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMPIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // WMPIntro
            // 
            this.WMPIntro.Enabled = true;
            this.WMPIntro.Location = new System.Drawing.Point(719, 387);
            this.WMPIntro.Name = "WMPIntro";
            this.WMPIntro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPIntro.OcxState")));
            this.WMPIntro.Size = new System.Drawing.Size(75, 49);
            this.WMPIntro.TabIndex = 0;
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 448);
            this.Controls.Add(this.WMPIntro);
            this.Name = "Music";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Music_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMPIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMPIntro;
        private OvalPictureBox test;
    }
}