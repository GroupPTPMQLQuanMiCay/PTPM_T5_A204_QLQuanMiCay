using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
using BLL_DAL.XuLy;
using Newtonsoft.Json;

namespace QLQuanMiCay.Controllers
{
    public class GioHangController : Controller
    {
        ThuatToan thuatToan = new ThuatToan();
        OrderBLL orderBLL = new OrderBLL();
        MonBll monBLL = new MonBll();
        //
        // GET: /GioHang/
        public ActionResult Index(string tenMonOrderJson)
        {
            
            List<string> tenMonOrder = null;
            List<Mon> monOrder = new List<Mon>();
            List<Mon> monGoiY = new List<Mon>();
            if (tenMonOrderJson != null)
            {
                tenMonOrder = JsonConvert.DeserializeObject<List<string>>(tenMonOrderJson);
            }

            if (tenMonOrder != null)
            {
                monOrder = monBLL.getMonByListTenMon(tenMonOrder);
                monGoiY = thuatToan.GetTop5MonGoiY(tenMonOrder);
            }

            if(monGoiY == null)
                monGoiY = orderBLL.get5TopMonBanChay();

            return View(monGoiY);
        }

       
	}
}