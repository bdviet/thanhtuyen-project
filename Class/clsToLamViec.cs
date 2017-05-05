using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Globalization;

namespace QL_nhansu.Class
{
    class clsToLamViec
    {
        clsData kn = new clsData();
        public void ThemTo(string Mato, string Tento, string Ghichu, string MaPb)
        {
            kn.StoreNone("proc_Tolamviec_Insert", Mato, Tento, Ghichu,MaPb);
        }
        public void SuaTo(string Mato, string Tento, string Ghichu, string MaPb)
        {
            kn.StoreNone("proc_Tolamviec_Update", Mato, Tento, Ghichu,MaPb);
        }
        public void XoaTo(string Mato)
        {
            kn.StoreNone("proc_Tolamviec_Delete", Mato);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT Mato,Tento,Maphongban,Ghichu FROM tblTolamviec", dgv);
        }
       
    }
}
