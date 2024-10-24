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
    public partial class FormChiTietHoaDon : Form
    {
        int maHoaDon;
        string trangThai;
        string con = @"Data Source=DESKTOP-TPG17OF;Initial Catalog=QuanLyChungCu;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection sqlConnection = null;
        //Đối tượng thực thi câu lệnh
        SqlCommand sqlCommand = null;
        SqlDataAdapter sqlDataAdapter = null;
        //Chứa dữ liệu đổ vào
        DataTable dt = new DataTable();
        public FormChiTietHoaDon()
        {
            InitializeComponent();
        }

        public FormChiTietHoaDon(int maHoaDon, string trangThaiHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.trangThai = trangThaiHoaDon;
            LayChiTietHoaDon(maHoaDon, trangThaiHoaDon);
        }

        private void LayChiTietHoaDon(int maHoaDon, string trangThaiHoaDon)
        {
            try
            {
                sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                using (sqlCommand = new SqlCommand("sp_LayChiTietHoaDon", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@MaHoaDon", SqlDbType.Int)).Value = maHoaDon;
                    sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    lblMaHoaDon.Text = "Mã hóa đơn:   " + maHoaDon.ToString();
                    dgvChiTiet.DataSource = dataTable;
                    lblTrangThai.Text = "Trạng Thái Thanh Toán:   " + trangThaiHoaDon.ToString();
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

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(con);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XacNhanHoaDon();
        }

        private void XacNhanHoaDon()
        {
            try
            {
                sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                using (sqlCommand = new SqlCommand("tg_CapNhatTrangThaiHoaDon", sqlConnection))
                {
                    trangThai = "Da Thanh Toan";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@MaHoaDon", SqlDbType.Int)).Value = maHoaDon;
                    sqlCommand.Parameters.Add(new SqlParameter("@TrangThaiMoi", SqlDbType.NVarChar)).Value = trangThai;
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã thanh toán thành công mã hóa đơn " + maHoaDon.ToString());
                    LayChiTietHoaDon(maHoaDon, trangThai);
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
    }
}
