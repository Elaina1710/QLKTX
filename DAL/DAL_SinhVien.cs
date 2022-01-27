using System;
using System.Data;
using DevExpress.Xpo;
using DTO;

namespace DAL
{

    public class DAL_SinhVien
    {
        private static DAL_SinhVien instance;
        private DAL_SinhVien() { }

        public static DAL_SinhVien Instance
        {
            get
            {
                if (instance == null) instance = new DAL_SinhVien();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable getSinhVien()
        {
            string query = "select a.*, b.MaPhong,b.NgayBatDau from SinhVien as a,HopDong as b " +
                "where a.MaSV = b.MaSV";
            return DBProvider.Instance.ExecuteQuery(query);
        }
        //Mã SV bắt buộc nhập chính xác mới tìm được
        public DataTable getbyID(String maSV)
        {
            string query = string.Format("select a.*, b.MaPhong,b.NgayBatDau from SinhVien as a,HopDong as b " +
                "where a.MaSV = b.MaSV and a.MaSV ='{0}'",maSV);
            return DBProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getbyName(String name)
        {
            string query = string.Format("select a.*, b.MaPhong,b.NgayBatDau from SinhVien as a,HopDong as b " +
                "where a.MaSV = b.MaSV and a.HoTen like N'%{0}%'", name);
            return DBProvider.Instance.ExecuteQuery(query);
        }
        public bool themSV(DTO_SinhVien sv,string maHD, string maPhong, string ngayBatdau)
        {
            //Việc thêm sinh viên vào ký túc xá sẽ thêm vào csdl SinhVien, HopDong, 
            //cập nhật số sinh viên đang ở trong Phong

            string queryThemSV = string.Format("insert into SinhVien values " +
                "('{0}',N'{1}',{2},'{3}','{4}','{5}','{6}',N'{7}',{8})",
                sv.MaSV,sv.HoTen,sv.Gioitinh,sv.Ngaysinh,sv.Sdt,sv.Email,sv.Sdt2,sv.Nganhhoc,sv.Khoahoc);
            
            return DBProvider.Instance.ExecuteNonQuery(queryThemSV)>0 && DAL_HopDong.Instance.themHD(maHD, sv.MaSV, maPhong, ngayBatdau) 
                && DAL_Phong.Instance.tangSoSV(maPhong);
        }

        //Xóa 1 SV phải xóa luôn hợp đồng của sinh viên đó
        //thêm việc giảm số sv đang ở xuống
        public bool XoaSV(string maSV, string maPhong)
        {
            string query = "DELETE FROM SinhVien WHERE MaSV='" + maSV + "'";
            
            return DAL_HopDong.Instance.xoaHD(maSV) 
                && DBProvider.Instance.ExecuteNonQuery(query) > 0 
                && DAL_Phong.Instance.giamSoSV(maPhong);
        }
    }

}