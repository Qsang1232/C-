using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // --- Các nút cũ (giữ nguyên) ---
        private void MayTinhBoTui_Click(object sender, EventArgs e) { new MayTinh().ShowDialog(); }
        private void TTĐG_Click(object sender, EventArgs e) { new TinhToanDG().ShowDialog(); }
        private void GameTrung_Click(object sender, EventArgs e) { new GameTrung().ShowDialog(); }
        private void QLSV_Click(object sender, EventArgs e) { new QLSV().ShowDialog(); }
        private void btMusic_Click(object sender, EventArgs e) { new Music().ShowDialog(); }
        private void btTimer_Click(object sender, EventArgs e) { new TimerArticle().ShowDialog(); }
        private void btQLNS_Click(object sender, EventArgs e) { new QLNS().ShowDialog(); }

        // Bài Date (nếu class tên là DateTimePicker thì phải dùng tên đầy đủ)
        private void btDate_Click(object sender, EventArgs e)
        {
            // Giả sử Namespace là WinFormsApp1
            WinFormsApp1.DateTimePicker frm = new WinFormsApp1.DateTimePicker();
            frm.ShowDialog();
        }

        // --- NÚT MỚI: COMBOBOX ---
        private void btCombo_Click(object sender, EventArgs e)
        {
            // LƯU Ý QUAN TRỌNG:
            // Vì bạn đặt tên form là "ComboBox", nó trùng với công cụ ComboBox của hệ thống.
            // Nên bắt buộc phải thêm tên Project (WinFormsApp1) đằng trước để phân biệt.

            WinFormsApp1.ComboBox frm = new WinFormsApp1.ComboBox();
            frm.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}