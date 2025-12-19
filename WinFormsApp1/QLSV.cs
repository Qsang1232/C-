using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class QLSV : Form
    {
       
        private DataGridView dgvSinhVien;
        private TextBox txtMaSV, txtTenSV, txtLop, txtDiem;
        private Button btnThem, btnXoa, btnSua;
        private Label lblTitle;

      
        private Color primaryColor = Color.FromArgb(52, 152, 219);
        private Color dangerColor = Color.FromArgb(231, 76, 60);
        private Color bgColor = Color.FromArgb(236, 240, 241);
        private Color gridHeaderColor = Color.FromArgb(44, 62, 80);
        private Font mainFont = new Font("Segoe UI", 10, FontStyle.Regular);
        private Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold);

        
        public class SinhVien
        {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            public string Lop { get; set; }
            public double Diem { get; set; }
        }

        List<SinhVien> danhSachSV = new List<SinhVien>();

        public QLSV()
        {
          
            TaoGiaoDienHienDai();

         
            danhSachSV.Add(new SinhVien { MaSV = "SV01", TenSV = "Nguyen Van A", Lop = "CNTT K15", Diem = 8.5 });
            danhSachSV.Add(new SinhVien { MaSV = "SV02", TenSV = "Tran Thi B", Lop = "QTKD K15", Diem = 7.0 });
            HienThiLenBang();
        }

     
        void HienThiLenBang()
        {
            var source = new BindingSource();
            source.DataSource = danhSachSV;
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = source;

            dgvSinhVien.Columns["MaSV"].HeaderText = "Mã Sinh Viên";
            dgvSinhVien.Columns["TenSV"].HeaderText = "Họ và Tên";
            dgvSinhVien.Columns["Lop"].HeaderText = "Lớp Học";
            dgvSinhVien.Columns["Diem"].HeaderText = "Điểm TB";
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text)) { MessageBox.Show("Vui lòng nhập Mã SV"); return; }

            SinhVien sv = new SinhVien();
            sv.MaSV = txtMaSV.Text;
            sv.TenSV = txtTenSV.Text;
            sv.Lop = txtLop.Text;

            if (double.TryParse(txtDiem.Text, out double d))
                sv.Diem = d;
            else { MessageBox.Show("Điểm phải là số"); return; }

            danhSachSV.Add(sv);
            HienThiLenBang();
            XoaTrangO();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text;
            SinhVien svXoa = danhSachSV.Find(x => x.MaSV == ma);
            if (svXoa != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    danhSachSV.Remove(svXoa);
                    HienThiLenBang();
                    XoaTrangO();
                }
            }
            else MessageBox.Show("Không tìm thấy Mã SV này để xóa!");
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtTenSV.Text = row.Cells["TenSV"].Value?.ToString();
                txtLop.Text = row.Cells["Lop"].Value?.ToString();
                txtDiem.Text = row.Cells["Diem"].Value?.ToString();
            }
        }

        void XoaTrangO() { txtMaSV.Clear(); txtTenSV.Clear(); txtLop.Clear(); txtDiem.Clear(); txtMaSV.Focus(); }

  
        private void TaoGiaoDienHienDai()
        {
            this.Size = new Size(600, 650);
            this.Text = "Quản Lý Sinh Viên Pro";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = bgColor;
            this.Font = mainFont;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            lblTitle = new Label();
            lblTitle.Text = "QUẢN LÝ HỒ SƠ SINH VIÊN";
            lblTitle.Font = titleFont;
            lblTitle.ForeColor = gridHeaderColor;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point((this.ClientSize.Width - 280) / 2, 20);
            this.Controls.Add(lblTitle);

            dgvSinhVien = new DataGridView();
            dgvSinhVien.Location = new Point(20, 70);
            dgvSinhVien.Size = new Size(545, 250);
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.BorderStyle = BorderStyle.None;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = false;

            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = gridHeaderColor;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSinhVien.ColumnHeadersHeight = 40;

            dgvSinhVien.RowTemplate.Height = 30;
            dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvSinhVien.DefaultCellStyle.SelectionBackColor = primaryColor;
            dgvSinhVien.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvSinhVien.CellClick += Dgv_CellClick;
            this.Controls.Add(dgvSinhVien);

            Panel pnlInput = new Panel();
            pnlInput.Location = new Point(20, 340);
            pnlInput.Size = new Size(545, 200);
            pnlInput.BackColor = Color.White;
            this.Controls.Add(pnlInput);

            TaoOInput(pnlInput, "Mã Sinh Viên:", 20, ref txtMaSV);
            TaoOInput(pnlInput, "Họ và Tên:", 60, ref txtTenSV);
            TaoOInput(pnlInput, "Lớp Học:", 100, ref txtLop);
            TaoOInput(pnlInput, "Điểm TB:", 140, ref txtDiem);

            int btnY = 560;
            btnThem = TaoNut("THÊM MỚI", new Point(100, btnY), primaryColor);
            btnThem.Click += BtnThem_Click;

            btnSua = TaoNut("CẬP NHẬT", new Point(250, btnY), Color.FromArgb(46, 204, 113));
            btnSua.Click += (s, e) => { BtnThem_Click(s, e); };

            btnXoa = TaoNut("XÓA BỎ", new Point(400, btnY), dangerColor);
            btnXoa.Click += BtnXoa_Click;

            this.Controls.Add(btnThem);
            this.Controls.Add(btnSua);
            this.Controls.Add(btnXoa);
        }

        void TaoOInput(Panel parent, string labelText, int y, ref TextBox txtBox)
        {
            Label lbl = new Label();
            lbl.Text = labelText;
            lbl.Location = new Point(30, y + 3);
            lbl.AutoSize = true;
            lbl.ForeColor = Color.DimGray;

            txtBox = new TextBox();
            txtBox.Location = new Point(150, y);
            txtBox.Width = 350;
            txtBox.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            txtBox.BorderStyle = BorderStyle.FixedSingle;

            parent.Controls.Add(lbl);
            parent.Controls.Add(txtBox);
        }

        Button TaoNut(string text, Point loc, Color backColor)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Location = loc;
            btn.Size = new Size(120, 40);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => { btn.BackColor = ControlPaint.Light(backColor); };
            btn.MouseLeave += (s, e) => { btn.BackColor = backColor; };
            return btn;
        }
    }
}