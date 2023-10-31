using System.Data;

namespace HotelApp.Interfaces.AdoNet.Interface
{
    public interface IGenericService<T>
    {
        DataTable Select();
        DataTable GetByName(string name);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
