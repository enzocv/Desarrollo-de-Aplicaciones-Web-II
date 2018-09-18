using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoUnidadI_TiconaCatalan.Models;

namespace TrabajoUnidadI_TiconaCatalan.Controllers
{
    public class ConcursoController : Controller
    {
        private CONCURSO Concurso = new CONCURSO();
        private CATEGORIAS Categoria = new CATEGORIAS();

        // GET: Concurso
        public ActionResult Index(string criterio)
        {
            return View(Concurso.Listar());
        }

        public ActionResult AgregarEditar(int id = 0)
        {
            ViewBag.Categorias = Categoria.Listar();

            return View(
                    id == 0 ? new CONCURSO() // Sirve para agregar una categoria nueva
                            : Concurso.Obtener(id)//devuelve un objeto
                );
        }

        public ActionResult Guardar(CONCURSO ObjConcurso)
        {
            if (ModelState.IsValid)
            {
                ObjConcurso.Guardar();
                return Redirect("~/Concurso");
            }
            else
            {
                return View("~/Views/Concurso/AgregarEditar.cshtml", ObjConcurso);
            }
        }

        public ActionResult Eliminar(int id)
        {
            Concurso.IDCONCURSO = id;
            Concurso.Eliminar();
            return Redirect("~/Concurso");
        }
    }
}