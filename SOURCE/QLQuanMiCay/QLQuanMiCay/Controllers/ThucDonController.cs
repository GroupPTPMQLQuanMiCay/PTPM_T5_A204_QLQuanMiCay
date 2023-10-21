using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
using BLL_DAL.XuLy;

namespace QLQuanMiCay.Controllers
{
    public class ThucDonController : Controller
    {
        DanhMucBLL dmBLL = new DanhMucBLL();
        //
        // GET: /ThucDon/
        public ActionResult Index(int? index)
        {
            int i = (index ?? 1);
            List<DanhMuc> lstDanhMuc = dmBLL.getAll();
            ViewBag.Index = i;
            return View(lstDanhMuc);
        }
	}
}