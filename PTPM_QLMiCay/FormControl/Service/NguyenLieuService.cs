using DataHelper.DTO.NguyenLieu;
using DataHelper.Entity;
using FormControl.Repository;
using System;
using System.Collections.Generic;
using System.Data;

namespace FormControl.Service
{
    public class NguyenLieuService : IService<NguyenLieuDto>
    {
        private NguyenLieuRepository _repository;

        public NguyenLieuService(NguyenLieuRepository repository)
        {
            _repository = repository;
        }

        public NguyenLieuDto create(NguyenLieuDto entity)
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
                return _repository.getAllNguyenLieuDto();
            }
            catch 
            {
                return null;
            }
        }

        public DataTable getNguyenLieuDtoByName(string name)
        {
            try
            {
                return _repository.getNguyenLieuDtoByName(name);
            }
            catch
            {
                return null;
            }
        }

        public NguyenLieuDto getById(int id)
        {
            throw new NotImplementedException();
        }

        public int update(int id, NguyenLieuDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
