using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Do_An_DBMS
{
    internal class MyDB
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-TPG17OF;Initial Catalog=QuanLyChungCu;Integrated Security=True");
        public SqlConnection SqlCon { get => sqlCon; set => sqlCon = value; }
        public void openConnection()
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
        }
        public void closeConnection()
        {
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
    }
}