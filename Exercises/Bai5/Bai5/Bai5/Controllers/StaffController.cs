using Bai5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai5.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(FormCollection f)
        {
            var fimg = Request.Files["myfileImage"];
            var pathimg = Server.MapPath("~/Images/" + fimg.FileName);
            fimg.SaveAs(pathimg);
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = { f["txtID"], f["txtName"], f["txtDate"], f["txtSalary"], fimg.FileName };
            System.IO.File.WriteAllLines(path, info);
            return View("Index");
        }

        public ActionResult Open()
        {
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = System.IO.File.ReadAllLines(path);
            Staff staff = new Staff();
            staff.StaffId = info[0];
            staff.StaffName = info[1];
            staff.BirthOfDate = DateTime.Parse(info[2]);
            staff.Salary = decimal.Parse(info[3]);
            staff.StaffImage = info[4];

            ViewBag.id = staff.StaffId;
            ViewBag.name = staff.StaffName;
            ViewBag.birthday = staff.BirthOfDate.ToString("yyyy-MM-dd");
            ViewBag.salary = staff.Salary;
            ViewBag.image = "../../Images/" + staff.StaffImage;
            return View("Index");
        }
    }
}