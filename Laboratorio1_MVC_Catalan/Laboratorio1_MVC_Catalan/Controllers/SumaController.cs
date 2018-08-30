using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio1_MVC_Catalan.Models;

namespace Laboratorio1_MVC_Catalan.Controllers
{
    public class SumaController : Controller
    {
        // GET: Suma
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarSuma()
        {
            ClsSuma objSuma = new ClsSuma();//instancia
            //recepcionar las variables de un formulario
            objSuma.num1 = Convert.ToDouble(Request.Form["valor1"]);
            objSuma.num2 = Convert.ToDouble(Request.Form["valor2"]);

            objSuma.resultado = objSuma.num1 + objSuma.num2;
            return View("Index", objSuma);
        }
    }
}