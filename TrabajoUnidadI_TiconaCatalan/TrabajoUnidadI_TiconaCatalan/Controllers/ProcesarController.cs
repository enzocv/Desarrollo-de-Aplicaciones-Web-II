using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TrabajoUnidadI_TiconaCatalan.Models;

namespace TrabajoUnidadI_TiconaCatalan.Controllers
{
    public class ProcesarController : Controller
    {
		private Persona persona = new Persona();
        // GET: Procesar
//        public ActionResult Index()
//        {
//            return View();
//        }
		public /*async Task<ActionResult>*/ ActionResult ProcesosEnParalelo(/*string criterio*/)
		{
			//List<Persona> per = new List<Persona>();
			//if (criterio == null || criterio == "")
			//{
			//	await Task.Run(()=>
			//	{
			//		//Cronometro
			//		var stopWatch = new Stopwatch();
			//		stopWatch.Start();

			//		per = persona.Listar();

			//		stopWatch.Stop();
			//		var duracionEnSegundos = stopWatch.ElapsedMilliseconds / 1000.0;
			//		ViewBag.DuracionL = duracionEnSegundos;
			//	});

			//	return View(per);
			//}
			//else
			//{
			//	await Task.Run(() =>
			//	{
			//		//Cronometro
			//		var stopWatch2 = new Stopwatch();
			//		stopWatch2.Start();

			//		per = persona.Buscar(criterio);

			//		stopWatch2.Stop();
			//		var duracionEnSegundos = stopWatch2.ElapsedMilliseconds / 1000.0;
			//		ViewBag.DuracionB = duracionEnSegundos;
			//	});
			return View("ProcesosEnParalelo");
			//}
		}
		//Accion Normal
		[HttpPost]
		[MultiButton(Name = "action", Argument = "Normal")]
		public ActionResult Normal(string criterio)
		{
			List<Persona> per = new List<Persona>();
			if (criterio != null || criterio != "")
			{
				//Cronometro
				//var stopWatch = new Stopwatch();
				//stopWatch.Start();

				//per = persona.ListarN();

				//stopWatch.Stop();
				//var duracionEnSegundos = stopWatch.ElapsedMilliseconds / 1000.0;
				//ViewBag.DuracionL = duracionEnSegundos;

				//return View("ProcesosEnParalelo", per);

				//Cronometro
				var stopWatch2 = new Stopwatch();
				stopWatch2.Start();

				per = persona.BuscarN(criterio);

				stopWatch2.Stop();
				var duracionEnSegundos = stopWatch2.ElapsedMilliseconds / 1000.0;
				ViewBag.DuracionB = duracionEnSegundos;
				ViewBag.DuracionBB = "Normal";
				return View("ProcesosEnParalelo", per);
			}
			else
			{
				return View("ProcesosEnParalelo", null);
			}

		}
		[HttpPost]
		[MultiButton(Name = "action", Argument = "Anormal")]
		public async Task<ActionResult> Anormal(string criterio)
		{
			List<Persona> per = new List<Persona>();
			if (criterio != null || criterio != "")
			{
				//Cronometro
				//var stopWatch = new Stopwatch();
				//stopWatch.Start();

				//per = persona.ListarN();

				//stopWatch.Stop();
				//var duracionEnSegundos = stopWatch.ElapsedMilliseconds / 1000.0;
				//ViewBag.DuracionL = duracionEnSegundos;

				//return View("ProcesosEnParalelo", per);

				//Cronometro
				var stopWatch2 = new Stopwatch();
				stopWatch2.Start();

				per = await persona.BuscarA(criterio);

				stopWatch2.Stop();
				var duracionEnSegundos = stopWatch2.ElapsedMilliseconds / 1000.0;
				ViewBag.DuracionB = duracionEnSegundos;
				ViewBag.DuracionBB = "Mejorada";
				return View("ProcesosEnParalelo", per);
			}
			else
			{
				return View("ProcesosEnParalelo", null);
			}

		}
		[HttpPost]
		[MultiButton(Name = "action", Argument = "ListarN")]
		public ActionResult ListarN(string criterio)
		{
			List<Persona> per = new List<Persona>();
			//Cronometro
			var stopWatch = new Stopwatch();
			stopWatch.Start();

			per = persona.ListarN();

			stopWatch.Stop();
			var duracionEnSegundos = stopWatch.ElapsedMilliseconds / 1000.0;
			ViewBag.DuracionL = duracionEnSegundos;
			ViewBag.DuracionLL = "Normal";
			return View("ProcesosEnParalelo", per);
		}
		[HttpPost]
		[MultiButton(Name = "action", Argument = "ListarA")]
		public async Task<ActionResult> ListarA(string criterio)
		{
			List<Persona> per = new List<Persona>();
			//Cronometro
			var stopWatch = new Stopwatch();
			stopWatch.Start();

			per = await persona.ListarA();

			stopWatch.Stop();
			var duracionEnSegundos = stopWatch.ElapsedMilliseconds / 1000.0;
			ViewBag.DuracionL = duracionEnSegundos;
			ViewBag.DuracionLL = "Mejorada";

			return View("ProcesosEnParalelo", per);
		}
	}
}