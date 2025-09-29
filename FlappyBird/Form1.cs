using System;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 8;      // kuþun düþme hýzý
        int pipeSpeed = 8;    // borularýn hýzý
        int score = 0;        // skor

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;            // kuþu aþaðýya doðru hareket ettir
            pipeBottom.Left -= pipeSpeed;   // alt boru sola kaydýr
            pipeTop.Left -= pipeSpeed;      // üst boru sola kaydýr
            scoreText.Text = "Score: " + score; // skoru ekrana yazdýr

            // borular ekranýn solundan çýkarsa tekrar saðdan gelsin
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

            // kuþ borulara veya zemine çarparsa oyun bitsin
            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25) // ekranýn üstüne çýkarsa da oyun bitsin
            {
                endGame();
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // boþluða basýldýðýnda kuþ yukarý zýplasýn
            {
                gravity = -8;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // boþluðu býraktýðýnda kuþ tekrar düþmeye baþlasýn
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
