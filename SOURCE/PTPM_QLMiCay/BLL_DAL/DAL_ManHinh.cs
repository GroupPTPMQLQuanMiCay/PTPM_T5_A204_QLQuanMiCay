using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class DAL_ManHinh
    {
        QLQuanMiCayDataContext qmc = new QLQuanMiCayDataContext();
        
        public DAL_ManHinh()
        {
        }
        
        public List<string> getListManHinhSelected(DataGridView dgv)
        {
            List<string> l = new List<string>();

            foreach (DataGridViewRow r in dgv.Rows)
            {
                string manHinhName = r.Cells[0].Value.ToString();
                bool check = bool.Parse(r.Cells[1].Value.ToString());

                if (check)
                {
                    string id = qmc.ManHinhs.Where(t => t.MH_HienThi.Equals(manHinhName)).Select(t => t.MH_Id).FirstOrDefault();
                    l.Add(id);
                }
            }
            return l;
        }

    }
}
