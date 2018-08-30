namespace JarvisGUI
{
    partial class SciFiButton
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
            this.google = new JarvisGUI.OvalPictureBox();
            this.wiki = new JarvisGUI.OvalPictureBox();
            this.youtube = new JarvisGUI.OvalPictureBox();
            this.gtalk = new JarvisGUI.OvalPictureBox();
            this.facebook = new JarvisGUI.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.google)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            this.SuspendLayout();
            // 
            // google
            // 
            this.google.BackColor = System.Drawing.Color.DarkGreen;
            this.google.BackgroundImage = global::JarvisGUI.Properties.Resources.google_show;
            this.google.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.google.Cursor = System.Windows.Forms.Cursors.Hand;
            this.google.Location = new System.Drawing.Point(134, 15);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(80, 50);
            this.google.TabIndex = 4;
            this.google.TabStop = false;
            this.google.Click += new System.EventHandler(this.google_Click);
            this.google.MouseLeave += new System.EventHandler(this.google_MouseLeave);
            this.google.MouseHover += new System.EventHandler(this.google_MouseHover);
            // 
            // wiki
            // 
            this.wiki.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wiki.BackgroundImage = global::JarvisGUI.Properties.Resources.wikipedia_show;
            this.wiki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wiki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wiki.Location = new System.Drawing.Point(230, 30);
            this.wiki.Name = "wiki";
            this.wiki.Size = new System.Drawing.Size(45, 30);
            this.wiki.TabIndex = 3;
            this.wiki.TabStop = false;
            this.wiki.Click += new System.EventHandler(this.wiki_Click);
            this.wiki.MouseLeave += new System.EventHandler(this.wiki_MouseLeave);
            this.wiki.MouseHover += new System.EventHandler(this.wiki_MouseHover);
            // 
            // youtube
            // 
            this.youtube.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.youtube.BackgroundImage = global::JarvisGUI.Properties.Resources.y_show;
            this.youtube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.youtube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.youtube.Location = new System.Drawing.Point(78, 30);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(45, 30);
            this.youtube.TabIndex = 2;
            this.youtube.TabStop = false;
            this.youtube.Click += new System.EventHandler(this.youtube_Click);
            this.youtube.MouseLeave += new System.EventHandler(this.youtube_MouseLeave);
            this.youtube.MouseHover += new System.EventHandler(this.youtube_MouseHover);
            // 
            // gtalk
            // 
            this.gtalk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gtalk.BackgroundImage = global::JarvisGUI.Properties.Resources.g_show;
            this.gtalk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gtalk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gtalk.Location = new System.Drawing.Point(291, 30);
            this.gtalk.Name = "gtalk";
            this.gtalk.Size = new System.Drawing.Size(45, 30);
            this.gtalk.TabIndex = 1;
            this.gtalk.TabStop = false;
            this.gtalk.Click += new System.EventHandler(this.gtalk_Click);
            this.gtalk.MouseLeave += new System.EventHandler(this.gtalk_MouseLeave);
            this.gtalk.MouseHover += new System.EventHandler(this.gtalk_MouseHover);
            // 
            // facebook
            // 
            this.facebook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.facebook.BackgroundImage = global::JarvisGUI.Properties.Resources.F_show;
            this.facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebook.Location = new System.Drawing.Point(20, 30);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(45, 30);
            this.facebook.TabIndex = 0;
            this.facebook.TabStop = false;
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            this.facebook.MouseLeave += new System.EventHandler(this.facebook_MouseLeave);
            this.facebook.MouseHover += new System.EventHandler(this.facebook_MouseHover);
            // 
            // SciFiButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::JarvisGUI.Properties.Resources.unnamed__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 87);
            this.ControlBox = false;
            this.Controls.Add(this.google);
            this.Controls.Add(this.wiki);
            this.Controls.Add(this.youtube);
            this.Controls.Add(this.gtalk);
            this.Controls.Add(this.facebook);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SciFiButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SciFiButton";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            ((System.ComponentModel.ISupportInitialize)(this.google)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OvalPictureBox facebook;
        private OvalPictureBox gtalk;
        private OvalPictureBox youtube;
        private OvalPictureBox wiki;
        private OvalPictureBox google;
    }
}