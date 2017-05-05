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
    public partial class frmBc_Khenthuong : Form
    {
        Class.clsReport bc = new QL_nhansu.Class.clsReport();
        public frmBc_Khenthuong()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmBc_Khenthuong_Load(object sender, EventArgs e)
        {
            CrystalReportKT rp = new CrystalReportKT();
            bc.Load_BC_Khenthuong(CryView, rp);
        }
    }
}
