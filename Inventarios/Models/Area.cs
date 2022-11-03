using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Area
    {
        [Key]
        public int Id { get; set; }
        public string NombreArea { get; set; }

    }
}
