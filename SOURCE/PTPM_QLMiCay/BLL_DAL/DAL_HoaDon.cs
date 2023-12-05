using System;
using System.Collections.Generic;
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
    }
}
