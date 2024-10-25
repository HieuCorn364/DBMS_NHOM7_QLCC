namespace Do_An_DBMS
{
    partial class DanhSachCanHo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.data_CanHo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThemCanHo = new System.Windows.Forms.Button();
            this.btb_reloaddata = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_xoacanho = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.txt_khucanho = new System.Windows.Forms.TextBox();
            this.txt_maloaicanho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_CanHo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 100);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(412, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Căn Hộ";
            // 
            // data_CanHo
            // 
            this.data_CanHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_CanHo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data_CanHo.Location = new System.Drawing.Point(0, 203);
            this.data_CanHo.Name = "data_CanHo";
            this.data_CanHo.RowHeadersWidth = 51;
            this.data_CanHo.RowTemplate.Height = 24;
            this.data_CanHo.Size = new System.Drawing.Size(1072, 335);
            this.data_CanHo.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaCanHo";
            this.Column1.HeaderText = "Mã Căn Hộ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TrangThaiSuDung";
            this.Column2.HeaderText = "Trạng Thái Sử Dụng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MaKhuCanHo";
            this.Column3.HeaderText = "Mã Khu Căn Hộ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "MaLoaiCanHo";
            this.Column4.HeaderText = "Mã Loại Căn Hộ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // btn_ThemCanHo
            // 
            this.btn_ThemCanHo.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_ThemCanHo.Location = new System.Drawing.Point(306, 570);
            this.btn_ThemCanHo.Name = "btn_ThemCanHo";
            this.btn_ThemCanHo.Size = new System.Drawing.Size(181, 55);
            this.btn_ThemCanHo.TabIndex = 27;
            this.btn_ThemCanHo.Text = "Thêm Căn Hộ";
            this.btn_ThemCanHo.UseVisualStyleBackColor = true;
            this.btn_ThemCanHo.Click += new System.EventHandler(this.btn_ThemCanHo_Click);
            // 
            // btb_reloaddata
            // 
            this.btb_reloaddata.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btb_reloaddata.Location = new System.Drawing.Point(588, 570);
            this.btb_reloaddata.Name = "btb_reloaddata";
            this.btb_reloaddata.Size = new System.Drawing.Size(181, 55);
            this.btb_reloaddata.TabIndex = 26;
            this.btb_reloaddata.Text = "Làm mới";
            this.btb_reloaddata.UseVisualStyleBackColor = true;
            this.btb_reloaddata.Click += new System.EventHandler(this.btb_reloaddata_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(-84, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tìm kiếm cư dân:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(82, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 35);
            this.textBox1.TabIndex = 24;
            // 
            // btn_xoacanho
            // 
            this.btn_xoacanho.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_xoacanho.Location = new System.Drawing.Point(847, 570);
            this.btn_xoacanho.Name = "btn_xoacanho";
            this.btn_xoacanho.Size = new System.Drawing.Size(181, 55);
            this.btn_xoacanho.TabIndex = 23;
            this.btn_xoacanho.Text = "Xóa Căn Hộ";
            this.btn_xoacanho.UseVisualStyleBackColor = true;
            this.btn_xoacanho.Click += new System.EventHandler(this.btn_xoacanho_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Trạng thái:";
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trangthai.Location = new System.Drawing.Point(135, 133);
            this.txt_trangthai.Multiline = true;
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(166, 37);
            this.txt_trangthai.TabIndex = 30;
            // 
            // txt_khucanho
            // 
            this.txt_khucanho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khucanho.Location = new System.Drawing.Point(495, 133);
            this.txt_khucanho.Multiline = true;
            this.txt_khucanho.Name = "txt_khucanho";
            this.txt_khucanho.Size = new System.Drawing.Size(166, 37);
            this.txt_khucanho.TabIndex = 31;
            // 
            // txt_maloaicanho
            // 
            this.txt_maloaicanho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maloaicanho.Location = new System.Drawing.Point(871, 136);
            this.txt_maloaicanho.Multiline = true;
            this.txt_maloaicanho.Name = "txt_maloaicanho";
            this.txt_maloaicanho.Size = new System.Drawing.Size(166, 37);
            this.txt_maloaicanho.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã Khu Căn Hộ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(705, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mã Loại Căn Hộ:";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_timkiem.Location = new System.Drawing.Point(61, 570);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(181, 55);
            this.btn_timkiem.TabIndex = 35;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // DanhSachCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 658);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_maloaicanho);
            this.Controls.Add(this.txt_khucanho);
            this.Controls.Add(this.txt_trangthai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_CanHo);
            this.Controls.Add(this.btn_ThemCanHo);
            this.Controls.Add(this.btb_reloaddata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_xoacanho);
            this.Name = "DanhSachCanHo";
            this.Text = "DanhSachCanHo";
            this.Load += new System.EventHandler(this.DanhSachCanHo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_CanHo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_CanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_ThemCanHo;
        private System.Windows.Forms.Button btb_reloaddata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_xoacanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.TextBox txt_khucanho;
        private System.Windows.Forms.TextBox txt_maloaicanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_timkiem;
    }
}