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

        public int getSLMonCoTen(string text)
        {
            int sl = _context.Mons.Where(m => m.M_Ten.Contains(text)).ToList().Count;
            return sl;
        }

        public List<Mon> getMonByTenMon(string text)
        {
            var mons = _context.Mons.Where(m => m.M_Ten.Contains(text)).Select(m => m).ToList();
            return mons;
        }
    }
}
