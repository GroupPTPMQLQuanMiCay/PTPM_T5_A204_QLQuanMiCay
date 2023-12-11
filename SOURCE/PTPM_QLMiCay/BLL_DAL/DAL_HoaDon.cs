using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_HoaDon
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public DAL_HoaDon()
        {

        }
        public HoaDon insert(string idNV,int soBan)
        {
            HoaDon hd = new HoaDon();
            hd.NV_Id = idNV;
            hd.B_SoBan = soBan;
            hd.HD_NgayXuat = DateTime.Now;
            _context.HoaDons.InsertOnSubmit(hd);
            _context.SubmitChanges();
            var HoaDon = _context.HoaDons.OrderByDescending(x => x.HD_Id).Take(1);
            return hd;
        }
        public HoaDon getLatestHD(int soBan)
        {
            return _context.HoaDons.Where(t => t.B_SoBan == soBan).OrderByDescending(x => x.HD_Id).FirstOrDefault();
        }

        public void PayHD(int soBan, int thanhTien)
        {
            var updateHD = _context.HoaDons.FirstOrDefault(h => h.B_SoBan == soBan && h.HD_TrangThai == 0);
            if (updateHD != null)
            {
                updateHD.HD_TrangThai = 1;
                updateHD.HD_ThanhTien = thanhTien; 
                _context.SubmitChanges();
            }
        }

        public int removeHD(int Id_hd)
        {
            // 0 thanh cong
            // -1 ngoai le error
            // -2 khong ton tai
            try
            {
                HoaDon HDTemp = _context.HoaDons.FirstOrDefault(m => m.HD_Id == Id_hd);
                if (HDTemp != null)//or co ton tai hay khong
                {
                    _context.HoaDons.DeleteOnSubmit(HDTemp);
                    _context.SubmitChanges();
                    return 0;
                }
                return -2;

            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}
