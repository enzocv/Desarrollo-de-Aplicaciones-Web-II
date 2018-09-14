namespace Laboratorio7_LINQ_BD_Catalan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("PRODUCTO")]
    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            DETALLE_PEDIDO = new HashSet<DETALLE_PEDIDO>();
        }

        [Key]
        public int IDPRODUCTO { get; set; }

        public int IDCATEGORIA { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Column(TypeName = "text")]
        public string DESCRIPCION { get; set; }

        public int PRECIO { get; set; }

        public int STOCK { get; set; }

        [StringLength(1)]
        public string ESTADO { get; set; }

        public virtual CATEGORIA CATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_PEDIDO> DETALLE_PEDIDO { get; set; }


        //metodos
        public List<PRODUCTO> Listar()
        {
            var productos = new List<PRODUCTO>();

            try
            {
                //definir origen de datos
                using (var db = new ModeloSistema())
                {
                    //sentencia LINQ
                    //listar trabajando con una sola tabla
                    //productos = db.PRODUCTO.ToList();

                    //listar trabajando con dos tablas que se relacionan
                    productos = db.PRODUCTO.Include("CATEGORIA").ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return productos;
        }

        public List<PRODUCTO> ListarConsulta()
        {
            var productos = new List<PRODUCTO>();

            try
            {
                //definir origen de datos
                using (var db = new ModeloSistema())
                {
                    //sentencia LINQ
                    productos = db.PRODUCTO.Include("CATEGORIA")
                                .Where(x => x.NOMBRE.StartsWith("F"))
                                .ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return productos;
        }

        public List<PRODUCTO> BuscarProducto(string valor)
        {
            var productos = new List<PRODUCTO>();

            try
            {
                if (valor == "" || valor == null)
                {
                    using (var db = new ModeloSistema())
                    {
                        productos = db.PRODUCTO.Include("CATEGORIA").ToList();
                    }
                }
                else
                {
                    //definir origen de datos
                    using (var db = new ModeloSistema())
                    {
                        //sentencia LINQ
                        productos = db.PRODUCTO.Include("CATEGORIA")
                                    .Where(x => x.NOMBRE.Equals(valor) || x.CATEGORIA.NOMBRE.Equals(valor))
                                    .ToList();
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
            return productos;
        }

        public List<PRODUCTO> MenorA()
        {
            var productos = new List<PRODUCTO>();

            try
            {
                //definir origen de datos
                using (var db = new ModeloSistema())
                {
                    //sentencia LINQ
                    productos = db.PRODUCTO.Include("CATEGORIA")
                                .Where(x => x.NOMBRE.StartsWith("J") && x.PRECIO < 200)
                                .ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return productos;
        }
        public void Listar2()
        {
            //var productos = new List<PRODUCTO>();
            var resultado = "";
            try
            {
                //definir origen de datos
                using (var db = new ModeloSistema())
                {
                    var productos = from p in db.PRODUCTO
                                orderby p.NOMBRE descending
                                select new { p.NOMBRE, p.DESCRIPCION };

                    foreach (var item in productos)
                    {
                        resultado += item.NOMBRE + " " + item.DESCRIPCION;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
