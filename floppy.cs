using System;
using System.Windows.Forms;
using System.Media;
using Random = System.Random;
using System.ComponentModel;

namespace floppyFish
{
    public partial class Form1 : Form
    {

        //public vars
        int obstacleSpeed = 3;
        int gravity = 2;
        int score = 0;
        bool gameStart = false;
        bool endGame = false;
        public SoundPlayer sp = new SoundPlayer();
        

        public Form1()
        {
            InitializeComponent();
            sp.Stream = Properties.Resources.music;
            int ob1 = obstacleTop.Location.Y;
            int ob2 = obstacleBot.Location.Y;
            int ob3 = obstacleTop2.Location.Y;
            int ob4 = obstacleBot2.Location.Y;
            //lowest vals for first obstacles is -20 for top and 484 for bot
            //size of pipe is 350 so gap should stay around 150 units
            //lowest vals for second obstacles is 484 and 350 for bot

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            //beginning of game
            if (!gameStart)
            {
                sp.PlayLooping();
                gameTimer.Stop();
                gameOver_txt.Text = "Press Space to Start\n\n" +
                    "Use Up and Down arrow keys to control your fish!." +
                    "\n\n Don't hit any obstacles and reach level 60 to win!\n\n" +
                    "The difficulty scales up as you progress!\n\n" +
                    "Press enter to restart and M to mute the music.";
            }

            //changes players margin according to gravity
            fishPlayer.Top += gravity;

            //makes the objects move to give sense of the player moving right
            obstacleBot.Left -= obstacleSpeed;
            obstacleTop.Left -= obstacleSpeed;
            obstacleBot2.Left -= obstacleSpeed;
            obstacleTop2.Left -= obstacleSpeed;

            //update score
            scoreText.Text = score.ToString();

            //allows the obstacles to keep spawning after going out of bounds
            if (obstacleBot.Left < 25)
            {
                obstacleBot.Top = RandomNumber(300,450 );
                obstacleBot.Left = 950;
                score++;
            }
            
            if (obstacleTop.Left < 25)
            {
                obstacleTop.Top = obstacleBot.Top - 445;
                obstacleTop.Left = 950;
                
            }
            if (obstacleBot2.Left < 25)
            {
                obstacleBot2.Top = RandomNumber(300, 450);
                obstacleBot2.Left = 950;
                score++;
            }

            if (obstacleTop2.Left < 25)
            {
                obstacleTop2.Top = obstacleBot2.Top - 445;
                obstacleTop2.Left = 950;
            }
            //increases difficulty as score increases
            if (score >= 4)
            {
                obstacleSpeed = 5;
            }
            if(score >= 20)
            {
                obstacleSpeed = 6;
            }
            if(score >= 30)
            {
                obstacleSpeed = 8;
            }
            if(score >= 50)
            {
                obstacleSpeed = 9;
            }
            

            //win condition
            if (score == 60)
            {
                endGame = true;
                gameTimer.Stop();
                gameOver_txt.Text = "You Win!\nPress Enter to Restart";
            }


            //prevent player from falling off screen if it goes out of bounds
            if (fishPlayer.Bounds.IntersectsWith(ground0.Bounds) ||
                fishPlayer.Bounds.IntersectsWith(ground1.Bounds) ||
                fishPlayer.Bounds.IntersectsWith(ground2.Bounds) ||
                fishPlayer.Top < -25 ||
                fishPlayer.Bounds.IntersectsWith(obstacleBot.Bounds) ||
                fishPlayer.Bounds.IntersectsWith(obstacleTop.Bounds) ||
                fishPlayer.Bounds.IntersectsWith(obstacleBot2.Bounds) ||
                fishPlayer.Bounds.IntersectsWith(obstacleTop2.Bounds))
            {
                gameOver();
            }
        }

        private void gameOver()
        {
            //end game function, if player dies it stops the timer and shows game over message
            gameStart = false;
            gameTimer.Stop();
            gameOver_txt.Text = " Game Over! \nEnter to Restart";
            endGame = true;
        }

        public void onKeyDown(object sender, KeyEventArgs e)
        {
            //fly down
            if (e.KeyCode == Keys.Down)
            {
                if (score >= 10)
                {
                    gravity = 3;
                }
                else
                {
                    gravity = 2;
                }
            }
            //fly up
            if (e.KeyCode == Keys.Up)
            {
                if (score >= 10)
                {
                    gravity = -3;
                }
                else
                {
                    gravity = -2;
                }
            }
            //start or pause game
            if (e.KeyCode == Keys.Space)
            {
                if (!endGame)
                {
                    if (gameTimer.Enabled)
                    {
                        gameTimer.Stop();
                        gameOver_txt.Text = "Paused";
                    }
                    else
                    {
                        gameTimer.Start();
                        gameStart = true;
                        gameOver_txt.Text = "";
                    }
                }
            }
            //restart game
            if (e.KeyCode == Keys.Enter)
            {
                Application.Restart();                
            }
            //quit game
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            //mute and unmute
            if (e.KeyCode == Keys.M)
            {
                if (muteBtn.Text == "Mute")
                {
                    sp.Stop();
                    muteBtn.Text = "Unmute";
                }
                else
                {
                    sp.PlayLooping();
                    muteBtn.Text = "Mute";
                }
            }
        }
        //get random number for moving obstacles
        int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void helpButton_Clicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Pat McCormick - W0183220 " +
                            "Use the up and down arrow keys to move the fish up and down. \n\nAvoid the obstacles and try to get the highest score possible." +
                            " \n\nPress Space to start or pause the game. \n\nPress Enter to restart the game. " +
                            "\n\nPress Escape to quit the game. \n\nPress M to mute or unmute the music. Good Luck!\n\n");
        }
    }
}
