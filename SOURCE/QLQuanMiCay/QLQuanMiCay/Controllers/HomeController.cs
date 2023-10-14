using BLL_DAL;
using BLL_DAL.XuLy;
using System.Collections.Generic;
using System.Web.Mvc;

namespace QLQuanMiCay.Controllers
{
    public class HomeController : Controller
    {
        DanhMucBLL dmBLL = new DanhMucBLL();
        //
        // GET: /Home/
        public ActionResult Index(int? index)
        {
            int i = (index ?? 1);
            List<DanhMuc> lstDanhMuc = dmBLL.getAll();
            ViewBag.Index = i;
            return View(lstDanhMuc);
        }
	}
}