using System;
using System.Data;
using DAL;
using DevExpress.Xpo;
using DTO;

namespace BUS
{

    public class BUS_SinhVien 
    {
        private static BUS_SinhVien instance;
        private BUS_SinhVien() { }

        public static BUS_SinhVien Instance
        {
            get
            {
                if (instance == null) instance = new BUS_SinhVien();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable getSinhVien()
        {
            return DAL_SinhVien.Instance.getSinhVien();
        }

        public DataTable getbyID(String maSV)
        {
            return DAL_SinhVien.Instance.getbyID(maSV);
        }
        public DataTable getbyName(String name)
        {
            return DAL_SinhVien.Instance.getbyName(name);
        }
        public bool themSV(DTO_SinhVien sv,string maHD,string maPhong, string ngayBatdau)
        {
            return DAL_SinhVien.Instance.themSV(sv, maHD,maPhong,ngayBatdau);
        }
        public bool xoaSV(string maSV,string maPhong)
        {
            return DAL_SinhVien.Instance.XoaSV(maSV, maPhong);
        }
    }
}