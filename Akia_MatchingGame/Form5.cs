using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akia_MatchingGame
{
    public partial class Form5 : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        Timer timer = new Timer { Interval = 1000 };
        int time = 60; // 1 minute
        int score = 2000; // Initial score

        public Form5()
        {
            InitializeComponent();
        }

        private PictureBox[] pictureBoxes
        {
            get
            {
                return Controls.OfType<PictureBox>().ToArray();
            }
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.bat,
                    Properties.Resources.cat,
                    Properties.Resources.cow,
                    Properties.Resources.deer,
                    Properties.Resources.elephant,
                    Properties.Resources.fox,
                    Properties.Resources.frog,
                    Properties.Resources.girraffe,
                    Properties.Resources.koala,
                    Properties.Resources.lion,
                    Properties.Resources.monkey,
                    Properties.Resources.owl,
                    Properties.Resources.panda,
                    Properties.Resources.penguin,
                    Properties.Resources.pig,
                    Properties.Resources.polar,
                    Properties.Resources.rabbit,
                    Properties.Resources.rhino,
                    Properties.Resources.squirrel,
                    Properties.Resources.tiger


                };
            }
        }

        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += timer_Tick;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetImages();
            ResetTimeAndScore();
        }

        private void ResetTimeAndScore()
        {
            time = 60; // Reset time to 1 minute
            score = 2000; // Reset score to 2000
            lblTime.Text = "01:00"; // Reset time label
            lblScore.Text = score.ToString(); // Reset score label
        }

        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 60; // Reset time to 1 minute
            timer.Start();
            ResetTimeAndScore(); // Call to reset time and score
        }

        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.question;
            }
        }

        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }

        private void setRandomImages()
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            clickTimer.Stop();
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;
            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                score += 100; // Increase score by 100 when a pair is correctly guessed
                lblScore.Text = score.ToString(); // Update score label
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            this.Hide();
            MessageBox.Show($"You Win. Final Score: {score}. Congratulations!");
            Application.Exit();
        }

        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            button1.Enabled = false;

            // Display initial score
            lblScore.Text = score.ToString();
        }

        private void exitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;
            if (time < 0)
            {
                timer.Stop();
                MessageBox.Show("Game Over");
                ResetImages();
            }
            var minutes = time / 60;
            var seconds = time % 60;
            lblTime.Text = $"{minutes:00}:{seconds:00}";

            // Decrease score by 20 every second
            score -= 20;
            lblScore.Text = score.ToString(); // Update score label
        }
    }
}
