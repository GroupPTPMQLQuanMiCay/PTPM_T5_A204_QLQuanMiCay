using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_NguoiDung
    {
        QLQuanMiCayDataContext qmc = new QLQuanMiCayDataContext();
        
        public DAL_NguoiDung()
        {
        }

        public object load()
        {
            return qmc.NguoiDungs.Where(t => !t.NG_Id.Equals("sa")).Select(t => t).ToList();
        }
    }
}
