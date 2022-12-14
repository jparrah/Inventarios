using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Equipos = new HashSet<Equipos>();
            Ordenes = new HashSet<Orden>();
        }
        [Key]
        public int Id { get; set; }
        public int CodigoSucursal { get; set; }
        public string NombreSucursal { get; set; }

        public virtual ICollection<Equipos> Equipos { get; set; }
        public virtual  ICollection<Orden> Ordenes { get; set; }
    }
}
