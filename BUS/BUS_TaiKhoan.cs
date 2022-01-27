using DAL;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        private static BUS_TaiKhoan instance;
        private BUS_TaiKhoan() { }

        public static BUS_TaiKhoan Instance {
            get { if (instance == null) instance = new BUS_TaiKhoan(); 
                return instance; }
            private set { instance = value; }
        }

        public bool login(string user,string pass)
        {
            return DAL_TaiKhoan.Instance.login(user, pass);
        }
    }
}
