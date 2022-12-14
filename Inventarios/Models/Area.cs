using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Area
    {
        public Area()
        {
            Equipos=  new HashSet<Equipos>();
        }
        [Key]
        public int Id { get; set; }
        public string NombreArea { get; set; }
        public virtual ICollection<Equipos> Equipos { get; set; }
    }
}
