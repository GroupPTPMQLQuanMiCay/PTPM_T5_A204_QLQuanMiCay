using System.Data;

namespace DAL
{
    public interface IRepository<T>
    {
        DataTable getAll();
        T getById(int id);
        int update(int id, T entity);
        int create(T entity);
        int delete(int id);
    }
}
