using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
namespace DAL
{
    public class DBProvider
    {
        private static DBProvider instance;
        private DBProvider() { }
        public static DBProvider Instance
        {
            get
            {
                if (instance == null) instance = new DBProvider();
                return instance;
            }
            private set { instance = value; }
        }
        
        String conn = ConfigurationManager.ConnectionStrings["SQLconn"].ConnectionString;
        //trả về những dòng kết quả
        public DataTable ExecuteQuery(String query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] lstPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lstPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        //trả về số dòng được thực thi
        //dùng trong câu truy vấn insert, update, delete
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] lstPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lstPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        //trả về số dòng kết quả
        //như select, select (count)
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] lstPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lstPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
