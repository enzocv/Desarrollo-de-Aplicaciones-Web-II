using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio7Controller : Controller
    {
        // GET: Ejercicio7
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dibujar(ClsEjercicio7 objdibujo)
        {
            objdibujo.grafico = new List<String>();

            for (int i = 0; i < objdibujo.filas; i++)
            {
                string x = "";
                for (int j = 0; j <= i; j++)
                {
                    x = x + objdibujo.simbolo;
                }
                objdibujo.grafico.Add(x);
            }

            return View("Dibujar", objdibujo);
        }
    }
}