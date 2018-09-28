using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using EXA_U1_CATALAN.Models;

namespace EXA_U1_CATALAN.Controllers
{
    public class CargaController : Controller
    {
        // GET
        public ActionResult Index(ClsCarga objCarga, string valor, string criterio)
        {
            //objCarga.BusquedaListar(valor, criterio);
            return View(objCarga.BusquedaListar(valor, criterio));
        }
    }
}