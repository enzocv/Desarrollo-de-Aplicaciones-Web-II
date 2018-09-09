using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using System.IO;
using TrabajoUnidadI_TiconaCatalan.Models;

namespace TrabajoUnidadI_TiconaCatalan.Controllers
{
    public class ConcursoController : Controller
    {
        private readonly string _path = $"d:\\GitHub\\Desarrollo-de-Aplicaciones-Web-II\\TrabajoUnidadI_TiconaCatalan\\Concurso.json";
        // GET: Concurso
        public ActionResult Index(ClsConcurso objconcurso)
        {
            
            
            return View(objconcurso);
        }
    }
}