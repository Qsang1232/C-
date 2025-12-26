namespace WinFormsApp1
{
    partial class Music
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1 (Tiêu đề trái)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách bài hát";
            // 
            // label2 (Tiêu đề phải)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh sách bài hát ưa thích";
            // 
            // lbSong (Danh sách Trái)
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.ItemHeight = 20;
            this.lbSong.Location = new System.Drawing.Point(30, 50);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(250, 304);
            this.lbSong.TabIndex = 0;
            // 
            // lbFavorite (Danh sách Phải)
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 20;
            this.lbFavorite.Location = new System.Drawing.Point(400, 50);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(250, 304);
            this.lbFavorite.TabIndex = 1;
            // 
            // btSelect (Nút >)
            // 
            this.btSelect.Location = new System.Drawing.Point(300, 80);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(80, 40);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btDeselect (Nút <)
            // 
            this.btDeselect.Location = new System.Drawing.Point(300, 130);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(80, 40);
            this.btDeselect.TabIndex = 3;
            this.btDeselect.Text = "<";
            this.btDeselect.UseVisualStyleBackColor = true;
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);
            // 
            // btSelectAll (Nút >>)
            // 
            this.btSelectAll.Location = new System.Drawing.Point(300, 200);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(80, 40);
            this.btSelectAll.TabIndex = 4;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // btDeselectAll (Nút <<)
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(300, 250);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(80, 40);
            this.btDeselectAll.TabIndex = 7;
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.btDeselectAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Name = "Music";
            this.Text = "Music Selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;     // >
        private System.Windows.Forms.Button btDeselect;   // <
        private System.Windows.Forms.Button btSelectAll;  // >>
        private System.Windows.Forms.Button btDeselectAll;// <<
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}