using System;
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
    public partial class DanhSachCanHo : Form
    {
        CanHo canho = new CanHo();
        MyDB db = new MyDB();
        public DanhSachCanHo()
        {
            InitializeComponent();
        }

        private void btn_ThemCanHo_Click(object sender, EventArgs e)
        {
            ThemCanHo themCanHo = new ThemCanHo();
            this.Hide();
            themCanHo.Show();
            themCanHo.FormClosed += (s, args) => {
                this.Show();
            };
        }
        void loaddata_canho()
        {
            SqlCommand command = new SqlCommand("Select * from view_danhsachcanho");
            data_CanHo.RowTemplate.Height = 30;
            data_CanHo.DataSource = canho.getCanHo(command);
            data_CanHo.AllowUserToAddRows = false;
        }

        private void DanhSachCanHo_Load(object sender, EventArgs e)
        {
            loaddata_canho();
        }

        private void btn_xoacanho_Click(object sender, EventArgs e)
        {
            int macanho = int.Parse(data_CanHo.CurrentRow.Cells[0].Value.ToString());
            if ((MessageBox.Show("Bạn có chắc muốn xóa chủ hộ này ra khỏi danh sách không", "Xóa Chủ Hộ", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.Yes))
            {
                canho.deletecanho(macanho);
                loaddata_canho();
            }
        }

        private void btb_reloaddata_Click(object sender, EventArgs e)
        {
            loaddata_canho();
        }

        
        public void timkiemcanho(string trangthai, int? makhucanho, int? maloaicanho)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TimKiemCanHoTheoTieuChi(@TrangThaiSuDung, @MaKhuCanHo, @MaLoaiCanHo)", db.SqlCon);
            command.Parameters.AddWithValue("@TrangThaiSuDung", string.IsNullOrEmpty(trangthai) ? (object)DBNull.Value : trangthai);
            command.Parameters.AddWithValue("@MaKhuCanHo", makhucanho.HasValue ? (object)makhucanho.Value : DBNull.Value);
            command.Parameters.AddWithValue("@MaLoaiCanHo", maloaicanho.HasValue ? (object)maloaicanho.Value : DBNull.Value);

            try
            {
                db.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                // Tạo DataTable và nạp dữ liệu từ SqlDataReader
                DataTable dt = new DataTable();
                dt.Load(reader);

                // Gắn dữ liệu vào DataGridView
                data_CanHo.DataSource = dt;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string trangThaiSuDung = txt_trangthai.Text.Trim();
            int? maKhuCanHo = string.IsNullOrEmpty(txt_khucanho.Text) ? (int?)null : int.Parse(txt_khucanho.Text);
            int? maLoaiCanHo = string.IsNullOrEmpty(txt_maloaicanho.Text) ? (int?)null : int.Parse(txt_maloaicanho.Text);

            // Gọi hàm tìm kiếm
            timkiemcanho(trangThaiSuDung, maKhuCanHo, maLoaiCanHo);

        }
    }
}
