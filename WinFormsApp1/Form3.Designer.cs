namespace WinFormsApp1
{
    partial class Form3
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            pbChicken.BackColor = Color.WhiteSmoke;
            pbChicken.Image = Properties.Resources.chicken;
            pbChicken.Location = new Point(230, 12);
            pbChicken.Name = "pbChicken";
            pbChicken.Size = new Size(100, 89);
            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.TabIndex = 0;
            pbChicken.TabStop = false;
            // 
            // pbEgg
            // 
            pbEgg.BackColor = Color.Gold;
            pbEgg.Image = Properties.Resources.egg;
            pbEgg.Location = new Point(256, 190);
            pbEgg.Name = "pbEgg";
            pbEgg.Size = new Size(30, 34);
            pbEgg.SizeMode = PictureBoxSizeMode.Zoom;
            pbEgg.TabIndex = 1;
            pbEgg.TabStop = false;
            // 
            // pbBasket
            // 
            pbBasket.BackColor = SystemColors.InactiveBorder;
            pbBasket.Image = Properties.Resources.basket1;
            pbBasket.Location = new Point(220, 500);
            pbBasket.Name = "pbBasket";
            pbBasket.Size = new Size(100, 50);
            pbBasket.SizeMode = PictureBoxSizeMode.Zoom;
            pbBasket.TabIndex = 2;
            pbBasket.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            lblScore.Location = new Point(12, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(128, 33);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score: 0";
            // 
            // tmEgg
            // 
            tmEgg.Enabled = true;
            tmEgg.Interval = 20;
            tmEgg.Tick += tmEgg_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(582, 553);
            Controls.Add(lblScore);
            Controls.Add(pbBasket);
            Controls.Add(pbEgg);
            Controls.Add(pbChicken);
            KeyPreview = true;
            Name = "Form3";
            Text = "Game Hứng Trứng";
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