namespace TrabajoUnidadI_TiconaCatalan.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model_Persona : DbContext
	{
		public Model_Persona()
			: base("name=Model_Persona")
		{
		}

		public virtual DbSet<Curso> Curso { get; set; }
		public virtual DbSet<Persona> Persona { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Curso>()
				.Property(e => e.NombreCurso)
				.IsUnicode(false);

			modelBuilder.Entity<Curso>()
				.Property(e => e.EstadoCurso)
				.IsUnicode(false);

			modelBuilder.Entity<Persona>()
				.Property(e => e.NombrePersona)
				.IsUnicode(false);

			modelBuilder.Entity<Persona>()
				.Property(e => e.Descripcion)
				.IsUnicode(false);

			modelBuilder.Entity<Persona>()
				.Property(e => e.Apodo)
				.IsUnicode(false);

			modelBuilder.Entity<Persona>()
				.Property(e => e.Direccion)
				.IsUnicode(false);

			modelBuilder.Entity<Persona>()
				.Property(e => e.Correo)
				.IsUnicode(false);

			modelBuilder.Entity<Persona>()
				.HasMany(e => e.Curso)
				.WithRequired(e => e.Persona)
				.WillCascadeOnDelete(false);
		}
	}
}
