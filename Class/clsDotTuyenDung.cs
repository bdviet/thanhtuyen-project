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
    class clsDotTuyenDung
    {
        clsData kn = new clsData();
        //load du lieu vao gridview
        public void LoadDataGridView(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT * FROM tblDottuyendung", dgv);
        }
        //load dl vao combobox
        public void LoadComboBox_PhongBan(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblPhongban", "Tenphongban", "Maphongban", cb);
        }
        public void LoadComboBox_NguoiPhuTrach(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblNhanvien", "TenNV", "MaNV", cb);
        } 
        public void LoadComboBox_BangCap(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblBangcap", "Tenbangcap", "Mabangcap", cb);
        } 
       
        public void LoadComboBox_TrangThai(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Select("SELECT DISTINCT Trangthai FROM tblDotTuyenDung", "Trangthai", "Trangthai", cb);
        }

        //thu tuc xu ly du lieu
        public void Them_DotTD(string MaTD, string TenTD, string MaPB, string NguoiPT,  string Bangcap, string Chucvu, string Dotuoi,string Gioitinh, int Soluong,string Trangthai )
        {
            kn.StoreNone("proc_DotTD_Insert", MaTD, TenTD, MaPB, NguoiPT, Bangcap,Chucvu,Dotuoi,Gioitinh,Soluong,Trangthai);
        }
        public void Sua_DotTD(string MaTD, string TenTD, string MaPB, string NguoiPT, string Bangcap, string Chucvu, string Dotuoi, string Gioitinh, int Soluong, string Trangthai)
        {
            kn.StoreNone("proc_DotTD_Update", MaTD, TenTD, MaPB, NguoiPT, Bangcap, Chucvu, Dotuoi, Gioitinh, Soluong, Trangthai);
        }
        public void Xoa_DotTD(string MaDotTD)
        {
            kn.StoreNone("proc_DotTD_Delete", MaDotTD);
        }
    }
}
