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
            txtUser = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            panel1 = new Panel();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 11F);
            txtUser.Location = new Point(51, 153);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(331, 32);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.Location = new Point(51, 247);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(331, 32);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(51, 120);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(51, 213);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(434, 107);
            label3.TabIndex = 4;
            label3.Text = "ĐĂNG NHẬP";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(51, 327);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(331, 53);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 419);
            label4.Name = "label4";
            label4.Size = new Size(168, 23);
            label4.TabIndex = 6;
            label4.Text = "TK:admin MK;123";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 467);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private Label label4;
    }
}