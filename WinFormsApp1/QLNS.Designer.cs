namespace WinFormsApp1
{
    partial class QLNS
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
            groupBoxInfo = new GroupBox();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            btBrowse = new Button();
            pbAvatar = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbAge = new TextBox();
            tbName = new TextBox();
            tbId = new TextBox();
            btAddNew = new Button();
            btDelete = new Button();
            groupBoxList = new GroupBox();
            dgvEmployee = new DataGridView();
            groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(rbNu);
            groupBoxInfo.Controls.Add(rbNam);
            groupBoxInfo.Controls.Add(btBrowse);
            groupBoxInfo.Controls.Add(pbAvatar);
            groupBoxInfo.Controls.Add(label3);
            groupBoxInfo.Controls.Add(label2);
            groupBoxInfo.Controls.Add(label1);
            groupBoxInfo.Controls.Add(tbAge);
            groupBoxInfo.Controls.Add(tbName);
            groupBoxInfo.Controls.Add(tbId);
            groupBoxInfo.Controls.Add(btAddNew);
            groupBoxInfo.Controls.Add(btDelete);
            groupBoxInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(776, 230);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông Tin Nhân Viên";
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Font = new Font("Segoe UI", 9F);
            rbNu.Location = new Point(400, 145);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 5;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Checked = true;
            rbNam.Font = new Font("Segoe UI", 9F);
            rbNam.Location = new Point(320, 145);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 24);
            rbNam.TabIndex = 4;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // btBrowse
            // 
            btBrowse.Font = new Font("Segoe UI", 9F);
            btBrowse.Location = new Point(25, 185);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(120, 30);
            btBrowse.TabIndex = 8;
            btBrowse.Text = "Chọn Ảnh...";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.WhiteSmoke;
            pbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAvatar.Location = new Point(25, 30);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(120, 150);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.TabIndex = 0;
            pbAvatar.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(180, 110);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 12;
            label3.Text = "Tuổi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(180, 70);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 11;
            label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(180, 30);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 10;
            label1.Text = "Mã NV:";
            // 
            // tbAge
            // 
            tbAge.Font = new Font("Segoe UI", 9F);
            tbAge.Location = new Point(260, 107);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 27);
            tbAge.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 9F);
            tbName.Location = new Point(260, 67);
            tbName.Name = "tbName";
            tbName.Size = new Size(300, 27);
            tbName.TabIndex = 2;
            // 
            // tbId
            // 
            tbId.Font = new Font("Segoe UI", 9F);
            tbId.Location = new Point(260, 27);
            tbId.Name = "tbId";
            tbId.Size = new Size(150, 27);
            tbId.TabIndex = 1;
            // 
            // btAddNew
            // 
            btAddNew.BackColor = Color.MediumSeaGreen;
            btAddNew.FlatStyle = FlatStyle.Flat;
            btAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btAddNew.ForeColor = Color.White;
            btAddNew.Location = new Point(600, 30);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(150, 45);
            btAddNew.TabIndex = 6;
            btAddNew.Text = "THÊM MỚI";
            btAddNew.UseVisualStyleBackColor = false;
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.IndianRed;
            btDelete.FlatStyle = FlatStyle.Flat;
            btDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btDelete.ForeColor = Color.White;
            btDelete.Location = new Point(600, 90);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(150, 45);
            btDelete.TabIndex = 7;
            btDelete.Text = "XÓA";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(dgvEmployee);
            groupBoxList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxList.Location = new Point(12, 250);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(776, 188);
            groupBoxList.TabIndex = 1;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Danh Sách Nhân Viên";
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.BackgroundColor = Color.White;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Dock = DockStyle.Fill;
            dgvEmployee.Location = new Point(3, 26);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(770, 159);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // QLNS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxList);
            Controls.Add(groupBoxInfo);
            Name = "QLNS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Sự";
            Load += QLNS_Load;
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo;
        private PictureBox pbAvatar;
        private Button btBrowse;
        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private Button btAddNew;
        private Button btDelete;
        private GroupBox groupBoxList;
        private DataGridView dgvEmployee;
    }
}