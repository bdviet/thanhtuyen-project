using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QL_nhansu
{
    public partial class frmBC_Bangchiluong : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsReport bc = new QL_nhansu.Class.clsReport();
        public frmBC_Bangchiluong()
        {
            InitializeComponent();
        }

        private void frmBC_Bangchiluong_Load(object sender, EventArgs e)
        {
            bc.LoadComboBox_phongban(cbphong);
            radchon1.Checked = true;

        }

        private void radchon1_CheckedChanged(object sender, EventArgs e)
        {
            if (radchon1.Checked == true)
            {
                groupPanel1.Enabled = true;
                groupPanel2.Enabled = false;
            }
            else
            {
                groupPanel1.Enabled = false;
                groupPanel2.Enabled = true;
            }
        }

        private void tbn_inBC_Click(object sender, EventArgs e)
        {
            if (radchon1.Checked == true)
            {
                rpt_BC_Chiluongthangnam pt = new rpt_BC_Chiluongthangnam();
                bc.loaddg_Chiluongthangnam(crystalReportViewer1, pt, Convert.ToInt32(cbthang.SelectedItem.ToString()), Convert.ToInt32(cbnam.SelectedItem.ToString()));
            }
            else
            {
                rpt_BC_Chiluongtheophong pt1 = new rpt_BC_Chiluongtheophong();
                bc.loaddg_Chiluongphongban(crystalReportViewer1, pt1, cbphong.SelectedValue.ToString());
            }
        }

       
    }
}