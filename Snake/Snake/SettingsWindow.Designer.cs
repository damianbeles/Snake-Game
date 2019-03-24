namespace Snake
{
    partial class SettingsWindow
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
            this.boardColorLabel = new System.Windows.Forms.PictureBox();
            this.wallColorLabel = new System.Windows.Forms.PictureBox();
            this.foodColorLabel = new System.Windows.Forms.PictureBox();
            this.bodyColorLabel = new System.Windows.Forms.PictureBox();
            this.headColorLabel = new System.Windows.Forms.PictureBox();
            this.bodyColorPb = new System.Windows.Forms.PictureBox();
            this.foodColorPb = new System.Windows.Forms.PictureBox();
            this.wallColorPb = new System.Windows.Forms.PictureBox();
            this.boardColorPb = new System.Windows.Forms.PictureBox();
            this.headColorPb = new System.Windows.Forms.PictureBox();
            this.sounds = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boardColorLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallColorLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodColorLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyColorLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headColorLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyColorPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodColorPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallColorPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardColorPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headColorPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            this.SuspendLayout();
            // 
            // boardColorLabel
            // 
            this.boardColorLabel.Image = global::Snake.Properties.Resources.boardcolor;
            this.boardColorLabel.Location = new System.Drawing.Point(130, 220);
            this.boardColorLabel.Name = "boardColorLabel";
            this.boardColorLabel.Size = new System.Drawing.Size(60, 15);
            this.boardColorLabel.TabIndex = 12;
            this.boardColorLabel.TabStop = false;
            // 
            // wallColorLabel
            // 
            this.wallColorLabel.Image = global::Snake.Properties.Resources.wallcolor;
            this.wallColorLabel.Location = new System.Drawing.Point(130, 190);
            this.wallColorLabel.Name = "wallColorLabel";
            this.wallColorLabel.Size = new System.Drawing.Size(60, 15);
            this.wallColorLabel.TabIndex = 11;
            this.wallColorLabel.TabStop = false;
            // 
            // foodColorLabel
            // 
            this.foodColorLabel.Image = global::Snake.Properties.Resources.foodcolor;
            this.foodColorLabel.Location = new System.Drawing.Point(130, 160);
            this.foodColorLabel.Name = "foodColorLabel";
            this.foodColorLabel.Size = new System.Drawing.Size(60, 15);
            this.foodColorLabel.TabIndex = 10;
            this.foodColorLabel.TabStop = false;
            // 
            // bodyColorLabel
            // 
            this.bodyColorLabel.Image = global::Snake.Properties.Resources.snakebodycolor;
            this.bodyColorLabel.Location = new System.Drawing.Point(130, 130);
            this.bodyColorLabel.Name = "bodyColorLabel";
            this.bodyColorLabel.Size = new System.Drawing.Size(60, 15);
            this.bodyColorLabel.TabIndex = 9;
            this.bodyColorLabel.TabStop = false;
            // 
            // headColorLabel
            // 
            this.headColorLabel.Image = global::Snake.Properties.Resources.snakeheadcolor;
            this.headColorLabel.Location = new System.Drawing.Point(130, 100);
            this.headColorLabel.Name = "headColorLabel";
            this.headColorLabel.Size = new System.Drawing.Size(60, 15);
            this.headColorLabel.TabIndex = 8;
            this.headColorLabel.TabStop = false;
            // 
            // bodyColorPb
            // 
            this.bodyColorPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyColorPb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bodyColorPb.Location = new System.Drawing.Point(110, 130);
            this.bodyColorPb.Name = "bodyColorPb";
            this.bodyColorPb.Size = new System.Drawing.Size(15, 15);
            this.bodyColorPb.TabIndex = 7;
            this.bodyColorPb.TabStop = false;
            this.bodyColorPb.Click += new System.EventHandler(this.bodyColorPb_Click);
            // 
            // foodColorPb
            // 
            this.foodColorPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodColorPb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodColorPb.Location = new System.Drawing.Point(110, 160);
            this.foodColorPb.Name = "foodColorPb";
            this.foodColorPb.Size = new System.Drawing.Size(15, 15);
            this.foodColorPb.TabIndex = 6;
            this.foodColorPb.TabStop = false;
            this.foodColorPb.Click += new System.EventHandler(this.foodColorPb_Click);
            // 
            // wallColorPb
            // 
            this.wallColorPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wallColorPb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wallColorPb.Location = new System.Drawing.Point(110, 190);
            this.wallColorPb.Name = "wallColorPb";
            this.wallColorPb.Size = new System.Drawing.Size(15, 15);
            this.wallColorPb.TabIndex = 5;
            this.wallColorPb.TabStop = false;
            this.wallColorPb.Click += new System.EventHandler(this.wallColorPb_Click);
            // 
            // boardColorPb
            // 
            this.boardColorPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boardColorPb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boardColorPb.Location = new System.Drawing.Point(110, 220);
            this.boardColorPb.Name = "boardColorPb";
            this.boardColorPb.Size = new System.Drawing.Size(15, 15);
            this.boardColorPb.TabIndex = 4;
            this.boardColorPb.TabStop = false;
            this.boardColorPb.Click += new System.EventHandler(this.boardColorPb_Click);
            // 
            // headColorPb
            // 
            this.headColorPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headColorPb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headColorPb.Location = new System.Drawing.Point(110, 100);
            this.headColorPb.Name = "headColorPb";
            this.headColorPb.Size = new System.Drawing.Size(15, 15);
            this.headColorPb.TabIndex = 3;
            this.headColorPb.TabStop = false;
            this.headColorPb.Click += new System.EventHandler(this.headColorPb_Click);
            // 
            // sounds
            // 
            this.sounds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sounds.Image = global::Snake.Properties.Resources.soundson;
            this.sounds.Location = new System.Drawing.Point(135, 280);
            this.sounds.Name = "sounds";
            this.sounds.Size = new System.Drawing.Size(30, 30);
            this.sounds.TabIndex = 2;
            this.sounds.TabStop = false;
            this.sounds.Click += new System.EventHandler(this.sounds_Click);
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Image = global::Snake.Properties.Resources.save;
            this.save.Location = new System.Drawing.Point(75, 330);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(150, 50);
            this.save.TabIndex = 1;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.MouseEnter += new System.EventHandler(this.save_MouseEnter);
            this.save.MouseLeave += new System.EventHandler(this.save_MouseLeave);
            // 
            // header
            // 
            this.header.Image = global::Snake.Properties.Resources.header300x50;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(300, 50);
            this.header.TabIndex = 0;
            this.header.TabStop = false;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.boardColorLabel);
            this.Controls.Add(this.wallColorLabel);
            this.Controls.Add(this.foodColorLabel);
            this.Controls.Add(this.bodyColorLabel);
            this.Controls.Add(this.headColorLabel);
            this.Controls.Add(this.bodyColorPb);
            this.Controls.Add(this.foodColorPb);
            this.Controls.Add(this.wallColorPb);
            this.Controls.Add(this.boardColorPb);
            this.Controls.Add(this.headColorPb);
            this.Controls.Add(this.sounds);
            this.Controls.Add(this.save);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsWindow";
            this.Text = "Snake - Settings Window";
            ((System.ComponentModel.ISupportInitialize)(this.boardColorLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallColorLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodColorLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyColorLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headColorLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyColorPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodColorPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallColorPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardColorPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headColorPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.PictureBox sounds;
        private System.Windows.Forms.PictureBox headColorPb;
        private System.Windows.Forms.PictureBox boardColorPb;
        private System.Windows.Forms.PictureBox wallColorPb;
        private System.Windows.Forms.PictureBox foodColorPb;
        private System.Windows.Forms.PictureBox bodyColorPb;
        private System.Windows.Forms.PictureBox headColorLabel;
        private System.Windows.Forms.PictureBox bodyColorLabel;
        private System.Windows.Forms.PictureBox foodColorLabel;
        private System.Windows.Forms.PictureBox wallColorLabel;
        private System.Windows.Forms.PictureBox boardColorLabel;
    }
}