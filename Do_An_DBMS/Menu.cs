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
    public partial class Menu : Form
    {
        string con = @"Data Source=DESKTOP-TPG17OF;Initial Catalog=QuanLyChungCu;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection sqlConnection = null;
        //Đối tượng thực thi câu lệnh
        SqlCommand sqlCommand = null;
        SqlDataAdapter sqlDataAdapter = null;
        //Chứa dữ liệu đổ vào
        DataTable dt = new DataTable();
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon();
            formHoaDon.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            FormDoanhThu form = new FormDoanhThu();
            form.ShowDialog();
        }

        private void btnDanCu_Click(object sender, EventArgs e)
        {
            DanhSachCuDan danhSachCuDan = new DanhSachCuDan();
            danhSachCuDan.ShowDialog();
        }

        private void btnCanHo_Click(object sender, EventArgs e)
        {
            DanhSachCanHo ho = new DanhSachCanHo();
            ho.ShowDialog();
        }

        private void btnChuHo_Click(object sender, EventArgs e)
        {
            DanhSachChuHo ho = new DanhSachChuHo();
            ho.ShowDialog();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Kết Nối Thành Công");
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

        private void Menu_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(con);
        }
    }
}
