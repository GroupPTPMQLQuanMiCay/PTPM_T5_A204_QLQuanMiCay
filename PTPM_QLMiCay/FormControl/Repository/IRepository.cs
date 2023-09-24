using System.Collections.Generic;

namespace FormControl.Repository
{
    public interface IRepository<T>
    {
        List<T> getAll();
        T getById(int id);
        int update(int id, T entity);
        T create(T entity);
        int delete(int id);
    }
}
