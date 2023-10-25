using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
using BLL_DAL.XuLy;
using PagedList;
using PagedList.Mvc;

namespace QLQuanMiCay.Controllers
{
    public class TinTucController : Controller
    {
        LoaiTinBLL loaiTinBLL = new LoaiTinBLL();
        TinTucBLL tinTucBLL = new TinTucBLL();
        //
        // GET: /TinTuc/
        public ActionResult Index(int? index)
        {
            var loaiTins = loaiTinBLL.getAll();
            ViewBag.Index = index ?? 1;
            return View(loaiTins);
        }

        public ActionResult TinTucPartial(int Id, int? index)
        {
            List<TinTuc> lstTinTucs = null;
            if (Id == -1)
            {
                lstTinTucs = tinTucBLL.getAll();
            }
            else
            {
                lstTinTucs = tinTucBLL.getTinTucByLoaiTin(Id);
            }
            ViewBag.Id = Id;
            return PartialView(lstTinTucs.ToPagedList(index ?? 1, 9));
        }
	}
}