using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class TipoEquipo {
        public TipoEquipo()
        {
            Equipos = new HashSet<Equipos>();
        }

        [Key]
        public int Id { get; set; }
        public string NombreTipoEquipo { get; set; }

        public virtual ICollection<Equipos> Equipos { get; set; }
    }
}
