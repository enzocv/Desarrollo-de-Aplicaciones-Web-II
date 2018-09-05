using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ejer_Propuestos1_Catalan.Models
{
    public class ClsEjercicio8
    {
        [Required]
        [Range(1, int.MaxValue)] //n numeros
        public int numeros { get; set; }
        public string validar { get; set; }
        public List<int> ListNumeros { get; set; }
    }
}