using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using QL_nhansu.Controller;


namespace QL_nhansu
{
    public partial class frmCapnhatchiluong : DevComponents.DotNetBar.Office2007Form
    {
       
        Class.clsCapnhatchiluong CapnhatCL = new QL_nhansu.Class.clsCapnhatchiluong();
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        clsBangchamcongController control = new clsBangchamcongController();
        DataTable dtCNCL = new DataTable();
        public frmCapnhatchiluong()
        {
            InitializeComponent();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            //Download source code FREE tai Sharecode.vn
            DialogResult thongbaoxoa = MessageBox.Show("Bạn có muốn cập nhật chi lương không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (thongbaoxoa == DialogResult.OK)
            {
                groupchon.Enabled = true;
                bntLuu.Enabled = true;

            }
        }

        bool KiemTraNhapLieu()
        {
            bool ok = false;
            if (txtLuongCB.Text.Trim() == "")
            {
                MessageBoxEx.Show("Lương cơ bản không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuongCB.Focus();
            }
            else if (txtPhucapDH.Text.Trim() == "")
            {
                MessageBoxEx.Show("Phụ cấp độc hại không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhucapDH.Focus();
            }
            else if (txtTrocapTN.Text.Trim() == "")
            {
                MessageBoxEx.Show("Trợ cấp trách nhiệm không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrocapTN.Focus();
            }
            else if (txtTrocapantrua.Text.Trim() == "")
            {
                MessageBoxEx.Show("Trợ cấp ăn trưa không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrocapantrua.Focus();
            }

            else if (txtTrocapxanha.Text.Trim() == "")
            {
                MessageBoxEx.Show("Trợ cấp xa nhà không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrocapxanha.Focus();
            }
            else
            {
                if (txtTrocapQLDN.Text.Trim() == "")
                {
                    MessageBoxEx.Show("Trợ cấp quản lý doanh nghiệp không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTrocapQLDN.Focus();
                }
                else
                {
                    ok = true;//Download source code FREE tai Sharecode.vn
                }
            }
            return ok;

        }
        private void bntLuu_Click(object sender, EventArgs e)
        {

            if (KiemTraNhapLieu() == true)
            {
                DialogResult thongbaoxoa = MessageBox.Show("Bạn có muốn cập nhật chi lương không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (thongbaoxoa == DialogResult.OK)
                {
                    CapnhatCL.Capnhat(Convert.ToDouble(txtLuongCB.Text.ToString()), Convert.ToDouble(txtPhucapDH.Text.ToString()), Convert.ToDouble(txtTrocapTN.Text.ToString()), Convert.ToDouble(txtTrocapantrua.Text.ToString()), Convert.ToDouble(txtTrocapxanha.Text.ToString()), Convert.ToDouble(txtTrocapQLDN.Text.ToString()));
                    DataTable dtCNmoi = new DataTable();
                    dtCNmoi = CapnhatCL.LaybangcapnhatCL();
                    CapnhatCL.HienthiGridtheoCNCL(dtCNmoi, dtgCapnhatchiluong);
                    txtLuongCB.Text = "";
                    txtPhucapDH.Text = "";
                    txtTrocapantrua.Text = "";
                    txtTrocapQLDN.Text = "";
                    txtTrocapTN.Text = "";
                    txtTrocapxanha.Text = "";
                    groupchon.Enabled = false;
                }
                else
                {
                    txtLuongCB.Text = "";
                    txtPhucapDH.Text = "";
                    txtTrocapantrua.Text = "";
                    txtTrocapQLDN.Text = "";
                    txtTrocapTN.Text = "";
                    txtTrocapxanha.Text = "";
                }
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapnhatchiluong_Load(object sender, EventArgs e)
        {
            groupchon.Enabled = false;
            dtCNCL = CapnhatCL.LaybangcapnhatCL();
            CapnhatCL.HienthiGridtheoCNCL(dtCNCL, dtgCapnhatchiluong);
            bntLuu.Enabled = false;
            dtgCapnhatchiluong.Enabled = false;
        }

        private void txtLuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoThuc(sender, e, txtLuongCB);
        }

        private void txtPhucapDH_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoThuc(sender, e, txtPhucapDH);
        }

        private void txtTrocapTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoThuc(sender, e, txtTrocapTN);
        }

        private void txtTrocapantrua_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoThuc(sender, e, txtTrocapantrua);
        }

        private void txtTrocapxanha_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoThuc(sender, e, txtTrocapxanha);
        }

        private void txtTrocapQLDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            dk.NhapSoThuc(sender, e, txtTrocapQLDN);
        }

       
    }
}