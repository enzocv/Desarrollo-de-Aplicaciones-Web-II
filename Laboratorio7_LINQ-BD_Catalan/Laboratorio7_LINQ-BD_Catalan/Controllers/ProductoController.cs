using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio7_LINQ_BD_Catalan.Models;

namespace Laboratorio7_LINQ_BD_Catalan.Controllers
{
    public class ProductoController : Controller
    {
        //instanciar clase de los metodos
        private PRODUCTO objProducto = new PRODUCTO();

        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View(objProducto.Listar());
        }

        public ActionResult ListarConsulta()
        {
            return View(objProducto.ListarConsulta());
        }

        public ActionResult BuscarProducto(string valor)
        {
            return View(objProducto.BuscarProducto(valor));
        }
        public ActionResult MenorA()
        {
            return View(objProducto.MenorA());
        }
    }
}