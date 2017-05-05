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
    class clsDotPhongVan
    {
        clsData kn = new clsData();
        //load du lieu vao gridview
        public void LoadDataGridView_PhongVan(DataGridViewX dgv)
        {
            kn.LoadDGV("SELECT Madotphongvan,Tendotphongvan,Madottuyendung,Manguoiphongvan,Ngaybatdau,Ngayketthuc,Chude,Madiadiem,Tinhtrang,Ghichu FROM tblDotphongvan", dgv);
        }
        public void LoadDataGridView_UngVien(DataGridViewX dgv, string MaPV)
        {
            kn.LoadDGV("SELECT Maungvien,Tenungvien,Ngaysinh,Gioitinh,Diachi,SDTrieng,Ngaynophoso,Trangthai,Madotphongvan FROM tblUngvien WHERE Madotphongvan='" + MaPV + "'", dgv);
        }
        //load dl vao combobox
        public void LoadComboBox_DotTuyenDung(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblDottuyendung", "Tendottuyendung", "Madottuyendung", cb);
        }
        public void LoadComboBox_NguoiPV(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblNhanvien", "TenNV", "MaNV", cb);
        }
        public void LoadComboBox_Diadiem(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Value("tblDiadiem", "Tendiadiem", "Madiadiem", cb);
        }
        public void LoadComboBox_TinhTrang(ComboBoxEx cb)
        {
            kn.LoadDataComboBox_Select("SELECT DISTINCT Tinhtrang FROM tblDotPhongVan", "Tinhtrang", "Tinhtrang", cb);
        }

        //thu tuc xu ly du lieu
        public void Them_DotPV(string MaPV, string TenPV,string MadotTD,string NguoiPV, DateTime Ngaybatdau, DateTime Ngayketthuc, string Chude, string Madiadiem, string Tinhtrang, string Ghichu)
        {
            kn.StoreNone("proc_DotPV_Insert", MaPV,TenPV,MadotTD,NguoiPV,Ngaybatdau,Ngayketthuc,Chude,Madiadiem,Tinhtrang,Ghichu);
        }
        public void Sua_DotPV(string MaPV, string TenPV, string MadotTD, string NguoiPV, DateTime Ngaybatdau, DateTime Ngayketthuc, string Chude, string Madiadiem, string Tinhtrang, string Ghichu)
        {
            kn.StoreNone("proc_DotPV_Update", MaPV, TenPV, MadotTD, NguoiPV, Ngaybatdau, Ngayketthuc, Chude, Madiadiem, Tinhtrang, Ghichu);
        }
        public void Xoa_DotPV(string MaDotPV)
        {
            kn.StoreNone("proc_DotPV_Delete", MaDotPV);
        }
    }
}
