using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QL_nhansu
{
    public partial class frmBc_Phongban : Form
    {
        Class.clsReport nvrp = new Class.clsReport();
        public frmBc_Phongban()
        {
            InitializeComponent();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            CrystalReportPb bc = new CrystalReportPb();
            nvrp.Load_BC_Phongban(CryView, bc,cmbPhongban.SelectedValue.ToString());
        }

        private void frmBc_Phongban_Load(object sender, EventArgs e)
        {
            nvrp.LoadComboBox_phongban(cmbPhongban);
        }

        private void CryView_Load(object sender, EventArgs e)
        {

        }


         }
}
