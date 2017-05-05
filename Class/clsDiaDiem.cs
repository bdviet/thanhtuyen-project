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
    class clsDiaDiem
    {
        clsData kn = new clsData();

        public void Them_DiaDiem(string MaDD, string TenDD)
        {
            kn.StoreNone("proc_DiaDiem_Insert", MaDD, TenDD);
        }
        public void Sua_DiaDiem(string MaDD, string TenDD)
        {
            kn.StoreNone("proc_DiaDiem_Update", MaDD, TenDD);
        }
        public void Xoa_DiaDiem(string MaDD)
        {
            kn.StoreNone("proc_DiaDiem_Delete", MaDD);
        }
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT * FROM tblDiadiem", dgv);
        }
    }
}
