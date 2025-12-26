using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class TimerArticle
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
            this.components = new System.ComponentModel.Container();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.tmStopwatch = new System.Windows.Forms.Timer(this.components);
            this.btStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplay.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(0, 40);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(582, 150);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "00:00";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStart.FlatAppearance.BorderSize = 0;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btStart.ForeColor = System.Drawing.Color.White;
            this.btStart.Location = new System.Drawing.Point(120, 230);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(150, 60);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tmStopwatch
            // 
            this.tmStopwatch.Tick += new System.EventHandler(this.tmStopwatch_Tick);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.Gray;
            this.btStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStop.Enabled = false;
            this.btStop.FlatAppearance.BorderSize = 0;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btStop.ForeColor = System.Drawing.Color.White;
            this.btStop.Location = new System.Drawing.Point(310, 230);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(150, 60);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // TimerArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lblDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TimerArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồng Hồ Bấm Giờ";
            this.Load += new System.EventHandler(this.Timer_Article_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer tmStopwatch;
        private System.Windows.Forms.Button btStop;
    }
}