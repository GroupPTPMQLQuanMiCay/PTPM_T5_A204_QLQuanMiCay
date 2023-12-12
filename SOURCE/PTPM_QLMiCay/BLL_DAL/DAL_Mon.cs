using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DAL_Mon
    {
        QLQuanMiCayDataContext _context = new QLQuanMiCayDataContext();

        public DAL_Mon()
        {

        }
        public List<Mon> LoadAllMon()
        {
            List<Mon> result = new List<Mon>();
            result = _context.Mons.Select(t => t).ToList();
            return result;
        }
        public List<Mon> getMonByIDDM(int id_DM)
        {
      
             List<Mon> result = _context.Mons.Where(m => m.DM_Id == id_DM && m.isDelete == false).ToList();
             return result;
        }

        public object loadData()
        {
            return _context.Mons.Where(x => x.isDelete == false).Select(x => new { x.M_Ten, x.M_Gia }).ToList();
        }

        public Mon GetMon(string tenMon)
        {
            return _context.Mons.Where(x => x.isDelete == false && x.M_Ten == tenMon).FirstOrDefault();
        }

        public bool insert(string tenMon, string danhMuc, string donGia)
        {
            var exist = _context.Mons.Where(x => x.M_Ten == tenMon).FirstOrDefault();

            if (exist != null)
            {
                return false;
            }

            try
            {
                int dmucId = int.Parse(danhMuc);
                int dGia = int.Parse(donGia);
                Mon m = new Mon();
                m.M_Ten = tenMon;
                m.DM_Id = dmucId;
                m.M_Gia = dGia; 
                m.M_IMG = "lau-kim-chi-bach-tuot.jpg";
                _context.Mons.InsertOnSubmit(m);
                _context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(string tenMon)
        {
            var exist = _context.Mons.Where(x => x.M_Ten == tenMon).FirstOrDefault();

            if (exist == null)
            {
                return false;
            }

            try
            {
                exist.isDelete = true;
                _context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteNguyenLieuMon(string tenMon, int NL_Id)
        {
            var exist = _context.Mon_Co_NLs.Where(x => x.M_Ten == tenMon && x.NL_Id == NL_Id).FirstOrDefault();

            if (exist == null)
            {
                return false;
            }

            try
            {
                _context.Mon_Co_NLs.DeleteOnSubmit(exist);
                _context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(string tenMon, string danhMuc, string donGia)
        {
            var exist = _context.Mons.Where(x => x.M_Ten == tenMon).FirstOrDefault();

            if (exist == null)
            {
                return false;
            }

            try
            {
                int dmucId = int.Parse(danhMuc);
                int dGia = int.Parse(donGia);
                exist.M_Ten = tenMon;
                exist.DM_Id = dmucId;
                exist.M_Gia = dGia;
                exist.M_IMG = "lau-kim-chi-bach-tuot.jpg";
                _context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateNguyenLieuMon(string tenMon, int nlId, string soLuong)
        {
            var exist = _context.Mon_Co_NLs.Where(x => x.M_Ten == tenMon && x.NL_Id == nlId).FirstOrDefault();

            if (exist == null)
            {
                try
                {
                    int sl = int.Parse(soLuong);
                    DAL_NguyenLieu nlDal = new DAL_NguyenLieu();
                    NguyenLieu nl = nlDal.getIncredientById(nlId);
                    Mon_Co_NL mon = new Mon_Co_NL();
                    mon.M_Ten = tenMon;
                    mon.NL_Id = nlId;
                    mon.MNL_SoLuong = sl;
                    mon.MNL_DonViTinh = nl.NL_DonViTinh;
                    return true;
                } catch
                {
                    return false;
                }
                
            }

            try
            {
                int sl = int.Parse(soLuong);
                if(sl != exist.MNL_SoLuong)
                {
                    exist.MNL_SoLuong = sl;
                }
                _context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
