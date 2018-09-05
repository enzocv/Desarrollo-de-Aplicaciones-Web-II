using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejer_Propuestos1_Catalan.Models;
using System.IO;

namespace Ejer_Propuestos1_Catalan.Controllers
{
    public class Ejercicio4Controller : Controller
    {
        public static int[] Ale;
        // GET: Ejercicio4
        [HttpGet]
        public ActionResult Index(ClsEjercicio4 objEjercicio4)
        {
            return View("Index", objEjercicio4);
        }

        [HttpPost]
        [MultiButton(Name = "action", Argument = "Generar")]
        public ActionResult Generar(ClsEjercicio4 objNumRamdon)
        {
            ViewData["Test"] = "1";
            int[] ArregloNumeros = new int[objNumRamdon.cantidadNums];
            int[] ArregloIDs = new int[objNumRamdon.cantidadNums];
            int[] Ales = new int[objNumRamdon.cantidadNums];
            int cont = 0;
            objNumRamdon.numeros = ArregloNumeros;
            objNumRamdon.ArregloID = ArregloIDs;
            Ale = Ales;
            Random random = new Random();
            for (int i = 0; i < objNumRamdon.cantidadNums; i++)
            {
                cont++;
                objNumRamdon.ArregloID[i] = cont;
                objNumRamdon.numeros[i] = random.Next(0, 1000);
                Ale[i] = objNumRamdon.numeros[i];
            }
            return View("Index", objNumRamdon);
        }

        [HttpPost]
        [MultiButton(Name = "action", Argument = "Grabar")]
        public ActionResult Grabar(ClsEjercicio4 objNumerosAleatorios)
        {
            if (!System.IO.File.Exists(@"D:\text.txt"))
            {
                StreamWriter fil = System.IO.File.CreateText(@"D:\text.txt");
                fil.Close();
                int counter = 0;
                string[] line = new string[objNumerosAleatorios.cantidadNums];
                StreamWriter file = new StreamWriter(@"D:\text.txt", true);
                foreach (int item in Ale)
                {
                    line[counter] = Convert.ToString(item);
                    file.WriteLine(line[counter]);
                    counter++;
                }
                file.Close();
            }
            else if (Ale != null)
            {
                int counter = 0;
                string[] line = new string[objNumerosAleatorios.cantidadNums];
                StreamWriter file = new StreamWriter(@"D:\text.txt", true);
                foreach (int item in Ale)
                {
                    line[counter] = Convert.ToString(item);
                    file.WriteLine(line[counter]);
                    counter++;
                }
                file.Close();
            }

            return View("Index", objNumerosAleatorios);
        }

        [HttpPost]
        [MultiButton(Name = "action", Argument = "Leer")]
        public ActionResult Leer(ClsEjercicio4 objEjercicio4)
        {
            if (System.IO.File.Exists(@"D:\text.txt"))
            {
                int countx = 0;
                string line;
                List<int> resultado = new List<int>();
                StreamReader file = new StreamReader(@"D:\text.txt", true);
                while ((line = file.ReadLine()) != null)
                {
                    resultado.Add(Convert.ToInt32(line));
                }
                file.Close();
                int[] ArregloNumerox = new int[resultado.Count()];
                objEjercicio4.numeros = ArregloNumerox;
                foreach (int item in resultado)
                {
                    objEjercicio4.numeros[countx] = item;
                    countx++;
                }
            }
            return View("Index", objEjercicio4);
        }
    }
}