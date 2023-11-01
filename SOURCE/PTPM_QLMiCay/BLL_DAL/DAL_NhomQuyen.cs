using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_NhomQuyen
    {
        QLQuanMiCayDataContext qmc = new QLQuanMiCayDataContext();

        public DAL_NhomQuyen()
        {
        }

        public object loadNhomQuyen()
        {
            return qmc.NhomQuyens.Select(t => t).ToList();
        }

        public NhomQuyen loadSingleNhomQuyen(string NQID)
        {
            NhomQuyen nq = qmc.NhomQuyens.Where(t => t.NQ_Id.Equals(NQID)).FirstOrDefault();
            return nq;
        }
        public bool addNhomQuyen(string id, string ten, string hienThi)
        {
            try
            {
                qmc.NhomQuyens.InsertOnSubmit(new NhomQuyen() { 
                    NQ_Id = id, 
                    NQ_Ten = ten, 
                    NQ_HienThi = hienThi });
                qmc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteNhomQuyen(string id)
        {
            try
            {
                qmc.NhomQuyens.DeleteOnSubmit(loadSingleNhomQuyen(id));
                qmc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateNhomQuyen(string id, string ten, string hienThi)
        {
            try
            {
                NhomQuyen nq = loadSingleNhomQuyen(id);
                nq.NQ_Ten = ten;
                nq.NQ_HienThi = hienThi;
                qmc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
