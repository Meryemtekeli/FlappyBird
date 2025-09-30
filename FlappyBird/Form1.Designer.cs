using DevExpress.XtraRichEdit.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FlappyBird
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            restartButton = new Button();
            gameOverText = new Label();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = Properties.Resources.bird;
            bird.Location = new Point(133, 262);
            bird.Name = "bird";
            bird.Size = new Size(50, 50);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 0;
            bird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.BackColor = Color.Transparent;
            pipeTop.Image = Properties.Resources.pipeTop;
            pipeTop.Location = new Point(500, 0);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(80, 200);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.BackColor = Color.Transparent;
            pipeBottom.Image = Properties.Resources.pipeBottom;
            pipeBottom.Location = new Point(457, 366);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(80, 235);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            pipeBottom.Click += pipeBottom_Click;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-10, 557);
            ground.Name = "ground";
            ground.Size = new Size(1051, 97);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            scoreText.ForeColor = Color.White;
            scoreText.Location = new Point(12, 11);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(171, 54);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // restartButton
            // 
            restartButton.BackColor = Color.Orange;
            restartButton.Cursor = Cursors.Hand;
            restartButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            restartButton.ForeColor = Color.White;
            restartButton.Location = new Point(356, 350);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(250, 70);
            restartButton.TabIndex = 5;
            restartButton.Text = "TEKRAR OYNA";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Visible = false;
            restartButton.Click += restartButton_Click;
            // 
            // gameOverText
            // 
            gameOverText.AutoSize = true;
            gameOverText.BackColor = Color.Transparent;
            gameOverText.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            gameOverText.ForeColor = Color.Red;
            gameOverText.Location = new Point(300, 250);
            gameOverText.Name = "gameOverText";
            gameOverText.Size = new Size(362, 81);
            gameOverText.TabIndex = 6;
            gameOverText.Text = "GAME OVER";
            gameOverText.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 649);
            Controls.Add(gameOverText);
            Controls.Add(restartButton);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(bird);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "Form1";
            Text = "Flappy Bird";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label gameOverText;
    }
}