namespace Do_An_DBMS
{
    partial class FormHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(875, 384);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            this.dgvHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellDoubleClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(1157, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(136, 36);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1157, 296);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(136, 67);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Tạo Hóa Đơn Cho Tháng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(999, 38);
            this.txtNam.Multiline = true;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(109, 28);
            this.txtNam.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(882, 99);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(411, 39);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Cập nhật Hóa Đơn";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(878, 12);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(67, 22);
            this.lblThang.TabIndex = 6;
            this.lblThang.Text = "Tháng";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(1006, 13);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(50, 22);
            this.lblNam.TabIndex = 7;
            this.lblNam.Text = "Năm";
            // 
            // cbThang
            // 
            this.cbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(881, 38);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(100, 28);
            this.cbThang.TabIndex = 8;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1311, 384);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cbThang;
    }
}