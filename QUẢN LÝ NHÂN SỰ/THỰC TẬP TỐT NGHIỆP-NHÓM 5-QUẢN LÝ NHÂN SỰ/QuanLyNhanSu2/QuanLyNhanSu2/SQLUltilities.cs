using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Ultilities
{
    class SQLUltilities
    {
        public SqlConnection connection;
        public String str= ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public SQLUltilities(){
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        
        }
        public int ExecuteNoneQuery(SqlCommand cmd) {
            try
            {
               
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                throw;
            }
            finally { Close(); }
        
        }
        public DataTable ExecuteQuery(SqlCommand cmd) {

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
            finally { Close(); }
        
        }
        public void Close() {
            try
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                    connection.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }
    }
}
