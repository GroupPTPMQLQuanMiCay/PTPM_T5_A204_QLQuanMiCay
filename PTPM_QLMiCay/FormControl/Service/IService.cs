using System.Collections.Generic;
using System.Data;

namespace FormControl.Service
{
    public interface IService<T>
    {
        DataTable getAll();
        T getById(int id);
        int update(int id, T entity);
        T create(T entity);
        int delete(int id);
    }
}
