using System.Collections.Generic;
using System.Data;

namespace FormControl.Repository
{
    public interface IRepository<T>
    {
        DataTable getAll();
        T getById(int id);
        int update(int id, T entity);
        T create(T entity);
        int delete(int id);
    }
}
