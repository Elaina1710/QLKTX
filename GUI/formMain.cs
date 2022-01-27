using System.Windows.Forms;
using DevExpress.XtraBars;

namespace GUI
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
        }
        //show form quản lý nhân viên
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            formNhanvien form = new formNhanvien();
            form.FormBorderStyle= FormBorderStyle.SizableToolWindow;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
        }
        //show form quản lý sinh viên
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            formSinhVien form = new formSinhVien();
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
        }
        //show form Quản lý Phòng
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            formPhong form = new formPhong();
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
        }
        //show form Hóa Đơn
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            formHoaDon form = new formHoaDon();
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
        }
        //show form thống kê Phòng
        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            baocaoPhong form = new baocaoPhong();
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
        }
        //show form Thống kê Hóa Đơn
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            baocaoHoaDon form = new baocaoHoaDon();
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void formMain_Load(object sender, System.EventArgs e)
        {

        }
    }
}