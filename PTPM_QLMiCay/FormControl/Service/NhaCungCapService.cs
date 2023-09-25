using FormControl.DTO.NhaCungCap;
using FormControl.Repository;
using System;
using System.Data;

namespace FormControl.Service
{
    public class NhaCungCapService : IService<NhaCungCapDto>
    {
        private NhaCungCapRepository _repository;

        public NhaCungCapService(NhaCungCapRepository repository)
        {
            _repository = repository;
        }

        public NhaCungCapDto create(NhaCungCapDto entity)
        {
            throw new NotImplementedException();
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable getAll()
        {
            try
            {
                return _repository.getAll();
            } catch
            {
                return null;
            }
        }

        public NhaCungCapDto getById(int id)
        {
            throw new NotImplementedException();
        }

        public int update(int id, NhaCungCapDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
