namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSO")]
    public partial class CONCURSO
    {
        [Key]
        public int IDCONCURSO { get; set; }

        public int IDCURSO { get; set; }

        [StringLength(80)]
        public string TEMA { get; set; }

        [Column(TypeName = "text")]
        public string INTEGRANTES { get; set; }

        public virtual CURSO CURSO { get; set; }
    }
}
