using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_Mon
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public DAL_Mon()
        {

        }
        public List<Mon> LoadAllMon()
        {
            List<Mon> result = new List<Mon>();
            result = _context.Mons.Select(t => t).ToList();
            return result;
        }
        public List<Mon> getMonByIDDM(int id_DM)
        {
      
             List<Mon> result = _context.Mons.Where(m => m.DM_Id == id_DM).ToList();
             return result;
        }
        
       
    }
}
