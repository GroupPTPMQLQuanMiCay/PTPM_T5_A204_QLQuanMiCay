using System.Collections.Generic;
using System.Linq;

namespace BLL_DAL.XuLy
{
    public class LoaiTinBLL
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public List<LoaiTinTuc> getAll()
        {
            var loaiTins = _context.LoaiTinTucs.Select(m => m).ToList();
            return loaiTins;
        }
    }
}
