using System;
using System.Data;
using DAL;
using DevExpress.Xpo;

namespace BUS
{

    public class BUS_Nhanvien
    {
        private static BUS_Nhanvien instance;
        private BUS_Nhanvien() { }

        public static BUS_Nhanvien Instance
        {
            get
            {
                if (instance == null) instance = new BUS_Nhanvien();
                return instance;
            }
            private set { instance = value; }
        }

        public DataTable getNhanVien()
        {
            return DAL_Nhanvien.Instance.getNhanvien();
        }
        public DataTable getbyID(String maNV)
        {
            return DAL_Nhanvien.Instance.getbyID(maNV);
        }
        public DataTable getbyName(String name)
        {
            return DAL_Nhanvien.Instance.getbyName(name);
        }
        public bool themNhanvien(string hoten, string gt,string sdt,string email,string mota)
        {
            return DAL_Nhanvien.Instance.themNhanVien(hoten, gt, sdt, email, mota);
        }
        public bool suaNhanvien(string hoten, string gt, string sdt, string email, string mota,int maNV)
        {
            return DAL_Nhanvien.Instance.suaNhanVien(hoten, gt, sdt, email, mota, maNV);
        }
        public bool xoaNhanVien(int maNV)
        {
            return DAL_Nhanvien.Instance.xoaNhanVien(maNV);
        }
    }

}