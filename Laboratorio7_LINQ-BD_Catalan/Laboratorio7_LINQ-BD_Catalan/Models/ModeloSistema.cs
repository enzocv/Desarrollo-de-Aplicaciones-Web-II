namespace Laboratorio7_LINQ_BD_Catalan.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloSistema : DbContext
    {
        public ModeloSistema()
            : base("name=ModeloSistema")
        {
        }

        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<DETALLE_PEDIDO> DETALLE_PEDIDO { get; set; }
        public virtual DbSet<PEDIDO> PEDIDO { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATEGORIA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORIA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORIA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORIA>()
                .HasMany(e => e.PRODUCTO)
                .WithRequired(e => e.CATEGORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.IDCLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.PEDIDO)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PEDIDO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<PEDIDO>()
                .Property(e => e.IDCLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<PEDIDO>()
                .HasMany(e => e.DETALLE_PEDIDO)
                .WithRequired(e => e.PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .HasMany(e => e.DETALLE_PEDIDO)
                .WithRequired(e => e.PRODUCTO)
                .WillCascadeOnDelete(false);
        }
    }
}
