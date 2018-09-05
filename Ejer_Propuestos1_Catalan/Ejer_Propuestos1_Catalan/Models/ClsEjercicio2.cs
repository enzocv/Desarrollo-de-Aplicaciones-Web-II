using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ejer_Propuestos1_Catalan.Models
{
    public class ClsEjercicio2
    {
        [Required]
        public int[] numeros { get; set; }
        public int valor { get; set; }
        public string validar { get; set; }
        public List<int> valNegativo { get; set; }
        public List<int> valPositivo { get; set; }
    }
}