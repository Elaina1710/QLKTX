using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class formPhong : DevExpress.XtraEditors.XtraForm
    {
        BindingSource listPhong = new BindingSource();

        public formPhong()
        {
            InitializeComponent();
            
            load();
            phongBinding();
        }
        void load()
        {
            dgvPhong.DataSource = listPhong;
            loadPhong();

            dgvPhong.Columns[0].HeaderText = "Mã Phòng";
            dgvPhong.Columns[1].HeaderText = "Khu KTX";
            dgvPhong.Columns[2].HeaderText = "Loại phòng";
            dgvPhong.Columns[3].HeaderText = "Số SV tối đa";
            dgvPhong.Columns[4].HeaderText = "Số SV đang ở";
            dgvPhong.Columns[5].HeaderText = "Tình trạng";
            dgvPhong.Columns[6].HeaderText = "Mô tả";
        }
        void loadPhong()
        {
            listPhong.DataSource = BUS_Phong.Instance.getPhong();
        }
        void phongBinding()
        {
            txtMa.DataBindings.Add(new Binding("Text", listPhong, "MaPhong", true, DataSourceUpdateMode.Never));
            numMaxSV.DataBindings.Add(new Binding("Text", listPhong, "SoSVToiDa", true, DataSourceUpdateMode.Never));
            txtSoSV.DataBindings.Add(new Binding("Text", listPhong, "SoSVDangO", true, DataSourceUpdateMode.Never));
            txtMota.DataBindings.Add(new Binding("Text", listPhong, "MoTa", true, DataSourceUpdateMode.Never));
            cmbKhu.DataBindings.Add(new Binding("Text", listPhong, "KhuKTX", true, DataSourceUpdateMode.Never));
            cmbLoai.DataBindings.Add(new Binding("Text", listPhong, "LoaiPhong", true, DataSourceUpdateMode.Never));
            cmbTinhTrang.DataBindings.Add(new Binding("Text", listPhong, "TinhTrang", true, DataSourceUpdateMode.Never));
        }
           
        private void btnThem_Click(object sender, EventArgs e)
        {
            string khuKTX = cmbKhu.SelectedItem.ToString();
            string maPhong = txtMa.Text;
            int maxSV =(int)numMaxSV.Value;
            int svDangO = 0;
            int LoaiPhong = cmbLoai.SelectedItem.ToString().Equals("Nam") ? 1 : 0;
            int TinhTrang = cmbTinhTrang.SelectedItem.ToString().Equals("Bình thường") ? 1 : 0;
            string mota = txtMota.Text;
            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            if (BUS_Phong.Instance.timTheoMa(maPhong).Rows.Count>0)
            {
                MessageBox.Show("Không được trùng mã phòng");
                return;
            }
            if (BUS_Phong.Instance.themPhong(maPhong, khuKTX, LoaiPhong, maxSV, svDangO, TinhTrang, mota))
            {
                MessageBox.Show("Đã thêm một phòng");
                loadPhong();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm phòng");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = txtMa.Text;
            int maxSV = (int)numMaxSV.Value;
            int LoaiPhong = cmbLoai.SelectedItem.ToString().Equals("Nam") ? 1 : 0;
            int TinhTrang = cmbTinhTrang.SelectedItem.ToString().Equals("Bình thường") ? 1 : 0;
            string mota = txtMota.Text;
            if (BUS_Phong.Instance.suaPhong(maxSV, LoaiPhong, TinhTrang, mota, maPhong))
            {
                MessageBox.Show("Đã sửa thành công");
                loadPhong();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa phòng");
            }
        }
        //Khi xóa phòng cần đảm bảo là không có sinh viên ở trong phòng đó
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhong = txtMa.Text;
            int soSVDangO = Convert.ToInt32(txtSoSV.Text);
            if (soSVDangO > 0)
            {
                MessageBox.Show("Đang có sinh viên ở trong phòng này");
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa phòng này hay không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (BUS_Phong.Instance.xoaPhong(maPhong))
                {
                    MessageBox.Show("Bạn đã xóa một phòng");
                    loadPhong();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa phòng");
                }
            }
        }
    }
}