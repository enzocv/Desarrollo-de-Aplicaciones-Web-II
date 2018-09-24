using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoUnidadI_TiconaCatalan.Models;

namespace TrabajoUnidadI_TiconaCatalan.Controllers
{
    public class SortearController : Controller
    {
        private CONCURSO Concursos = new CONCURSO();
        private CATEGORIAS Categorias = new CATEGORIAS();
        // GET: Sortear
        public ActionResult Index(string criterio)
        {
            List<CONCURSO> lista = new List<CONCURSO>();
            List<int> posA = new List<int>();//para sorteo
            List<int> posB = new List<int>();//para sorteo
            List<int> posC = new List<int>();//para sorteo
            
            Random rnd = new Random();
            
            int cantA = Concursos.ListarA().Count();

            while (posA.Count() < cantA)
            {
                int num = rnd.Next(cantA + 1);
                if (!posA.Contains(num))
                {
                    if (num == 0)
                    {

                    }
                    else {
                        posA.Add(num);
                    }
                }
            }

            //2
            int cantB = Concursos.ListarB().Count();

            while (posB.Count() < cantB)
            {
                int num = rnd.Next(cantB + 1);
                if (!posB.Contains(num))
                {
                    if (num == 0)
                    {

                    }
                    else
                    {
                        posB.Add(num);
                    }
                }
            }
            //3
            int cantC = Concursos.ListarC().Count();

            while (posC.Count() < cantC)
            {
                int num = rnd.Next(cantC + 1);
                if (!posC.Contains(num))
                {
                    if (num == 0)
                    {

                    }
                    else
                    {
                        posC.Add(num);
                    }
                }
            }

            int[]  arreglo = new int[posA.Count()];
            ViewBag.array = arreglo = posA.ToArray();
			ViewBag.lenght = arreglo.Count();
			ViewBag.ListA = Concursos.ListarA().ToList();

            int[] arreglo2 = new int[posB.Count()];
            ViewBag.array1 = arreglo2 = posB.ToArray();
			ViewBag.lenght1 = arreglo2.Count();
			ViewData["ListB"] = posB;

			int[] arreglo3 = new int[posC.Count()];
            ViewBag.array2 = arreglo3 = posC.ToArray();
			ViewBag.lenght2 = arreglo3.Count();
			ViewData["ListC"] = posC;

			return View(Concursos.Listar());
        }
    }
}