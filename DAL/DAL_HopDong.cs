using System;
using DevExpress.Xpo;

namespace DAL
{

    public class DAL_HopDong
    {
        private static DAL_HopDong instance;

        public static DAL_HopDong Instance
        {
            get
            {
                if (instance == null) instance = new DAL_HopDong();
                return instance;
            }
            private set { instance = value; }
        }
        public bool themHD(string maHD,string maSV,string maPhong,string NgayBatDau)
        {
            string query = string.Format("insert into HopDong values" +
                "('{0}', '{1}', getdate(), '{2}', '{3}')",
                maHD,maSV,maPhong,NgayBatDau);
            return DBProvider.Instance.ExecuteNonQuery(query)>0;
        }
        public bool xoaHD(string maSV)
        {
            string query = "DELETE FROM HopDong WHERE MaSV='" + maSV + "'";
            return DBProvider.Instance.ExecuteNonQuery(query)>0;
        }
    }

}