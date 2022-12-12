namespace floppyFish
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.fishPlayer = new System.Windows.Forms.PictureBox();
            this.obstacleBot = new System.Windows.Forms.PictureBox();
            this.obstacleTop = new System.Windows.Forms.PictureBox();
            this.ground0 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground4 = new System.Windows.Forms.PictureBox();
            this.obstacleBot2 = new System.Windows.Forms.PictureBox();
            this.obstacleTop2 = new System.Windows.Forms.PictureBox();
            this.gameOver_txt = new System.Windows.Forms.Label();
            this.muteBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fishPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(201, 62);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "SCORE:";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.MintCream;
            this.scoreText.Location = new System.Drawing.Point(219, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 62);
            this.scoreText.TabIndex = 1;
            // 
            // fishPlayer
            // 
            this.fishPlayer.Image = ((System.Drawing.Image)(resources.GetObject("fishPlayer.Image")));
            this.fishPlayer.InitialImage = ((System.Drawing.Image)(resources.GetObject("fishPlayer.InitialImage")));
            this.fishPlayer.Location = new System.Drawing.Point(103, 251);
            this.fishPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.fishPlayer.Name = "fishPlayer";
            this.fishPlayer.Size = new System.Drawing.Size(151, 70);
            this.fishPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fishPlayer.TabIndex = 2;
            this.fishPlayer.TabStop = false;
            // 
            // obstacleBot
            // 
            this.obstacleBot.Image = ((System.Drawing.Image)(resources.GetObject("obstacleBot.Image")));
            this.obstacleBot.Location = new System.Drawing.Point(424, 523);
            this.obstacleBot.Name = "obstacleBot";
            this.obstacleBot.Size = new System.Drawing.Size(113, 328);
            this.obstacleBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleBot.TabIndex = 3;
            this.obstacleBot.TabStop = false;
            // 
            // obstacleTop
            // 
            this.obstacleTop.Image = ((System.Drawing.Image)(resources.GetObject("obstacleTop.Image")));
            this.obstacleTop.Location = new System.Drawing.Point(438, -29);
            this.obstacleTop.Name = "obstacleTop";
            this.obstacleTop.Size = new System.Drawing.Size(121, 350);
            this.obstacleTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleTop.TabIndex = 4;
            this.obstacleTop.TabStop = false;
            // 
            // ground0
            // 
            this.ground0.Image = ((System.Drawing.Image)(resources.GetObject("ground0.Image")));
            this.ground0.Location = new System.Drawing.Point(-10, 645);
            this.ground0.Name = "ground0";
            this.ground0.Size = new System.Drawing.Size(337, 110);
            this.ground0.TabIndex = 5;
            this.ground0.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // ground1
            // 
            this.ground1.Image = ((System.Drawing.Image)(resources.GetObject("ground1.Image")));
            this.ground1.Location = new System.Drawing.Point(323, 645);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(337, 110);
            this.ground1.TabIndex = 6;
            this.ground1.TabStop = false;
            // 
            // ground2
            // 
            this.ground2.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.ground2.Image = ((System.Drawing.Image)(resources.GetObject("ground2.Image")));
            this.ground2.Location = new System.Drawing.Point(655, 645);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(337, 110);
            this.ground2.TabIndex = 7;
            this.ground2.TabStop = false;
            // 
            // ground4
            // 
            this.ground4.Image = ((System.Drawing.Image)(resources.GetObject("ground4.Image")));
            this.ground4.Location = new System.Drawing.Point(1322, 748);
            this.ground4.Name = "ground4";
            this.ground4.Size = new System.Drawing.Size(337, 110);
            this.ground4.TabIndex = 9;
            this.ground4.TabStop = false;
            // 
            // obstacleBot2
            // 
            this.obstacleBot2.Image = ((System.Drawing.Image)(resources.GetObject("obstacleBot2.Image")));
            this.obstacleBot2.Location = new System.Drawing.Point(849, 475);
            this.obstacleBot2.Name = "obstacleBot2";
            this.obstacleBot2.Size = new System.Drawing.Size(112, 328);
            this.obstacleBot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleBot2.TabIndex = 10;
            this.obstacleBot2.TabStop = false;
            // 
            // obstacleTop2
            // 
            this.obstacleTop2.Image = ((System.Drawing.Image)(resources.GetObject("obstacleTop2.Image")));
            this.obstacleTop2.Location = new System.Drawing.Point(860, -61);
            this.obstacleTop2.Name = "obstacleTop2";
            this.obstacleTop2.Size = new System.Drawing.Size(119, 350);
            this.obstacleTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleTop2.TabIndex = 11;
            this.obstacleTop2.TabStop = false;
            // 
            // gameOver_txt
            // 
            this.gameOver_txt.AutoSize = true;
            this.gameOver_txt.BackColor = System.Drawing.Color.Gray;
            this.gameOver_txt.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver_txt.ForeColor = System.Drawing.Color.LightSalmon;
            this.gameOver_txt.Location = new System.Drawing.Point(133, 203);
            this.gameOver_txt.Name = "gameOver_txt";
            this.gameOver_txt.Size = new System.Drawing.Size(0, 29);
            this.gameOver_txt.TabIndex = 12;
            this.gameOver_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // muteBtn
            // 
            this.muteBtn.AutoSize = true;
            this.muteBtn.BackColor = System.Drawing.Color.Transparent;
            this.muteBtn.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteBtn.ForeColor = System.Drawing.Color.Yellow;
            this.muteBtn.Location = new System.Drawing.Point(762, 682);
            this.muteBtn.Name = "muteBtn";
            this.muteBtn.Size = new System.Drawing.Size(149, 62);
            this.muteBtn.TabIndex = 13;
            this.muteBtn.Text = "Mute";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(991, 753);
            this.Controls.Add(this.muteBtn);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground0);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.gameOver_txt);
            this.Controls.Add(this.obstacleTop2);
            this.Controls.Add(this.obstacleBot2);
            this.Controls.Add(this.ground4);
            this.Controls.Add(this.obstacleTop);
            this.Controls.Add(this.obstacleBot);
            this.Controls.Add(this.fishPlayer);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Floppy Fish";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.helpButton_Clicked);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fishPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox fishPlayer;
        private System.Windows.Forms.PictureBox obstacleBot;
        private System.Windows.Forms.PictureBox obstacleTop;
        private System.Windows.Forms.PictureBox ground0;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.PictureBox ground2;
        private System.Windows.Forms.PictureBox ground4;
        private System.Windows.Forms.PictureBox obstacleBot2;
        private System.Windows.Forms.PictureBox obstacleTop2;
        private System.Windows.Forms.Label gameOver_txt;
        private System.Windows.Forms.Label muteBtn;
    }
}

