using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using TONA.Models;

namespace TonaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Tona()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Galeria()
        {
            return View();
        }
        public ActionResult Galeriainvierno()
        {
            return View();
        }
        public ActionResult Galeriaverano()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Contact(MailModel mailModel)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("gustifeli@hotmail.com");
                mail.From = new MailAddress("gustifeli@hotmail.com");
                mail.Subject = "Msj Tona Web " + mailModel.nombre + " " + mailModel.apellido;
                string body = "Nombre: " + mailModel.nombre + " " + mailModel.apellido +
                    "</br> E-mail: " + mailModel.email +
                    "</br> Telefono: " + mailModel.telefono +
                    "</br> Localidad: " + mailModel.localidad +
                    "</br> Comentario: " + mailModel.comentario;
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.live.com";
                smtp.Port = 25;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new System.Net.NetworkCredential
                    ("gustifeli@hotmail.com", "contraseña");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                ViewBag.Message = "sent";
                return View();
            }
            else
            {
                return View();

            }
        }
    }
}