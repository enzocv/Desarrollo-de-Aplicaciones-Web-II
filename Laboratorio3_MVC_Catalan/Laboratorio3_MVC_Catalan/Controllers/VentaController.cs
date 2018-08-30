using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3_MVC_Catalan.Models;

namespace Laboratorio3_MVC_Catalan.Controllers
{
    public class VentaController : Controller
    {
        public static 
            double PRECIOUSB = 120;
            double PRECIOMOUSE = 50;
            double PRECIOTECLADO = 85;
            double PRECIODISCO = 350; 

        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }

        //otra forma de instanciar CalcularVenta(ClsVenta objVenta) 
        public ActionResult CalcularVenta(ClsVenta objVenta) 
        {
            if(objVenta.productoUSB == true)
            {
                objVenta.subtotal = objVenta.subtotal + PRECIOUSB;
            }

            if (objVenta.productoMouse == true)
            {
                objVenta.subtotal = objVenta.subtotal + PRECIOMOUSE;
            }

            if (objVenta.productoTeclado == true)
            {
                objVenta.subtotal = objVenta.subtotal + PRECIOTECLADO;
            }

            if (objVenta.productoDiscoDuro == true)
            {
                objVenta.subtotal = objVenta.subtotal + PRECIODISCO;
            }

            objVenta.igv = objVenta.subtotal * 0.18;
            objVenta.total = objVenta.subtotal + objVenta.igv;

            return View("CalcularVenta", objVenta);
        }
    }
}