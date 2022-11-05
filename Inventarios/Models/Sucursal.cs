using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Equipos = new HashSet<Equipos>();
        }
        [Key]
        public int Id { get; set; }
        public int CodigoSucursal { get; set; }
        public string NombreSucursal { get; set; }

        public virtual ICollection<Equipos> Equipos { get; set; }
    }
}
