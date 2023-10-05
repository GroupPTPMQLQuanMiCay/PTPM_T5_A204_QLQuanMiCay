using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
using BLL_DAL.XuLy;

namespace QLQuanMiCay.Controllers
{
    public class MonController : Controller
    {
        MonBll monBll = new MonBll();
        //
        // GET: /Mon/
        public ActionResult Index()
        {
            List<Mon> mons = monBll.getAll();
            return View(mons);
        }

        public ActionResult MonPartial()
        {
            List<Mon> mons = monBll.getAll();
            return View(mons);
        }
	}
}