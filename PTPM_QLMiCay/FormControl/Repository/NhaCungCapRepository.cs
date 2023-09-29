using DataHelper;
using FormControl.Entity;
using System.Collections.Generic;
using System.Data;

namespace FormControl.Repository
{
    public class NhaCungCapRepository : IRepository<NhaCungCap>
    {
        private SqlHelper _sqlHelper;

        public NhaCungCapRepository(SqlHelper sqlHelper)
        {
            _sqlHelper = sqlHelper;
        }

        public int create(NhaCungCap entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public DataTable getAll()
        {
            try
            {
                return _sqlHelper.executeQuery("Select * from NhaCungCap");
            } catch
            {
                return null;
            }
        }

        public NhaCungCap getById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int update(int id, NhaCungCap entity)
        {
            throw new System.NotImplementedException();
        }
    }
}