using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_DBMS
{
    public partial class DanhSachCuDan : Form
    {
        MyDB db = new MyDB();
        CuDan cudan = new CuDan();
        public DanhSachCuDan()
        {
            InitializeComponent();
        }

        private void btb_reloaddata_Click(object sender, EventArgs e)
        {
            loaddatacudan();
        }

        private void loaddatacudan(string query = "Select * from view_danhsachcudan")
        {
            SqlCommand command = new SqlCommand(query);
            data_CuDan.RowTemplate.Height = 30;
            data_CuDan.DataSource = cudan.getCuDan(command);
            data_CuDan.AllowUserToAddRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemCuDan themCuDan = new ThemCuDan();
            themCuDan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int macudan = int.Parse(data_CuDan.CurrentRow.Cells[0].Value.ToString());
            if ((MessageBox.Show("Bạn có chắc muốn xóa cư dân này ra khỏi danh sách không", "Xóa Cư Dân", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.Yes))
            {
                cudan.deletecudan(macudan);
                loaddatacudan();
            }
        }

        private void DanhSachCuDan_Load(object sender, EventArgs e)
        {
            loaddatacudan();
        }

        private void data_CuDan_DoubleClick(object sender, EventArgs e)
        {
            ChinhSuaCuDan chinhsuacudan = new ChinhSuaCuDan();
            staticdata.Macudan = int.Parse(data_CuDan.CurrentRow.Cells[0].Value.ToString());
            chinhsuacudan.txt_Hoten.Text = data_CuDan.CurrentRow.Cells[1].Value.ToString();
            chinhsuacudan.txt_Sdt.Text = data_CuDan.CurrentRow.Cells[2].Value.ToString();
            chinhsuacudan.txt_CCCD.Text = data_CuDan.CurrentRow.Cells[3].Value.ToString();
            String gioitinh = data_CuDan.CurrentRow.Cells[4].Value.ToString();
            if (gioitinh == "Nam")
            {
                chinhsuacudan.rbtn_nam.Checked = true;
                chinhsuacudan.rbtn_nu.Checked = false;
            }
            if (gioitinh == "Nu")
            {
                chinhsuacudan.rbtn_nam.Checked = false;
                chinhsuacudan.rbtn_nu.Checked = true;
            }
            chinhsuacudan.txt_MaChuHo.Text = data_CuDan.CurrentRow.Cells[5].Value.ToString();
            this.Hide();

            chinhsuacudan.Show();

            chinhsuacudan.FormClosed += (s, args) =>
            {
                this.Show();  // Hiển thị lại form gốc khi form mới bị đóng
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timkiemcudan(textBox1.Text);
        }
        public void timkiemcudan(string tencudan)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.TimKiemCuDanTheoTen(@TenCuDan)", db.SqlCon);
            sqlCommand.Parameters.Add("@TenCuDan", SqlDbType.VarChar, 100).Value = tencudan;

            try
            {
                db.openConnection();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                // Tạo DataTable và nạp dữ liệu từ SqlDataReader
                DataTable dt = new DataTable();
                dt.Load(reader);

                // Gắn dữ liệu vào DataGridView
                data_CuDan.DataSource = dt;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
