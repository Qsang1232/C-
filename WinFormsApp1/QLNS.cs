using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class QLNS : Form
    {
        List<Employee> lstEmp;
        BindingSource bs = new BindingSource();
        string currentAvatarPath = "";

        public QLNS()
        {
            InitializeComponent();
        }

        private void QLNS_Load(object sender, EventArgs e)
        {
            lstEmp = new List<Employee>();
            // Dữ liệu mẫu
            lstEmp.Add(new Employee("NV001", "Nguyễn Văn A", 25, true, ""));
            lstEmp.Add(new Employee("NV002", "Trần Thị B", 22, false, ""));

            bs.DataSource = lstEmp;
            dgvEmployee.DataSource = bs;

            FormatDataGridView(); // Hàm làm đẹp bảng
        }

        // Hàm định dạng tên cột cho đẹp
        private void FormatDataGridView()
        {
            if (dgvEmployee.Columns.Count > 0)
            {
                dgvEmployee.Columns["Id"].HeaderText = "Mã NV";
                dgvEmployee.Columns["Name"].HeaderText = "Họ và Tên";
                dgvEmployee.Columns["Age"].HeaderText = "Tuổi";
                dgvEmployee.Columns["Gender"].HeaderText = "Giới Tính (Nam=Tích)";
                dgvEmployee.Columns["AvatarPath"].Visible = false; // Ẩn cột đường dẫn ảnh
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn ảnh nhân viên";
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.ImageLocation = dlg.FileName;
                currentAvatarPath = dlg.FileName;
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(tbId.Text) || string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tuổi có phải số không
            if (!int.TryParse(tbAge.Text, out int age))
            {
                MessageBox.Show("Tuổi phải là một số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy giới tính từ RadioButton
            bool isMale = rbNam.Checked;

            Employee emp = new Employee(
                tbId.Text,
                tbName.Text,
                age,
                isMale,
                currentAvatarPath
            );

            lstEmp.Add(emp);
            bs.ResetBindings(false); // Cập nhật lại Grid

            // Reset form
            tbId.Clear();
            tbName.Clear();
            tbAge.Clear();
            rbNam.Checked = true;
            pbAvatar.Image = null;
            currentAvatarPath = "";
            tbId.Focus();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    lstEmp.RemoveAt(dgvEmployee.CurrentCell.RowIndex);
                    bs.ResetBindings(false);
                    pbAvatar.Image = null;
                    ClearInputs();
                }
            }
        }

        private void ClearInputs()
        {
            tbId.Text = "";
            tbName.Text = "";
            tbAge.Text = "";
            rbNam.Checked = true;
            pbAvatar.Image = null;
        }

        // Sự kiện khi click vào một dòng trong bảng
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < lstEmp.Count)
            {
                Employee emp = lstEmp[e.RowIndex];

                tbId.Text = emp.Id;
                tbName.Text = emp.Name;
                tbAge.Text = emp.Age.ToString();

                // Cập nhật RadioButton
                if (emp.Gender) rbNam.Checked = true;
                else rbNu.Checked = true;

                // Hiển thị ảnh
                if (!string.IsNullOrEmpty(emp.AvatarPath) && File.Exists(emp.AvatarPath))
                {
                    pbAvatar.ImageLocation = emp.AvatarPath;
                    currentAvatarPath = emp.AvatarPath;
                }
                else
                {
                    pbAvatar.Image = null;
                    currentAvatarPath = "";
                }
            }
        }
    }
}