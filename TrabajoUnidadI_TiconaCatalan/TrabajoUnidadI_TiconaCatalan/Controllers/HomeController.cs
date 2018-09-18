using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoUnidadI_TiconaCatalan.Models;

namespace TrabajoUnidadI_TiconaCatalan.Controllers
{
    public class HomeController : Controller
    {
        private CONCURSO objConcurso = new CONCURSO();
        private CATEGORIAS objCategoria = new CATEGORIAS();

        public ActionResult Index()
        {
            //return View(objConcurso.GetProyectos());
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}