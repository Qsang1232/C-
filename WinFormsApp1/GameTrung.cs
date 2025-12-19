using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class GameTrung : Form
    {
        int score = 0;
        int eggSpeed = 5;      // Tốc độ rơi
        int basketSpeed = 90;  // Tốc độ di chuyển giỏ

        public GameTrung()
        {
            InitializeComponent();
        }

        // 1. Khi Form bắt đầu chạy
        private void Form3_Load(object sender, EventArgs e)
        {
            // Cài đặt vị trí ban đầu
            pbBasket.Top = this.ClientSize.Height - pbBasket.Height - 10;
            StartNewGame();
        }

        // Hàm bắt đầu game mới (Dùng chung cho lúc mở và lúc chơi lại)
        private void StartNewGame()
        {
            score = 0;
            lblScore.Text = "Score: 0";
            eggSpeed = 8; // Reset tốc độ

            ResetEgg();   // Đưa trứng lên trên
            tmEgg.Start(); // Chạy đồng hồ

            this.Focus(); // Lấy lại quyền điều khiển bàn phím cho Form
        }

        // 2. Timer chạy liên tục
        private void tmEgg_Tick(object sender, EventArgs e)
        {
            pbEgg.Top += eggSpeed;

            // --- XỬ LÝ THUA GAME ---
            // Nếu trứng chạm đáy (Rơi quá chiều cao form)
            if (pbEgg.Top > this.ClientSize.Height)
            {
                tmEgg.Stop(); // Dừng game lại ngay

                // Hiện bảng thông báo
                DialogResult hoidap = MessageBox.Show(
                    "Bạn đã làm vỡ trứng!\nĐiểm của bạn: " + score + "\n\nBạn có muốn chơi lại không?",
                    "Game Over",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (hoidap == DialogResult.Yes)
                {
                    StartNewGame(); // Reset game
                }
                else
                {
                    this.Close(); // Thoát game
                }
            }

            // --- XỬ LÝ HỨNG TRÚNG ---
            if (pbEgg.Bounds.IntersectsWith(pbBasket.Bounds))
            {
                score++;
                lblScore.Text = "Score: " + score;

                // Tăng độ khó: Cứ 5 điểm thì trứng rơi nhanh hơn 1 chút
                if (score % 5 == 0) eggSpeed += 2;

                ResetEgg(); // Rơi quả tiếp theo
            }
        }

        // Hàm đưa trứng lên vị trí ngẫu nhiên
        private void ResetEgg()
        {
            pbEgg.Top = 80; // Cách đỉnh 80px (để dưới con gà)
            Random r = new Random();
            pbEgg.Left = r.Next(0, this.ClientSize.Width - pbEgg.Width);
        }

        // 3. Sự kiện bấm phím di chuyển
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && pbBasket.Left > 0)
            {
                pbBasket.Left -= basketSpeed;
            }
            else if (e.KeyCode == Keys.Right && pbBasket.Right < this.ClientSize.Width)
            {
                pbBasket.Left += basketSpeed;
            }
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            tmEgg.Stop();
            this.Close();
        }

        private void pbBasket_Click(object sender, EventArgs e)
        {

        }
    }
}