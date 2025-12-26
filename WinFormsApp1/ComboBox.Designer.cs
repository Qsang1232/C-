namespace WinFormsApp1
{
    partial class ComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cb_Faculty = new System.Windows.Forms.ComboBox();
            tbDisplay = new TextBox();
            btOK = new Button();
            btClear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Items.AddRange(new object[] { "Công Nghệ Thông Tin", "Điện", "Thực Phẩm", "May", "Cơ Khí" });
            cb_Faculty.Location = new Point(110, 56);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(359, 28);
            cb_Faculty.TabIndex = 0;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(110, 107);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.ReadOnly = true;
            tbDisplay.Size = new Size(359, 168);
            tbDisplay.TabIndex = 1;
            // 
            // btOK
            // 
            btOK.Location = new Point(110, 281);
            btOK.Name = "btOK";
            btOK.Size = new Size(120, 27);
            btOK.TabIndex = 2;
            btOK.Text = "Ok";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(349, 281);
            btClear.Name = "btClear";
            btClear.Size = new Size(120, 27);
            btClear.TabIndex = 3;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 18);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 4;
            label1.Text = "CHỌN KHOA CỦA BẠN";
            // 
            // ComboBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btClear);
            Controls.Add(btOK);
            Controls.Add(tbDisplay);
            Controls.Add(cb_Faculty);
            Name = "ComboBox";
            Text = "ComboBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private TextBox tbDisplay;
        private Button btOK;
        private Button btClear;
        private Label label1;
    }
}