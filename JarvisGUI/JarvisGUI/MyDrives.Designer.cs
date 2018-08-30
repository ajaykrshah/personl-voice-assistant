namespace JarvisGUI
{
    partial class MyDrives
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Drive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeSpace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProgressBar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Drive,
            this.FreeSpace,
            this.ProgressBar,
            this.GB});
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(4, 12);
            this.listView1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 118);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // Drive
            // 
            this.Drive.Text = "";
            this.Drive.Width = 40;
            // 
            // FreeSpace
            // 
            this.FreeSpace.DisplayIndex = 2;
            this.FreeSpace.Text = "";
            // 
            // ProgressBar
            // 
            this.ProgressBar.DisplayIndex = 1;
            this.ProgressBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProgressBar.Width = 120;
            // 
            // GB
            // 
            this.GB.Text = "";
            this.GB.Width = 40;
            // 
            // MyDrives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 130);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "MyDrives";
            this.Opacity = 0.05D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyDrives";
            this.Load += new System.EventHandler(this.MyDrives_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Drive;
        private System.Windows.Forms.ColumnHeader FreeSpace;
        private System.Windows.Forms.ColumnHeader GB;
        private System.Windows.Forms.ColumnHeader ProgressBar;
    }
}