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
    public partial class frmBc_Kyluat : Form
    {
        Class.clsReport bc = new QL_nhansu.Class.clsReport();
        public frmBc_Kyluat()
        {
            InitializeComponent();
        }

        private void frmBc_Kyluat_Load(object sender, EventArgs e)
        {
            CrystalReportKL rp = new CrystalReportKL();
            bc.Load_BC_Kyluat(CryViewKL, rp);
        }
    }
}
