using System;
using System.Data;
using DevExpress.Xpo;

namespace DTO
{

    public class DTO_Phong
    {
        private string khuKTX;
        private string maPhong;

        public DTO_Phong(string khu, string maPhong)
        {
            KhuKTX = khu;
            MaPhong = maPhong;
        }
        public DTO_Phong(DataRow row)
        {
            KhuKTX = row["KhuKTX"].ToString();
            MaPhong = row["MaPhong"].ToString();
        }
        public string KhuKTX { get { return khuKTX; } set => khuKTX = value; }
        public string MaPhong { get { return maPhong; } set => maPhong = value; }
    }

}