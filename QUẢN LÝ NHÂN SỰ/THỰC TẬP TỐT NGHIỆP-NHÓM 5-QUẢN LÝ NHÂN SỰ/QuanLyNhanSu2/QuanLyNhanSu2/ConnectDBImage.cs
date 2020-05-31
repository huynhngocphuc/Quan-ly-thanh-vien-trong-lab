using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyNhanSu2
{
    class ConnectDBImage
    {
        private SqlConnection conn;
        private string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public ConnectDBImage()
        {
            conn = new SqlConnection(strCon);
        }
        public void StorePicture(string filename)
        {
            byte[] ImageData = null;
            // Đọc tệp tin vào 1 mảng kiểu byte
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                ImageData = new byte[fs.Length];
                fs.Read(ImageData, 0, (int)fs.Length);
            }
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand("InsertImage", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Filename", filename);
                cmd.Parameters["@Filename"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@blobdata", SqlDbType.Image);
                cmd.Parameters["@blobdata"].Direction = ParameterDirection.Input;
                cmd.Parameters["@blobdata"].Value = ImageData;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public byte[] RetrieveImage()
        {
            byte[] ImageData = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select blobdata from Image", conn);
            using (SqlDataReader read = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
            {
                read.Read();
                long bytesize = read.GetBytes(0, 0, null, 0, 0);
                ImageData = new byte[bytesize];
                long bytesread = 0;
                int curpos = 0;
                int chunksize = 1;
                while (bytesread < bytesize)
                {
                    bytesread += read.GetBytes(0, curpos, ImageData, curpos, chunksize);
                    curpos += chunksize;
                }
            }
            conn.Close();
            return ImageData;
        }
    }
}
