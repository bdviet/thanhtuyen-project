using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_nhansu
{
    public partial class frmBc_Nghiviec : Form
    {
        Class.clsReport bc = new QL_nhansu.Class.clsReport();
        public frmBc_Nghiviec()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
          
        }

        private void frmBc_Nghiviec_Load(object sender, EventArgs e)
        {
            CrystalReportNghiviec rp = new CrystalReportNghiviec();
            bc.Load_BC_Nghiviec(CryView, rp);

        }
    }
}
