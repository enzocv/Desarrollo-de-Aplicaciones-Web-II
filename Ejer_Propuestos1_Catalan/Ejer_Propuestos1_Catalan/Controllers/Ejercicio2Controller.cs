using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio2Controller : Controller
    {
        // GET: Ejercicio2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularNumeros(ClsEjercicio2 objejer2)
        {
            objejer2.valPositivo = new List<int>();
            objejer2.valNegativo = new List<int>();
            IList<ClsEjercicio2> List = new List<ClsEjercicio2>();
            if (objejer2.numeros != null && ModelState.IsValid)
            {
                foreach (int i in objejer2.numeros)
                    if (i < 0)
                    {
                        objejer2.valNegativo.Add(i);
                    }
                    else
                    {
                        objejer2.valPositivo.Add(i);
                    }
                ViewData["numNegativos"] = objejer2.valNegativo;
                ViewData["numPositivos"] = objejer2.valPositivo;
                objejer2.validar = null;
            }
            else
            {
                objejer2.validar = "ERROR";
                ViewBag.Comunicado = "Ingrese valor válido";
            }

            return View(objejer2);
        }
    }
}