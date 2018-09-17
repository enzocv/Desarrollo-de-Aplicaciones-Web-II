using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EXA_U1_Catalan.Models;

namespace EXA_U1_Catalan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(ClsCarga objCarga)
        {
            return View(objCarga.ListarCarga());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}