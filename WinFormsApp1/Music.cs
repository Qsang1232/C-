using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
        }

        // 1. Tạo dữ liệu mẫu
        private void Form1_Load(object sender, EventArgs e)
        {
            lbSong.Items.Add("Giấc mơ Chapi");
            lbSong.Items.Add("Đôi mắt Pleiku");
            lbSong.Items.Add("Em muốn sống bên anh trọn đời");
            lbSong.Items.Add("H'Zen Lên Rẫy");
            lbSong.Items.Add("Ly cà phê Ban Mê");
            lbSong.Items.Add("Đi tìm lời ru mặt trời");
        }

        // 2. Nút [>] : Chuyển 1 bài từ Trái -> Phải
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                string song = lbSong.SelectedItem.ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.Remove(song);
            }
        }

        // 3. Nút [<] : Trả 1 bài từ Phải -> Trái (Ngược lại)
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                string song = lbFavorite.SelectedItem.ToString();
                lbSong.Items.Add(song);         // Trả về danh sách gốc
                lbFavorite.Items.Remove(song);  // Xóa khỏi danh sách yêu thích
            }
        }

        // 4. Nút [>>] : Chuyển TẤT CẢ từ Trái -> Phải
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Duyệt hết danh sách trái
            foreach (var item in lbSong.Items)
            {
                lbFavorite.Items.Add(item);
            }
            lbSong.Items.Clear(); // Xóa sạch bên trái
        }

        // 5. Nút [<<] : Trả TẤT CẢ từ Phải -> Trái
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            // Duyệt hết danh sách phải
            foreach (var item in lbFavorite.Items)
            {
                lbSong.Items.Add(item);
            }
            lbFavorite.Items.Clear(); // Xóa sạch bên phải
        }
    }
}