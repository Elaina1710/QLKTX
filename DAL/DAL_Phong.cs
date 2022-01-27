using System;
using System.Data;
using DevExpress.Xpo;

namespace DAL
{

    public class DAL_Phong
    {
        private static DAL_Phong instance;
        private DAL_Phong() { }

        public static DAL_Phong Instance
        {
            get
            {
                if (instance == null) instance = new DAL_Phong();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable getPhong()
        {
            string query = "select MaPhong, KhuKTX," +
                "(case when LoaiPhong = 1 then 'Nam' when LoaiPhong = 0 then N'Nữ' end) as LoaiPhong," +
                " SoSVToiDa,SoSVDangO," +
                "(case when TinhTrang = 1 then N'Bình thường' when TinhTrang = 0 then N'Đang sửa chữa' end) as TinhTrang," +
                " MoTa from Phong";
            return DBProvider.Instance.ExecuteQuery(query);
        }
        public DataTable timTheoMa(string maPhong)
        {
            string query = string.Format("SELECT * FROM Phong WHERE MaPhong='{0}'",maPhong);
            return DBProvider.Instance.ExecuteQuery(query);
        }
        public bool themPhong(string maPhong,string khuKTX,int LoaiPhong,int maxSV,int svDangO,int TinhTrang,string mota)
        {
            string query = String.Format("INSERT INTO Phong " +
                "VALUES ('{0}',{1},{2},{3},{4},N'{5}','{6}')",
                maPhong, LoaiPhong, maxSV, svDangO, TinhTrang, mota, khuKTX);
            return DBProvider.Instance.ExecuteNonQuery(query)>0;
        }
        public bool suaPhong(int maxSV, int LoaiPhong, int TinhTrang, string mota, string maPhong)
        {
            string query = string.Format("UPDATE Phong set " +
                "SoSVToiDa = {0}, LoaiPhong = {1}, TinhTrang = {2}, MoTa = N'{3}' where MaPhong = '{4}'"
                , maxSV, LoaiPhong, TinhTrang, mota, maPhong);
            int result = DBProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool xoaPhong(string maPhong)
        {
            string query = string.Format("DELETE FROM Phong WHERE maPhong='{0}'", maPhong);
            int result = DBProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable chonPhong(int LoaiPhong)
        {
            string query = string.Format("SELECT * FROM Phong WHERE LoaiPhong={0}" +
                " AND SoSVToiDa>SoSVDangO" +
                " AND TinhTrang=1 ORDER BY KhuKTX ASC", LoaiPhong);
            return DBProvider.Instance.ExecuteQuery(query);
        }
        public bool tangSoSV(string maPhong)
        {
            string query= string.Format("update Phong set SoSVDangO+= 1 where MaPhong = '{0}'", maPhong);
            return DBProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool giamSoSV(string maPhong)
        {
            string query= string.Format("update Phong set SoSVDangO-=1 where MaPhong ='{0}'", maPhong);
            return DBProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }

}