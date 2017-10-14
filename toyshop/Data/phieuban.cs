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
        
    }
}
