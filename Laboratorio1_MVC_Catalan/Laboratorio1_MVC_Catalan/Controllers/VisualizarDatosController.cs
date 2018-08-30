using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio1_MVC_Catalan.Controllers
{
    public class VisualizarDatosController : Controller
    {
        // GET: VisualizarDatos
        public ActionResult Index()
        {
            return View();
        }

        //Crear accion Mostrar Datos
        public ActionResult MostrarDatos()
        {
            //pasar parametros
            //primera forma
            ViewBag.Curso = "Desarrollo de Aplicaciones Web II";
            ViewBag.Nombre = "Enzo Catalan Vargas";
            //segunda forma
            ViewData["Carrera"] = "Ingenieria de Sistemas";
            ViewData["FechaHora"] = DateTime.Now.ToString();
            return View();
        }
    }
}