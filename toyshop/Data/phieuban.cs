using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyshop.Data
{
    public class phieuban
    {
        public string mahang { get; set; }
        public int soluong { get; set; }
        public long giaban { get; set; }
        public long thanhtien { get; set; }
        public string phieu { get; set; }
        public DataTable getphieubantam()
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
        public int addHang()
        {

            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("luusanphamtam_ban", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", this.mahang);
                cmd.Parameters.AddWithValue("@soluong", this.soluong);
                cmd.Parameters.AddWithValue("@giaban", this.giaban);
                cmd.Parameters.AddWithValue("@thanhtien", this.thanhtien);
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
                cmd.Parameters.AddWithValue("@mahang", this.mahang);
                cmd.Parameters.AddWithValue("@gia", this.giaban);

                con.Open();
                kq = cmd.ExecuteScalar();
                if (kq != null)
                    if ((long)kq == this.giaban)   //giabanle
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
                cmd.Parameters.AddWithValue("@mahang", this.mahang);
                cmd.Parameters.AddWithValue("@soluong", this.soluong);
                cmd.Parameters.AddWithValue("@giaban", this.giaban);
                cmd.Parameters.AddWithValue("@thanhtien", this.thanhtien);
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
                cmd.Parameters.AddWithValue("@mahang", this.mahang);
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
    }
}
