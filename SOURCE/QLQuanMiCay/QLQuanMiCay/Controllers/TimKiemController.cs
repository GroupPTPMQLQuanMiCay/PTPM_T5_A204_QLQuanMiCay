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
    public class TimKiemController : Controller
    {
        MonBll monBll = new MonBll();
        TinTucBLL tinBll = new TinTucBLL();
        //
        // GET: /TimKiem/
        public ActionResult Index(string text, string searchBy, int? index)
        {
            ViewBag.searchBy = searchBy;
            ViewBag.slMon = monBll.getSLMonCoTen(text);
            ViewBag.slTin = tinBll.getSLTinTucCoTen(text);
            ViewBag.Text = text;
            ViewBag.Index = index ?? 1;
            return View();
        }

        public ActionResult MonSearchPartial(string text, int? index, string searchBy)
        {
            List<Mon> lstMon = null;
            lstMon = monBll.getMonByTenMon(text);
            ViewBag.searchBy = searchBy;
            return PartialView(lstMon.ToPagedList(index ?? 1, 10));
        }

        public ActionResult TinSearchPartial(string text, int? index, string searchBy)
        {
            List<TinTuc> lstTin = null;
            lstTin = tinBll.getTinTucByTieuDe(text);
            ViewBag.searchBy = searchBy;
            return PartialView(lstTin.ToPagedList(index ?? 1, 10));
        }
	}
}