using System;
using System.Collections.Generic;

namespace second_exam_2w2_practice.Model
{
    public partial class Obra
    {
        public Obra()
        {
            AlbanilesXObras = new HashSet<AlbanilesXObra>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string DatosVarios { get; set; } = null!;
        public Guid IdTipoObra { get; set; }

        public virtual TiposObra IdTipoObraNavigation { get; set; } = null!;
        public virtual ICollection<AlbanilesXObra> AlbanilesXObras { get; set; }
    }
}
