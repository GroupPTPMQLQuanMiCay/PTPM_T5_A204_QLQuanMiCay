using System.Data.SqlClient;
using System.Data;

namespace DataHelper
{
    public class QLNguoiDung 
    {
        public int Check_Config(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                return 1;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                return 0;
            } catch
            {
                return 2;
            }
        }
    }
}
