using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.XuLy
{
    public class MonBLL
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public List<Mon> getAll()
        {
            var mons = _context.Mons.Select(m => m).ToList();
            return mons;
        }
    }
}
