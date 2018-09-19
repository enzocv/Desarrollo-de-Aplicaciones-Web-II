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
            List<CATEGORIAS> catego = new List<CATEGORIAS>();
            List<int> posA = new List<int>();//para sorteo
            List<int> posB = new List<int>();//para sorteo
            List<int> posC = new List<int>();//para sorteo

            lista = Concursos.Listar();
            catego = Categorias.Listar();

            Random rnd = new Random();
            int num = 0, aux = 0;
            foreach (var item in lista)
            {
                if (item.CATEGORIAS.NOMBRECATEGORIA.Equals("A"))
                {
                    num = rnd.Next(1,5);
                    //ver si el numero generado se encuentra en la lista para que no se repita
                    //while ()
                    //{

                    //}
                    
                }
            }
            foreach (var item in lista)
            {
                if (item.CATEGORIAS.NOMBRECATEGORIA.Equals("B"))
                {

                }
            }
            foreach (var item in lista)
            {
                if (item.CATEGORIAS.NOMBRECATEGORIA.Equals("C"))
                {

                }
            }

            return View(Concursos.Listar());
        }
    }
}