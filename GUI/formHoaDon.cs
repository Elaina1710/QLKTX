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
using BUS;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class formHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public formHoaDon()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            loadAll();
            dgvHoaDon.Columns[0].HeaderText = "Mã Phòng";
            dgvHoaDon.Columns[1].HeaderText = "Ngày lập";
            dgvHoaDon.Columns[2].HeaderText = "Chỉ số điện cũ";
            dgvHoaDon.Columns[3].HeaderText = "Chỉ số điện mới";
            dgvHoaDon.Columns[4].HeaderText = "Chỉ số nước cũ";
            dgvHoaDon.Columns[5].HeaderText = "Chỉ số nước mới";
            dgvHoaDon.Columns[6].HeaderText = "Tổng tiền";
            dgvHoaDon.Columns[7].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns[8].HeaderText = "Số tiền đã nộp";
        }
        void loadAll()
        {
            dgvHoaDon.DataSource = BUS_HoaDon.Instance.getAll();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maPhong = txtMaPhong.Text;
            DataTable table = BUS_HoaDon.Instance.getChiSo(maPhong);
            if(table.Rows.Count==0)
            {
                MessageBox.Show("Mã phòng không hợp lệ");
            }
            else 
            {
                //chỉ số điện cũ
                txtCSDienCu.Text = table.Rows[0][0].ToString();
                //chỉ số nước cũ
                txtCSNuocCu.Text = table.Rows[0][1].ToString();
            }
        }

        private void txtCSDienMoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int chisocu = Int32.Parse(txtCSDienCu.Text),
                    chisomoi = Int32.Parse(txtCSDienMoi.Text);
                //trường hợp nhập chỉ số điện mới không lớn hơn chỉ số cũ
                if (chisocu - chisomoi >= 0)
                {
                    txtCSDienMoi.ForeColor = Color.Red;
                    txtSoDien.Text = "0";
                    txtTienDien.Text = "0";
                }
                //trường hợp ngược lại
                else
                {
                    int tien1ChiSoDien = 3200;
                    txtCSDienMoi.ForeColor = Color.Green;
                    txtSoDien.Text =(chisomoi - chisocu).ToString();
                    txtTienDien.Text = ((chisomoi - chisocu)*tien1ChiSoDien).ToString();
                }
            }
            catch
            {
                txtSoDien.Text = "0";
                txtTienDien.Text = "0";
            }
        }

        private void txtCSNuocMoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int chisocu = Int32.Parse(txtCSNuocCu.Text),
                    chisomoi = Int32.Parse(txtCSNuocMoi.Text);
                //trường hợp nhập chỉ số nước mới không lớn hơn chỉ số cũ
                if (chisocu - chisomoi >= 0)
                {
                    txtCSNuocMoi.ForeColor = Color.Red;
                    txtSoNuoc.Text = "0";
                    txtTienNuoc.Text = "0";
                }
                //trường hợp ngược lại
                else
                {
                    int tien1ChiSoNuoc = 2000;
                    txtCSNuocMoi.ForeColor = Color.Green;
                    txtSoNuoc.Text = (chisomoi - chisocu).ToString();
                    txtTienNuoc.Text = ((chisomoi - chisocu) * tien1ChiSoNuoc).ToString();
                }
            }
            catch
            {
                txtSoNuoc.Text = "0";
                txtTienNuoc.Text = "0";
            }
        }

        private void txtCSDienMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtCSNuocMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtTienDien_TextChanged(object sender, EventArgs e)
        {
            txtTongTien.Text = (Int32.Parse(txtTienNuoc.Text) +
                Int32.Parse(txtTienDien.Text)).ToString();
        }

        private void txtTienNuoc_TextChanged(object sender, EventArgs e)
        {
            txtTongTien.Text = (Int32.Parse(txtTienNuoc.Text) + 
                Int32.Parse(txtTienDien.Text)).ToString();
        }
    }
}