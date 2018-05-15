using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLINICAMVC.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Inicio()
        {
            return View();
        }
        public ActionResult MenuSeguridad()
        {
            return View();
        }
        public ActionResult MenuCitas()
        {
            return View();
        }
    }
}