using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Defectacion { 


        [Key]
        public int Id { get; set; }
        public string NombreDefectacion { get; set; }
    }
}
