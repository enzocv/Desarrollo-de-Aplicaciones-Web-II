using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio6_LINQ_XML_Catalan.Models;
using System.Data;

namespace Laboratorio6_LINQ_XML_Catalan.Controllers
{
    public class CursosController : Controller
    {
        // GET: Cursos
        public ActionResult Index()
        {
            //trabajando con el metodo listar cursos
            ClsCursos objCurso = new ClsCursos();
            var data = objCurso.ListarCursos();
            return View(data.ToList());
        }

        public ActionResult ListarCursos2(ClsCursos objCurso)
        {
            //trabajando con el metodo listar cursos 2
            return View(objCurso.ListarCursos2());
        }

        public ActionResult ObtenerCodigo(ClsCursos objCurso, string codigo)
        {
            //trabajando con el metodo BuscarPorCodigo 
            if (codigo == "" ||  codigo == null)
            {
                return View(objCurso.ListarCursos2());
            }
            else
            {
                return View(objCurso.ObtenerPorCodigo(codigo));
            }
        }

        public ActionResult ObtenerCodigo2(ClsCursos objCurso, string codigo)
        {
            //trabajando con el metodo BuscarPorCodigo 
            if (codigo == "" || codigo == null)
            {
                return View(objCurso.ListarCursos2());
            }
            else
            {
                return View(objCurso.ObtenerPorCodigo2(codigo));
            }
        }
    }
}