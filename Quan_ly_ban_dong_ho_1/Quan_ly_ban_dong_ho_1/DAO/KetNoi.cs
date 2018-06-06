using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.Connection
{
    public class KetNoi
    {
        private static KetNoi instance;

        public static KetNoi Instance
        {
            get
            {
                if (instance == null) instance = new KetNoi();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        

        private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // Câu truy vẫn thực thi

                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command); //Thằng trung gian để lấy dữ liệu

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        public bool ExecuteNonQuery(string query, object[] parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                try
                {
                    SqlCommand command = new SqlCommand(query, connection); // Câu truy vẫn thực thi

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    command.ExecuteNonQuery();
                }
                catch
                {
                    return false;
                }

                connection.Close();
            }
            return true;
        }
    }
}
