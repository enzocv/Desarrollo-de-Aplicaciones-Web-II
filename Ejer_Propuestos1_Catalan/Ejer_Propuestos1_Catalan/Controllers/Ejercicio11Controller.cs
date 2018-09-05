using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio11Controller : Controller
    {
        // GET: Ejercicio11
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularUllman(ClsEjercicio11 objEjercicio11)
        {
            objEjercicio11.Uentero = new List<int>();
            objEjercicio11.Usimbolo = new List<string>();
            ViewBag.Primero = objEjercicio11.entero;
            if (objEjercicio11.entero != 0 && ModelState.IsValid)
            {//Validando
                objEjercicio11.Uentero.Add(objEjercicio11.entero);
                do
                {
                    if (objEjercicio11.entero % 2 == 0)
                    {
                        objEjercicio11.entero = objEjercicio11.entero / 2;
                        objEjercicio11.Uentero.Add(objEjercicio11.entero);
                    }
                    else
                    {
                        objEjercicio11.entero = (objEjercicio11.entero * 3) + 1;
                        objEjercicio11.Uentero.Add(objEjercicio11.entero);
                    }
                } while (objEjercicio11.entero != 1);
                
            }
            
            //generar el grafico segun el resultado de Ullman
            for (int i = 0; i < objEjercicio11.Uentero.Count(); i++)
            {
                string sim = "";
                for (int j = 0; j < objEjercicio11.Uentero[i]; j++)
                {
                    sim = sim + objEjercicio11.simbolo;
                }
                objEjercicio11.Usimbolo.Add(sim);
            }

            ViewBag.CountU = objEjercicio11.Uentero.Count();
            ViewData["Usimbolo"] = objEjercicio11.Usimbolo;
            ViewData["Ullman"] = objEjercicio11.Uentero;

            return View(objEjercicio11);
        }
    }
}