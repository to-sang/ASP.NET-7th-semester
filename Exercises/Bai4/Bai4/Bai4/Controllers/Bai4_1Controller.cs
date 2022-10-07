using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4.Controllers
{
    public class Bai4_1Controller : Controller
    {
        // GET: Bai4_1
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string aa, string bb, string Cal)
        {
            double a = Convert.ToDouble(aa);
            double b = Convert.ToDouble(bb);
            double c = 0;
            System.Diagnostics.Debug.WriteLine(Cal);
            switch (Cal)
            {
                case "add":
                    c = a + b;
                    break;
                case "sub":
                    c = a - b;
                    break;
                case "mul":
                    c = a * b;
                    break;
                case "div":
                    c = a / b;
                    break;
            }
            ViewBag.Result = c;
            return View();
        }
    }
}