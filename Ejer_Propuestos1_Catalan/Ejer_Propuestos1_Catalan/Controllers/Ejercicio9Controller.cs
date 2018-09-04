using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio9Controller : Controller
    {
        // GET: Ejercicio9
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularBilletes(ClsEjercicio9 objbilletes)
        {
            objbilletes.billetes = new List<int>();
            objbilletes.cantBilletes = new List<int>();

            double[] cajero = { 100, 50, 20, 10 };
            int res = 0, cos = 0;
            for (int i = 0; i < cajero.Count(); i++)
            {
                if (i == 0)
                {
                    cos = Convert.ToInt32(Math.Floor(objbilletes.monto / cajero[i]));
                    res = Convert.ToInt32((objbilletes.monto % cajero[i]));

                    objbilletes.cantBilletes.Add(cos);
                }
                else
                {
                    cos = Convert.ToInt32(Math.Floor(res / cajero[i]));
                    res = Convert.ToInt32((res % cajero[i]));

                    objbilletes.cantBilletes.Add(cos);
                }
            }


            return View("CalcularBilletes", objbilletes);
        }
    }
}