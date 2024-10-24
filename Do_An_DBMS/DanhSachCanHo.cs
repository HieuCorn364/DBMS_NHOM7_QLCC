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
    }
}
