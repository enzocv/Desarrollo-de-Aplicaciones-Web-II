using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoUnidadI_TiconaCatalan.Models;

namespace TrabajoUnidadI_TiconaCatalan.Controllers
{
    public class SorteoController : Controller
    {
        private CATEGORIAS Categorias = new CATEGORIAS();
        // GET: Sorteo
        public ActionResult Index(string criterio)
        {
            return View(Categorias.Listar());
        }
        public ActionResult AgregarEditar(int id = 0)
        {
            return View(
                    id == 0 ? new CATEGORIAS() // Sirve para agregar una categoria nueva
                            : Categorias.Obtener(id)//devuelve un objeto
                );
        }
        public ActionResult Guardar( CATEGORIAS ObjCategorias)
        {
            if (ModelState.IsValid)
            {
                ObjCategorias.Guardar();
                return Redirect("~/Sorteo");
            }
            else {
                return View("~/Views/Sorteo/AgregarEditar.cshtml",ObjCategorias);
            }
        }

        public ActionResult Eliminar(int id)
        {
            Categorias.IDCATEGORIA = id;
            Categorias.Eliminar();
            return Redirect("~/Sorteo");
        }
    }
}