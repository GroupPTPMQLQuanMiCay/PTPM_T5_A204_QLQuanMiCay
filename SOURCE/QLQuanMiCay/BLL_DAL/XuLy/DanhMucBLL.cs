using System.Collections.Generic;
using System.Linq;
namespace BLL_DAL.XuLy
{
    public class DanhMucBLL
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public List<DanhMuc> getAll()
        {
            var mons = _context.DanhMucs.Select(m => m).ToList();
            return mons;
        }
    }
}
