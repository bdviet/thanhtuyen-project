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
using System.Security.Cryptography;

namespace QL_nhansu
{
    public partial class frmDangNhap : DevComponents.DotNetBar.Office2007Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public static string TenDN ;
        public static string TenDangNhap = null;
        public static string MatKhau;
        public static string Quyen;
        public int dem = 3;
        //public static  string quyenhan;
       // frmMain frm;
        
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Class.clsData.OpenSqlConnection();
            string strSql = "SELECT Chophepthaotac FROM tblNguoidung WHERE Usename='" + txtUser.Text + "' and Pass='" + txtMatKhau.Text + "'";
            string strSql1 = "SELECT Usename FROM tblNguoidung WHERE Usename='" + txtUser.Text + "' and Pass='" + txtMatKhau.Text + "'";
            string strSql2 = "SELECT Pass FROM tblNguoidung WHERE Usename= '" + txtUser.Text + "' and Pass='" + txtMatKhau.Text + "'";
        SqlCommand cmd = new SqlCommand(strSql);
            SqlCommand cmd1 = new SqlCommand(strSql1);
            SqlCommand cmd2 = new SqlCommand(strSql2);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn;
            cmd2.CommandType = CommandType.Text;
            cmd2.Connection = conn;
            try
            {
                Quyen = cmd.ExecuteScalar().ToString();
                TenDangNhap = (string)cmd1.ExecuteScalar();
                MatKhau = (string)cmd2.ExecuteScalar();
                //MessageBox.Show(TenDangNhap);
            }
            catch (Exception )
            {
                //MessageBox.Show(ex.Message);
            }
            if (dem > 0) /// mat khau la gi vay ??? 123456 ok
            {
                if (txtUser.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
                {
                    dem--;
                    MessageBox.Show("Bạn phải điền thông tin đăng nhập !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Focus();
                    return;
                }
                else
                    if (TenDangNhap == null)
                    {
                        dem--;
                        MessageBox.Show("Không tồn tại tên đăng nhập: " + txtUser.Text + " này", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Clear();
                        txtMatKhau.Clear();
                        txtUser.Focus();
                    }
                    else
                        if (MatKhau.ToString().Trim() != txtMatKhau.Text.Trim())
                        {
                            dem--;
                            MessageBox.Show("Mật khẩu không đúng !", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMatKhau.Clear();
                            txtMatKhau.Focus();
                        }
                        else
                            
                            if (TenDangNhap == txtUser.Text.Trim() && MatKhau == txtMatKhau.Text.Trim())
                            {

                                //MessageBox.Show(QuyenDN());
                                if (BienToanCuc.f_main == null || BienToanCuc.f_main.IsDisposed)
                                {
                                    BienToanCuc.f_main = new frmMain();
                                }

                                BienToanCuc.f_main.Q = QuyenDN();
                                BienToanCuc.f_main.frmMain_Load(null, null);//no bao loi o day ne
                              
                              
                                MessageBoxEx.Show("Bạn đã đăng nhập thành công", "Chúc mừng");
                                txtUser.Text = "";
                                txtMatKhau.Text = "";
                                this.Hide();
                            }
                 }
                     else
                if (dem == 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập quá 3 lần cho phép !");
                    Application.Exit();
                }
        }

        public string QuyenDN()
        {
            return Quyen;
        }
    }
}