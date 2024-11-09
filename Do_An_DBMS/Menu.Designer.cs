namespace Do_An_DBMS
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnChuHo = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnDanCu = new System.Windows.Forms.Button();
            this.btnCanHo = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 504);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKetNoi);
            this.panel2.Controls.Add(this.btnChuHo);
            this.panel2.Controls.Add(this.btnHoaDon);
            this.panel2.Controls.Add(this.btnDanCu);
            this.panel2.Controls.Add(this.btnCanHo);
            this.panel2.Controls.Add(this.btnDoanhThu);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 504);
            this.panel2.TabIndex = 0;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.BackColor = System.Drawing.Color.Silver;
            this.btnKetNoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKetNoi.Location = new System.Drawing.Point(0, 463);
            this.btnKetNoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(296, 42);
            this.btnKetNoi.TabIndex = 12;
            this.btnKetNoi.Text = "Kết Nối";
            this.btnKetNoi.UseVisualStyleBackColor = false;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnChuHo
            // 
            this.btnChuHo.BackColor = System.Drawing.Color.Silver;
            this.btnChuHo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChuHo.Location = new System.Drawing.Point(0, 421);
            this.btnChuHo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChuHo.Name = "btnChuHo";
            this.btnChuHo.Size = new System.Drawing.Size(296, 42);
            this.btnChuHo.TabIndex = 11;
            this.btnChuHo.Text = "Quản Lý Chủ Hộ";
            this.btnChuHo.UseVisualStyleBackColor = false;
            this.btnChuHo.Click += new System.EventHandler(this.btnChuHo_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Silver;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 379);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(296, 42);
            this.btnHoaDon.TabIndex = 10;
            this.btnHoaDon.Text = "Quản Lý Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnDanCu
            // 
            this.btnDanCu.BackColor = System.Drawing.Color.Silver;
            this.btnDanCu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanCu.Location = new System.Drawing.Point(0, 333);
            this.btnDanCu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDanCu.Name = "btnDanCu";
            this.btnDanCu.Size = new System.Drawing.Size(296, 46);
            this.btnDanCu.TabIndex = 9;
            this.btnDanCu.Text = "Quản Lý Dân Cư";
            this.btnDanCu.UseVisualStyleBackColor = false;
            this.btnDanCu.Click += new System.EventHandler(this.btnDanCu_Click);
            // 
            // btnCanHo
            // 
            this.btnCanHo.BackColor = System.Drawing.Color.Silver;
            this.btnCanHo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCanHo.Location = new System.Drawing.Point(0, 291);
            this.btnCanHo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCanHo.Name = "btnCanHo";
            this.btnCanHo.Size = new System.Drawing.Size(296, 42);
            this.btnCanHo.TabIndex = 8;
            this.btnCanHo.Text = "Quản Lý Căn Hộ";
            this.btnCanHo.UseVisualStyleBackColor = false;
            this.btnCanHo.Click += new System.EventHandler(this.btnCanHo_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.Silver;
            this.btnDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThu.Location = new System.Drawing.Point(0, 243);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(296, 48);
            this.btnDoanhThu.TabIndex = 7;
            this.btnDoanhThu.Text = "Quản Lý Doanh Thu";
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1142, 504);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Button btnChuHo;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnDanCu;
        private System.Windows.Forms.Button btnCanHo;
        private System.Windows.Forms.Button btnDoanhThu;
    }
}