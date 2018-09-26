using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EXA_U1_Catalan.Models
{
    public class ClsCargaDocente
    {
        public String idcarga { get; set; }
        public String iddocente { get; set; }
        public String nomDocen { get; set; }
        
        public List<ClsCargaDocente> ListarCargaDocente()
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


            var objCarga = new List<ClsCargaDocente>();
            objCarga = (from car in xmlDataCA.Descendants("carga")
                    join doce in xmlDataD.Descendants("docente")
                        on car.Element("iddocente").Value equals doce.Element("codigo").Value
                    select new ClsCargaDocente
                    {
                        idcarga = car.Element("idcarga").Value,
                        iddocente = doce.Element("codigo").Value,
                        nomDocen = doce.Element("nombre").Value + ", " + doce.Element("Apellido").Value
                    }
                ).ToList();
            return objCarga;
        }
    }
}