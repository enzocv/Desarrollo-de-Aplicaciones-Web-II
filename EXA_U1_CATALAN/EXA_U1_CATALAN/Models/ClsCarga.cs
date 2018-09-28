using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.WebPages;
using System.Xml.Linq;

namespace EXA_U1_CATALAN.Models
{
    public class ClsCarga
    {
        public string id { get; set; }
        public string codigoDocente { get; set; }
        public string nombreDocente { get; set; }
        public string codigoCurso { get; set; }
        public string nombreCurso { get; set; }
        public int horasCurso { get; set; }
        public int creditosCurso { get; set; }
        public string prerequisitosCurso { get; set; }
        
        XDocument xmlDataCurso = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/cursos.xml"));
        
        XDocument xmlDataDocente = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/docentes.xml"));
        
        XDocument xmlDataCarga = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/cargas.xml"));
        
        public List<ClsCarga> BusquedaListar(string valor, string criterio)
        {
            List<ClsCarga> objCarga = new List<ClsCarga>();

            if (valor.IsEmpty() || valor.Equals(""))
            {
                //objCarga =  ListarCargas();
                objCarga = (from curso in xmlDataCurso.Descendants("curso")
                        join carga in xmlDataCarga.Descendants("carga")
                            on curso.Element("codigo").Value equals carga.Element("codigoCurso").Value
                        join docente in xmlDataDocente.Descendants("docente")
                            on carga.Element("codigoDocente").Value equals docente.Element("codigo").Value
                        select new ClsCarga()
                        {
                            id = carga.Element("id").Value,
                            nombreDocente = docente.Element("nombre").Value + ", " + docente.Element("apellido").Value,
                            nombreCurso = curso.Element("nombre").Value,
                            horasCurso = Convert.ToInt32(curso.Element("horas").Value),
                            creditosCurso = Convert.ToInt32(curso.Element("creditos").Value)
                        }
                    ).ToList();
            }
            else if (criterio.Equals("Docente"))
            {
                objCarga = (from curso in xmlDataCurso.Descendants("curso")
                        join carga in xmlDataCarga.Descendants("carga")
                            on curso.Element("codigo").Value equals carga.Element("codigoCurso").Value
                        join docente in xmlDataDocente.Descendants("docente")
                            on carga.Element("codigoDocente").Value equals docente.Element("codigo").Value
                        where docente.Element("codigo").Value == valor 
                        select new ClsCarga()
                        {
                            id = carga.Element("id").Value,
                            nombreDocente = docente.Element("nombre").Value + ", " + docente.Element("apellido").Value,
                            nombreCurso = curso.Element("nombre").Value,
                            horasCurso = Convert.ToInt32(curso.Element("horas").Value),
                            creditosCurso = Convert.ToInt32(curso.Element("creditos").Value)
                        }
                    ).ToList();
            }
            else if (criterio.Equals("Curso"))
            {
                objCarga = (from curso in xmlDataCurso.Descendants("curso")
                        join carga in xmlDataCarga.Descendants("carga")
                            on curso.Element("codigo").Value equals carga.Element("codigoCurso").Value
                        join docente in xmlDataDocente.Descendants("docente")
                            on carga.Element("codigoDocente").Value equals docente.Element("codigo").Value
                        where curso.Element("codigo").Value == valor 
                        select new ClsCarga()
                        {
                            id = carga.Element("id").Value,
                            nombreDocente = docente.Element("nombre").Value + ", " + docente.Element("apellido").Value,
                            nombreCurso = curso.Element("nombre").Value,
                            horasCurso = Convert.ToInt32(curso.Element("horas").Value),
                            creditosCurso = Convert.ToInt32(curso.Element("creditos").Value)
                        }
                    ).ToList();
            }

            return objCarga;
        }
        
    }
}