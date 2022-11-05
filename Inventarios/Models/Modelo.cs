using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Modelo
    {
        public Modelo()
        {
            Equipos = new HashSet<Equipos>();
        }
        [Key]
        public int Id { get; set; }
        public string NombreModelo { get; set; }
        public virtual ICollection<Equipos> Equipos { get; set; }
    }
}
