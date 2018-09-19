using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoUnidadI_TiconaCatalan.Models;

namespace TrabajoUnidadI_TiconaCatalan.Controllers
{
    public class MruvController : Controller
    {
        private ClsMruv objMoto = new ClsMruv();
        // GET: Mruv
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calcular(ClsMruv objmoto)
        {

            if (objmoto.velocidadA > objmoto.velocidadB)
            {
                objmoto.ganador = "Moto A";
                objmoto.tiempoGanador = (Math.Sqrt(2 * objmoto.distancia / objmoto.velocidadA));
                objmoto.tiempoPerdedor = (Math.Sqrt(2 * objmoto.distancia / objmoto.velocidadB));
                objmoto.distanciaPerdedor = (objmoto.velocidadB * Math.Pow(objmoto.tiempoGanador, 2)) / 2;
            }
            else if (objmoto.velocidadB > objmoto.velocidadA)
            {
                objmoto.ganador = "Moto B";
                objmoto.tiempoGanador = (Math.Sqrt(2 * objmoto.distancia / objmoto.velocidadB));
                objmoto.tiempoPerdedor = (Math.Sqrt(2 * objmoto.distancia / objmoto.velocidadA));
                objmoto.distanciaPerdedor = (objmoto.velocidadA * Math.Pow(objmoto.tiempoGanador, 2)) / 2;
            }
            else
            {
                objmoto.ganador = "Empate";
                objmoto.tiempoGanador = (Math.Sqrt(2 * objmoto.distancia / objmoto.velocidadA));
                objmoto.tiempoPerdedor = (Math.Sqrt(2 * objmoto.distancia / objmoto.velocidadB));
                objmoto.distanciaPerdedor = (objmoto.velocidadA * Math.Pow(objmoto.tiempoGanador, 2)) / 2;
            }

            return View(objmoto);
        }
    }
}