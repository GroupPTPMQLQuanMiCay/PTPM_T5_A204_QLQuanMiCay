using System.Linq;

namespace BLL_DAL
{
    public class DAL_TaiKhoan
    {
        QLQuanMiCayDataContext qmc = new QLQuanMiCayDataContext();
        public DAL_TaiKhoan()
        {
        }

        public TaiKhoan loadTaiKhoan(string TK_TEN, string TK_MATKHAU)
        {
            return qmc.TaiKhoans.Where(
                t => t.TK_Ten.Equals(TK_TEN) && t.TK_MatKhau.Equals(TK_MATKHAU))
                .FirstOrDefault();
        }

        public int checkTaiKhoan(string TK_TEN, string TK_MATKHAU)
        {
            TaiKhoan tk = null;
            try
            {
                tk = qmc.TaiKhoans.Where(
                t => t.TK_Ten.Equals(TK_TEN))
                .FirstOrDefault();
            }
            catch
            {
                return -3;
            }
            
            if (tk == null)
                return -1;
            if (!tk.TK_MatKhau.Equals(TK_MATKHAU))
                return -2;
            return 1;
        }

    }
}
