using System;
using System.Data;
using DevExpress.Xpo;

namespace DAL
{

    public class DAL_Nhanvien
    {
        private static DAL_Nhanvien instance;
        private DAL_Nhanvien() { }

        public static DAL_Nhanvien Instance
        {
            get
            {
                if (instance == null) instance = new DAL_Nhanvien();
                return instance;
            }
            private set { instance = value; }
        }

        public DataTable getNhanvien()
        {
            return DBProvider.Instance.ExecuteQuery("SELECT * FROM NhanVien");
        }
        public DataTable getbyID(String maNV)
        {
            return DBProvider.Instance.ExecuteQuery("SELECT * FROM NhanVien where MaNV = "+maNV);
        }
        public DataTable getbyName(String name)
        {
            return DBProvider.Instance.ExecuteQuery("SELECT * FROM NhanVien where HoTen like N'%"+ name +"%'");
        }
        public bool themNhanVien(string hoten, string gt, string sdt, string email, string mota)
        {
            string query = string.Format("INSERT INTO NhanVien " +
                "VALUES (N'{0}',{1},'{2}','{3}',N'{4}')",hoten,gt,sdt,email,mota);
            int result=DBProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool suaNhanVien(string hoten, string gt, string sdt, string email, string mota, int maNV)
        {
            string query = string.Format("UPDATE NhanVien SET " +
                "HoTen = N'{0}', GioiTinh = {1}, SDT = '{2}', Email = '{3}', MoTa = N'{4}' where MaNV = {5}"
                , hoten, gt, sdt, email, mota, maNV);
            int result = DBProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool xoaNhanVien(int maNV)
        {
            DAL_TaiKhoan.Instance.xoaTK(maNV);
            string query = "DELETE FROM NhanVien WHERE MaNV=" + maNV;
            int result = DBProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }

}