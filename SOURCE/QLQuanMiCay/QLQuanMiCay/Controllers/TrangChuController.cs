using BLL_DAL;
using BLL_DAL.XuLy;
using System.Collections.Generic;
using System.Web.Mvc;

namespace QLQuanMiCay.Controllers
{
    public class TrangChuController : Controller
    {
        OrderBLL orderBLL = new OrderBLL();
        //
        // GET: /TrangChu/
        public ActionResult Index()
        {
            List<Mon> mons = null;
            mons = orderBLL.get5TopMonBanChay();
            return View(mons);
        }

	}
}