using System.Data;
using System.Data.SqlClient;
using toyshop.Data;

namespace toyshop
{
    public class donvitinh
    {
        public int ID { get; set; }
        public string DONVITINH { get; set; }

        //các phương thức xử lý
        public void ThemMoidvt()
        {
            //gọi đến cơ sở dữ liệu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);


            //thủ tục xử lý thêm mới
            SqlCommand sqlCmd = new SqlCommand("DVT_THEMMOI", sqlCon);

            //loại thủ tục
            sqlCmd.CommandType = CommandType.StoredProcedure;

            //truyen tham so
           // sqlCmd.Parameters.AddWithValue("@ID", ID);
            sqlCmd.Parameters.AddWithValue("@DONVITINH", DONVITINH);
            //mo cong kết nối đến sql
            sqlCon.Open();

            //thực thi câu lệnh thêm mới    
            sqlCmd.ExecuteNonQuery();


            //sqlCmd2.ExecuteNonQuery();
            //đóng kết nối lại
            sqlCon.Close();



        }

        /// <summary>
        /// Phuong Thuc xoa
        /// </summary>
        public void XoaDVT()
        {
            //gọi đến cơ sở dữ liệu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //thủ tục xử lý thêm mới
            SqlCommand sqlCmd = new SqlCommand("DVT_XOA", sqlCon);
            //loại thủ tục
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so
            sqlCmd.Parameters.AddWithValue("@ID", ID);
            //mo cong kết nối đến sql
            sqlCon.Open();
            //thực thi câu lệnh thêm mới    
            sqlCmd.ExecuteNonQuery();
            //đóng kết nối lại
            sqlCon.Close();
        }
        /// <summary>
        /// Phương Thức sửa
        /// </summary>
        public void SuaDVT()
        {
            //gọi đến cơ sở dữ liệu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //thủ tục xử lý thêm mới
            SqlCommand sqlCmd = new SqlCommand("DVT_SUA", sqlCon);
            //loại thủ tục
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so
            sqlCmd.Parameters.AddWithValue("@ID", ID);
            sqlCmd.Parameters.AddWithValue("@DONVITINH", DONVITINH);
            

            //mo cong kết nối đến sql
            sqlCon.Open();
            //thực thi câu lệnh thêm mới    
            sqlCmd.ExecuteNonQuery();
            //đóng kết nối lại
            sqlCon.Close();

        }
        
        /// <summary>
        /// Lấy Danh Sách từ database sql
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhSach()
        { //goi lop ket noi csdl
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //loaddata goi thu tuc, minh da viet tren sql
            SqlDataAdapter sqlDA = new SqlDataAdapter("DVT_LAYDANHSACH", sqlCon);
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
    }
}
