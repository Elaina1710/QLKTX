using System;
using System.Data;
using DAL;
using DevExpress.Xpo;

namespace BUS
{

    public class BUS_HoaDon : XPObject
    {
        private static BUS_HoaDon instance;
        private BUS_HoaDon() { }

        public static BUS_HoaDon Instance
        {
            get
            {
                if (instance == null) instance = new BUS_HoaDon();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable getChiSo(String maPhong)
        {
            return DAL_HoaDon.Instance.getChiSo(maPhong);
        }
        public DataTable getAll()
        {
            return DAL_HoaDon.Instance.getAll();
        }
    }

}