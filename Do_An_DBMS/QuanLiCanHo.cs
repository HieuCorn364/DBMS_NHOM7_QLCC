using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_DBMS
{
    public partial class QuanLiCanHo : Form
    {
        CanHo canho = new CanHo();
        public QuanLiCanHo()
        {

            InitializeComponent();
        }

        private void QuanLiCanHo_Load(object sender, EventArgs e)
        {

            //hien cho loai can ho cao cap
            canho.hienToa("o", canho.caocap, pn_CaoCap, Constrain.soLuongLoaiCaoCap, Constrain.CaoLoaiCaoCap, Constrain.RongLoaiCaoCap, Constrain.khoangCachNgangLoaiCaoCap, Constrain.LoaiCaoCapDauTien);
            //hien nhung cho da duoc dang ki chu ho
            //canho.canhoOdkBiChiem("select * from GiuOto", canho.caocap);

            //hien cho loai can ho trung binh
            canho.hienToa("m", canho.trungbinh, pn_TrungBinh, Constrain.soLuongLoaiTrungBinh, Constrain.CaoLoaiTrungBinh, Constrain.RongLoaiTrungBinh, Constrain.khoangCachNgangLoaiTrungBinh, Constrain.LoaiTrungBinhDauTien);
            //hien nhung cho da duoc dang ki chu ho
           // canho.canhoOdkBiChiem("select * from GiuXeMay", canho.trungbinh);

            //hien cho loai can ho co ban
            canho.hienToa("d", canho.coban, pn_CoBan, Constrain.soLuongLoaiCoBan, Constrain.CaoLoaiCoBan, Constrain.RongLoaiCoBan, Constrain.khoangCachNgangLoaiCoBan, Constrain.LoaiCoBanDauTien);
            //hien nhung cho da duoc gui xe dap
           // canho.canhoOdkBiChiem("select * from GiuXeDap", canho.coban);
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            //hien cho loai can ho cao cap
            canho.hienToa("o", canho.caocap, pn_CaoCap, Constrain.soLuongLoaiCaoCap, Constrain.CaoLoaiCaoCap, Constrain.RongLoaiCaoCap, Constrain.khoangCachNgangLoaiCaoCap, Constrain.LoaiCaoCapDauTien);
            //hien nhung cho da duoc dang ki chu ho
            //canho.canhoOdkBiChiem("select * from GiuOto", canho.caocap);

            //hien cho loai can ho trung binh
            canho.hienToa("m", canho.trungbinh, pn_TrungBinh, Constrain.soLuongLoaiTrungBinh, Constrain.CaoLoaiTrungBinh, Constrain.RongLoaiTrungBinh, Constrain.khoangCachNgangLoaiTrungBinh, Constrain.LoaiTrungBinhDauTien);
            //hien nhung cho da duoc dang ki chu ho
            //canho.canhoOdkBiChiem("select * from GiuXeMay", canho.trungbinh);

            //hien cho loai can ho co ban
            canho.hienToa("d", canho.coban, pn_CoBan, Constrain.soLuongLoaiCoBan, Constrain.CaoLoaiCoBan, Constrain.RongLoaiCoBan, Constrain.khoangCachNgangLoaiCoBan, Constrain.LoaiCoBanDauTien);
            //hien nhung cho da duoc gui xe dap
           // canho.canhoOdkBiChiem("select * from GiuXeDap", canho.coban);
        }
    }
}
