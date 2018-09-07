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

        public string nombreA { get; set; }
        public double notaA { get; set; }
    }
}