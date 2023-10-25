using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL.XuLy
{
    public class TinTucBLL
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public List<TinTuc> getAll()
        {
            var tintucs = _context.TinTucs.Select(tt => tt).ToList();
            return tintucs;
        }

        public List<TinTuc> getTinTucByLoaiTin(int Id)
        {
            var tintucs = _context.TinTucs.Where(tt => tt.LoaiTin_Id == Id).Select(tt => tt).ToList();
            return tintucs;
        }

        public int getSLTinTucCoTen(string text)
        {
            int sl = _context.TinTucs.Where(m => m.TieuDe.Contains(text)).ToList().Count;
            return sl;
        }

        public List<TinTuc> getTinTucByTieuDe(string text)
        {
            var tintucs = _context.TinTucs.Where(tt => tt.TieuDe.Contains(text)).Select(tt => tt).ToList();
            return tintucs;
        }
    }
}
