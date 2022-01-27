using System;
using System.Linq;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class formNhanvien : DevExpress.XtraEditors.XtraForm
    {
        BindingSource nhanvienlist = new BindingSource();

        public formNhanvien()
        {
            InitializeComponent();
            load();
            NhanvienBinding();
        }
        void load()
        {
            dgvNhanvien.DataSource = nhanvienlist;
            loadNhanvien();

            dgvNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanvien.Columns[1].HeaderText = "Họ tên";
            dgvNhanvien.Columns[2].HeaderText = "Giới tính";
            dgvNhanvien.Columns[3].HeaderText = "SDT";
            dgvNhanvien.Columns[4].HeaderText = "Email";
            dgvNhanvien.Columns[5].HeaderText = "Mô tả";
        }
        void loadNhanvien()
        {
            nhanvienlist.DataSource = BUS_Nhanvien.Instance.getNhanVien();
        }
        void NhanvienBinding()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtHoten.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtMota.DataBindings.Add(new Binding("Text", dgvNhanvien.DataSource, "MoTa", true, DataSourceUpdateMode.Never));
            
        }
        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maNV = Convert.ToInt32(txtMaNV.Text);
            string gioitinh = rbtnNam.Checked ? "1" : "0";
            string hoten = txtHoten.Text, sdt = txtSDT.Text,
            email = txtEmail.Text, mota = txtMota.Text;
            if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(sdt)
                    || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            if(MessageBox.Show("Bạn có muốn sửa thông tin nhân viên này không ?", "Thông báo", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if(BUS_Nhanvien.Instance.suaNhanvien(hoten, gioitinh, sdt, email, mota, maNV))
                {
                     MessageBox.Show("Đã sửa thành công");
                     loadNhanvien();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa thông tin");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa thông tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNV = Convert.ToInt32(txtMaNV.Text);
            if (MessageBox.Show("Bạn có muốn xóa không ?","Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (BUS_Nhanvien.Instance.xoaNhanVien(maNV))
                {
                    MessageBox.Show("Đã xóa một nhân viên");
                   loadNhanvien();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa nhân viên");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioitinh = rbtnNam.Checked ? "1" : "0";
            string hoten = txtHoten.Text, sdt = txtSDT.Text,
                email = txtEmail.Text, mota = txtMota.Text;
            if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(sdt)
                || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
           
            if (BUS_Nhanvien.Instance.themNhanvien(hoten, gioitinh, sdt, email, mota))
            {
                
                MessageBox.Show("Đã thêm nhân viên");
                loadNhanvien();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            String keysearch = txtKey.Text;
            if (string.IsNullOrEmpty(keysearch))
            {
                loadNhanvien();
            }
            else if (rbtnMaNV.Checked)
            {
                //tìm nhân viên theo mã nhân viên
                nhanvienlist.DataSource = BUS_Nhanvien.Instance.getbyID(keysearch);
            }
            else
            {
                //tìm nhân viên theo tên
                nhanvienlist.DataSource = BUS_Nhanvien.Instance.getbyName(keysearch);
            }
        }
    }
}