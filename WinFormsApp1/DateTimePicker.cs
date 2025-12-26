using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        // Sự kiện click nút OK: Đổi tiêu đề thành Ngày Dài (LongDate)
        // Ví dụ: Saturday, September 30, 2017
        private void btOK_Click(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToLongDateString();
        }

        // Sự kiện thay đổi ngày: Đổi tiêu đề thành Ngày Ngắn (ShortDate)
        // Ví dụ: 30/09/2017
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}