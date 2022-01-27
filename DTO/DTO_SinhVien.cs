using System;
using DevExpress.Xpo;

namespace DTO
{

    public class DTO_SinhVien
    {
        private string maSV, hoTen ,
                ngaysinh,
                sdt , sdt2 ,
                email ,
                nganhhoc,
                khoahoc;
        private int gioitinh;

        public DTO_SinhVien(string maSV, string hoTen, string ngaysinh, string sdt, string sdt2, string email, string nganhhoc, string khoahoc, int gioitinh)
        {
            MaSV = maSV;
            HoTen = hoTen;
            Ngaysinh = ngaysinh;
            Sdt = sdt;
            Sdt2 = sdt2;
            Email = email;
            Nganhhoc = nganhhoc;
            Khoahoc = khoahoc;
            Gioitinh = gioitinh;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Sdt2 { get => sdt2; set => sdt2 = value; }
        public string Email { get => email; set => email = value; }
        public string Nganhhoc { get => nganhhoc; set => nganhhoc = value; }
        public string Khoahoc { get => khoahoc; set => khoahoc = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
    }

}