using System.Data;
using System.Data.SqlClient;

namespace HotelApp.DataAccess.Concrete.AdoNet.Context
{
    public class Tool
    {
        private static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                    _connection = new SqlConnection("Data Source=SERVER;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                return _connection;
            }
        }

        public static bool OpenAndCloseTheConnection(SqlCommand command)
        {
            try
            {
                if (command.Connection.State == ConnectionState.Closed)
                    command.Connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0 ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
        }

        public static int InsertScalar(SqlCommand command)
        {
            try
            {
                if (command.Connection.State == ConnectionState.Closed)
                    command.Connection.Open();
                return Convert.ToInt32(((SqlCommand)command).ExecuteScalar());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
        }
    }
}
