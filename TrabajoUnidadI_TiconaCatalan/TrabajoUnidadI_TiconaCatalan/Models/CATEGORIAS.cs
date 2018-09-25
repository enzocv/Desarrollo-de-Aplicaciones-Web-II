namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;
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
                throw new Exception(ex.Message);
            }
            return categorias;
        }

        public CATEGORIAS Obtener(int id)
        {
            var cate = new CATEGORIAS();

            try
            {
                using (var context = new ModeloCONCURSO())
                {

                    cate = context.CATEGORIAS
                        .Where(x => x.IDCATEGORIA == id)
                        .Single();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            
            return cate;
        }

		public void Guardar()
		{
			try
			{
				using (var db = new ModeloCONCURSO())
				{
					if (this.IDCATEGORIA > 0)
					{
						db.Entry(this).State = EntityState.Modified;
					}
					else
					{
						db.Entry(this).State = EntityState.Added;
					}
					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

        

        public void Eliminar()
        {
            try
            {
                using (var db = new ModeloCONCURSO())
                {
                    db.Entry(this).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
