using BUS;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace GUI
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        public formLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPass.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập/mật khẩu");
                return;
            }
            if (login(user,pass))
            {
                formMain form = new formMain();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.");
            }
        }
        bool login(string user,string pass)
        {
            return BUS_TaiKhoan.Instance.login(user,pass);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", 
                MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}