using System;
using System.Data;
using System.Data.SqlClient;

namespace GUI
{
    public partial class baocaoHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public baocaoHoaDon()
        {
            InitializeComponent();
        }

        private void formBaoCao_Load(object sender, EventArgs e)
        {
            /*CrystalReport1 crp = new CrystalReport1();
            SqlConnection conn = 
                new SqlConnection("Data Source=ELAINA;Initial Catalog=QLKTX;Integrated Security=True");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("select id,HoTen from demo", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            crp.SetDataSource(ds.Tables[0]);
            
            crv.ReportSource=crp;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}