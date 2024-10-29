using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Do_An_DBMS
{
    internal class CanHo
    {
        MyDB db = new MyDB();


        public DataTable getMaKhuCanHo()
        {
            SqlCommand command = new SqlCommand("Select * from V_TimMaKhuCanHo", db.SqlCon);

            SqlDataAdapter Adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            Adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getMaLoaiCanHo()
        {
            SqlCommand command = new SqlCommand("Select * from V_TimMaLoaiCanHo", db.SqlCon);
            SqlDataAdapter Adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            Adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getCanHo(SqlCommand command)
        {
            command.Connection = db.SqlCon;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
        public bool addcanho(string trangthai, int makhucanho, int maloaicanho)
        {
            SqlCommand command = new SqlCommand("EXEC sp_ThemCanHo @TrangThaiSuDung, @MaKhuCanHo, @MaLoaiCanHo", db.SqlCon);
            command.Parameters.Add("@TrangThaiSuDung", SqlDbType.VarChar, 100).Value = trangthai;
            command.Parameters.Add("@MaKhuCanHo", SqlDbType.Int).Value = makhucanho;
            command.Parameters.Add("@MaLoaiCanHo", SqlDbType.Int).Value = maloaicanho;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();

                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool editcanho(int macanho, string trangthai, int makhucanho, int maloaicanho)
        {
            SqlCommand command = new SqlCommand("EXEC sp_CapNhatCanHo @MaCanHo, @TrangThaiSuDung, @MaKhuCanHo, @MaLoaiCanHo", db.SqlCon);
            command.Parameters.Add("@MaCanHo", SqlDbType.Int).Value = macanho;
            command.Parameters.Add("@TrangThaiSuDung", SqlDbType.VarChar, 100).Value = trangthai;
            command.Parameters.Add("@MaKhuCanHo", SqlDbType.Int).Value = makhucanho;
            command.Parameters.Add("@MaLoaiCanHo", SqlDbType.Int).Value = maloaicanho;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();

                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool deletecanho(int macanho)
        {
            SqlCommand command = new SqlCommand("EXEC sp_XoaCanHo @MaCanHo", db.SqlCon);
            command.Parameters.Add("@MaCanHo", SqlDbType.Int).Value = macanho;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();

                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    
        public List<List<Button>> caocap = new List<List<Button>>();
        public List<List<Button>> trungbinh = new List<List<Button>>();
        public List<List<Button>> coban = new List<List<Button>>();
        #region tao slot giu xe

        public void hienToa(string loai, List<List<Button>> canho, Panel pnl, Point sl, int height, int width, int kcN, Point first)
        {
            int n = sl.X;
            int m = sl.Y;
            int cnt = 0;
            Button oldBtn = new Button() { Location = first, Width = 0 };
            for (int i = 0; i < n; i++)
            {
                canho.Add(new List<Button>());
                for (int j = 0; j < m; j++)
                {
                    Button btn = new Button()
                    {
                        Height = height,
                        Width = width,
                        BackColor = Color.White,
                        Location = new Point(oldBtn.Location.X + kcN + width, oldBtn.Location.Y),
                        Name = loai + cnt.ToString(),
                        Tag = cnt,
                    };
                    btn.Click += Btn_Click;
                    canho[i].Add(btn);
                    pnl.Controls.Add(btn);
                    oldBtn = btn;
                    cnt++;
                }
                oldBtn.Location = new Point(first.X, oldBtn.Location.Y + height);
                oldBtn.Width = oldBtn.Height = 0;
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (btn.BackColor == Color.Yellow)
            {
                //hien thong tin chu ho
                if (btn.Name.ToString()[0] == 'o')
                {
                    ChinhSuaChuHo chinhSuaChuHo = new ChinhSuaChuHo();
                    if (chinhSuaChuHo.ShowDialog() == DialogResult.OK)
                    {
                        btn.BackColor = Color.White;
                    }
                }
                else if (btn.Name.ToString()[0] == 'd')
                {
                    ChinhSuaChuHo chinhSuaChuHo = new ChinhSuaChuHo();
                    if (chinhSuaChuHo.ShowDialog() == DialogResult.OK)
                    {
                        btn.BackColor = Color.White;
                    }
                }   
                else
                {
                    ChinhSuaChuHo chinhSuaChuHo = new ChinhSuaChuHo();
                    //ChiTietLayXeMay ctLayXemay = new ChiTietLayXeMay((int)btn.Tag);
                    if (chinhSuaChuHo.ShowDialog() == DialogResult.OK)
                    {
                        btn.BackColor = Color.White;
                    }
                }

            }
            else
            {
                //gui xe
                if (btn.Name.ToString()[0] == 'o')
                {
                    ThemChuHo themchu = new ThemChuHo();
                    //ChiTietGiuOto chiTietGiuOto = new ChiTietGiuOto((int)btn.Tag);
                    if (themchu.ShowDialog() == DialogResult.OK)
                    {
                        btn.BackColor = Color.Yellow;
                    }
                }
                else if (btn.Name.ToString()[0] == 'd')
                {
                    ThemChuHo themChuHo = new ThemChuHo();
                    if (themChuHo.ShowDialog() == DialogResult.OK)
                    {
                        btn.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    ThemChuHo themChuHo = new ThemChuHo();
                    //ChiTietGiuXeMay chiTietGiuXeMay = new ChiTietGiuXeMay((int)btn.Tag);
                    if (themChuHo.ShowDialog() == DialogResult.OK)
                    {
                        btn.BackColor = Color.Yellow;
                    }
                }
            }

        }

        public void canhoOdkBiChiem(string query, List<List<Button>> canho)
        {
            SqlCommand sqlCommand = new SqlCommand(query, db.SqlCon);
            db.openConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            //lay ra so hang va so cot cua bat ky xe nao
            int n = canho.Count;
            int m = canho[0].Count;
            while (reader.Read())
            {
                //đánh dấu lại những ô đã bị chiếm
                int id = reader.GetInt32(0);
                int row = id / m;
                int col = id % m;
                canho[row][col].BackColor = Color.Yellow;
            }
            reader.Close();
            db.closeConnection();
        }

        #endregion tao slot giu xe

    }
}
