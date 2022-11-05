using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Medios {
        public Medios()
        {
            Equipos = new HashSet<Equipos>();
        }

        [Key]
        public int Id { get; set; }
        public string NombreMedio { get; set; }

        public virtual ICollection<Equipos> Equipos { get; set; }
    }
}
