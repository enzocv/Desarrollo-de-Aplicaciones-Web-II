using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EXA_U1_Catalan.Models
{
    public class ClsCargaCurso
    {
        public String idcarga { get; set; }
        public String idcurso { get; set; }
        public String nomCurso { get; set; }
        public int horas { get; set; }
        public int creditos { get; set; }
        
        public List<ClsCargaCurso> ListarCargaCurso()
        {
            XDocument xmlDataD = XDocument
                .Load(HttpContext
                    .Current
                    .Server
                    .MapPath("~/App_Data/cursos.xml"));

            XDocument xmlDataCA = XDocument
                .Load(HttpContext
                    .Current
                    .Server
                    .MapPath("~/App_Data/carga.xml"));


            var objCarga = new List<ClsCargaCurso>();
            objCarga = (from car in xmlDataCA.Descendants("carga")
                    join curso in xmlDataD.Descendants("curso")
                        on car.Element("idcurso").Value equals curso.Element("codigo").Value
                    select new ClsCargaCurso
                    {
                        idcarga = car.Element("idcarga").Value,
                        idcurso = curso.Element("codigo").Value,
                        nomCurso = curso.Element("nombre").Value,
                        horas = Convert.ToInt32(curso.Element("horas").Value),
                        creditos = Convert.ToInt32(curso.Element("creditos").Value)
                    }
                ).ToList();
            return objCarga;
        }
    }
}