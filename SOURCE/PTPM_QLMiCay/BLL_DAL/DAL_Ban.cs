using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_Ban
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public DAL_Ban()
        {

        }
        public object loadBanALL()
        {
            return _context.Bans.Select(t => t).ToList();
        }
        public List<int> loadBanHD()
        {
            List<int> result = new List<int>();
            result = _context.Bans
            .Where(b => _context.HoaDons.Any(hd => hd.B_SoBan == b.B_SoBan && hd.HD_TrangThai == 0) == false)
            .Select(b => b.B_SoBan)
            .Distinct().ToList();

            return result;
        }

      
      

    }
}
