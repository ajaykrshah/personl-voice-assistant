namespace JarvisGUI
{
    partial class DownBorder
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
            this.shutdown = new System.Windows.Forms.Label();
            this.Lock = new System.Windows.Forms.Label();
            this.logOff = new System.Windows.Forms.Label();
            this.Sleep = new System.Windows.Forms.Label();
            this.Hibernate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shutdown
            // 
            this.shutdown.AutoSize = true;
            this.shutdown.BackColor = System.Drawing.Color.DodgerBlue;
            this.shutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdown.Location = new System.Drawing.Point(367, 61);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(55, 13);
            this.shutdown.TabIndex = 0;
            this.shutdown.Text = "Shutdown";
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            this.shutdown.MouseLeave += new System.EventHandler(this.shutdown_MouseLeave);
            this.shutdown.MouseHover += new System.EventHandler(this.shutdown_MouseHover);
            // 
            // Lock
            // 
            this.Lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lock.Location = new System.Drawing.Point(145, 62);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(55, 14);
            this.Lock.TabIndex = 1;
            this.Lock.Text = "Lock PC";
            this.Lock.Click += new System.EventHandler(this.Lock_Click);
            this.Lock.MouseLeave += new System.EventHandler(this.Lock_MouseLeave);
            this.Lock.MouseHover += new System.EventHandler(this.Lock_MouseHover);
            // 
            // logOff
            // 
            this.logOff.AutoSize = true;
            this.logOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOff.Location = new System.Drawing.Point(253, 62);
            this.logOff.Name = "logOff";
            this.logOff.Size = new System.Drawing.Size(49, 13);
            this.logOff.TabIndex = 2;
            this.logOff.Text = "Log Off";
            this.logOff.Click += new System.EventHandler(this.logOff_Click);
            this.logOff.MouseLeave += new System.EventHandler(this.logOff_MouseLeave);
            this.logOff.MouseHover += new System.EventHandler(this.logOff_MouseHover);
            // 
            // Sleep
            // 
            this.Sleep.AutoSize = true;
            this.Sleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sleep.Location = new System.Drawing.Point(491, 62);
            this.Sleep.Name = "Sleep";
            this.Sleep.Size = new System.Drawing.Size(39, 13);
            this.Sleep.TabIndex = 3;
            this.Sleep.Text = "Sleep";
            this.Sleep.Click += new System.EventHandler(this.Sleep_Click);
            this.Sleep.MouseLeave += new System.EventHandler(this.Sleep_MouseLeave);
            this.Sleep.MouseHover += new System.EventHandler(this.Sleep_MouseHover);
            // 
            // Hibernate
            // 
            this.Hibernate.AutoSize = true;
            this.Hibernate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hibernate.Location = new System.Drawing.Point(594, 62);
            this.Hibernate.Name = "Hibernate";
            this.Hibernate.Size = new System.Drawing.Size(62, 13);
            this.Hibernate.TabIndex = 4;
            this.Hibernate.Text = "Hibernate";
            this.Hibernate.Click += new System.EventHandler(this.Hibernate_Click);
            this.Hibernate.MouseLeave += new System.EventHandler(this.Hibernate_MouseLeave);
            this.Hibernate.MouseHover += new System.EventHandler(this.Hibernate_MouseHover);
            // 
            // DownBorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::JarvisGUI.Properties.Resources.player;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(803, 136);
            this.ControlBox = false;
            this.Controls.Add(this.Hibernate);
            this.Controls.Add(this.Sleep);
            this.Controls.Add(this.logOff);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.shutdown);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DownBorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.DownBorder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shutdown;
        private System.Windows.Forms.Label Lock;
        private System.Windows.Forms.Label logOff;
        private System.Windows.Forms.Label Sleep;
        private System.Windows.Forms.Label Hibernate;
    }
}