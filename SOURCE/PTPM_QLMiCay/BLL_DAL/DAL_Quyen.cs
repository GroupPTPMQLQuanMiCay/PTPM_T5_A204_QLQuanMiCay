using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class DAL_Quyen
    {
        QLQuanMiCayDataContext qmc = new QLQuanMiCayDataContext();
        
        public DAL_Quyen()
        {
        }
        public object load()
        {
            return qmc.Quyens.Select(t => t).ToList();
        }


        
    }
}
