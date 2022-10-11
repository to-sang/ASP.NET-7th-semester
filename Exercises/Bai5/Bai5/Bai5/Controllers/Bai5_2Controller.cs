using Bai5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Bai5.Controllers
{
    public class Bai5_2Controller : Controller
    {
        // GET: Bai5_2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send(SendMailInfo info)
        {
            MailMessage message = new MailMessage(from: info.From, to: info.To);
            message.SubjectEncoding = System.Text.Encoding.Unicode;
            message.Subject = info.Subject;
            message.BodyEncoding = System.Text.Encoding.Unicode;
            info.Body = info.Body.Replace("\r\n", "<br />");
            message.Body = info.Body;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient(host: "smtp.gmail.com", port: 587)
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential(info.From, info.Password),
                EnableSsl = true
            };
            try
            {
                client.Send(message);
            }
            catch (Exception e)
            {
                throw e;
            }
            return View("Index");
        }
    }
}