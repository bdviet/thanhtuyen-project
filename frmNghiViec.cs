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
    public partial class frmNghiViec : DevComponents.DotNetBar.Office2007Form
    {
        Class.clsDieuKien dk = new QL_nhansu.Class.clsDieuKien();
        Class.clsNghiViec nvdn = new QL_nhansu.Class.clsNghiViec();
        //bool trangthai = true;
        public frmNghiViec()
        {
            InitializeComponent();
        }
        bool Trangthai = true;
        private void frmNghiViec_Load(object sender, EventArgs e)
        {
            dk.LoadLen(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
            nvdn.LoadDataGridView(dgvNghiViec);
            txtMaNghiViec.Text = dgvNghiViec[0, 0].Value.ToString();
            txtNhanVien.Text = dgvNghiViec[1, 0].Value.ToString();
            dtiNgayQuyetDinh.Text = dgvNghiViec[2, 0].Value.ToString();
            dtiNgayHieuLuc.Text = dgvNghiViec[3, 0].Value.ToString();
            txtLyDo.Text = dgvNghiViec[4, 0].Value.ToString();
            txtGhiChu.Text = dgvNghiViec[5, 0].Value.ToString();
        }

       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc không ?", "Xóa nghỉ việc", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                nvdn.XoaNghiViec(txtMaNghiViec.Text,txtNhanVien.Text);
                nvdn.LoadDataGridView(dgvNghiViec);
                Xoa();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        { Trangthai=true;
            int MaNghiViec = dk.MaTuTang(dgvNghiViec);

           
                if (MaNghiViec <= 9)
                {
                    txtMaNghiViec.Text = "NC" + "0" + MaNghiViec.ToString();
                }
                else
                {
                    txtMaNghiViec.Text = "NC" + MaNghiViec.ToString();
                }

                dk.Them(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                txtNhanVien.Text = "";
                txtLyDo.Text = "";
                txtGhiChu.Text = "";
                dtiNgayHieuLuc.Text = "";
                dtiNgayQuyetDinh.Text = "";
                          
                       

                        
                    
            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Trangthai=false;
            dk.Sua(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
           
                           
        }

        private void dgvNghiViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = dgvNghiViec.CurrentRow.Index;
            txtMaNghiViec.Text = dgvNghiViec[0, hang].Value.ToString();
            txtNhanVien.Text = dgvNghiViec[1, hang].Value.ToString();
            dtiNgayQuyetDinh.Text = dgvNghiViec[2, hang].Value.ToString();
            dtiNgayHieuLuc.Text = dgvNghiViec[3, hang].Value.ToString();
            txtLyDo.Text = dgvNghiViec[4, hang].Value.ToString();
            txtGhiChu.Text = dgvNghiViec[5, hang].Value.ToString();

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien f_NhanVien = new frmNhanVien();
            f_NhanVien.ShowDialog();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNghiViec.Text.Trim() == "")
            {
                MessageBoxEx.Show("Mã nghỉ việc không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNghiViec.Focus();
            }

            else
            
                if (txtNhanVien.Text.Trim() == "")
                {
                    MessageBoxEx.Show("Tên nhân viên không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNhanVien.Focus();
                }
                else
                    if (dtiNgayQuyetDinh.Text.Trim() == ""||dtiNgayQuyetDinh.Value.Date>DateTime.Now.Date)
                    {
                        MessageBoxEx.Show("Ngày quyết định không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtiNgayQuyetDinh.Focus();
                    }
                    else

                        if (dtiNgayHieuLuc.Text.Trim() == "")
                        {
                            MessageBoxEx.Show("Ngày hiệu lực không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dtiNgayHieuLuc.Focus();
                        }
                        else
                        {
                            if (Trangthai == true)
                            {
                                nvdn.ThemNghiViec(txtMaNghiViec.Text.ToString(), txtNhanVien.Text.ToString(), Convert.ToDateTime(dtiNgayQuyetDinh.Text), Convert.ToDateTime(dtiNgayHieuLuc.Text), txtLyDo.Text.ToString(), txtGhiChu.Text.ToString());
                            }
                            else
                            {
                                nvdn.SuaNghiViec(txtMaNghiViec.Text.ToString(), txtNhanVien.Text, Convert.ToDateTime(dtiNgayQuyetDinh.Text), Convert.ToDateTime(dtiNgayHieuLuc.Text), txtLyDo.Text.ToString(), txtGhiChu.Text.ToString());
                            }
                            nvdn.LoadDataGridView(dgvNghiViec);
                            dk.Luu(btnThem, btnSua, btnLuu, btnXoa, btnThoat);
                            Xoa();
                        }


        }
        public void Xoa()
        {
            txtMaNghiViec.Text = "";
            txtNhanVien.Text = "";
            txtLyDo.Text = "";
            txtGhiChu.Text = "";
            dtiNgayHieuLuc.Text = "";
            dtiNgayQuyetDinh.Text = "";
            
        }
        
    }
}