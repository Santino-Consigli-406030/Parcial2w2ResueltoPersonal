﻿using System;
using System.Collections.Generic;

namespace second_exam_2w2_practice.Model
{
    public partial class Deporte
    {
        public Deporte()
        {
            Socios = new HashSet<Socio>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public DateTime FechaAlta { get; set; }

        public virtual ICollection<Socio> Socios { get; set; }
    }
}
