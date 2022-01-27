using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;
using static GUI.formSinhVien;

namespace GUI
{
    public partial class formChonPhong : DevExpress.XtraEditors.XtraForm
    {
        private int loaiPhong;
        private string phongChon=null;

        public SendMaPhong sendMaPhong;
        public formChonPhong()
        {
            InitializeComponent();
        }
        public formChonPhong(SendMaPhong send, int loaiphong)
        {
            InitializeComponent();
            sendMaPhong = send;
            loaiPhong = loaiphong;
            load();
        }
        void load()
        {
            List<DTO_Phong> list = layListPhong();
            foreach(DTO_Phong item in list)
            {
                Button btn = new Button() { Width = 90, Height = 90 };
                btn.Text = "Khu: "+item.KhuKTX +Environment.NewLine+"Số phòng: "+ item.MaPhong;
                btn.Font = new Font("Times New Roman", 11F);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.BackColor = Color.Aqua;
                
                btn.Click += Btn_Click;
                btn.Tag = item;
                flpPhong.Controls.Add(btn);
            }
        }

        private List<DTO_Phong> layListPhong()
        {
            List<DTO_Phong> listPhong = new List<DTO_Phong>();
            DataTable table = BUS_Phong.Instance.chonPhong(loaiPhong);
            foreach(DataRow item in table.Rows)
            {
                DTO_Phong phong = new DTO_Phong(item);
                listPhong.Add(phong);
            }
            return listPhong;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
           phongChon=((sender as Button).Tag as DTO_Phong).MaPhong;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            //Nếu chưa chọn phòng sẽ không thoát được
            if (phongChon!=null)
            {
                sendMaPhong(phongChon);
                Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}