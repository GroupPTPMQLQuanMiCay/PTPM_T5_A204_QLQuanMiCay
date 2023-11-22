using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_ChiTietNhap
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public DAL_ChiTietNhap() { }

        public void insert(int nlId, int hdId, int sl, int gia)
        {
            ChiTietNhap ct = new ChiTietNhap();
            ct.NL_Id = nlId;
            ct.HDN_Id = hdId;
            ct.CTN_SoLuong = sl;
            ct.CTN_Gia = gia;

            _context.ChiTietNhaps.InsertOnSubmit(ct);
            _context.SubmitChanges();
        }
    }
}
