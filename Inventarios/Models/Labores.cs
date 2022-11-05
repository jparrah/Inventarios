﻿using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Labores
    {
        public Labores()
        {
            EquiposDefectados=new HashSet<EquiposDefectados>();
        }
        [Key]
        public int Id { get; set; }
        public string NombreLabor { get; set; }
        public virtual ICollection<EquiposDefectados> EquiposDefectados { get; set; }
    }
}
