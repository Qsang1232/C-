namespace WinFormsApp1
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel(); 
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // label3 (Tiêu đề LOGIN)
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80))))); // Màu xanh đen
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 80);
            this.label3.TabIndex = 4;
            this.label3.Text = "ĐĂNG NHẬP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // label1 (Nhãn Username)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(45, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản:";

            // 
            // txtUser (Ô nhập Username)
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.Location = new System.Drawing.Point(45, 115);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(290, 27);
            this.txtUser.TabIndex = 0;

            // 
            // label2 (Nhãn Password)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(45, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";

            // 
            // txtPass (Ô nhập Password)
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(45, 185);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(290, 27);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true; // Dùng ký tự mật khẩu chấm tròn mặc định của Win

            // 
            // btnLogin (Nút Đăng nhập)
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219))))); // Màu xanh dương phẳng
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand; // Đổi chuột thành bàn tay
            this.btnLogin.FlatAppearance.BorderSize = 0; // Bỏ viền
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(45, 245);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(290, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // Login (Cài đặt Form)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White; // Nền trắng sang trọng
            this.ClientSize = new System.Drawing.Size(380, 350);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3); // Tiêu đề
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Cố định khung, không cho kéo dãn
            this.MaximizeBox = false; // Tắt nút phóng to
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Hiện giữa màn hình
            this.Text = "Hệ thống quản lý";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
    }
}