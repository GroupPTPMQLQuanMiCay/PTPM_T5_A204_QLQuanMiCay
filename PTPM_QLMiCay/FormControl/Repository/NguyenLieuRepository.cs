using DataHelper;
using DataHelper.DTO.NguyenLieu;
using DataHelper.Entity;
using FormControl.Converter;
using System.Collections.Generic;
using System.Data;

namespace FormControl.Repository
{
    public class NguyenLieuRepository : IRepository<NguyenLieu>
    {
        private SqlHelper _sqlHelper;

        public NguyenLieuRepository(SqlHelper sqlHelper)
        {
            _sqlHelper = sqlHelper;
        }

        public NguyenLieu create(NguyenLieu entity)
        {
            throw new System.NotImplementedException();
        }

        public int delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<NguyenLieu> getAll()
        {
            try
            {
                DataTable dt = _sqlHelper.executeQuery("Select * from NguyenLieu");
                return NguyenLieuConverter.toListNguyenLieuEntity(dt);
            }
            catch
            {
                return null;
            }
        }

        public NguyenLieu getById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int update(int id, NguyenLieu entity)
        {
            throw new System.NotImplementedException();
        }

        public DataTable getAllNguyenLieuDto()
        {
            try
            {
                DataTable dt = _sqlHelper.executeQuery("select NguyenLieu.NL_Id, NL_Ten, "
                    + "NL_DonViTinh, NL_Gia from NguyenLieu, GiaNguyenLieu"
                    + " where NguyenLieu.NL_ID = GiaNguyenLieu.NL_ID order by NGAYTHAYDOI desc, NL_Id asc");
                return dt;
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
                DataTable dt = _sqlHelper.executeQuery("select NguyenLieu.NL_Id, NL_Ten, "
                    + "NL_DonViTinh, NL_Gia from NguyenLieu, GiaNguyenLieu  and NL_Ten like N'%" + name + "%'"
                    + " where NguyenLieu.NL_ID = GiaNguyenLieu.NL_ID order by NGAYTHAYDOI desc, NL_Id asc");
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
