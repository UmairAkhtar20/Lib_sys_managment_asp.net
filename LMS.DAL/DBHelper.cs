using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    internal class DBHelper : IDisposable
    {
        string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\umair\Downloads\SHAREit\Library_Management_system_winform_Csharp\Lib Mang Sys\Database1.mdf;Integrated Security=True;";
        SqlConnection conn = null;
        public DBHelper()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
        }

        public void Dispose()
        {
           if(conn !=null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public int ExecuteQuery(string squery)
        {
            SqlCommand command = new SqlCommand(squery,conn);
            var count = command.ExecuteNonQuery();
            return count;
        }
        public SqlDataReader ExecuteReader(string squery)
        {
            SqlCommand command = new SqlCommand(squery, conn);
            var count = command.ExecuteReader();
            return count;
        }
        public SqlDataAdapter DataAdapter(string query)
        {
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            return da;
        }
        
    }
}
