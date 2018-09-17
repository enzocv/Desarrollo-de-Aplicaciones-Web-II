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

        public int IDCATEGORIA { get; set; }

        [Required]
        [StringLength(80)]
        public string TEMA { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string INTEGRANTES { get; set; }

        [Required]
        [StringLength(50)]
        public string CURSO { get; set; }

        [Required]
        [StringLength(50)]
        public string ASESOR { get; set; }

        public virtual CATEGORIAS CATEGORIAS { get; set; }
    }
}
