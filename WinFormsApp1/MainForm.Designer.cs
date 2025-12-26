namespace WinFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.btMayTinh = new System.Windows.Forms.Button();
            this.btTinhToan = new System.Windows.Forms.Button();
            this.btGameTrung = new System.Windows.Forms.Button();
            this.btQLSV = new System.Windows.Forms.Button();
            this.btMusic = new System.Windows.Forms.Button();
            this.btTimer = new System.Windows.Forms.Button();
            this.btDate = new System.Windows.Forms.Button();
            this.btQLNS = new System.Windows.Forms.Button();
            // Nút Mới
            this.btCombo = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Blue;
            this.labelTitle.Location = new System.Drawing.Point(230, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(350, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "MENU BÀI TẬP C#";
            // 
            // btMayTinh (1)
            // 
            this.btMayTinh.BackColor = System.Drawing.Color.LightBlue;
            this.btMayTinh.Location = new System.Drawing.Point(100, 80);
            this.btMayTinh.Name = "btMayTinh";
            this.btMayTinh.Size = new System.Drawing.Size(250, 60);
            this.btMayTinh.Text = "1. Máy Tính Bỏ Túi";
            this.btMayTinh.UseVisualStyleBackColor = false;
            this.btMayTinh.Click += new System.EventHandler(this.MayTinhBoTui_Click);
            // 
            // btTinhToan (2)
            // 
            this.btTinhToan.BackColor = System.Drawing.Color.LightGreen;
            this.btTinhToan.Location = new System.Drawing.Point(450, 80);
            this.btTinhToan.Name = "btTinhToan";
            this.btTinhToan.Size = new System.Drawing.Size(250, 60);
            this.btTinhToan.Text = "2. Tính Toán Đơn Giản";
            this.btTinhToan.UseVisualStyleBackColor = false;
            this.btTinhToan.Click += new System.EventHandler(this.TTĐG_Click);
            // 
            // btGameTrung (3)
            // 
            this.btGameTrung.BackColor = System.Drawing.Color.Orange;
            this.btGameTrung.Location = new System.Drawing.Point(100, 160);
            this.btGameTrung.Name = "btGameTrung";
            this.btGameTrung.Size = new System.Drawing.Size(250, 60);
            this.btGameTrung.Text = "3. Game Hứng Trứng";
            this.btGameTrung.UseVisualStyleBackColor = false;
            this.btGameTrung.Click += new System.EventHandler(this.GameTrung_Click);
            // 
            // btQLSV (4)
            // 
            this.btQLSV.BackColor = System.Drawing.Color.Pink;
            this.btQLSV.Location = new System.Drawing.Point(450, 160);
            this.btQLSV.Name = "btQLSV";
            this.btQLSV.Size = new System.Drawing.Size(250, 60);
            this.btQLSV.Text = "4. Quản Lý Sinh Viên";
            this.btQLSV.UseVisualStyleBackColor = false;
            this.btQLSV.Click += new System.EventHandler(this.QLSV_Click);
            // 
            // btMusic (5)
            // 
            this.btMusic.BackColor = System.Drawing.Color.Violet;
            this.btMusic.Location = new System.Drawing.Point(100, 240);
            this.btMusic.Name = "btMusic";
            this.btMusic.Size = new System.Drawing.Size(250, 60);
            this.btMusic.Text = "5. Music ListBox";
            this.btMusic.UseVisualStyleBackColor = false;
            this.btMusic.Click += new System.EventHandler(this.btMusic_Click);
            // 
            // btTimer (6)
            // 
            this.btTimer.BackColor = System.Drawing.Color.Yellow;
            this.btTimer.Location = new System.Drawing.Point(450, 240);
            this.btTimer.Name = "btTimer";
            this.btTimer.Size = new System.Drawing.Size(250, 60);
            this.btTimer.Text = "6. Timer Đồng Hồ";
            this.btTimer.UseVisualStyleBackColor = false;
            this.btTimer.Click += new System.EventHandler(this.btTimer_Click);
            // 
            // btDate (7)
            // 
            this.btDate.BackColor = System.Drawing.Color.Cyan;
            this.btDate.Location = new System.Drawing.Point(100, 320);
            this.btDate.Name = "btDate";
            this.btDate.Size = new System.Drawing.Size(250, 60);
            this.btDate.Text = "7. DateTimePicker";
            this.btDate.UseVisualStyleBackColor = false;
            this.btDate.Click += new System.EventHandler(this.btDate_Click);
            // 
            // btQLNS (8)
            // 
            this.btQLNS.BackColor = System.Drawing.Color.MediumPurple;
            this.btQLNS.Location = new System.Drawing.Point(450, 320);
            this.btQLNS.Name = "btQLNS";
            this.btQLNS.Size = new System.Drawing.Size(250, 60);
            this.btQLNS.Text = "8. Quản Lý Nhân Sự (Ảnh)";
            this.btQLNS.UseVisualStyleBackColor = false;
            this.btQLNS.Click += new System.EventHandler(this.btQLNS_Click);
            // 
            // btCombo (9 - NÚT MỚI)
            // 
            this.btCombo.BackColor = System.Drawing.Color.NavajoWhite;
            this.btCombo.Location = new System.Drawing.Point(100, 400); // Cột Trái, Hàng 5
            this.btCombo.Name = "btCombo";
            this.btCombo.Size = new System.Drawing.Size(250, 60);
            this.btCombo.TabIndex = 8;
            this.btCombo.Text = "9. ComboBox Khoa";
            this.btCombo.UseVisualStyleBackColor = false;
            this.btCombo.Click += new System.EventHandler(this.btCombo_Click);
            // 
            // btThoat (Nút thoát chuyển sang phải)
            // 
            this.btThoat.BackColor = System.Drawing.Color.Red;
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btThoat.Location = new System.Drawing.Point(450, 400); // Cột Phải, Hàng 5
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(250, 60);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500); // Tăng chiều cao lên 500
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btCombo); // Thêm nút mới
            this.Controls.Add(this.btQLNS);
            this.Controls.Add(this.btDate);
            this.Controls.Add(this.btTimer);
            this.Controls.Add(this.btMusic);
            this.Controls.Add(this.btQLSV);
            this.Controls.Add(this.btGameTrung);
            this.Controls.Add(this.btTinhToan);
            this.Controls.Add(this.btMayTinh);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng hợp bài tập";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btMayTinh;
        private System.Windows.Forms.Button btTinhToan;
        private System.Windows.Forms.Button btGameTrung;
        private System.Windows.Forms.Button btQLSV;
        private System.Windows.Forms.Button btMusic;
        private System.Windows.Forms.Button btTimer;
        private System.Windows.Forms.Button btDate;
        private System.Windows.Forms.Button btQLNS;
        private System.Windows.Forms.Button btCombo; // Khai báo biến nút mới
        private System.Windows.Forms.Button btThoat;
    }
}