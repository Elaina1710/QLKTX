using System;
using System.Data;
using DevExpress.Xpo;

namespace DAL
{

    public class DAL_HoaDon : XPObject
    {
        private static DAL_HoaDon instance;
        private DAL_HoaDon() { }

        public static DAL_HoaDon Instance
        {
            get
            {
                if (instance == null) instance = new DAL_HoaDon();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable getChiSo(String maPhong)
        {
            String query = "select top(1) CSDienCuoi,CSNuocCuoi from HoaDon " +
                "where MaPhong='" + maPhong + "' order by NgayLap DESC";
            return DBProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getAll()
        {
            String query = "select * from HoaDon";
            return DBProvider.Instance.ExecuteQuery(query);
        }
        //DDDDDDDDD
    }

}