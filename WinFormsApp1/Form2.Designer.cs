namespace WinFormsApp1
{
    partial class Form2
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
            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
          
            this.btCong.Location = new System.Drawing.Point(184, 253);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(94, 29);
            this.btCong.TabIndex = 0;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click); 
           
            this.btNhan.Location = new System.Drawing.Point(345, 253);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(94, 29);
            this.btNhan.TabIndex = 1;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click); 
            
            this.btThoat.Location = new System.Drawing.Point(502, 253);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(94, 29);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click); 
           
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập X";
           
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết Quả";
            
            this.tbSoX.Location = new System.Drawing.Point(194, 95);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(402, 27);
            this.tbSoX.TabIndex = 6;
            
            this.tbSoY.Location = new System.Drawing.Point(194, 151);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(402, 27);
            this.tbSoY.TabIndex = 7;
           
            this.tbKetQua.Location = new System.Drawing.Point(194, 201);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.ReadOnly = true; 
            this.tbKetQua.Size = new System.Drawing.Size(402, 27);
            this.tbKetQua.TabIndex = 8;
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Name = "Form2";
            this.Text = "Tính toán đơn giản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbKetQua;
    }
}