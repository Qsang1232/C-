using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            // Hàm này cực kỳ quan trọng, nó gọi code bên file Designer bạn vừa gửi
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút Đăng Nhập
        // Tên hàm này phải trùng khớp với dòng 'btnLogin.Click += ...' trong file Designer
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ ô nhập (tên biến theo file Designer bạn gửi)
            string taiKhoan = txtUser.Text;
            string matKhau = txtPass.Text;

            // Kiểm tra đăng nhập đơn giản
            if (taiKhoan == "admin" && matKhau == "123")
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Ẩn form đăng nhập
                this.Hide();

                // Mở form Quản Lý Sinh Viên (QLSV)
                // Lưu ý: Nếu dòng dưới báo lỗi đỏ, hãy đảm bảo bạn đã có file QLSV.cs trong dự án
                MainForm formMainForm = new MainForm();
                formMainForm.ShowDialog();

                // Khi tắt form QLSV thì tắt luôn chương trình
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu! (Thử: admin / 123)");
            }
        }
    }
}