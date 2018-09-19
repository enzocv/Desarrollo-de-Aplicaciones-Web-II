namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Curso")]
    public partial class Curso
    {
        [Key]
        public int IdCurso { get; set; }

        public int IdPersona { get; set; }

        [Required]
        [StringLength(80)]
        public string NombreCurso { get; set; }

        [Required]
        [StringLength(80)]
        public string EstadoCurso { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
