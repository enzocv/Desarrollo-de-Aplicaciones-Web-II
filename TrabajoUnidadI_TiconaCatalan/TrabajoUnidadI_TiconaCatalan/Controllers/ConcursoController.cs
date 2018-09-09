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
            objconcurso.integrantes = new List<string>();

            objconcurso.tema = "proyecto 1";
            objconcurso.curso = "LP3";
            objconcurso.categoria = "A";
            objconcurso.asesor = "Ing Lanchipa";
            objconcurso.integrantes.Add("AL 1 V");
            objconcurso.integrantes.Add("AL 2 VI");

            //crear archivo JSON
            try
            {
                string output = JsonConvert.SerializeObject(objconcurso, Formatting.Indented);

                using (var writer = new StreamWriter(_path))
                {
                    writer.Write(output);
                }
            }
            catch (Exception ex)
            {
                // ignored
            }

            return View(objconcurso);
        }
    }
}