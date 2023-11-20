using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_PhieuDat
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();
        private static int INVALID_PARAMETER = -1;
        private static int ERROR_ON_EXECUTION = -2;
        private static int SUCCESS = 1;
        public DAL_PhieuDat() { }

        public int insert(string creater, DateTime ngaydat)
        {
            PhieuDat pd = new PhieuDat();
            pd.PD_Date = ngaydat;
            pd.isDeleted = false;
            pd.createdBy = creater;
            pd.createdAt = DateTime.Now;
            pd.updatedAt = DateTime.Now;
            pd.updatedBy = creater;
            pd.isSentSupplier = false;
            try
            {
                _context.PhieuDats.InsertOnSubmit(pd);
                _context.SubmitChanges();
                return SUCCESS;
            } catch
            {
                return ERROR_ON_EXECUTION;
            }
        }

        public PhieuDat getLatestIncredientOrder()
        {
            return _context.PhieuDats.OrderByDescending(x => x.PD_Id).FirstOrDefault();
        }
    }
}
