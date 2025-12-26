namespace WinFormsApp1
{
    partial class GameTrung
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
            components = new System.ComponentModel.Container();
            pbChicken = new PictureBox();
            pbEgg = new PictureBox();
            pbBasket = new PictureBox();
            lblScore = new Label();
            tmEgg = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEgg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBasket).BeginInit();
            SuspendLayout();

            // 
            // pbChicken
            // 
            // Đặt nền trong suốt để thấy màu trời xanh phía sau
            pbChicken.BackColor = Color.Transparent;
            pbChicken.Image = Properties.Resources.chicken;
            pbChicken.Location = new Point(230, 12);
            pbChicken.Name = "pbChicken";
            pbChicken.Size = new Size(100, 89);
            // Dùng Zoom để giữ tỷ lệ ảnh, không bị méo gà
            pbChicken.SizeMode = PictureBoxSizeMode.Zoom;
            pbChicken.TabIndex = 0;
            pbChicken.TabStop = false;

            // 
            // pbEgg
            // 
            pbEgg.BackColor = Color.Transparent; // Nền trong suốt
            pbEgg.Image = Properties.Resources.egg;
            pbEgg.Location = new Point(256, 190);
            pbEgg.Name = "pbEgg";
            pbEgg.Size = new Size(30, 40); // Chỉnh lại tỷ lệ cho giống quả trứng hơn
            pbEgg.SizeMode = PictureBoxSizeMode.Zoom;
            pbEgg.TabIndex = 1;
            pbEgg.TabStop = false;

            // 
            // pbBasket
            // 
            pbBasket.BackColor = Color.Transparent; // Nền trong suốt
            pbBasket.Image = Properties.Resources.basket1;
            pbBasket.Location = new Point(216, 449);
            pbBasket.Name = "pbBasket";
            pbBasket.Size = new Size(135, 66);
            pbBasket.SizeMode = PictureBoxSizeMode.Zoom;
            pbBasket.TabIndex = 2;
            pbBasket.TabStop = false;
            pbBasket.Click += pbBasket_Click;

            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            // Cho label nền trong suốt để đẹp hơn
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblScore.ForeColor = Color.DarkBlue; // Đổi màu chữ cho dễ nhìn trên nền xanh
            lblScore.Location = new Point(12, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(118, 38);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score: 0";

            // 
            // tmEgg
            // 
            tmEgg.Enabled = true;
            tmEgg.Interval = 20;
            tmEgg.Tick += tmEgg_Tick;

            // 
            // GameTrung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue; // Màu bầu trời
            ClientSize = new Size(582, 553);
            Controls.Add(lblScore);
            Controls.Add(pbBasket);
            Controls.Add(pbEgg);
            Controls.Add(pbChicken);
            KeyPreview = true;
            Name = "GameTrung";
            Text = "Game Hứng Trứng";
            Load += Form3_Load;
            KeyDown += Form3_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEgg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBasket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbChicken;
        private System.Windows.Forms.PictureBox pbEgg;
        private System.Windows.Forms.PictureBox pbBasket;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmEgg;
    }
}