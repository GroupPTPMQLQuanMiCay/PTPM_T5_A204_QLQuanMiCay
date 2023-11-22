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
    }
}
