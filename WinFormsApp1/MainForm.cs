using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Trang trí thêm cho Form chính đẹp hơn
            this.Text = "Tổng hợp bài tập Windows Form";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Minimized; // Mở to hết cỡ
        }


        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void TTĐG_Click(object sender, EventArgs e)
        {
            TinhToanDG formForm2 = new TinhToanDG();
            formForm2.ShowDialog();
        }

        private void GameTrung_Click(object sender, EventArgs e)
        {
            GameTrung formForm3 = new GameTrung();
            formForm3.ShowDialog();
        }

        private void QLSV_Click(object sender, EventArgs e)
        {
            QLSV formQLSV = new QLSV();
            formQLSV.ShowDialog();
        }

        private void MayTinhBoTui_Click(object sender, EventArgs e)
        {
            MayTinh formForm1 = new MayTinh();
            formForm1.ShowDialog();
        }
    }
}