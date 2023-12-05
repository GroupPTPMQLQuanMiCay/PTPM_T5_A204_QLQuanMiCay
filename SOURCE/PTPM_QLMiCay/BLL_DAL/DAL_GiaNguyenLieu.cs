using System.Linq;

namespace BLL_DAL
{
    public class DAL_GiaNguyenLieu
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();
        public DAL_GiaNguyenLieu() { }

        public object getIncredientWithPrice(int supplierId)
        {
            var s = (from gia in _context.GiaNguyenLieus
                    join nl in _context.NguyenLieus on gia.NL_Id equals nl.NL_Id
                    where nl.NCC_Id == supplierId
                    select new
                    {
                        NL_Id = gia.NL_Id,
                        NL_Ten = gia.NguyenLieu.NL_Ten,
                        NL_DonViTinh = gia.NguyenLieu.NL_DonViTinh,
                        NL_SoLuong = gia.NguyenLieu.NL_SoLuong,
                        NL_Gia = gia.NL_Gia,
                        NL_ThoiGian = gia.NgayThayDoi 
                    }).OrderByDescending(x => x.NL_ThoiGian)
                    .Select(x => new { x.NL_Id, x.NL_Ten, x.NL_DonViTinh, x.NL_SoLuong, x.NL_Gia})
                    .ToList();
            return s;
        }
    }
}
