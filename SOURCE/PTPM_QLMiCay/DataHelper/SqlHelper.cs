using System;
using System.Data;
using System.Data.SqlClient;

namespace DataHelper
{
    public class SqlHelper
    {
        private SqlConnection _connection;

        public SqlHelper(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public DataTable executeQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                _connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Execute query error " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return dt;
        }

        public int executeNonQuery(string  query)
        {
            SqlCommand cmd = new SqlCommand(query, _connection);
            try
            {
                _connection.Open();
                return cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                throw new Exception("Execute nonquery error " + ex.Message);
            } finally
            {
                if(_connection != null)
                {
                    _connection.Close();
                }
                if(cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }
    }
}