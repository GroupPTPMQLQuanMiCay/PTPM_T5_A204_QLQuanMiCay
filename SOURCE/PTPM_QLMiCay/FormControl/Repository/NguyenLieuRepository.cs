using DataHelper;
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

        public int create(NguyenLieu entity)
        {
            try
            {
                return _sqlHelper.executeNonQuery(string.Format("insert into NguyenLieu(" +
                    "NL_Ten, NL_DonViTinh, NL_SoLuong, NCC_Id) values(N'{0}', " +
                    "N'{1}', {2}, {3})", entity.nl_Ten(), entity.nl_DonViTinh(),
                    entity.nl_SoLuong(), entity.ncc_Id()));
            }
            catch
            {
                return 0;
            }
        }

        public int delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public DataTable getAll()
        {
            try
            {
                return _sqlHelper.executeQuery("Select * from NguyenLieu");
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
                    + "NL_DonViTinh, NL_Gia from NguyenLieu, GiaNguyenLieu"
                    + " where NguyenLieu.NL_ID = GiaNguyenLieu.NL_ID"
                    + " and NL_Ten like N'%" + name + "%' order by NGAYTHAYDOI desc, NL_Id asc");
                return dt;
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
                DataTable dt = _sqlHelper.executeQuery("select NguyenLieu.NL_Id, NL_Ten, "
                    + "NL_DonViTinh, NL_Gia from NguyenLieu, GiaNguyenLieu"
                    + " where NguyenLieu.NL_ID = GiaNguyenLieu.NL_ID"
                    + " and NCC_Id = " + nccId + " order by NGAYTHAYDOI desc, NL_Id asc");
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable getNguyenLieuDtoByNhaCungCapAndName(int nccId, string name)
        {
            try
            {
                DataTable dt = _sqlHelper.executeQuery("select NguyenLieu.NL_Id, NL_Ten, "
                    + "NL_DonViTinh, NL_Gia from NguyenLieu, GiaNguyenLieu"
                    + " where NguyenLieu.NL_ID = GiaNguyenLieu.NL_ID and NL_Ten like N'%" + name + "%'"
                    + " and NCC_Id = " + nccId + " order by NGAYTHAYDOI desc, NL_Id asc");
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
