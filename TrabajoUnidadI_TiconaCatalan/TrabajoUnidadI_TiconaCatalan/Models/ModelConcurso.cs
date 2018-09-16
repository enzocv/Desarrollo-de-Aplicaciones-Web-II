namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelConcurso : DbContext
    {
        public ModelConcurso()
            : base("name=ModelConcurso")
        {
        }

        public virtual DbSet<CONCURSO> CONCURSO { get; set; }
        public virtual DbSet<CURSO> CURSO { get; set; }
        public virtual DbSet<DOCENTE> DOCENTE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONCURSO>()
                .Property(e => e.TEMA)
                .IsUnicode(false);

            modelBuilder.Entity<CONCURSO>()
                .Property(e => e.INTEGRANTES)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.CICLO)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .HasMany(e => e.CONCURSO)
                .WithRequired(e => e.CURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCENTE>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<DOCENTE>()
                .HasMany(e => e.CURSO)
                .WithRequired(e => e.DOCENTE)
                .WillCascadeOnDelete(false);
        }
    }
}
