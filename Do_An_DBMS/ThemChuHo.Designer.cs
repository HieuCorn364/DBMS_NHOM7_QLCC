﻿namespace Do_An_DBMS
{
    partial class ThemChuHo
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
            this.btn_ThemChuHo = new System.Windows.Forms.Button();
            this.cbb_macanho = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_kieusohuu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.txt_machuho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 100);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Chủ Hộ";
            // 
            // btn_ThemChuHo
            // 
            this.btn_ThemChuHo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemChuHo.Location = new System.Drawing.Point(250, 379);
            this.btn_ThemChuHo.Name = "btn_ThemChuHo";
            this.btn_ThemChuHo.Size = new System.Drawing.Size(166, 54);
            this.btn_ThemChuHo.TabIndex = 30;
            this.btn_ThemChuHo.Text = "Thêm";
            this.btn_ThemChuHo.UseVisualStyleBackColor = true;
            this.btn_ThemChuHo.Click += new System.EventHandler(this.btn_ThemChuHo_Click);
            // 
            // cbb_macanho
            // 
            this.cbb_macanho.FormattingEnabled = true;
            this.cbb_macanho.Location = new System.Drawing.Point(171, 331);
            this.cbb_macanho.Name = "cbb_macanho";
            this.cbb_macanho.Size = new System.Drawing.Size(228, 24);
            this.cbb_macanho.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã căn hộ:";
            // 
            // txt_kieusohuu
            // 
            this.txt_kieusohuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kieusohuu.Location = new System.Drawing.Point(171, 266);
            this.txt_kieusohuu.Multiline = true;
            this.txt_kieusohuu.Name = "txt_kieusohuu";
            this.txt_kieusohuu.Size = new System.Drawing.Size(236, 28);
            this.txt_kieusohuu.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kiếu sở hữu:";
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayketthuc.Location = new System.Drawing.Point(485, 193);
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Size = new System.Drawing.Size(154, 22);
            this.ngayketthuc.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaybatdau.Location = new System.Drawing.Point(171, 192);
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.Size = new System.Drawing.Size(154, 22);
            this.ngaybatdau.TabIndex = 22;
            // 
            // txt_machuho
            // 
            this.txt_machuho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_machuho.Location = new System.Drawing.Point(171, 121);
            this.txt_machuho.Multiline = true;
            this.txt_machuho.Name = "txt_machuho";
            this.txt_machuho.Size = new System.Drawing.Size(236, 28);
            this.txt_machuho.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Chủ Hộ:";
            // 
            // ThemChuHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ThemChuHo);
            this.Controls.Add(this.cbb_macanho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_kieusohuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ngayketthuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ngaybatdau);
            this.Controls.Add(this.txt_machuho);
            this.Controls.Add(this.label2);
            this.Name = "ThemChuHo";
            this.Text = "ThemChuHo";
            this.Load += new System.EventHandler(this.ThemChuHo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThemChuHo;
        private System.Windows.Forms.ComboBox cbb_macanho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_kieusohuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ngayketthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ngaybatdau;
        private System.Windows.Forms.TextBox txt_machuho;
        private System.Windows.Forms.Label label2;
    }
}