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
        string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DADBMS;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection sqlConnection = null;
        //Đối tượng thực thi câu lệnh
        SqlCommand sqlCommand = null;
        SqlDataAdapter sqlDataAdapter = null;
        //Chứa dữ liệu đổ vào
        DataTable dt = new DataTable();
        //Singleton pattern
        private static Menu instance;
        public static Menu Instance
        {
            get
            {
                if (instance == null||instance.IsDisposed)
                {
                    instance = new Menu();
                }
                return instance;
            }
        }

        //Child Form
        private Form childForm;
        public void OpenChildForm(Form childForm)
        {
            if (this.childForm != null)
            {
                this.childForm.Close();
            }
            this.childForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(FormHoaDon.Instance);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(FormDoanhThu.Instance);
            
        }

        private void btnDanCu_Click(object sender, EventArgs e)
        {
            OpenChildForm(DanhSachCuDan.Instance);
        }

        private void btnCanHo_Click(object sender, EventArgs e)
        {
            OpenChildForm(DanhSachCanHo.Instance);
        }

        private void btnChuHo_Click(object sender, EventArgs e)
        {
            OpenChildForm(DanhSachChuHo.Instance);
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
