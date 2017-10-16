using System.Data;
using System.Data.SqlClient;

namespace toyshop.Data
{
    public class phieunhap
    {
        public string mahang { get; set; }
        public int soluong { get; set; }
        public long gianhap { get; set; }
        public long thanhtien { get; set; }
        public int phieu { get; set; }
        public DataTable getphieunhaptam()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("getphieunhap", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds,"a");
                dt = ds.Tables[0];
                
                
            }
            return dt;
        }
        public int addHang(phieunhap pn)
        {
            using (SqlConnection con=new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("luusanphamtam", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", pn.mahang);
                cmd.Parameters.AddWithValue("@soluong", pn.soluong);
                cmd.Parameters.AddWithValue("@gianhap", pn.gianhap);
                cmd.Parameters.AddWithValue("@thanhtien", pn.thanhtien);
                //cmd.Parameters.AddWithValue("@phieu", "tam");
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (System.Exception)
                {

                    return -1;
                }
                
            }
            return 1;
        }
        public int capnhatHang(phieunhap pn)
        {
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("capnhatphieutam", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", pn.mahang);
                cmd.Parameters.AddWithValue("@soluong", pn.soluong);
                cmd.Parameters.AddWithValue("@gianhap", pn.gianhap);
                cmd.Parameters.AddWithValue("@thanhtien", pn.thanhtien);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return 1;
        }
        public int xoaHang(string mahang)
        {
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("xoasp_phieutam", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", mahang);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return 1;
        }
        public int chotToa(int nhanvien)
        {
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("chot_nhaphang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nhanvien", nhanvien);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return 1;
        }
        public DataTable get_report_all_pn()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("REPORT_PHIEUNHAPHANG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                dt = ds.Tables[0];


            }
            return dt;
        }
        public DataSet get_report_ct_pn()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("REPORT_CHITIETPHIEUNHAP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phieu", this.phieu);
                
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
               


            }
            return ds;
        }
    }
}
