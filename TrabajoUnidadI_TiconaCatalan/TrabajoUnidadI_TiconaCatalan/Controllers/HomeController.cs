using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoUnidadI_TiconaCatalan.Models;

namespace TrabajoUnidadI_TiconaCatalan.Controllers
{
    public class HomeController : Controller
    {
        private CONCURSO objConcurso = new CONCURSO();
        private CATEGORIAS objCategoria = new CATEGORIAS();

        public ActionResult Index()
        {
            //return View(objConcurso.GetProyectos());
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ListarCategorias()
        {
            return View(objCategoria.Listar());
        }

        public ActionResult AgregarCategoria(string valor = "")
        {
            ViewBag.Message = "Agregar Categoria";

            if (valor.Equals(""))
            {
                return View();
            }
            else
            {
                objCategoria.NOMBRECATEGORIA = valor;

                using (var db = new ModeloCONCURSO())
                {
                    db.CATEGORIAS.Add(this.objCategoria);
                    db.SaveChanges();
                }

                return RedirectToAction("ListarCategorias");
            }
        }
        public ActionResult EditarCategoria(CATEGORIAS objCats, int id = 0)
        {
            objCategoria.Obtener(id);
            if (objCategoria.IDCATEGORIA == 0)
            {
                return RedirectToAction("ListarCategorias");
            }
            else
            {
                return View();
            }
        }
    }
}