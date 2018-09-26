using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EXA_U1_Catalan.Models
{
    public class ClsCarga
    {
        public String idcarga { get; set; }
        public String iddocente { get; set; }
        public String nomCurso { get; set; }
        public String nomDocen { get; set; }
        public int horas { get; set; }
        public int creditos { get; set; }

        public List<ClsCarga> ListarCarga()
        {
            XDocument xmlDataD = XDocument
                                .Load(HttpContext
                                .Current
                                .Server
                                .MapPath("~/App_Data/docentes.xml"));

            XDocument xmlDataCA = XDocument
                                .Load(HttpContext
                                .Current
                                .Server
                                .MapPath("~/App_Data/carga.xml"));


            var objCarga = new List<ClsCarga>();
            objCarga = (from car in xmlDataCA.Descendants("carga")
                        join doce in xmlDataD.Descendants("docente")
                        on car.Element("iddocente").Value equals doce.Element("codigo").Value
                        //join cur in xmlDataC.Descendants("curso") on
                        //car.Element("idcurso").Value equals cur.Element("codigo")
                        select new ClsCarga
                        {
                            idcarga = car.Element("idcarga").Value,
                            iddocente = doce.Element("codigo").Value,
                            nomDocen = doce.Element("nombre").Value + ", " + doce.Element("Apellido").Value
                            //nomCurso = 
                            //horas = Convert.ToInt32(cur.Element("horas").Value),
                            //creditos = Convert.ToInt32(cur.Element("creditos").Value)
                        }
                        ).ToList();
            return objCarga;

        }
    }
}