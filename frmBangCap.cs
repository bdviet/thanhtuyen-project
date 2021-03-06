using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QL_nhansu
{
    public partial class frmBangCap : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsBangCap nvdn = new QL_nhansu.Class.clsBangCap();
        public frmBangCap()
        {
            InitializeComponent();
        }
        bool Trangthai = true;
        private void frmBangCap_Load(object sender, EventArgs e)
        {
            dk.LoadLen(btnThem, btnSua,btnLuu, btnXoa, btnThoat);
            nvdn.LoadDataGridView(dgvBangCap);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa bằng cấp", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.Xoa_BangCap(txtMaBangCap.Text);
                nvdn.LoadDataGridView(dgvBangCap);
                Xoa();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Trangthai = false;
            
                   
                    dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int MaBC = dk.MaTuTang(dgvBangCap);

            if (MaBC <= 9)
            {
                txtMaBangCap.Text = "BC" + "0" + MaBC.ToString();
            }
            else
            {
                txtMaBangCap.Text = "BC" + MaBC.ToString();
            }

                           
                    dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                    txtTenBangCap.Text = "";
        }

        private void dgvBangCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvBangCap.CurrentRow.Index;
            txtMaBangCap.Text = dgvBangCap[0, hang].Value.ToString();
            txtTenBangCap.Text = dgvBangCap[1, hang].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaBangCap.Text.Trim() == "")
            {
                MessageBoxEx.Show("Mã bằng cấp không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaBangCap.Focus();
            }
            else

                if (txtTenBangCap.Text.Trim() == "")
                {
                    MessageBoxEx.Show("Tên bằng cấp không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenBangCap.Focus();
                }
                else
                {
                    if (Trangthai == true)
                    {
                        nvdn.Them_BangCap(txtMaBangCap.Text, txtTenBangCap.Text);
                    }
                    else
                    {
                        nvdn.Sua_BangCap(txtMaBangCap.Text, txtTenBangCap.Text);
                    }
                    nvdn.LoadDataGridView(dgvBangCap);
                    dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                    Xoa();
                }
                }
        public void Xoa()
        {
            txtMaBangCap.Text = "";
            txtTenBangCap.Text = "";

        }

    }
}