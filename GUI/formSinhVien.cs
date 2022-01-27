using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static GUI.formChonPhong;
using BUS;
using DTO;

namespace GUI
{
    public partial class formSinhVien : XtraForm
    {
        public delegate void SendMaPhong(String maPhong);

        BindingSource listSV = new BindingSource();
        public formSinhVien()
        {
            InitializeComponent();
            load();
            
            BindSinhVien();
        }
        void load()
        {
            dgvSV.DataSource = listSV;
            loadSV();

            dgvSV.Columns[0].HeaderText ="Mã SV";
            dgvSV.Columns[1].HeaderText ="Họ Tên";
            dgvSV.Columns[2].HeaderText ="Giới tính";
            dgvSV.Columns[3].HeaderText ="Ngày sinh";
            dgvSV.Columns[4].HeaderText ="SDT";
            dgvSV.Columns[5].HeaderText ="Email";
            dgvSV.Columns[6].HeaderText ="SDT phụ huynh";
            dgvSV.Columns[7].HeaderText ="Ngành học";
            dgvSV.Columns[8].HeaderText ="Khóa học";
            dgvSV.Columns[9].HeaderText ="Mã phòng";
        }
        void loadSV()
        {
            listSV.DataSource = BUS_SinhVien.Instance.getSinhVien();
        }
        void BindSinhVien()
        {
            txtMaSV.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
            txtTenSV.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            dateSV.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtMaPhong.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            cmbNganh.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "NganhHoc", true, DataSourceUpdateMode.Never));
            txtKhoa.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "KhoaHoc", true, DataSourceUpdateMode.Never));
            txtSDT2.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "SDTNguoiThan", true, DataSourceUpdateMode.Never));
            dateStart.DataBindings.Add(new Binding("Text", dgvSV.DataSource, "NgayBatDau", true, DataSourceUpdateMode.Never));
        }

        private void setMaPhong(string maPhong)
        {
            txtMaPhong.Text = maPhong;
        }
        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            int loaiPhong = rbtnNam.Checked ? 1 : 0;
            formChonPhong form = new formChonPhong(setMaPhong,loaiPhong);
            form.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text, hoTen = txtTenSV.Text,
                ngaysinh = dateSV.Value.ToString("yyyyMMdd"),
                sdt = txtSDT.Text, sdt2 = txtSDT2.Text,
                email = txtEmail.Text,
                nganhhoc = cmbNganh.Text,
                khoahoc = txtKhoa.Text,
                maPhong = txtMaPhong.Text,
                ngayBatDau = dateStart.Value.ToString("yyyyMMdd");
            int gioitinh = rbtnNam.Checked ? 1 : 0;
            
            string maHopDong = "HD" + maSV;

            DTO_SinhVien sv = new DTO_SinhVien(maSV, hoTen, ngaysinh, sdt, sdt2, 
                email, nganhhoc, khoahoc, gioitinh);

            if (BUS_SinhVien.Instance.themSV(sv,maHopDong,maPhong,ngayBatDau))
            {
                MessageBox.Show("Đã thêm một sinh viên");
                loadSV();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sinh viên");
            }
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text, maPhong = txtMaPhong.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                if (BUS_SinhVien.Instance.xoaSV(maSV, maPhong))
                {
                    MessageBox.Show("Đã xóa một sinh viên");
                    loadSV();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa sinh viên");
                }
            }
        }
        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtName.Text = Convert.ToString(dgvDeparts.CurrentRow.Cells["clName"].Value);
                txtDescription.Text = Convert.ToString(dgvDeparts.CurrentRow.Cells["clDescription"].Value);
            }*/
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keysearch = txtKey.Text;
            if (String.IsNullOrEmpty(keysearch))
            {
                loadSV();
            }else if (rbtnMaSV.Checked)
            {
                //tìm theo mã SV
                listSV.DataSource = BUS_SinhVien.Instance.getbyID(keysearch);
            }
            else
            {
                //tìm theo tên SV
                listSV.DataSource = BUS_SinhVien.Instance.getbyName(keysearch);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}