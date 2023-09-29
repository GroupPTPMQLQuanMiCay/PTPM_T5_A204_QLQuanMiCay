using DataHelper;
using DataHelper.DTO.NguyenLieu;
using DataHelper.Entity;
using FormControl.Converter;
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

        public int create(NguyenLieuDto dto)
        {
            try
            {
                NguyenLieu nlieu = NguyenLieuConverter.toNguyenLieuEntity(dto);
                return _repository.create(nlieu);
            } catch
            {
                return 0;
            }
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

        public DataTable getNguyenLieuDtoByNhaCungCap(int nccId)
        {
            try
            {
                DataTable dt = _repository.getNguyenLieuDtoByNhaCungCap(nccId);
                return dt;
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

        public DataTable getNguyenLieuDtoByNhaCungCapAndName(int nccId, string name)
        {
            try
            {
                return _repository.getNguyenLieuDtoByNhaCungCapAndName(nccId, name);
            }
            catch
            {
                return null;
            }
        }
    }
}
