using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Componente
    {
        [Key]
        public int Id { get; set; }
        public int EquiposId { get; set; }
        public string Serie { get; set; }
        public string  Nombre { get; set; }
        public string Modelo { get; set; }
        public Equipos Equipos { get; set; }
    }
}
