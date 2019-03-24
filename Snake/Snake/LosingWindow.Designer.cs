namespace Snake
{
    partial class LosingWindow
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
            this.header = new System.Windows.Forms.PictureBox();
            this.ok = new System.Windows.Forms.PictureBox();
            this.lostPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lostPb)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Image = global::Snake.Properties.Resources.header600x50;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(600, 50);
            this.header.TabIndex = 0;
            this.header.TabStop = false;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // ok
            // 
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.Image = global::Snake.Properties.Resources.ok;
            this.ok.Location = new System.Drawing.Point(225, 240);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(150, 50);
            this.ok.TabIndex = 2;
            this.ok.TabStop = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            this.ok.MouseEnter += new System.EventHandler(this.ok_MouseEnter);
            this.ok.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            // 
            // lostPb
            // 
            this.lostPb.Image = global::Snake.Properties.Resources.lost;
            this.lostPb.Location = new System.Drawing.Point(50, 70);
            this.lostPb.Name = "lostPb";
            this.lostPb.Size = new System.Drawing.Size(500, 150);
            this.lostPb.TabIndex = 3;
            this.lostPb.TabStop = false;
            // 
            // LosingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.lostPb);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LosingWindow";
            this.Text = "Snake - Losing Window";
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lostPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox ok;
        private System.Windows.Forms.PictureBox lostPb;
    }
}