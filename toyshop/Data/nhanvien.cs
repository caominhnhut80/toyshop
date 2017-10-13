using System;
using System.Data;
using System.Data.SqlClient;

namespace toyshop.Data
{
    public class nhanvien
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string hoten { get; set; }
        public int quyen { get; set; }
        public nhanvien()
        {
            this.id = -1;
        }
        public nhanvien check_userlogin(string username, string password)
        {
            DataSet ds = new DataSet();
            nhanvien kq = new nhanvien();
            using (SqlConnection con = new SqlConnection(ketnoi.chuoikn))
            {
                SqlCommand cmd = new SqlCommand("check_userlogin", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);

                sa.Fill(ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                kq.id = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                kq.username = ds.Tables[0].Rows[0][1].ToString();
                kq.password = ds.Tables[0].Rows[0][2].ToString();
                kq.hoten = ds.Tables[0].Rows[0][3].ToString();
                kq.quyen = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());

            }

            return kq;
        }
        public void ThemMoi()
        {

            // goi dien co so du lieu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            // thu tuc xu ly them moi, duoc viet tren sql server
            SqlCommand sqlCmd = new SqlCommand("NHANVIEN_THEMMOI", sqlCon);
            //loai thu tuc
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so
            //sqlCmd.Parameters.AddWithValue("@id", id);
            sqlCmd.Parameters.AddWithValue("@username", username);
            sqlCmd.Parameters.AddWithValue("@password", password);
            sqlCmd.Parameters.AddWithValue("@hoten", hoten);
            sqlCmd.Parameters.AddWithValue("@quyen", quyen);
            //mo cong ket noi den sql
            sqlCon.Open();
            // thuc thi  lenh them moi
            sqlCmd.ExecuteNonQuery();
            //dong ket noi lai
            sqlCon.Close();
        }

        /// <summary>
        /// phuong thuc xu ly xoa loai khach hang
        /// </summary>
        public void Xoa()
        {
            // goi dien co so du lieu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            // thu tuc xu ly XOA, duoc viet tren sql server
            SqlCommand sqlCmd = new SqlCommand("NHANVIEN_XOA", sqlCon);
            //loai thu tuc
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so
            sqlCmd.Parameters.AddWithValue("@id", id);
            //mo cong ket noi den sql
            sqlCon.Open();
            // thuc thi  lenh them moi
            sqlCmd.ExecuteNonQuery();
            //dong ket noi lai
            sqlCon.Close();
        }

        /// <summary>
        /// PHUONG THUC SUA LOAI KHACH HANG
        /// </summary>
        public void Sua()
        {
            // goi dien co so du lieu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            // thu tuc xu ly SUA, duoc viet tren sql server
            SqlCommand sqlCmd = new SqlCommand("NHANVIEN_SUA", sqlCon);
            //loai thu tuc
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so
            sqlCmd.Parameters.AddWithValue("@id", id);
            sqlCmd.Parameters.AddWithValue("@username", username);
            sqlCmd.Parameters.AddWithValue("@password", password);
            sqlCmd.Parameters.AddWithValue("@hoten", hoten);
            sqlCmd.Parameters.AddWithValue("@quyen", quyen);
            //mo cong ket noi den sql
            sqlCon.Open();
            // thuc thi  lenh them moi
            sqlCmd.ExecuteNonQuery();
            //dong ket noi lai
            sqlCon.Close();
        }

        /// <summary>
        /// phuong thuc lay danh sach loại khach hang
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhSach()
        {

            // goi lop ket noi den co so du lieu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //goi thu tuc, minh da viwt tren sql
            SqlDataAdapter sqlDA = new SqlDataAdapter("NHANVIEN_LAYDANHSACH", sqlCon);
            //khoi tao 1 dataset
            DataSet dSet = new DataSet();
            //mo cong ket noi
            sqlCon.Open();
            //fill du lieu vao datatable 
            sqlDA.Fill(dSet);

            //dong ket noi lai
            sqlCon.Close();
            //tra ve du lieu (dang bang)

            return dSet.Tables[0];
        }


        public bool kiemtrausernametrung()
        {
            // goi lop ket noi den co so du lieu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            SqlCommand sqlCmd = new SqlCommand("NHANVIEN_KTUSERTRUNG", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@username", username);
            sqlCon.Open();

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
            sqlCon.Close();
            return ketqua;
        }



        public DataTable LayDanhSachQuyen()
        {

            // goi lop ket noi den co so du lieu
            SqlConnection sqlCon = new SqlConnection(ketnoi.chuoikn);
            //goi thu tuc, minh da viwt tren sql
            SqlDataAdapter sqlDA = new SqlDataAdapter("QUYEN_LAYDANHSACH", sqlCon);
            //khoi tao 1 dataset
            DataSet dSet = new DataSet();
            //mo cong ket noi
            sqlCon.Open();
            //fill du lieu vao datatable 
            sqlDA.Fill(dSet);

            //dong ket noi lai
            sqlCon.Close();
            //tra ve du lieu (dang bang)
            return dSet.Tables[0];
        }
    }
}


