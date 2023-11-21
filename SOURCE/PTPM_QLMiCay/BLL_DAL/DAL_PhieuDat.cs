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

        public List<PhieuDat> getIncredientOrders()
        {
            return _context.PhieuDats.Where(x => x.isDeleted == false).Select(x => x).ToList();
        }

        public PhieuDat getIncredientOrder(int orderId)
        {
            return _context.PhieuDats.Where(p => p.PD_Id == orderId && p.isDeleted == false).FirstOrDefault();
        }

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
            }
            catch
            {
                return ERROR_ON_EXECUTION;
            }
        }

        public PhieuDat getLatestIncredientOrder()
        {
            return _context.PhieuDats.Where(x => x.isDeleted == false)
                                     .OrderByDescending(x => x.PD_Id)
                                     .FirstOrDefault();
        }

        public int update(int pdId, string creater, DateTime ngaydat)
        {
            PhieuDat pd = _context.PhieuDats.Where(x => x.PD_Id == pdId && x.isDeleted == false)
                                            .FirstOrDefault();
            if (pd != null)
            {
                pd.updatedAt = DateTime.Now;
                pd.updatedBy = creater;
                pd.PD_Date = ngaydat;
                _context.SubmitChanges();
                return SUCCESS;
            }
            else
            {
                return INVALID_PARAMETER;
            }
        }

        public int delete(int pdId, string creater)
        {
            PhieuDat pd = _context.PhieuDats.Where(x => x.PD_Id == pdId && x.isDeleted == false).FirstOrDefault();
            if (pd != null)
            {
                pd.updatedAt = DateTime.Now;
                pd.updatedBy = creater;
                pd.isDeleted = true;
                _context.SubmitChanges();
                return SUCCESS;
            }
            else
            {
                return INVALID_PARAMETER;
            }
        }

        public int sendToSupplier(int pdId, string sender)
        {
            PhieuDat pd = _context.PhieuDats.Where(x => x.PD_Id == pdId && x.isDeleted == false)
                                            .FirstOrDefault();
            if (pd != null)
            {
                pd.updatedAt = DateTime.Now;
                pd.updatedBy = sender;
                pd.sentSupplierBy = sender;
                pd.isSentSupplier = true;
                _context.SubmitChanges();
                return SUCCESS;
            }
            else
            {
                return INVALID_PARAMETER;
            }
        }
    }
}
