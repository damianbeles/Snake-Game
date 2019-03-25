namespace Snake
{
    partial class CreateWindow
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
            this.boardCreator = new System.Windows.Forms.Panel();
            this.eatToBeatCount = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.direction = new System.Windows.Forms.ComboBox();
            this.done = new System.Windows.Forms.PictureBox();
            this.fclear = new System.Windows.Forms.PictureBox();
            this.wwall = new System.Windows.Forms.PictureBox();
            this.psnake = new System.Windows.Forms.PictureBox();
            this.wallPb = new System.Windows.Forms.PictureBox();
            this.freeSquarePb = new System.Windows.Forms.PictureBox();
            this.headPb = new System.Windows.Forms.PictureBox();
            this.bottomBorder = new System.Windows.Forms.PictureBox();
            this.topBorder = new System.Windows.Forms.PictureBox();
            this.rightBorder = new System.Windows.Forms.PictureBox();
            this.leftBorder = new System.Windows.Forms.PictureBox();
            this.directionPb = new System.Windows.Forms.PictureBox();
            this.speedPb = new System.Windows.Forms.PictureBox();
            this.eatToBeatPb = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.done)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fclear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wwall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSquarePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatToBeatPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            this.SuspendLayout();
            // 
            // boardCreator
            // 
            this.boardCreator.Location = new System.Drawing.Point(150, 70);
            this.boardCreator.Name = "boardCreator";
            this.boardCreator.Size = new System.Drawing.Size(480, 480);
            this.boardCreator.TabIndex = 7;
            this.boardCreator.Paint += new System.Windows.Forms.PaintEventHandler(this.boardCreator_Paint);
            // 
            // eatToBeatCount
            // 
            this.eatToBeatCount.Enabled = false;
            this.eatToBeatCount.Location = new System.Drawing.Point(15, 116);
            this.eatToBeatCount.Name = "eatToBeatCount";
            this.eatToBeatCount.Size = new System.Drawing.Size(120, 20);
            this.eatToBeatCount.TabIndex = 9;
            this.eatToBeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speed
            // 
            this.speed.Enabled = false;
            this.speed.Location = new System.Drawing.Point(15, 188);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(120, 20);
            this.speed.TabIndex = 11;
            this.speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // direction
            // 
            this.direction.Enabled = false;
            this.direction.FormattingEnabled = true;
            this.direction.Items.AddRange(new object[] {
            "NORTH",
            "SOUTH",
            "WEST",
            "EAST"});
            this.direction.Location = new System.Drawing.Point(14, 260);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(121, 21);
            this.direction.TabIndex = 13;
            this.direction.Text = "NORTH";
            // 
            // done
            // 
            this.done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done.Image = global::Snake.Properties.Resources.done;
            this.done.Location = new System.Drawing.Point(-1, 350);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(150, 50);
            this.done.TabIndex = 24;
            this.done.TabStop = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            this.done.MouseEnter += new System.EventHandler(this.done_MouseEnter);
            this.done.MouseLeave += new System.EventHandler(this.done_MouseLeave);
            // 
            // fclear
            // 
            this.fclear.Image = global::Snake.Properties.Resources.fclear;
            this.fclear.Location = new System.Drawing.Point(681, 130);
            this.fclear.Name = "fclear";
            this.fclear.Size = new System.Drawing.Size(70, 15);
            this.fclear.TabIndex = 23;
            this.fclear.TabStop = false;
            // 
            // wwall
            // 
            this.wwall.Image = global::Snake.Properties.Resources.wwall;
            this.wwall.Location = new System.Drawing.Point(681, 100);
            this.wwall.Name = "wwall";
            this.wwall.Size = new System.Drawing.Size(70, 15);
            this.wwall.TabIndex = 22;
            this.wwall.TabStop = false;
            // 
            // psnake
            // 
            this.psnake.Image = global::Snake.Properties.Resources.psnake;
            this.psnake.Location = new System.Drawing.Point(681, 70);
            this.psnake.Name = "psnake";
            this.psnake.Size = new System.Drawing.Size(70, 15);
            this.psnake.TabIndex = 21;
            this.psnake.TabStop = false;
            // 
            // wallPb
            // 
            this.wallPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wallPb.Cursor = System.Windows.Forms.Cursors.Default;
            this.wallPb.Location = new System.Drawing.Point(660, 100);
            this.wallPb.Name = "wallPb";
            this.wallPb.Size = new System.Drawing.Size(15, 15);
            this.wallPb.TabIndex = 20;
            this.wallPb.TabStop = false;
            // 
            // freeSquarePb
            // 
            this.freeSquarePb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.freeSquarePb.Cursor = System.Windows.Forms.Cursors.Default;
            this.freeSquarePb.Location = new System.Drawing.Point(660, 130);
            this.freeSquarePb.Name = "freeSquarePb";
            this.freeSquarePb.Size = new System.Drawing.Size(15, 15);
            this.freeSquarePb.TabIndex = 19;
            this.freeSquarePb.TabStop = false;
            // 
            // headPb
            // 
            this.headPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headPb.Cursor = System.Windows.Forms.Cursors.Default;
            this.headPb.Location = new System.Drawing.Point(660, 70);
            this.headPb.Name = "headPb";
            this.headPb.Size = new System.Drawing.Size(15, 15);
            this.headPb.TabIndex = 18;
            this.headPb.TabStop = false;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.Black;
            this.bottomBorder.Location = new System.Drawing.Point(150, 550);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(480, 2);
            this.bottomBorder.TabIndex = 17;
            this.bottomBorder.TabStop = false;
            // 
            // topBorder
            // 
            this.topBorder.BackColor = System.Drawing.Color.Black;
            this.topBorder.Location = new System.Drawing.Point(150, 69);
            this.topBorder.Name = "topBorder";
            this.topBorder.Size = new System.Drawing.Size(480, 2);
            this.topBorder.TabIndex = 16;
            this.topBorder.TabStop = false;
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.Black;
            this.rightBorder.Location = new System.Drawing.Point(630, 70);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(2, 480);
            this.rightBorder.TabIndex = 15;
            this.rightBorder.TabStop = false;
            // 
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.Black;
            this.leftBorder.Location = new System.Drawing.Point(149, 70);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(2, 480);
            this.leftBorder.TabIndex = 14;
            this.leftBorder.TabStop = false;
            // 
            // directionPb
            // 
            this.directionPb.Image = global::Snake.Properties.Resources.direction;
            this.directionPb.Location = new System.Drawing.Point(15, 214);
            this.directionPb.Name = "directionPb";
            this.directionPb.Size = new System.Drawing.Size(120, 40);
            this.directionPb.TabIndex = 12;
            this.directionPb.TabStop = false;
            // 
            // speedPb
            // 
            this.speedPb.Image = global::Snake.Properties.Resources.speed;
            this.speedPb.Location = new System.Drawing.Point(15, 142);
            this.speedPb.Name = "speedPb";
            this.speedPb.Size = new System.Drawing.Size(120, 40);
            this.speedPb.TabIndex = 10;
            this.speedPb.TabStop = false;
            // 
            // eatToBeatPb
            // 
            this.eatToBeatPb.Image = global::Snake.Properties.Resources.eattobeat;
            this.eatToBeatPb.Location = new System.Drawing.Point(15, 70);
            this.eatToBeatPb.Name = "eatToBeatPb";
            this.eatToBeatPb.Size = new System.Drawing.Size(120, 40);
            this.eatToBeatPb.TabIndex = 8;
            this.eatToBeatPb.TabStop = false;
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Image = global::Snake.Properties.Resources.save;
            this.save.Location = new System.Drawing.Point(0, 500);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(150, 50);
            this.save.TabIndex = 6;
            this.save.TabStop = false;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.MouseEnter += new System.EventHandler(this.save_MouseEnter);
            this.save.MouseLeave += new System.EventHandler(this.save_MouseLeave);
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = global::Snake.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(710, 15);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(20, 20);
            this.minimize.TabIndex = 5;
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
            this.exit.TabIndex = 4;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // header
            // 
            this.header.Image = global::Snake.Properties.Resources.header;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(780, 50);
            this.header.TabIndex = 3;
            this.header.TabStop = false;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // CreateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(780, 570);
            this.Controls.Add(this.done);
            this.Controls.Add(this.fclear);
            this.Controls.Add(this.wwall);
            this.Controls.Add(this.psnake);
            this.Controls.Add(this.wallPb);
            this.Controls.Add(this.freeSquarePb);
            this.Controls.Add(this.headPb);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.topBorder);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.directionPb);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.speedPb);
            this.Controls.Add(this.eatToBeatCount);
            this.Controls.Add(this.eatToBeatPb);
            this.Controls.Add(this.boardCreator);
            this.Controls.Add(this.save);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateWindow";
            this.Text = "Snake - Level Creator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.done)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fclear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wwall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSquarePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatToBeatPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.Panel boardCreator;
        private System.Windows.Forms.TextBox eatToBeatCount;
        private System.Windows.Forms.PictureBox eatToBeatPb;
        private System.Windows.Forms.PictureBox speedPb;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.PictureBox directionPb;
        private System.Windows.Forms.ComboBox direction;
        private System.Windows.Forms.PictureBox bottomBorder;
        private System.Windows.Forms.PictureBox topBorder;
        private System.Windows.Forms.PictureBox rightBorder;
        private System.Windows.Forms.PictureBox leftBorder;
        private System.Windows.Forms.PictureBox wallPb;
        private System.Windows.Forms.PictureBox freeSquarePb;
        private System.Windows.Forms.PictureBox headPb;
        private System.Windows.Forms.PictureBox psnake;
        private System.Windows.Forms.PictureBox wwall;
        private System.Windows.Forms.PictureBox fclear;
        private System.Windows.Forms.PictureBox done;
    }
}