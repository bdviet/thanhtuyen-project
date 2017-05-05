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
    public partial class frmBC_Bangchamcong : DevComponents.DotNetBar.Office2007Form
    {
        public frmBC_Bangchamcong()
        {
            InitializeComponent();
        }
        Class.clsReport nvrp = new Class.clsReport();

        private void btnInbaocao_Click(object sender, EventArgs e)
        {
            if (radchon1.Checked == true)
            {
                rpt_BC_Chamcongthangnam1 pt = new rpt_BC_Chamcongthangnam1();
                nvrp.loaddg_Chamcongthangnam(CryView, pt, Convert.ToInt32(cbthang.SelectedItem.ToString()), Convert.ToInt32(cbnam.SelectedItem.ToString()));
            
            }
            else
            {//Download source code FREE tai Sharecode.vn
                //rptChamcongtheophong pt1 = new rptChamcongtheophong();
                rpt_BC_Chamcongphongban1 pt1 = new rpt_BC_Chamcongphongban1();
                nvrp.loaddg_Chamcongphongban(CryView, pt1, combophongban.SelectedValue.ToString());

            }
        }

        private void frmBC_Bangchamcong_Load(object sender, EventArgs e)
        {
            nvrp.LoadComboBox_phongban(combophongban);
            radchon1.Checked = true;
        }

        private void radchon1_CheckedChanged(object sender, EventArgs e)
        {
            if (radchon1.Checked == true)
            {
                groupPanel1.Enabled = false;
                groupPanel2.Enabled = true;
            }
            else
            {
                groupPanel1.Enabled = true;
                groupPanel2.Enabled = false;
            }
            //Download source code FREE tai Sharecode.vn
               
        }

        private void combophongban_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
       

      
    }
}