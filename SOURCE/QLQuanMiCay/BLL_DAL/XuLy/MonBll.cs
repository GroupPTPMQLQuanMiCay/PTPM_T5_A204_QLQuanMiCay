using System.Collections.Generic;
using System.Linq;

namespace BLL_DAL.XuLy
{
    public class MonBll
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public List<Mon> getAll()
        {
            var mons = _context.Mons.Select(m => m).ToList();
            return mons;
        }

        public List<Mon> getMonByDanhMucId(int id)
        {
            var mons = _context.Mons.Where(m => m.DM_Id == id).Select(m => m).ToList();
            return mons;
        }
    }
}
