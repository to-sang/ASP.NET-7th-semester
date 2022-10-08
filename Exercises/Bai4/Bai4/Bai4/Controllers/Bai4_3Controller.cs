using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4.Controllers
{
    public class Bai4_3Controller : Controller
    {
        // GET: Bai4_3
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result()
        {
            ViewBag.name = Request.Form["name"];
            string kv = Request.Form["kv"];
            double diem = Convert.ToDouble(Request.Form["toan"]) + Convert.ToDouble(Request.Form["ly"]) + Convert.ToDouble(Request.Form["hoa"]) + 
                ((kv == "a") ? 1 : (kv == "b") ? 2 : 3) + ((Request.Form["gdcs"] == "on") ? 1 : 0);
            ViewBag.diem = diem;
            ViewBag.kq = (diem >= 20) ? "Đỗ đại học" : (diem >= 15) ? "Đỗ cao đẳng" : (diem >= 10) ? "Đỗ trung cấp" : "Thi trượt";
            return View();
        }
    }
}