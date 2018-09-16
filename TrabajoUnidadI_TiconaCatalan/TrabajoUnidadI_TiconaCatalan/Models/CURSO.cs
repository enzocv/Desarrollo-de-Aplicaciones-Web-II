namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CURSO")]
    public partial class CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CURSO()
        {
            CONCURSO = new HashSet<CONCURSO>();
        }

        [Key]
        public int IDCURSO { get; set; }

        public int IDDOCENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(5)]
        public string CICLO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONCURSO> CONCURSO { get; set; }

        public virtual DOCENTE DOCENTE { get; set; }
    }
}
