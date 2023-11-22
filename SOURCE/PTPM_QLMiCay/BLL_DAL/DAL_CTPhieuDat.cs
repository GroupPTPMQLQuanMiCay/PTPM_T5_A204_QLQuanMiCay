using System.Collections.Generic;
using System.Linq;

namespace BLL_DAL
{
    public class DAL_CTPhieuDat
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();
        private static int INVALID_PARAMETER = -1;
        private static int ERROR_ON_EXECUTION = -2;
        private static int SUCCESS = 1;
        public DAL_CTPhieuDat() { }

        public int insert(int pdatId, int nlId, int soLuong, double gia)
        {
            CTPhieuDat ctpd = new CTPhieuDat();
            ctpd.PD_Id = pdatId;
            ctpd.NL_Id = nlId;
            ctpd.soluong = soLuong;
            ctpd.NL_Gia = gia;
            try
            {
                _context.CTPhieuDats.InsertOnSubmit(ctpd);
                _context.SubmitChanges();
                return SUCCESS;
            }
            catch
            {
                return ERROR_ON_EXECUTION;
            }
        }

        public List<CTPhieuDat> getIncredientOrderDetail(int orderId)
        {
            return _context.CTPhieuDats.Where(ct => ct.PD_Id == orderId).ToList();
        }

        public int update(int pdatId, int nlId, int soLuong, double gia)
        {
            CTPhieuDat ctpd = _context.CTPhieuDats.Where(x => x.PD_Id == pdatId && x.NL_Id == nlId)
                                                  .FirstOrDefault();

            try
            {
                if (ctpd != null)
                {
                    ctpd.soluong = soLuong;
                    ctpd.NL_Gia = gia;
                    _context.CTPhieuDats.InsertOnSubmit(ctpd);
                    _context.SubmitChanges();
                    return SUCCESS;
                }
                else
                {
                    return INVALID_PARAMETER;
                }
            }
            catch
            {
                return ERROR_ON_EXECUTION;
            }
        }

        public int updateDeliveredQuantity(int pdatId, int nlId, int soLuong)
        {
            CTPhieuDat ctpd = _context.CTPhieuDats.Where(x => x.PD_Id == pdatId && x.NL_Id == nlId)
                                                  .FirstOrDefault();

            try
            {
                if (ctpd != null)
                {
                    ctpd.DaGiao = ctpd.DaGiao + soLuong;
                    _context.SubmitChanges();
                    return SUCCESS;
                }
                else
                {
                    return INVALID_PARAMETER;
                }
            }
            catch
            {
                return ERROR_ON_EXECUTION;
            }
        }

        public int delete(int pdatId, int nlId)
        {
            CTPhieuDat ctpd = _context.CTPhieuDats.Where(x => x.PD_Id == pdatId && x.NL_Id == nlId)
                                                  .FirstOrDefault();

            try
            {
                if (ctpd != null)
                {
                    _context.CTPhieuDats.DeleteOnSubmit(ctpd);
                    _context.SubmitChanges();
                    return SUCCESS;
                }
                else
                {
                    return INVALID_PARAMETER;
                }
            }
            catch
            {
                return ERROR_ON_EXECUTION;
            }
        }

        public CTPhieuDat detail(int pdatId, int nlId)
        {
            return _context.CTPhieuDats.Where(x => x.PD_Id == pdatId && x.NL_Id == nlId)
                                                  .FirstOrDefault();
        }
    }
}
