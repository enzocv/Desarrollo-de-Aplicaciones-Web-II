using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio3_MVC_Catalan.Models
{
    public class ClsVenta
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public bool productoUSB { get; set; }
        public bool productoMouse { get; set; }
        public bool productoTeclado { get; set; }
        public bool productoDiscoDuro { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
    }
}