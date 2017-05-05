using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QL_nhansu.Class
{
    class clsPhongBan
    {
        clsData kn=new clsData();
        //public clsChucVu()
        //{
        //    kn = new clsData(@".\SQLEXPRESS", "QuanLy_NhanSu");
        //}
        public void ThemPB(string Mapb, string Tenpb, string Mota)
        {
            kn.StoreNone("proc_Phongban_Insert", Mapb, Tenpb, Mota);
        }
        public void SuaPB(string Mapb, string Tenpb, string Mota)
        {
            kn.StoreNone("proc_Phongban_Update", Mapb, Tenpb, Mota);
        }
        public void XoaPB(string Mapb)
        {
            kn.StoreNone("proc_Phongban_Delete", Mapb);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT Maphongban,Tenphongban,Ghichu FROM tblPhongban", dgv);
        }
        
    }
}
