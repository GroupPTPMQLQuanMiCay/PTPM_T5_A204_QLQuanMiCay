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

        public List<string> getListQuyenSelected(DataGridView dgv)
        {
            List<string> l = new List<string>();

            foreach (DataGridViewRow r in dgv.Rows)
            {
                string tableName = r.Cells[0].Value.ToString();
                bool select = bool.Parse(r.Cells[1].Value.ToString());
                bool insert = bool.Parse(r.Cells[2].Value.ToString());
                bool delete = bool.Parse(r.Cells[3].Value.ToString());
                bool update = bool.Parse(r.Cells[4].Value.ToString());

                if(select || insert || delete || update)
                {
                    List<Quyen> quyens = locTheoBang(tableName);
                    foreach (Quyen quyen in quyens)
                    {

                        if (select && quyen.DienGiai.Contains("select"))
                        {
                            l.Add(quyen.Quyen_Id);
                        }
                        else if (insert && quyen.DienGiai.Contains("insert"))
                        {
                            l.Add(quyen.Quyen_Id);
                        }
                        else if (delete && quyen.DienGiai.Contains("delete"))
                        {
                            l.Add(quyen.Quyen_Id);
                        }
                        else if (update && quyen.DienGiai.Contains("update"))
                        {
                            l.Add(quyen.Quyen_Id);
                        }
                    }
                }
                
            }
            return l;
        }

        public List<Quyen> locTheoBang(string tableName)
        {
            List<Quyen> quyens = qmc.Quyens.Where(t => t.DienGiai.Contains(tableName))
                    .Select(t => t)
                    .ToList();
            for (int i = 0; i < quyens.Count; i++)
            {
                Quyen quyen = quyens[i];
                string name = quyen.DienGiai.Substring(10);
                if (!name.ToLower().Equals(tableName.ToLower()))
                {
                    quyens.Remove(quyen);
                    i--;
                }
            }
            return quyens;
        }
    }
}
