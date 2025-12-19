using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (tbSoX.Text == "" || tbSoY.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!");
                return;
            }
            try
            {
                double x = double.Parse(tbSoX.Text);
                double y = double.Parse(tbSoY.Text);
                double kq = x + y;
                tbKetQua.Text = kq.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào phải là số!");
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            if (tbSoX.Text == "" || tbSoY.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!");
                return;
            }
            try
            {
                double x = double.Parse(tbSoX.Text);
                double y = double.Parse(tbSoY.Text);
                double kq = x * y;
                tbKetQua.Text = kq.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào phải là số!");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}