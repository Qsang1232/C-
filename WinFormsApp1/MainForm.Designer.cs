namespace WinFormsApp1
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            hỆTHỐNGToolStripMenuItem = new ToolStripMenuItem();
            tHOÁTToolStripMenuItem = new ToolStripMenuItem();
            bÀITẬPToolStripMenuItem = new ToolStripMenuItem();
            MáyTínhBỏTúi = new ToolStripMenuItem();
            TTĐG = new ToolStripMenuItem();
            GameTrung = new ToolStripMenuItem();
            QLSV = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hỆTHỐNGToolStripMenuItem, bÀITẬPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hỆTHỐNGToolStripMenuItem
            // 
            hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tHOÁTToolStripMenuItem });
            hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
            hỆTHỐNGToolStripMenuItem.Size = new Size(101, 24);
            hỆTHỐNGToolStripMenuItem.Text = "HỆ  THỐNG";
            // 
            // tHOÁTToolStripMenuItem
            // 
            tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
            tHOÁTToolStripMenuItem.Size = new Size(139, 26);
            tHOÁTToolStripMenuItem.Text = "THOÁT";
            // 
            // bÀITẬPToolStripMenuItem
            // 
            bÀITẬPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MáyTínhBỏTúi, TTĐG, GameTrung, QLSV });
            bÀITẬPToolStripMenuItem.Name = "bÀITẬPToolStripMenuItem";
            bÀITẬPToolStripMenuItem.Size = new Size(76, 24);
            bÀITẬPToolStripMenuItem.Text = "BÀI TẬP";
            // 
            // MáyTínhBỏTúi
            // 
            MáyTínhBỏTúi.Name = "MáyTínhBỏTúi";
            MáyTínhBỏTúi.Size = new Size(224, 26);
            MáyTínhBỏTúi.Text = "Máy tính bỏ túi";
            MáyTínhBỏTúi.Click += MayTinhBoTui_Click;
            // 
            // TTĐG
            // 
            TTĐG.Name = "TTĐG";
            TTĐG.Size = new Size(224, 26);
            TTĐG.Text = "Tính toán đơn giản";
            TTĐG.Click += TTĐG_Click;
            // 
            // GameTrung
            // 
            GameTrung.Name = "GameTrung";
            GameTrung.Size = new Size(224, 26);
            GameTrung.Text = "Game Hứng Trứng";
            GameTrung.Click += GameTrung_Click;
            // 
            // QLSV
            // 
            QLSV.Name = "QLSV";
            QLSV.Size = new Size(224, 26);
            QLSV.Text = "Quản lý Sinh viên";
            QLSV.Click += QLSV_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
        private ToolStripMenuItem tHOÁTToolStripMenuItem;
        private ToolStripMenuItem bÀITẬPToolStripMenuItem;
        private ToolStripMenuItem MáyTínhBỏTúi;
        private ToolStripMenuItem TTĐG;
        private ToolStripMenuItem GameTrung;
        private ToolStripMenuItem QLSV;
    }
}