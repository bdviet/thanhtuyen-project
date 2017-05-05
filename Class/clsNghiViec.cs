using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar.Controls;

using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Data;
namespace QL_nhansu.Class
{
    class clsNghiViec
    {
        clsData kn = new clsData();

        public void ThemNghiViec(string MaNghiViec,string NhanVien, DateTime NgayQD,DateTime NgayHL, string LyDo, string GhiChu)
        {
            kn.StoreNone("proc_Nghiviec_Insert", MaNghiViec,NhanVien,NgayQD,NgayHL,LyDo,GhiChu);
        }
        public void SuaNghiViec(string MaNghiViec, string NhanVien, DateTime NgayQD, DateTime NgayHL, string LyDo,  string GhiChu)
        {
            kn.StoreNone("proc_Nghiviec_Update", MaNghiViec, NhanVien, NgayQD, NgayHL, LyDo,  GhiChu);
        }
        public void XoaNghiViec(string MaNghiViec ,string Manv)
        {
            kn.StoreNone("proc_Nghiviec_Delete",MaNghiViec,Manv);
        }
        //--------------------------
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT Manghiviec,MaNV,Ngayquyetdinh,Ngayhieuluc,Lydo,Ghichu FROM tblNghiviec", dgv);
        }
    }
}
