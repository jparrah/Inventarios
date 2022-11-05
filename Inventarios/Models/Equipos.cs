using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Equipos
    {
        [Key]
        public int Id { get; set; }
        public int EstadoId { get; set; }
        public int AreaId { get; set; }
        public int MedioId { get; set; }
        public int SucursalId { get; set; }
        public int ModeloId { get; set; }
        public long Inventario { get; set; }
        public float Valor { get; set; }
        public float Depreciacion { get; set; }
        public long Sello { get; set; }

        public Estado Estado { get; set; }
        public Area Area { get; set; }
        public Medios Medios { get; set; }
        public Sucursal Sucursal { get; set; }
        public Modelo Modelo { get; set; }
        public Orden Orden { get; set; }
        public EquiposBaja EquiposBaja { get; set; }




    }
}
