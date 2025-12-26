using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TimerArticle : Form
    {
        // Biến lưu tổng số giây đã trôi qua
        int totalSeconds = 0;

        public TimerArticle()
        {
            InitializeComponent();
        }

        private void Timer_Article_Load(object sender, EventArgs e)
        {
            // Đặt hiển thị ban đầu
            lblDisplay.Text = "00:00";

            // QUAN TRỌNG: 1000ms = 1 giây. 
            // Nếu để 100 thì nó chạy nhanh gấp 10 lần thực tế.
            tmStopwatch.Interval = 1000;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Start();
            // Đổi màu nút để biết đang chạy
            btStart.Enabled = false; // Khóa nút Start lại
            btStop.Enabled = true;
            btStart.BackColor = System.Drawing.Color.Gray;
            btStop.BackColor = System.Drawing.Color.FromArgb(231, 76, 60); // Màu đỏ
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();

            btStart.Enabled = true;
            btStop.Enabled = false;
            btStart.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); // Màu xanh
            btStop.BackColor = System.Drawing.Color.Gray;
        }

        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            totalSeconds++; 

           
            int minutes = totalSeconds / 60; 
            int seconds = totalSeconds % 60; 

           
            lblDisplay.Text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}