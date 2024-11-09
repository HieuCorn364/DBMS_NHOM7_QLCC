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
    public partial class FormDoanhThu : Form
    {
        string con = @"Data Source=DESKTOP-TPG17OF;Initial Catalog=QuanLyChungCu;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection sqlConnection = null;
        //Đối tượng thực thi câu lệnh
        SqlCommand sqlCommand = null;
        SqlDataAdapter sqlDataAdapter = null;
        //Chứa dữ liệu đổ vào
        DataTable dt = new DataTable();
        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TongDoanhThu();
        }
        private void TongDoanhThu()
        {
            string query = "SELECT * FROM fn_TinhDoanhThuTienIch(@Month, @Year)";

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
                    dgvDoanhThu.DataSource = dt;

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

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(con);
        }

    }
}
