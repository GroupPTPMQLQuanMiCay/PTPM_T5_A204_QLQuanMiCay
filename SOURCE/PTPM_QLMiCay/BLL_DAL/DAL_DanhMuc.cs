using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_DanhMuc
    {

        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();
        public DAL_DanhMuc()
        {

        }
        public List<DanhMuc> LoadAllDM()
        {
            List<DanhMuc> l = new List<DanhMuc>();
            l = _context.DanhMucs.Select(t => t).ToList();
            return l;
        }

        public void insertDM(string tenDm)
        {
           
                DanhMuc dm = new DanhMuc();
                dm.DM_Ten = tenDm;
                _context.DanhMucs.InsertOnSubmit(dm);
                _context.SubmitChanges();
               
        }
   
    }
}
