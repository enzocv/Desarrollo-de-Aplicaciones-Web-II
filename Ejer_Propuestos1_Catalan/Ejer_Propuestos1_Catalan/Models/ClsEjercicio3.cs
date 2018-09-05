using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ejer_Propuestos1_Catalan.Models
{
    public class ClsEjercicio3
    {
        [Required]
        public uint[] numeros { get; set; }
        public int valor { get; set; }
        public string validar { get; set; }
        public List<double> valMediaPares { get; set; }
        public List<double> valMediaInpares { get; set; }
        public bool LMDes { get; set; }
    }
}