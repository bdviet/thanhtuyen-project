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
    class clsHopDong

    {
        clsData kn = new clsData();
        //load du lieu vao gridview
        public void LoadDataGridView (DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT Mahopdong,MaNV,Ngaybatdau,Ngayketthuc,Lanky,Noidung,Ngayky,Tennguoiky,Ghichu FROM tblHopdong", dgv);
        }
        public void LoadDataGridView_HopDong_TimKiem(DataGridViewX dgv ,string Manv)
        {
            kn.LoadDGV("SELECT Mahopdong,MaNV,Ngaybatdau,Ngayketthuc,Lanky,Noidung,Ngayky,Tennguoiky,Ghichu FROM tblHopdong WHERE MaNV='" + Manv + "'", dgv);
        }
        //load dl vao combobox
        public void LoadComboBox_NhanVien(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblNhanvien", "TenNV", "MaNV", cb);
        }
        public void LoadComboBox_LanKy(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Select("SELECT DISTINCT Lanky FROM tblHopdong", "Lanky", "Lanky", cb);
        }
        public void LoadComboBox_NguoiKy(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblNhanvien", "TenNV", "MaNV", cb);
        }
        //thu tuc xu ly du lieu
        public void ThemHD(string Mahd, string Manv, DateTime Ngaybatdau, DateTime Ngayketthuc,int Lanky, string Noidung, DateTime Ngayky, string Nguoiky, string Ghichu)
        {
            kn.StoreNone("proc_Hopdong_Insert", Mahd, Manv, Ngaybatdau, Ngayketthuc,Lanky, Noidung, Ngayky, Nguoiky, Ghichu);
        }
        public void SuaHD(string Mahd, string Manv, DateTime Ngaybatdau, DateTime Ngayketthuc, int Lanky, string Noidung,  DateTime Ngayky, string Nguoiky, string Ghichu)
        {
            kn.StoreNone("proc_Hopdong_Update", Mahd, Manv, Ngaybatdau, Ngayketthuc,Lanky,Noidung,Ngayky, Nguoiky, Ghichu);
        }
        public void XoaHD(string Mahd)
        {
            kn.StoreNone("proc_Hopdong_Delete", Mahd);
        }
    }
}
