namespace Snake
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            this.visualBoard = new System.Windows.Forms.Panel();
            this.eatToBeatCount = new System.Windows.Forms.TextBox();
            this.snakeSpeed = new System.Windows.Forms.Timer(this.components);
            this.couldntLoadFilePb = new System.Windows.Forms.PictureBox();
            this.eatToBeatPb = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.PictureBox();
            this.leftBorder = new System.Windows.Forms.PictureBox();
            this.rightBorder = new System.Windows.Forms.PictureBox();
            this.topBorder = new System.Windows.Forms.PictureBox();
            this.bottomBorder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.couldntLoadFilePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatToBeatPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // visualBoard
            // 
            this.visualBoard.Location = new System.Drawing.Point(150, 70);
            this.visualBoard.Name = "visualBoard";
            this.visualBoard.Size = new System.Drawing.Size(480, 480);
            this.visualBoard.TabIndex = 3;
            this.visualBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.visualBoard_Paint);
            // 
            // eatToBeatCount
            // 
            this.eatToBeatCount.Enabled = false;
            this.eatToBeatCount.Location = new System.Drawing.Point(15, 116);
            this.eatToBeatCount.Name = "eatToBeatCount";
            this.eatToBeatCount.Size = new System.Drawing.Size(120, 20);
            this.eatToBeatCount.TabIndex = 5;
            this.eatToBeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // snakeSpeed
            // 
            this.snakeSpeed.Tick += new System.EventHandler(this.snakeSpeed_Tick);
            // 
            // couldntLoadFilePb
            // 
            this.couldntLoadFilePb.Image = global::Snake.Properties.Resources.wrongfile;
            this.couldntLoadFilePb.Location = new System.Drawing.Point(140, 235);
            this.couldntLoadFilePb.Name = "couldntLoadFilePb";
            this.couldntLoadFilePb.Size = new System.Drawing.Size(500, 150);
            this.couldntLoadFilePb.TabIndex = 6;
            this.couldntLoadFilePb.TabStop = false;
            this.couldntLoadFilePb.Visible = false;
            // 
            // eatToBeatPb
            // 
            this.eatToBeatPb.Image = global::Snake.Properties.Resources.eattobeat;
            this.eatToBeatPb.Location = new System.Drawing.Point(15, 70);
            this.eatToBeatPb.Name = "eatToBeatPb";
            this.eatToBeatPb.Size = new System.Drawing.Size(120, 40);
            this.eatToBeatPb.TabIndex = 4;
            this.eatToBeatPb.TabStop = false;
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
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.Black;
            this.leftBorder.Location = new System.Drawing.Point(149, 70);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(2, 480);
            this.leftBorder.TabIndex = 7;
            this.leftBorder.TabStop = false;
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.Black;
            this.rightBorder.Location = new System.Drawing.Point(630, 70);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(2, 480);
            this.rightBorder.TabIndex = 8;
            this.rightBorder.TabStop = false;
            // 
            // topBorder
            // 
            this.topBorder.BackColor = System.Drawing.Color.Black;
            this.topBorder.Location = new System.Drawing.Point(150, 69);
            this.topBorder.Name = "topBorder";
            this.topBorder.Size = new System.Drawing.Size(480, 2);
            this.topBorder.TabIndex = 9;
            this.topBorder.TabStop = false;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.Black;
            this.bottomBorder.Location = new System.Drawing.Point(150, 550);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(480, 2);
            this.bottomBorder.TabIndex = 10;
            this.bottomBorder.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(780, 570);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.topBorder);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.couldntLoadFilePb);
            this.Controls.Add(this.eatToBeatCount);
            this.Controls.Add(this.eatToBeatPb);
            this.Controls.Add(this.visualBoard);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.Text = "Snake - Game Window";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.couldntLoadFilePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatToBeatPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.Panel visualBoard;
        private System.Windows.Forms.PictureBox eatToBeatPb;
        private System.Windows.Forms.TextBox eatToBeatCount;
        private System.Windows.Forms.Timer snakeSpeed;
        private System.Windows.Forms.PictureBox couldntLoadFilePb;
        private System.Windows.Forms.PictureBox leftBorder;
        private System.Windows.Forms.PictureBox rightBorder;
        private System.Windows.Forms.PictureBox topBorder;
        private System.Windows.Forms.PictureBox bottomBorder;
    }
}