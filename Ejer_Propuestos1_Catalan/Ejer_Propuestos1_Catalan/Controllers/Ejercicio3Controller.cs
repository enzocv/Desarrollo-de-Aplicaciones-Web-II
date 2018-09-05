using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio3Controller : Controller
    {
        // GET: Ejercicio3
        public ActionResult Index()
        {
            return View();
        }
        int auxCont = 0;
        public ActionResult CalcPosiciones(ClsEjercicio3 objEjercicio3)
        {
            //instaciar dos list tipo int
            objEjercicio3.valMediaPares = new List<double>();
            objEjercicio3.valMediaInpares = new List<double>();

            if (objEjercicio3.numeros != null && ModelState.IsValid)
            {
                foreach (int i in objEjercicio3.numeros)
                    if (auxCont % 2 == 0)
                    {
                        objEjercicio3.valMediaPares.Add(i);
                        auxCont++;
                    }
                    else
                    {
                        objEjercicio3.valMediaInpares.Add(i);
                        auxCont++;
                    }
                if (objEjercicio3.LMDes)
                {
                    ViewData["Result"] = objEjercicio3.valMediaPares.Sum() / objEjercicio3.valMediaPares.Count();
                }
                else
                {
                    ViewData["Result"] = objEjercicio3.valMediaInpares.Sum() / objEjercicio3.valMediaInpares.Count();
                }
                objEjercicio3.validar = null;
            }
            else
            {
                objEjercicio3.validar = "ERROR";
                ViewBag.Comunicado = "Ingrese valor válido";
            }

            return View(objEjercicio3);
        }
    }
}