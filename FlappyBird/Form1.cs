using System;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 8;      // ku�un d��me h�z�
        int pipeSpeed = 8;    // borular�n h�z�
        int score = 0;        // skor

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;            // ku�u a�a��ya do�ru hareket ettir
            pipeBottom.Left -= pipeSpeed;   // alt boru sola kayd�r
            pipeTop.Left -= pipeSpeed;      // �st boru sola kayd�r
            scoreText.Text = "Score: " + score; // skoru ekrana yazd�r

            // borular ekran�n solundan ��karsa tekrar sa�dan gelsin
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            // ku� borulara veya zemine �arparsa oyun bitsin
            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25) // ekran�n �st�ne ��karsa da oyun bitsin
            {
                endGame();
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // bo�lu�a bas�ld���nda ku� yukar� z�plas�n
            {
                gravity = -8;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // bo�lu�u b�rakt���nda ku� tekrar d��meye ba�las�n
            {
                gravity = 8;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "   Game Over!";
        }
    }
}
