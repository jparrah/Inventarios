using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Componente
    {
        [Key]
        public int Id { get; set; }
        public string  NombreComponente { get; set; }
    }
}
