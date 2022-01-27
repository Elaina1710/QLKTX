using DAL;
using System.Data;

namespace BUS
{

    public class BUS_Phong
    {
        private static BUS_Phong instance;
        private BUS_Phong() { }

        public static BUS_Phong Instance
        {
            get{
                if (instance == null) instance = new BUS_Phong();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable getPhong()
        {
            return DAL_Phong.Instance.getPhong();
        }
        public DataTable timTheoMa(string maPhong) {
            return DAL_Phong.Instance.timTheoMa(maPhong);
        }
        public bool themPhong(string maPhong,string khuKTX,int LoaiPhong,int maxSV,int svDangO,int TinhTrang,string mota)
        {
            return DAL_Phong.Instance.themPhong(maPhong, khuKTX, LoaiPhong, maxSV, svDangO, TinhTrang, mota);
        }
        public bool suaPhong(int maxSV,int LoaiPhong,int TinhTrang,string mota,string maPhong)
        {
            return DAL_Phong.Instance.suaPhong(maxSV, LoaiPhong, TinhTrang, mota, maPhong);
        }
        public bool xoaPhong(string maPhong)
        {
            return DAL_Phong.Instance.xoaPhong(maPhong);
        }
        public DataTable chonPhong(int LoaiPhong)
        {
            return DAL_Phong.Instance.chonPhong(LoaiPhong);
        }
    }

}