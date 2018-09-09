using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TrabajoUnidadI_TiconaCatalan.Models
{
    public class ClsConcurso
    {
        public string tema { get; set; }
        public string curso { get; set; }
        public string asesor { get; set; }
        public string categoria { get; set; }
        public List<string> integrantes { get; set; }
    }
}