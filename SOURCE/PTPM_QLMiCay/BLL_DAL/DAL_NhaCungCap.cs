using System.Collections.Generic;
using System.Linq;

namespace BLL_DAL
{
    public class DAL_NhaCungCap
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public DAL_NhaCungCap() { }

        public List<NhaCungCap> getAllSupplier()
        {
            return _context.NhaCungCaps.Select(ncc => ncc).ToList();
        }
    }
}
