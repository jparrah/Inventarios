using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Labores
    {
        [Key]
        public int Id { get; set; }
        public string NombreLabor { get; set; }
    }
}
