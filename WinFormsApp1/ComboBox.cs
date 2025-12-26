using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ComboBox : Form
    {
        public ComboBox() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            // Chọn mặc định mục đầu tiên
            if (cb_Faculty.Items.Count > 0)
                cb_Faculty.SelectedIndex = 0;
        }

        // Sự kiện khi nhấn nút OK
        private void btOK_Click(object sender, EventArgs e)
        {
            // Lấy mục đang chọn
            string selectedFaculty = cb_Faculty.SelectedItem.ToString();

            // Hiển thị lên TextBox
            tbDisplay.Text = "Bạn đã chọn khoa: " + selectedFaculty;
        }

        // Sự kiện khi nhấn nút Clear (Xóa trắng)
        private void btClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
            cb_Faculty.SelectedIndex = -1; // Bỏ chọn ComboBox
        }

        // Sự kiện khi thay đổi lựa chọn (SelectedIndexChanged)
        // (Nếu muốn chọn xong là hiện ngay không cần bấm OK)
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Faculty.SelectedItem != null)
            {
                // this.Text = cb_Faculty.SelectedItem.ToString(); // Đổi tên form theo khoa
            }
        }
    }
}