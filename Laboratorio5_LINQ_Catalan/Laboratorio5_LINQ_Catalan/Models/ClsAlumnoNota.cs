using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio5_LINQ_Catalan.Models
{
    public class ClsAlumnoNota
    {
        public string busqueda { get; set; } = "";
        public string resultado { get; set; } = "";

        public List<string> nombreA { get; set; }
        public List<double> notaA { get; set; }
        public int filas { get; set; }
    }
}