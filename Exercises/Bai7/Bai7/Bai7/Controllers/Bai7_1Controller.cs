using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai7.Controllers
{
    public class Bai7_1Controller : Controller
    {
        // GET: Bai7_1
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string so1, string so2, string cal)
        {
            double sot1 = Convert.ToDouble(so1);
            double sot2 = Convert.ToDouble(so2);
            switch (cal)
            {
                case "Cộng":
                    ViewBag.kq = sot1 + sot2;
                    break;
                case "Trừ":
                    ViewBag.kq = sot1 - sot2;
                    break;
                case "Nhân":
                    ViewBag.kq = sot1 * sot2;
                    break;
                case "Chia":
                    ViewBag.kq = sot1 / sot2;
                    break;
            }
            ViewBag.kq = ViewBag.kq.ToString();
            return View();
        }
    }
}