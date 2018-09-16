namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCENTE")]
    public partial class DOCENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCENTE()
        {
            CURSO = new HashSet<CURSO>();
        }

        [Key]
        public int IDDOCENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CURSO> CURSO { get; set; }
    }
}
