using System;
using System.Data;
using DevExpress.Xpo;

namespace DAL
{

    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;
        private DAL_TaiKhoan() { }

        public static DAL_TaiKhoan Instance
        {
            get
            {
                if (instance == null) instance = new DAL_TaiKhoan();
                return instance;
            }
            private set { instance = value; }
        }

        public bool login(string user, string pass)
        {
            string query = "SELECT * FROM TaiKhoan WHERE " +
                "username = '" + user + "' AND pass = '" + pass + "' ";
            DataTable result = DBProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public void xoaTK(int maNV)
        {
            string query = "DELETE FROM TaiKhoan WHERE MaNV=" + maNV;
            DBProvider.Instance.ExecuteNonQuery(query);
        }
    }

}