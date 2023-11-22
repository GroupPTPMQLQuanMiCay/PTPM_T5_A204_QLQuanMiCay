using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL.XuLy
{
    public class OrderBLL
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public OrderBLL()
        {
        }

        public List<Mon> get5TopMonBanChay()
        {
            List<Mon> mons = new List<Mon>();

            var query = _context.OrDers.GroupBy(s => s.M_Ten)
                .Select(o => new
                {
                    tenMon = o.Key,
                    soLuong = o.Sum(s => s.O_SoLuong)
                })
                .OrderByDescending(result => result.soLuong);
            foreach (var item in query)
            {
                Mon mon = _context.Mons.Where(s=>s.M_Ten.Contains(item.tenMon)).FirstOrDefault();
                if (mon != null)
                    mons.Add(mon);
            }

            return mons;
        }

        public List<string> getTenMonTheoHDID(int idHD)
        {
            var tenMon = _context.OrDers.Where(o => o.HD_Id == idHD).Select(o=>o.M_Ten).ToList();
            return tenMon;
        }
    }
}
