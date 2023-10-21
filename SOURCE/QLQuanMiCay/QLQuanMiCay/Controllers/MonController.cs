using BLL_DAL;
using BLL_DAL.XuLy;
using System.Collections.Generic;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace QLQuanMiCay.Controllers
{
    public class MonController : Controller
    {
        MonBll monBll = new MonBll();
        //
        // GET: /Mon/
        public ActionResult MonPartial(int Id, int? index)
        {
            List<Mon> mons = null;
            if (Id == -1)
            {
                mons = monBll.getAll();
            }
            else
            {
                mons = monBll.getMonByDanhMucId(Id);
            }
            ViewBag.Id = Id;
            return PartialView(mons.ToPagedList(index ?? 1, 12));
        }
    }
}