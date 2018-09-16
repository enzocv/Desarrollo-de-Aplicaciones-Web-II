namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("CONCURSO")]
    public partial class CONCURSO
    {
        #region DatosClase
        [Key]
        public int IDCONCURSO { get; set; }

        public int IDCURSO { get; set; }

        [StringLength(80)]
        public string TEMA { get; set; }

        [Column(TypeName = "text")]
        public string INTEGRANTES { get; set; }

        public virtual CURSO CURSO { get; set; }
        #endregion

        #region Metodos
        public List<CONCURSO> GetProyectos()
        {
            var proyectos = new List<CONCURSO>();
            try
            {
                using (var db = new ModeloConcurso())
                {
                    proyectos = db.CONCURSO.Include("CURSO")
                                .OrderBy(x => x.CURSO.CICLO)
                                .ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return proyectos;
        }
        
        #endregion
    }
}
