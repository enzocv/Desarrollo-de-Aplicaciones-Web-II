namespace TrabajoUnidadI_TiconaCatalan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
	using System.Linq;
	using System.Threading.Tasks;

	[Table("Persona")]
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            Curso = new HashSet<Curso>();
        }

        [Key]
        public int IdPersona { get; set; }

        [Required]
        [StringLength(50)]
        public string NombrePersona { get; set; }

        [Required]
        [StringLength(80)]
        public string Descripcion { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Apodo { get; set; }

        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curso> Curso { get; set; }

		public async Task<List<Persona>> ListarA() //retorna una colleccion
		{
			var persona = new List<Persona>();
			try
			{
				await Task.Run(() =>
				{
					//coneccion a la fuente de datos
					using (var db = new Model_Persona())
					{
						persona = db.Persona.ToList();
					}
				});
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return persona;
		}
		//Listar
		public List<Persona> ListarN() //retorna una colleccion
		{
			var persona = new List<Persona>();
			try
			{
				// coneccion a la fuente de datos
				using (var db = new Model_Persona())
				{
					persona = db.Persona.ToList();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return persona;
		}
		//Metodo Buscar
		public List<Persona> BuscarN(string criterio)//retorna un solo objeto
		{
			var persona = new List<Persona>();
			try
			{
				using (var db = new Model_Persona())
				{
					persona = db.Persona
						.Where(x => x.NombrePersona.Contains(criterio))
						.ToList();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return persona;
		}
		//Metodo Buscar
		public async Task<List<Persona>> BuscarA(string criterio)//retorna un solo objeto
		{
			var persona = new List<Persona>();
			try
			{
				await Task.Run(() =>
				{
					using (var db = new Model_Persona())
					{
						persona = db.Persona
							.Where(x => x.NombrePersona.Contains(criterio))
							.ToList();
					}
				});
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return persona;
		}

	}
}
