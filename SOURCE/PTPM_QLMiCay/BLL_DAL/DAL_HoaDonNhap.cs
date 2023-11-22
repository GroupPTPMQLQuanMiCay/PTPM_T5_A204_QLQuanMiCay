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
