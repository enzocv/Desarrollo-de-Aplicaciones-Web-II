using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio8Controller : Controller
    {
        // GET: Ejercicio8
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IngresarDatos(ClsEjercicio8 objEjercicio8)
        {
            if (ModelState.IsValid)
            {
                /**
                 * Almacenar la session
                 * */
                if (Session["EJER"] != null)
                {
                    /**
                     * Almacenar los datos
                     * */
                    objEjercicio8.ListNumeros = Session["EJER"] as List<int>;
                }
                else
                {
                    /**
                     * Crear nueva lista
                     * */
                    objEjercicio8.ListNumeros = new List<int>();
                }

                objEjercicio8.ListNumeros.Add(objEjercicio8.numeros);
                /**
                 * Almacenar todos los cambios que se hacen en la session
                 * */
                Session["EJER"] = objEjercicio8.ListNumeros;

                objEjercicio8.validar = null;
            }
            return View(objEjercicio8);
        }

    }
}