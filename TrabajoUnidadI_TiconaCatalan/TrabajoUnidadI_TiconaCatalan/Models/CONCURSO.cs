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


        public List<CONCURSO> Listar()
        {
            var proyecto = new List<CONCURSO>();

            try
            {
                using (var db = new ModeloCONCURSO())
                {
                    proyecto = db.CONCURSO.Include("CATEGORIAS").ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return proyecto;
        }

        public CONCURSO Obtener(int id)
        {
            var proyecto = new CONCURSO();

            try
            {
                using (var context = new ModeloCONCURSO())
                {

                    proyecto = context.CONCURSO.Include("CATEGORIAS")
                        .Where(x => x.IDCONCURSO == id)
                        .Single();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            return proyecto;
        }

        public void Guardar()
        {
            try
            {
                using (var db = new ModeloCONCURSO())
                {
                    if (this.IDCONCURSO > 0)
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
            catch (Exception)
            {
                throw;
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
                throw;
            }
        }
    }
}
