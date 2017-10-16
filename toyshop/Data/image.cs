using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyshop.Data
{
    public class image
    {
        //Open file in to a filestream and read data in a byte array.
        public byte[] ReadFile(string sPath)
        {
            if (sPath == null) return null;
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes 
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);

            return data;
        }
        //private void cmdSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //Read Image Bytes into a byte array
        //        byte[] imageData = ReadFile(txtImagePath.Text);

        //        //Initialize SQL Server Connection
        //        SqlConnection CN = new SqlConnection(txtConnectionString.Text);

        //        //Set insert query
        //        string qry = "insert into ImagesStore 
        //      (OriginalPath, ImageData) values(@OriginalPath, @ImageData)";

        //  //Initialize SqlCommand object for insert.
        //        SqlCommand SqlCom = new SqlCommand(qry, CN);

        //        //We are passing Original Image Path and 
        //        //Image byte data as SQL parameters.
        //        SqlCom.Parameters.Add(new SqlParameter("@OriginalPath",
        //          (object)txtImagePath.Text));
        //        SqlCom.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));

        //        //Open connection and execute insert query.
        //        CN.Open();
        //        SqlCom.ExecuteNonQuery();
        //        CN.Close();

        //        //Close form and return to list or images.
        //        this.Close();
        //    }
        //public DataTable GetImagesFromDatabase()
        //{
        //    try
        //    {
        //        //Initialize SQL Server connection.

        //        SqlConnection CN = new SqlConnection(txtConnectionString.Text);

        //        //Initialize SQL adapter.
        //        SqlDataAdapter ADAP = new SqlDataAdapter("Select * from ImagesStore", CN);

        //        //Initialize Dataset.
        //        DataSet DS = new DataSet();

        //        //Fill dataset with ImagesStore table.
        //        ADAP.Fill(DS, "ImagesStore");

        //        //Fill Grid with dataset.
        //        return DS.Tables["ImagesStore"];
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //        //MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
