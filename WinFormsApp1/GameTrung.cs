using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class GameTrung : Form
    {
        int score = 0;
        int eggSpeed = 5;
        int basketSpeed = 30; // Giảm tốc độ giỏ chút cho mượt, 90 hơi nhanh quá

        public GameTrung()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Đặt giỏ nằm sát đáy
            pbBasket.Top = this.ClientSize.Height - pbBasket.Height - 10;
            // Căn giữa giỏ lúc đầu
            pbBasket.Left = (this.ClientSize.Width - pbBasket.Width) / 2;

            StartNewGame();
        }

        private void StartNewGame()
        {
            score = 0;
            lblScore.Text = "Score: 0";
            eggSpeed = 5;

            ResetEgg();
            tmEgg.Start();
            this.Focus();
        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            pbEgg.Top += eggSpeed;

            // Nếu trứng chạm đáy
            if (pbEgg.Top > this.ClientSize.Height)
            {
                tmEgg.Stop();
                DialogResult hoidap = MessageBox.Show(
                    "Toang rồi! Trứng đã vỡ.\nĐiểm: " + score + "\n\nChơi lại nha?",
                    "Game Over",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (hoidap == DialogResult.Yes) StartNewGame();
                else this.Close();
            }

            // Nếu trứng chạm giỏ
            if (pbEgg.Bounds.IntersectsWith(pbBasket.Bounds))
            {
                score++;
                lblScore.Text = "Score: " + score;

                // Tăng độ khó: Cứ 5 điểm tăng tốc 1 lần
                if (score % 5 == 0) eggSpeed += 1;

                ResetEgg();
            }
        }

        private void ResetEgg()
        {
            Random r = new Random();
            // 1. Random vị trí trứng
            int x = r.Next(10, this.ClientSize.Width - pbEgg.Width - 10);

            pbEgg.Left = x;
            pbEgg.Top = 80; // Trứng xuất phát từ trên cao

            // 2. Di chuyển con gà đến chỗ trứng rơi (Cho trực quan)
            // Căn giữa con gà theo quả trứng
            pbChicken.Left = x - (pbChicken.Width / 2) + (pbEgg.Width / 2);

            // Xử lý nếu gà bị trôi ra khỏi màn hình thì kéo lại
            if (pbChicken.Left < 0) pbChicken.Left = 0;
            if (pbChicken.Right > this.ClientSize.Width) pbChicken.Left = this.ClientSize.Width - pbChicken.Width;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            // Thêm logic giữ phím mượt mà hơn (nếu cần) nhưng ở mức cơ bản thì dùng cách này:
            if (e.KeyCode == Keys.Left && pbBasket.Left > 0)
            {
                pbBasket.Left -= basketSpeed;
            }
            else if (e.KeyCode == Keys.Right && pbBasket.Right < this.ClientSize.Width)
            {
                pbBasket.Left += basketSpeed;
            }
        }

        private void pbBasket_Click(object sender, EventArgs e) { }
    }
}