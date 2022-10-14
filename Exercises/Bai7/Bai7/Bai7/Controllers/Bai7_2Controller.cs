using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai7.Controllers
{
    public class Bai7_2Controller : Controller
    {
        // GET: Bai7_2
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string save)
        {
            ViewBag.content = "Full name: " + Request.Form["lname"] + " " + Request.Form["fname"] + "<br />";
            ViewBag.content += "Email: " + Request.Form["email"] + "<br />";
            ViewBag.content += "Password: " + Request.Form["pwd"] + "<br />";
            ViewBag.content += "City: " + Request.Form["city"] + "<br />";
            ViewBag.content += "Gender: " + Request.Form["gender"];
            return View();
        }
    }
}