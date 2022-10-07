using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4.Controllers
{
    public class Bai4_2Controller : Controller
    {
        // GET: Bai4_2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result(string name, string ut, string type, string vaocu, string vaomoi)
        {
            ViewBag.name = name;
            double dien = Convert.ToDouble(vaomoi) - Convert.ToDouble(vaocu);
            ViewBag.dien = dien;
            ViewBag.tien = ((dien <= 100) ? dien * 2000 :
                            (dien <= 150) ? (dien - 100) * 2500 + 200000 :
                            (dien <= 200) ? (dien - 150) * 3000 + 125000 + 200000 :
                            (dien - 200) * 4000 + 150000 + 125000 + 200000) * 
                            ((type == "kd") ? 1.2 : 
                            (type == "sx") ? 1.3 : 1) * 
                            ((ut == "on") ? 0.9 : 1);
            return View();
        }
    }
}