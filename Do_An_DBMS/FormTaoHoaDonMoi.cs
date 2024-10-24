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
    public partial class FormTaoHoaDonMoi : Form
    {
        int maHD;
        string con = @"Data Source=DESKTOP-TPG17OF;Initial Catalog=QuanLyChungCu;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection sqlConnection = null;
        //Đối tượng thực thi câu lệnh
        SqlCommand sqlCommand = null;
        SqlDataAdapter sqlDataAdapter = null;
        //Chứa dữ liệu đổ vào
        DataTable dt = new DataTable();
        public FormTaoHoaDonMoi(int maHoaDon)
        {
            InitializeComponent();
            maHD = maHoaDon;
            lblTitle.Text = "Cập nhật số liệu cho mã hóa đơn: " + maHoaDon.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTaoHoaDonMoi_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(con);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                using (sqlCommand = new SqlCommand("sp_TaoChiTietHoaDon", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@MaHoaDon", SqlDbType.Int)).Value = maHD;
                    sqlCommand.Parameters.Add(new SqlParameter("@SoDien", SqlDbType.Int)).Value = int.Parse(txtDien.Text);
                    sqlCommand.Parameters.Add(new SqlParameter("@SoKhoiNuoc", SqlDbType.Int)).Value = int.Parse(txtDien.Text);
                    sqlCommand.Parameters.Add(new SqlParameter("@SoXe", SqlDbType.Int)).Value = int.Parse(txtDien.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật dữ liệu hóa đơn thành công!");
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
