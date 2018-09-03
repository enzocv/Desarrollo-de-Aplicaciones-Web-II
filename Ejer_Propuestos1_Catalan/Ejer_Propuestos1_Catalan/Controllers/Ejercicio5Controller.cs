using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio5Controller : Controller
    {
        // GET: Ejercicio5
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularPension(ClsEjercicio5 objejer5)
        {
            objejer5.pension = 0;

            //cantidad de Hijos
            if (objejer5.numHijos1 == "Hijos1")
            {
                objejer5.pension = objejer5.pension + 70;

            }
            else if (objejer5.numHijos1 == "Hijos2")
            {
                objejer5.pension = objejer5.pension + 90;
            }
            else if (objejer5.numHijos1 == "Hijos3")
            {
                objejer5.pension = objejer5.pension + 120;
            }

            //Hijos en edad escolar
            objejer5.pension = objejer5.pension  + (10 * objejer5.cantHijosEscu);

            //Madre viuda
            if (objejer5.viuda == "Viuda")
            {
                objejer5.pension = objejer5.pension + 20;
            }

            return View("CalcularPension", objejer5);
        }
    }
}