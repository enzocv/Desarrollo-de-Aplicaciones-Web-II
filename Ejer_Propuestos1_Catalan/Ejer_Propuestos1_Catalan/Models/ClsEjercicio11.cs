using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ejer_Propuestos1_Catalan.Models
{
    public class ClsEjercicio11
    {
        public List<int> Uentero { get; set; }
        [Required]
        [StringLength(1)]
        public string simbolo { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int entero { get; set; }
        public List<string> Usimbolo { get; set; }
    }
}