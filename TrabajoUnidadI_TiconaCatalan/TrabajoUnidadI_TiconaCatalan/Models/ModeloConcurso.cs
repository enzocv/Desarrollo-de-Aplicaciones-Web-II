namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloConcurso : DbContext
    {
        public ModeloConcurso()
            : base("name=ModeloConcurso")
        {
        }

        public virtual DbSet<CONCURSO> CONCURSO { get; set; }
        public virtual DbSet<CURSO> CURSO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONCURSO>()
                .Property(e => e.TEMA)
                .IsUnicode(false);

            modelBuilder.Entity<CONCURSO>()
                .Property(e => e.INTEGRANTES)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.NOMBREDOCENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .HasMany(e => e.CONCURSO)
                .WithRequired(e => e.CURSO)
                .WillCascadeOnDelete(false);
        }
    }
}
