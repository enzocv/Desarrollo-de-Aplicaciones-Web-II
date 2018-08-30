using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio1_MVC_Catalan.Models;//referenciar al modelo

namespace Laboratorio1_MVC_Catalan.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            return View();
        }

        //accion Mostrar Datos
        public ActionResult MostrarDatosEstudiante()
        {
            ClsEstudiante objEstudiante = new ClsEstudiante();//instancia de clase
            objEstudiante.Nombre = "Jose";
            objEstudiante.Apellido = "Alvarez Catalan";
            objEstudiante.Edad = 23;
            objEstudiante.Peso = 70.50;
            return View("MostrarDatosEstudiante", objEstudiante);
        }
    }
}