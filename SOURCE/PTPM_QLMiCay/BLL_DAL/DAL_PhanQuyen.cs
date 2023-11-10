using System.Collections.Generic;

namespace BLL_DAL
{
    public class DAL_PhanQuyen
    {
        QLQuanMiCayDataContext qmc = new QLQuanMiCayDataContext();

        DAL_NhomQuyen_NguoiDung nhomQuyen_nguoiDung = new DAL_NhomQuyen_NguoiDung();
        DAL_CapQuyenNhom capQuyenNhom = new DAL_CapQuyenNhom();
        public DAL_PhanQuyen()
        {
        }

        public int getQuyenID(string user, string MHID)
        {
            List<string> NQIDS = nhomQuyen_nguoiDung.layNhomQuyenTheoNguoiDung(user);
            int id = 0;
            foreach (string item in NQIDS)
            {
                int ID = capQuyenNhom.getQuyenID(item, MHID);
                if (id < ID)
                    id = ID;
            }
            return id;
        }


    }
}
