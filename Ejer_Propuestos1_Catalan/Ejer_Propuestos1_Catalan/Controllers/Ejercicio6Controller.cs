using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio6Controller : Controller
    {
        // GET: Ejercicio6
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(ClsEjercicio6 objcoche)
        {
            objcoche.total = 0;
            switch (objcoche.coche)
            {
                case "chico":
                    objcoche.total = (20 * objcoche.km) + (15 * objcoche.dias);
                    break;
                case "mediano":
                    objcoche.total = (30 * objcoche.km) + (20 * objcoche.dias);
                    break;
                case "grande":
                    objcoche.total = (40 * objcoche.km) + (30 * objcoche.dias);
                    break;
                default:
                    objcoche.total = 0;
                    break;
            }

            return View("Calcular", objcoche);
        }
    }
}