using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace QL_nhansu.Class
{
    public class clsLaybangchiluong
    {
        clsKetnoi kn = new clsKetnoi();
        public DataTable Laybangluongtheothangnam(int thang, int nam)
        {
            SqlCommand com = new SqlCommand("select * from tblBangchiluong where month(Thangchi)='" + thang + "'and year(Thangchi)='" + nam + "'");
            kn.Load(com);
            return kn;
        }
        public void Capnhatngaylamtheothangnam(int thang, int nam, int ngaylam, string MaNV)
        {
            SqlCommand com = new SqlCommand("update tblBangchiluong set Ngaylamviec='" + ngaylam + "' where MaNV='" + MaNV + "'and month(Thangchi)='" + thang + "'and year(Thangchi)='" + nam + "'");
            kn.Load(com);

        }
        public void Xoa(string maluong)
        {
            SqlCommand com = new SqlCommand("delete from tblBangchiluong where Maluong='" + maluong + "'");
            kn.Load(com);

        }

        public void Capnhattruluong(int thang, int nam, string manv, double truluong, double thuclinh)
        {
            SqlCommand com = new SqlCommand("update tblBangchiluong set Truluong='" + truluong + "',Thuclinh='" + thuclinh + "'where MaNV='" + manv + "'and month(Thangchi)='" + thang + "'and year(Thangchi)='" + nam + "'");
            kn.Load(com);
        }


        public DataTable Laybangluong()
        {
            SqlCommand com = new SqlCommand("select * from tblBangchiluong");
            kn.Load(com);
            return kn;
        }
        public DataTable Laybangluongrong()
        {
            SqlCommand com = new SqlCommand("select * from tblBangchiluong where Maluong=''");
            kn.Load(com);
            return kn;
        }
        public void Themmoi(string maluong, string thangchi, string manv, int ngaylamviec, double luongthang, double truluong, double phucapCV, double phucapdochai, double trocapTN, double trocapantrua, double trocapxanha, double trocapQLDN, double tongluong, double BHXH, double BHYT, double doanphi, double thuclinh)
        {
            string query = "INSERT INTO tblBangchiluong(Maluong,Thangchi,MaNV,Ngaylamviec,Luongthang,Truluong,PhucapCV,Phucapdochai,Trocaptrachnhiem,Trocapantrua,Trocapxanha,TrocapQLDN,Tongluong,BHXH,BHYT,Doanphi,Thuclinh) values ('" + maluong + "','" + thangchi + "','" + manv + "','" + ngaylamviec + "','" + luongthang + "','" + truluong + "','" + phucapCV + "','" + phucapdochai + "','" + trocapTN + "','" + trocapantrua + "','" + trocapxanha + "','" + trocapQLDN + "','" + tongluong + "','" + BHXH + "','" + BHYT + "','" + doanphi + "','" + thuclinh + "')";
            SqlCommand com = new SqlCommand(query);
            kn.Load(com);
        }
        public void Capnhat(string maluong, double tongluong, double thuclinh, double phucapDH, double trocapTN, double trocapantrua, double trocapxanha, double trocapQLDN)
        {
            string query = "update tblBangchiluong set Phucapdochai=" + phucapDH + ",Trocaptrachnhiem=" + trocapTN + ",Trocapantrua=" + trocapantrua + ",Trocapxanha=" + trocapxanha + ", TrocapQLDN=" + trocapQLDN + ",Tongluong=" + tongluong + " where Maluong=" + maluong + "";
            SqlCommand com = new SqlCommand(query);
            kn.Load(com);
        }

        //------------------
        public DataTable Laybangchamcongtheochucvu()
        {
            SqlCommand com = new SqlCommand("select * from View_Chamcongchucvu");
            kn.Load(com);
            return kn;
        }

    }
}
