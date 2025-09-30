using System;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 8;
        int pipeSpeed = 8;
        int score = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // 🔑 Tuşlar önce form tarafından yakalanır
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 650;
                pipeBottom.Top = rand.Next(350, 450);
                score++;
            }
            if (pipeTop.Left < -150)
            {
                pipeTop.Left = 650;
                pipeTop.Top = rand.Next(-200, -50);
                score++;
            }

            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25)
            {
                endGame();
            }

            if (score > 5 && pipeSpeed == 8)
                pipeSpeed = 10;
            if (score > 10 && pipeSpeed == 10)
                pipeSpeed = 12;
            if (score > 15 && pipeSpeed == 12)
                pipeSpeed = 15;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            restartButton.Visible = true;
            gameOverText.Visible = true;
            restartButton.BringToFront();
            gameOverText.BringToFront();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            restartButton.Visible = false;
            gameOverText.Visible = false;

            score = 0;
            pipeSpeed = 8;
            gravity = 8;

            bird.Top = 262;
            bird.Left = 133;

            pipeTop.Left = 650;
            pipeTop.Top = 0;
            pipeBottom.Left = 450;
            pipeBottom.Top = 366;

            scoreText.Text = "Score: 0";

            gameTimer.Start();

            this.Focus(); // 🔑 Form yeniden odaklanıyor
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // 🔑 Load’da da garanti olsun
        }

        private void pipeBottom_Click(object sender, EventArgs e)
        {
        }
    }
}
