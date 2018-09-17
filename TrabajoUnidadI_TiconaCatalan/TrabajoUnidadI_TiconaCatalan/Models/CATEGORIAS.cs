namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class CATEGORIAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORIAS()
        {
            CONCURSO = new HashSet<CONCURSO>();
        }

        [Key]
        public int IDCATEGORIA { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRECATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONCURSO> CONCURSO { get; set; }
        

        public List<CATEGORIAS> Listar()
        {
            var categorias = new List<CATEGORIAS>();

            try
            {
                using (var db = new ModeloCONCURSO())
                {
                    categorias = db.CATEGORIAS.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return categorias;
        }

    }
}
