using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_nhansu.Class;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace QL_nhansu.Controller
{
    public class clsBangchiluongController
    {
        clsLaybangchiluong bangchiluong = new clsLaybangchiluong();
        clsLaybangnhanvien nv = new clsLaybangnhanvien();
        clsLayphongban phongban = new clsLayphongban();

        public void HienthicomboboxNV(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = nv.Laynhanvien();
            cmb.DisplayMember = "TenNV";
            cmb.ValueMember = "MaNV";
            cmb.DataPropertyName = "MaNV";

        }
        public void Hienthicomboboxphongban(ComboBoxEx cmb)
        {
            cmb.DataSource = phongban.Layphongban();
            cmb.DisplayMember = "Tenphongban";
            cmb.ValueMember = "Maphongban";
        }
        public void Hienthi(ComboBoxEx cmb)
        {
            //cmb.DataSource = phongban.Layphongban();
            //cmb.DisplayMember = "Tenphongban";
            //cmb.ValueMember = "Maphongban";
        }
        public void HienThiGridTheoThangNam(DataTable dt, DataGridViewX dtg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            bn.BindingSource = bs;
            dtg.DataSource = bs;
        }
    }
}
