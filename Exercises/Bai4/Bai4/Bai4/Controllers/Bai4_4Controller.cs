using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4.Controllers
{
    public class Bai4_4Controller : Controller
    {
        // GET: Bai4_4
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Result()
        {
            ViewBag.manv = Request.Form["manv"];
            int nc = Convert.ToInt32(Request.Form["nc"]);
            ViewBag.nc = nc;
            string cv = Request.Form["cv"];
            double tien = Convert.ToDouble(Request.Form["bl"]) * 650000 *
                ((nc < 25) ? nc : 2 * nc - 25) + 
                ((cv == "tp") ? 500000 : (cv == "pp") ? 300000 : 0);
            ViewBag.tien = tien;
            return View();
        }
    }
}