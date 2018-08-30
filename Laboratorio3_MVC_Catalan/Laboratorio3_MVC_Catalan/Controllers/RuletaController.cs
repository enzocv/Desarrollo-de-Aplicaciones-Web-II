using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3_MVC_Catalan.Models;

namespace Laboratorio3_MVC_Catalan.Controllers
{
    public class RuletaController : Controller
    {
        // GET: Ruleta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenerarRuleta(ClsRuleta objRuleta)
        {
            Random rnd = new Random();

            objRuleta.valor1 = rnd.Next(3);
            objRuleta.valor2 = rnd.Next(3);
            objRuleta.valor3 = rnd.Next(3);

            if (objRuleta.valor1 == objRuleta.valor2 && objRuleta.valor2 == objRuleta.valor3)
            {
                objRuleta.resultado = "GANASTE";
            }
            else
            {
                objRuleta.resultado = "Para la proxima INCAUTO!!";
            }
            return View("GenerarRuleta", objRuleta);
        }
    }
}