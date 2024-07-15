using System;
using System.Collections.Generic;

namespace second_exam_2w2_practice.Model
{
    public partial class TiposObra
    {
        public TiposObra()
        {
            Obras = new HashSet<Obra>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Obra> Obras { get; set; }
    }
}
