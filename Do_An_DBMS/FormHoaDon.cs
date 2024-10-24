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
    public partial class FormHoaDon : Form
    {
        string con = @"Data Source=DESKTOP-TPG17OF;Initial Catalog=QuanLyChungCu;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection sqlConnection = null;
        //Đối tượng thực thi câu lệnh
        SqlCommand sqlCommand = null;
        SqlDataAdapter sqlDataAdapter = null;
        //Chứa dữ liệu đổ vào
        DataTable dt = new DataTable();
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemHoaDon();
        }

        private void TimKiemHoaDon()
        {
            // Câu truy vấn SQL để gọi function
            string query = "SELECT * FROM fn_TimKiemHoaDonTheoThangNam(@Month, @Year)";

            // Tạo kết nối với SQL Server
                try
                {
                    // Mở kết nối
                    sqlConnection.Open();

                    // Tạo SqlCommand để thực thi truy vấn
                    using (sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        // Thêm tham số cho function
                        sqlCommand.Parameters.AddWithValue("@Month", cbThang.SelectedItem);
                        sqlCommand.Parameters.AddWithValue("@Year", txtNam.Text);

                   sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    // Tạo DataTable để chứa dữ liệu từ SQL Server
                    DataTable dt = new DataTable();

                    // Đổ dữ liệu từ SQL Server vào DataTable
                    sqlDataAdapter.Fill(dt);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvHoaDon.DataSource = dt;

                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            finally
            {
                sqlConnection.Close();
            }
            
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(con);
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvHoaDon.Rows[e.RowIndex];
            string maHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString();
            string trangThai = selectedRow.Cells["TrangThai"].Value.ToString();
            FormChiTietHoaDon formChiTietHoaDon = new FormChiTietHoaDon(int.Parse(maHoaDon), trangThai);
            formChiTietHoaDon.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaoHoaDonMoi();
        }
        private void TaoHoaDonMoi()
        {
            try
            {
                sqlConnection.Open();
                using (sqlCommand = new SqlCommand("sp_TaoHoaDonChoChuHo", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã tạo thành công các hóa đơn cho tháng " + DateTime.Now.Month);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int maHoaDon = int.Parse(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
            FormTaoHoaDonMoi formTaoHoaDonMoi = new FormTaoHoaDonMoi(maHoaDon);
            formTaoHoaDonMoi.ShowDialog();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
