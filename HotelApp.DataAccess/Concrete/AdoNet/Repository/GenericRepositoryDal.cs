using HotelApp.DataAccess.Concrete.AdoNet.Context;
using HotelApp.Interfaces.AdoNet.Interface;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace HotelApp.DataAccess.Concrete.AdoNet.Repository
{
    public class GenericRepositoryDal<T> : IGenericService<T> where T : class
    {
        private string ClassName
        {
            get
            {
                return typeof(T).Name;
            }
        }

        public DataTable Select()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(string.Format("{0}_Select", ClassName), Tool.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable GetByName(string name)
        {
            SqlCommand command = new SqlCommand(string.Format("{0}_SelectName", ClassName), Tool.Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool Insert(T entity)
        {
            SqlCommand command = new SqlCommand(string.Format("{0}_Insert", ClassName), Tool.Connection);
            command.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] prop = typeof(T).GetProperties();
            foreach (var item in prop)
            {
                if (item.Name == "Id")
                    continue;
                command.Parameters.AddWithValue("@" + item.Name, item.GetValue(entity));
            }
            return Tool.OpenAndCloseTheConnection(command);
        }

        public bool Update(T entity)
        {
            SqlCommand command = new SqlCommand(string.Format("{0}_Update", ClassName), Tool.Connection);
            command.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] prop = typeof(T).GetProperties();
            foreach (var item in prop)
            {
                command.Parameters.AddWithValue("@" + item.Name, item.GetValue(entity));
            }
            return Tool.OpenAndCloseTheConnection(command);
        }
        public bool Delete(T entity)
        {
            SqlCommand command = new SqlCommand(string.Format("{0}_Delete", ClassName), Tool.Connection);
            command.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] prop = typeof(T).GetProperties();
            foreach (var item in prop)
            {
                if (item.Name == "Id" || item.Name == "IsActive")
                {
                    command.Parameters.AddWithValue("@" + item.Name, item.GetValue(entity));
                }
            }
            return Tool.OpenAndCloseTheConnection(command);
        }
    }
}
