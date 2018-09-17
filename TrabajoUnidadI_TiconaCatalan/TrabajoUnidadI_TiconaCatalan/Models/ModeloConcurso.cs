namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloCONCURSO : DbContext
    {
        public ModeloCONCURSO()
            : base("name=ModeloCONCURSO")
        {
        }

        public virtual DbSet<CATEGORIAS> CATEGORIAS { get; set; }
        public virtual DbSet<CONCURSO> CONCURSO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATEGORIAS>()
                .Property(e => e.NOMBRECATEGORIA)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORIAS>()
                .HasMany(e => e.CONCURSO)
                .WithRequired(e => e.CATEGORIAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONCURSO>()
                .Property(e => e.TEMA)
                .IsUnicode(false);

            modelBuilder.Entity<CONCURSO>()
                .Property(e => e.INTEGRANTES)
                .IsUnicode(false);

            modelBuilder.Entity<CONCURSO>()
                .Property(e => e.CURSO)
                .IsUnicode(false);

            modelBuilder.Entity<CONCURSO>()
                .Property(e => e.ASESOR)
                .IsUnicode(false);
        }
    }
}
