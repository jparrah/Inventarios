using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Orden
    {
        [Key]
        public int Id { get; set; }
        public int EquipoId { get; set; }
        public int TecnicoId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string  Fundamento { get; set; }
        public Equipos Equipos { get; set; }
        public Tecnico Tecnico { get; set; }
        public EquiposBaja EquiposBaja { get; set; }



    }
}
