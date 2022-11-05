﻿using System.ComponentModel.DataAnnotations;

namespace Inventarios.Models
{
    public partial class Defectacion {
        public Defectacion()
        {
            EquiposDefectados=new HashSet<EquiposDefectados>();
        }

        [Key]
        public int Id { get; set; }
        public string NombreDefectacion { get; set; }
        public virtual ICollection<EquiposDefectados> EquiposDefectados { get; set; }
    }
}
