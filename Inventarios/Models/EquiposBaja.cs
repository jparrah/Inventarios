using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class EquiposBaja
    {
        [Key]
        public int Id { get; set; }
        public int EquipoId { get; set; }
        public int OrdenId { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Comentario { get; set; }
        public Equipos Equipos { get; set; }
        public Orden Orden { get; set; }
    }
}
