using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyshop.Data
{
    public class Phieuban
    {
        public string Mahang { get; set; }
        public int Soluong { get; set; }
        public long Giaban { get; set; }
        public long Thanhtien { get; set; }
        public int Phieu { get; set; }
        public DataTable Getphieubantam()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("getphieubantam", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                dt = ds.Tables[0];

            }
            return dt;
        }
        public int AddHang()
        {

            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("luusanphamtam_ban", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", this.Mahang);
                cmd.Parameters.AddWithValue("@soluong", this.Soluong);
                cmd.Parameters.AddWithValue("@giaban", this.Giaban);
                cmd.Parameters.AddWithValue("@thanhtien", this.Thanhtien);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    return -1;
                }


            }
            return 1;
        }
        public DataTable hien_gb_sl_dvt(string mahang)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("hien_gb_sl_dvt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", mahang);
                DataSet ds = new DataSet();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                dt = ds.Tables[0];

            }
            return dt;
        }
        public int checkGiaSiLe()
        {
            object kq;
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("checkgiasile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", this.Mahang);
                cmd.Parameters.AddWithValue("@gia", this.Giaban);

                con.Open();
                kq = cmd.ExecuteScalar();
                if (kq != null)
                    if ((long)kq == this.Giaban)   //giabanle
                    {
                        return 0;
                    }
                    else
                        return 1;
                else
                    return -1;
            }
        }
        public int capnhatHang()
        {
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("capnhatphieubantam", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", this.Mahang);
                cmd.Parameters.AddWithValue("@soluong", this.Soluong);
                cmd.Parameters.AddWithValue("@giaban", this.Giaban);
                cmd.Parameters.AddWithValue("@thanhtien", this.Thanhtien);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return 1;
        }
        public int xoaHang()
        {
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("xoasp_phieubantam", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", this.Mahang);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return 1;
        }
        public int chotToa(int nhanvien)
        {
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("chot_banhang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nhanvien", nhanvien);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return 1;
        }
        public DataTable get_report_all_pb()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("REPORT_PHIEUBANHANG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                dt = ds.Tables[0];


            }
            return dt;
        }
        public DataSet get_report_ct_pb()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("REPORT_CHITIETPHIEUBAN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phieu", this.Phieu);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);



            }
            return ds;
        }
    }
}
