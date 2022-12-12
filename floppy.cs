﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace floppyFish
{
    public partial class Form1 : Form
    {

        //public vars
        int obstacleSpeed = 4;
        int gravity = 1;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            
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
                obstacleBot.Left = 950;
                score++;
            }

            if (obstacleTop.Left < 25)
            {
                obstacleTop.Left = 950;
                score++;
            }
            if (obstacleBot2.Left < 25)
            {
                obstacleBot2.Left = 950;
                score++;
            }

            if (obstacleTop2.Left < 25)
            {
                obstacleTop2.Left = 950;
                score++;
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
            gameTimer.Stop();
            gameOver_txt.Text = " Game Over!";
            
            
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            //fly down
            if (e.KeyCode == Keys.Down)
            {
                gravity = 2;
            }
            //fly up
            if (e.KeyCode == Keys.Up)
            {
                gravity = -2;
            }
            //start or pause game
            if (e.KeyCode == Keys.Space)
            {
                if (gameTimer.Enabled)
                {
                    gameTimer.Stop();
                    gameOver_txt.Text = "Paused";
                }
                else
                {
                    gameTimer.Start();
                    gameOver_txt.Text = "";
                }

            }
        }
    }
}