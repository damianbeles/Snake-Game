namespace Snake
{
    partial class StartupWindow
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
            this.settings = new System.Windows.Forms.PictureBox();
            this.create = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.Image = global::Snake.Properties.Resources.settings;
            this.settings.Location = new System.Drawing.Point(730, 520);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(30, 30);
            this.settings.TabIndex = 5;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // create
            // 
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.Image = global::Snake.Properties.Resources.create;
            this.create.Location = new System.Drawing.Point(315, 320);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(150, 50);
            this.create.TabIndex = 4;
            this.create.TabStop = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            this.create.MouseEnter += new System.EventHandler(this.create_MouseEnter);
            this.create.MouseLeave += new System.EventHandler(this.create_MouseLeave);
            // 
            // play
            // 
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Image = global::Snake.Properties.Resources.play;
            this.play.Location = new System.Drawing.Point(315, 200);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(150, 50);
            this.play.TabIndex = 3;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            this.play.MouseEnter += new System.EventHandler(this.play_MouseEnter);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = global::Snake.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(710, 15);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(20, 20);
            this.minimize.TabIndex = 2;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::Snake.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(745, 15);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // header
            // 
            this.header.Image = global::Snake.Properties.Resources.header;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(780, 50);
            this.header.TabIndex = 0;
            this.header.TabStop = false;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // StartupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(780, 570);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.create);
            this.Controls.Add(this.play);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "StartupWindow";
            this.Text = "Snake - Startup Window";
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox create;
        private System.Windows.Forms.PictureBox settings;
    }
}

