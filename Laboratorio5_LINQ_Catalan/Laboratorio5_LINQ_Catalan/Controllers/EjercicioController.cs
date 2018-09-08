using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio5_LINQ_Catalan.Models;

namespace Laboratorio5_LINQ_Catalan.Controllers
{
    public class EjercicioController : Controller
    {
        public String[] alumnos = { "Carlos",
            "Leonardo", "Ana", "Maria", "Miquel", "Sergio", "Luis", "Hernan" };

        public String[] notas = { "20", "5", "12", "8", "16", "18", "10.4", "10.5" };

        // GET: Ejercicio
        public ActionResult Index(ClsAlumnoNota objAlumno)
        {
            string busqueda;
            objAlumno.nombreA = new List<string>();
            objAlumno.notaA = new List<double>();

            if (objAlumno.busqueda != null)
            {
                busqueda = objAlumno.busqueda;

                var query = (from a in alumnos.Select((alumno, index) => new { alumno, index })
                             join n in notas.Select((nota, index) => new { nota, index })
                             on a.index equals n.index
                             where a.alumno.Contains(busqueda)
                             select new { a.alumno, n.nota }).ToList();
                foreach (var item in query)
                {
                    objAlumno.nombreA.Add(Convert.ToString(item.alumno));
                    objAlumno.notaA.Add(Convert.ToDouble(item.nota));
                }
            }
            else
            {
                var query = (from a in alumnos.Select((alumno, index) => new { alumno, index })
                             join n in notas.Select((nota, index) => new { nota, index })
                             on a.index equals n.index
                             select new { a.alumno, n.nota }).ToList();

                foreach (var item in query)
                {
                    objAlumno.nombreA.Add(Convert.ToString(item.alumno));
                    objAlumno.notaA.Add(Convert.ToDouble(item.nota));
                }
            }
            objAlumno.filas = objAlumno.nombreA.Count();
            return View(objAlumno);
        }
    }
}