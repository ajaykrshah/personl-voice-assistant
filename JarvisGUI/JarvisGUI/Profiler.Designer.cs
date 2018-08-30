namespace JarvisGUI
{
    partial class Profiler
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.avtar = new JarvisGUI.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avtar)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // avtar
            // 
            this.avtar.BackColor = System.Drawing.Color.DarkGray;
            this.avtar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avtar.Location = new System.Drawing.Point(69, 12);
            this.avtar.Name = "avtar";
            this.avtar.Size = new System.Drawing.Size(152, 226);
            this.avtar.TabIndex = 0;
            this.avtar.TabStop = false;
            this.avtar.Click += new System.EventHandler(this.avatar_Click);
            this.avtar.MouseLeave += new System.EventHandler(this.avtar_MouseLeave);
            this.avtar.MouseHover += new System.EventHandler(this.avtar_MouseHover);
            // 
            // Profiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JarvisGUI.Properties.Resources.profiler_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 250);
            this.Controls.Add(this.avtar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profiler";
            this.Opacity = 0.05D;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.Profiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private OvalPictureBox avtar;
    }
}