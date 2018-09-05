using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ejer_Propuestos1_Catalan.Models
{
    public class ClsEjercicio4
    {
        public int[] numeros { get; set; }
        public int[] ArregloID { get; set; }
        [Required]
        [Range(1, 1000)] //int.MaxValue (valor maximo posible)
        public int cantidadNums { get; set; }
        public double Respuesta { get; set; }
        public string Tipo { get; set; }
    }
}