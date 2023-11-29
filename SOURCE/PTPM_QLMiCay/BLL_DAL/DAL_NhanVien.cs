using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_NhanVien
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public DAL_NhanVien()
        {

        }
        public object getAllNV()
        {
            return _context.NhanViens.Select(t => new { t.NV_Id, t.NV_Ten, t.NV_GioiTinh, t.NV_NgaySinh, t.NV_DiaChi, t.NV_SDT, t.NV_TinhTrang }).ToList();
        }
    }
}
