using System.Linq;

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
