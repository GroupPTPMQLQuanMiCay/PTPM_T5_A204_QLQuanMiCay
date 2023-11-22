using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class DAL_HoaDonNhap
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public DAL_HoaDonNhap() {  }

        public object getListOrderReceiptBySupplier(int subId)
        {
            return (from nl in _context.NguyenLieus
                    join ct in _context.CTPhieuDats on nl.NL_Id equals ct.NL_Id
                    join hdn in _context.HoaDonNhaps on ct.PD_Id equals hdn.PD_Id
                    where (nl.NCC_Id == subId)
                    select new
                    {
                        HDN_Id = hdn.HDN_Id,
                        NV_Ten = hdn.NhanVien.NV_Ten,
                        HDN_Ngaynhap = hdn.HDN_Ngaynhap,
                        HDN_ThanhTien = hdn.HDN_ThanhTien,
                        PD_Id = hdn.PD_Id
                    }).Distinct().ToList();

        }

        public object getListOrderReceiptByDate(DateTime ngayNhap)
        {
            return _context.HoaDonNhaps.Where(hd => hd.HDN_Ngaynhap.Date == ngayNhap.Date)
                                       .Select(x => new { x.HDN_Id, x.NhanVien.NV_Ten, x.HDN_Ngaynhap, x.HDN_ThanhTien, x.PD_Id })
                                       .ToList();
        }

        public object getListOrderReceiptByOrder(int pdId)
        {
            return _context.HoaDonNhaps.Where(hd => hd.PD_Id == pdId)
                                       .Select(x => new { x.HDN_Id, x.NhanVien.NV_Ten, x.HDN_Ngaynhap, x.HDN_ThanhTien, x.PD_Id })
                                       .ToList();
        }

        public void insert(string creator, DateTime ngayNhap, int thanhTien, int pdId)
        {
            HoaDonNhap hd = new HoaDonNhap();
            hd.NV_Id = creator;
            hd.HDN_Ngaynhap = ngayNhap;
            hd.HDN_ThanhTien = thanhTien;
            hd.PD_Id = pdId;

            _context.HoaDonNhaps.InsertOnSubmit(hd);
            _context.SubmitChanges();
        }

        public HoaDonNhap getLatestIncredientDilivery()
        {
            return _context.HoaDonNhaps.OrderByDescending(x => x.HDN_Id)
                                     .FirstOrDefault();
        }

        public List<HoaDonNhap> getListReceipt()
        {
            return _context.HoaDonNhaps.Select(x => x).ToList();
        }

        public HoaDonNhap getIncredientDilivery(int hdnId)
        {
            return _context.HoaDonNhaps.Where(x => x.HDN_Id == hdnId)
                                     .FirstOrDefault();
        }
    }
}
