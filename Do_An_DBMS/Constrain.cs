using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_DBMS
{
    internal class Constrain
    {
        public static int CaoLoaiCaoCap = 90;
        public static int RongLoaiCaoCap = 90;
        public static int CaoLoaiTrungBinh = 50;
        public static int RongLoaiTrungBinh = 50;
        public static Point LoaiCaoCapDauTien = new Point(15 - RongLoaiCaoCap, 40);
        public static Point LoaiTrungBinhDauTien = new Point(15 - RongLoaiTrungBinh, 40);
        public static Point soLuongLoaiCaoCap = new Point(5, 4);
        public static Point soLuongLoaiTrungBinh = new Point(9, 5);
        public static int khoangCachNgangLoaiCaoCap = 50;
        public static int khoangCachNgangLoaiTrungBinh = 30;


        public static int CaoLoaiCoBan = 30;
        public static int RongLoaiCoBan = 30;
        public static Point LoaiCoBanDauTien = new Point(15 - RongLoaiCoBan, 40);
        public static Point soLuongLoaiCoBan = new Point(9, 3);
        public static int khoangCachNgangLoaiCoBan = 20;
    }
}
