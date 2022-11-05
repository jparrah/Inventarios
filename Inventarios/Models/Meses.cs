using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Meses
    {
        [Key]
        public int Id { get; set; }
        public string NombreMes { get; set; }
    }
}
