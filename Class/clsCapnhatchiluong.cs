using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Threading;

namespace QL_nhansu.Class
{
    class clsCapnhatchiluong
    {
        clsKetnoi kn = new clsKetnoi();
        public DataTable LaybangcapnhatCL()
        {
            SqlCommand com = new SqlCommand("select * from tblCapnhatchiluong");
            kn.Load(com);
            return kn;
        }
        public void Capnhat(double Luongcoban, double phucapdochai, double trocapTN, double trocapantrua, double trocapxanha, double trocapQLDN)
        {
            string query = "UPDATE tblCapnhatchiluong SET Luongcoban='" + Luongcoban + "',Phucapdochai='" + phucapdochai + "',Trocaptrachnhiem='" + trocapTN + "',Trocapantrua='" + trocapantrua + "',Trocapxanha='" + trocapxanha + "',TrocapQLDN='" + trocapQLDN + "'";
            SqlCommand com = new SqlCommand(query);
            kn.Load(com);
        }
        public void HienthiGridtheoCNCL(DataTable dt, DataGridViewX dgv)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgv.DataSource = bs;
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
    }
}
