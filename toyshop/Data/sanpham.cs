using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyshop.Data
{
    public class sanpham
    {

        public int id { get; set; }
        public string mahang { get; set; }
        public string tenhang { get; set; }
        public int soluong { get; set; }
        public long giabanle { get; set; }
        public long giabansi { get; set; }
        public int donvitinh { get; set; }
        public byte[] hinh { get; set; }
        public DataTable getGiaban()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("get_giaban", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                dt = ds.Tables[0];


            }
            return dt;
        }
        public int setGiaban()
        {

            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("set_giaban", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahang", this.mahang);
                cmd.Parameters.AddWithValue("@giabanle", this.giabanle);
                cmd.Parameters.AddWithValue("@giabansi", this.giabansi);
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
            return 0;
        }
        public bool kiemtramahang()
        {
            SqlConnection sqlConn = new SqlConnection(ketnoi.chuoikn);
            SqlCommand sqlCmd = new SqlCommand("SP_KIEMTRA", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@MAHANG", mahang);

            sqlConn.Open();

            SqlDataReader dread = sqlCmd.ExecuteReader();
            //tao 1 bien
            bool ketqua = false;
            if (dread.Read())
            {
                // IDNV = int.Parse(dread["IDNV"].ToString());
                //HoTen = dread["HoTen"] as string;
                ketqua = true;
            }
            //dong ket noi lại
            sqlConn.Close();
            return ketqua;
        }
        public void ThemMoisp()
        {
            //gọi đến cơ sở dữ liệu


            SqlConnection sqlConn = new SqlConnection(ketnoi.chuoikn);
            //thủ tục xử lý thêm mới
            SqlCommand sqlCmd = new SqlCommand("SP_THEMMOI", sqlConn);

            //loại thủ tục
            sqlCmd.CommandType = CommandType.StoredProcedure;

            //truyen tham so
            sqlCmd.Parameters.AddWithValue("@MAHANG", mahang);
            sqlCmd.Parameters.AddWithValue("@TENHANG", tenhang);
            sqlCmd.Parameters.AddWithValue("@DONVITINH", donvitinh);
            if (hinh!=null)
            sqlCmd.Parameters.AddWithValue("@hinh", hinh);

            //mo cong kết nối đến sql
            sqlConn.Open();

            //thực thi câu lệnh thêm mới    
            sqlCmd.ExecuteNonQuery();


            //sqlCmd2.ExecuteNonQuery();
            //đóng kết nối lại
            sqlConn.Close();



        }
        public void Sua()
        {
            //gọi đến cơ sở dữ liệu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //thủ tục xử lý thêm mới
            SqlCommand sqlCmd = new SqlCommand("SP_SUA", sqlCon);
            //loại thủ tục
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so
            sqlCmd.Parameters.AddWithValue("@MAHANG", mahang);
            sqlCmd.Parameters.AddWithValue("@TENHANG", tenhang);
            sqlCmd.Parameters.AddWithValue("@DONVITINH", donvitinh);
            sqlCmd.Parameters.AddWithValue("@hinh", hinh);

            //mo cong kết nối đến sql
            sqlCon.Open();
            //thực thi câu lệnh thêm mới    
            sqlCmd.ExecuteNonQuery();
            //đóng kết nối lại
            sqlCon.Close();

        }
        public void Xoa()
        {
            //gọi đến cơ sở dữ liệu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //thủ tục xử lý thêm mới
            SqlCommand sqlCmd = new SqlCommand("SP_XOA", sqlCon);
            //loại thủ tục
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so
            sqlCmd.Parameters.AddWithValue("@MAHANG", mahang);
            //mo cong kết nối đến sql
            sqlCon.Open();
            //thực thi câu lệnh thêm mới    
            sqlCmd.ExecuteNonQuery();
            //đóng kết nối lại
            sqlCon.Close();
        }
        public DataTable LayDanhSach()
        { //goi lop ket noi csdl
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //loaddata goi thu tuc, minh da viet tren sql
            SqlDataAdapter sqlDA = new SqlDataAdapter("SP_LAYDANHSACH", sqlCon);


            //khoi tao 1 cai dataset
            DataSet dSet = new DataSet();
            //mo cong ket noi
            sqlCon.Open();
            //fill du lieu vao datatable
            sqlDA.Fill(dSet);
            //dong ket noi lai
            sqlCon.Close();
            //tra ve du lieu(dang bang)
            return dSet.Tables[0];
        }
        public DataTable LayDanhSach_deban()
        { //goi lop ket noi csdl
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //loaddata goi thu tuc, minh da viet tren sql
            SqlDataAdapter sqlDA = new SqlDataAdapter("SP_LAYDANHSACH_deban", sqlCon);


            //khoi tao 1 cai dataset
            DataSet dSet = new DataSet();
            //mo cong ket noi
            sqlCon.Open();
            //fill du lieu vao datatable
            sqlDA.Fill(dSet);
            //dong ket noi lai
            sqlCon.Close();
            //tra ve du lieu(dang bang)
            return dSet.Tables[0];
        }
        public DataTable LayDanhSach_deban_truphieutam()
        { //goi lop ket noi csdl
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //loaddata goi thu tuc, minh da viet tren sql
            SqlDataAdapter sqlDA = new SqlDataAdapter("SP_LAYDANHSACH_deban_truphieutam", sqlCon);


            //khoi tao 1 cai dataset
            DataSet dSet = new DataSet();
            //mo cong ket noi
            sqlCon.Open();
            //fill du lieu vao datatable
            sqlDA.Fill(dSet);
            //dong ket noi lai
            sqlCon.Close();
            //tra ve du lieu(dang bang)
            return dSet.Tables[0];
        }
        public DataTable LayDanhSach_dvt()
        { //goi lop ket noi csdl
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //loaddata goi thu tuc, minh da viet tren sql
            SqlDataAdapter sqlDA = new SqlDataAdapter("DVTCB_LAYDANHSACH", sqlCon);


            //khoi tao 1 cai dataset
            DataSet dSet = new DataSet();
            //mo cong ket noi
            sqlCon.Open();
            //fill du lieu vao datatable
            sqlDA.Fill(dSet);
            //dong ket noi lai
            sqlCon.Close();
            //tra ve du lieu(dang bang)
            return dSet.Tables[0];
        }
        public byte[] getHinh()
        {
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //loaddata goi thu tuc, minh da viet tren sql
            SqlCommand cmd = new SqlCommand("getHinhsp", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahang", this.mahang);
            SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);


            //khoi tao 1 cai dataset
            DataSet dSet = new DataSet();
            //mo cong ket noi
            sqlCon.Open();
            //fill du lieu vao datatable
            sqlDA.Fill(dSet);
            //dong ket noi lai
            sqlCon.Close();
            //tra ve du lieu(dang bang)
            if (dSet.Tables[0] != null)
                return (byte[])dSet.Tables[0].Rows[0][0];
            else return null;
        }
    }
}
