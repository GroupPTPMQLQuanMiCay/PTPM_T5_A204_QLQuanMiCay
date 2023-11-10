﻿using System.Linq;

namespace BLL_DAL
{
    public class DAL_NguoiDung
    {
        QLQuanMiCayDataContext qmc = new QLQuanMiCayDataContext();
        
        public DAL_NguoiDung()
        {
        }

        public object load()
        {
            return qmc.NguoiDungs.Where(t => !t.NG_Id.Equals("sa")).Select(t => t).ToList();
        }
    }
}
