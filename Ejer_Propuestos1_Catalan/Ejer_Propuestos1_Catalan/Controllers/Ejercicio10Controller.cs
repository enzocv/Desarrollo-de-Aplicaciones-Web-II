using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio10Controller : Controller
    {
        // GET: Ejercicio10
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dibujar(ClsEjercicio10 objbrujula)
        {
            /*Si x> 0 y y> 0 = Se encuentra en el Norte
            Si x > 0 y y<0 = Se encuentra en el Sur
            Si x < 0 y y<0 = Se encuentra en el Este
            Si x < 0 y y> 0 = Se encuentra en el Oeste
            Caso contrario se encuentra en el origen*/

            if (objbrujula.posX > 0 && objbrujula.posY > 0)
            {
                objbrujula.ubicacion = "Norte";
            }
            else if (objbrujula.posX > 0 && objbrujula.posY < 0)
            {
                objbrujula.ubicacion = "Sur";
            }
            else if (objbrujula.posX < 0 && objbrujula.posY < 0)
            {
                objbrujula.ubicacion = "Este";
            }
            else if (objbrujula.posX < 0 && objbrujula.posY > 0)
            {
                objbrujula.ubicacion = "Oeste";
            }
            else
            {
                //centro posX = 0 y posY = 0
                objbrujula.ubicacion = "Origen";
            }

            return View("Dibujar", objbrujula);
        }
    }
}