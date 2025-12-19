namespace WinFormsApp1
{
    partial class MayTinh
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
            tbDisplay = new TextBox();
            bt8 = new Button();
            bt9 = new Button();
            btDiv = new Button();
            bt4 = new Button();
            bt5 = new Button();
            bt6 = new Button();
            btMul = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btMinus = new Button();
            bt0 = new Button();
            btClear = new Button();
            btEquals = new Button();
            btPlus = new Button();
            bt7 = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Font = new Font("Microsoft Sans Serif", 20F);
            tbDisplay.Location = new Point(14, 16);
            tbDisplay.Margin = new Padding(3, 4, 3, 4);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(372, 45);
            tbDisplay.TabIndex = 0;
            tbDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // bt8
            // 
            bt8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt8.Location = new Point(109, 93);
            bt8.Margin = new Padding(3, 4, 3, 4);
            bt8.Name = "bt8";
            bt8.Size = new Size(86, 80);
            bt8.TabIndex = 2;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += btNumber_Click;
            // 
            // bt9
            // 
            bt9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt9.Location = new Point(203, 93);
            bt9.Margin = new Padding(3, 4, 3, 4);
            bt9.Name = "bt9";
            bt9.Size = new Size(86, 80);
            bt9.TabIndex = 3;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += btNumber_Click;
            // 
            // btDiv
            // 
            btDiv.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btDiv.Location = new Point(298, 93);
            btDiv.Margin = new Padding(3, 4, 3, 4);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(86, 80);
            btDiv.TabIndex = 4;
            btDiv.Text = "/";
            btDiv.UseVisualStyleBackColor = true;
            btDiv.Click += btOperator_Click;
            // 
            // bt4
            // 
            bt4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt4.Location = new Point(14, 187);
            bt4.Margin = new Padding(3, 4, 3, 4);
            bt4.Name = "bt4";
            bt4.Size = new Size(86, 80);
            bt4.TabIndex = 5;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += btNumber_Click;
            // 
            // bt5
            // 
            bt5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt5.Location = new Point(109, 187);
            bt5.Margin = new Padding(3, 4, 3, 4);
            bt5.Name = "bt5";
            bt5.Size = new Size(86, 80);
            bt5.TabIndex = 6;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += btNumber_Click;
            // 
            // bt6
            // 
            bt6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt6.Location = new Point(203, 187);
            bt6.Margin = new Padding(3, 4, 3, 4);
            bt6.Name = "bt6";
            bt6.Size = new Size(86, 80);
            bt6.TabIndex = 7;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += btNumber_Click;
            // 
            // btMul
            // 
            btMul.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btMul.Location = new Point(298, 187);
            btMul.Margin = new Padding(3, 4, 3, 4);
            btMul.Name = "btMul";
            btMul.Size = new Size(86, 80);
            btMul.TabIndex = 8;
            btMul.Text = "*";
            btMul.UseVisualStyleBackColor = true;
            btMul.Click += btOperator_Click;
            
            bt1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt1.Location = new Point(14, 280);
            bt1.Margin = new Padding(3, 4, 3, 4);
            bt1.Name = "bt1";
            bt1.Size = new Size(86, 80);
            bt1.TabIndex = 9;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += btNumber_Click;
           
            bt2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt2.Location = new Point(109, 280);
            bt2.Margin = new Padding(3, 4, 3, 4);
            bt2.Name = "bt2";
            bt2.Size = new Size(86, 80);
            bt2.TabIndex = 10;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += btNumber_Click;
           
            bt3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt3.Location = new Point(203, 280);
            bt3.Margin = new Padding(3, 4, 3, 4);
            bt3.Name = "bt3";
            bt3.Size = new Size(86, 80);
            bt3.TabIndex = 11;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += btNumber_Click;
           
            btMinus.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btMinus.Location = new Point(298, 280);
            btMinus.Margin = new Padding(3, 4, 3, 4);
            btMinus.Name = "btMinus";
            btMinus.Size = new Size(86, 80);
            btMinus.TabIndex = 12;
            btMinus.Text = "-";
            btMinus.UseVisualStyleBackColor = true;
            btMinus.Click += btOperator_Click;
           
            bt0.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt0.Location = new Point(14, 373);
            bt0.Margin = new Padding(3, 4, 3, 4);
            bt0.Name = "bt0";
            bt0.Size = new Size(86, 80);
            bt0.TabIndex = 13;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += btNumber_Click;
            
            btClear.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btClear.Location = new Point(109, 373);
            btClear.Margin = new Padding(3, 4, 3, 4);
            btClear.Name = "btClear";
            btClear.Size = new Size(86, 80);
            btClear.TabIndex = 14;
            btClear.Text = "C";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            
            btEquals.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btEquals.Location = new Point(203, 373);
            btEquals.Margin = new Padding(3, 4, 3, 4);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(86, 80);
            btEquals.TabIndex = 15;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += btEquals_Click;
           
            btPlus.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btPlus.Location = new Point(298, 373);
            btPlus.Margin = new Padding(3, 4, 3, 4);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(86, 80);
            btPlus.TabIndex = 16;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btOperator_Click;
           
            bt7.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            bt7.Location = new Point(14, 93);
            bt7.Margin = new Padding(3, 4, 3, 4);
            bt7.Name = "bt7";
            bt7.Size = new Size(86, 80);
            bt7.TabIndex = 1;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += btNumber_Click;
         
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 480);
            Controls.Add(btPlus);
            Controls.Add(btEquals);
            Controls.Add(btClear);
            Controls.Add(bt0);
            Controls.Add(btMinus);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(btMul);
            Controls.Add(bt6);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(btDiv);
            Controls.Add(bt9);
            Controls.Add(bt8);
            Controls.Add(bt7);
            Controls.Add(tbDisplay);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button btPlus;
        private Button bt7;
    }
}