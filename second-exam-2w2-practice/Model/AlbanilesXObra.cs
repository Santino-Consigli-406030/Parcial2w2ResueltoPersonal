using System;
using System.Collections.Generic;

namespace second_exam_2w2_practice.Model
{
    public partial class AlbanilesXObra
    {
        public Guid Id { get; set; }
        public Guid IdAlbanil { get; set; }
        public Guid IdObra { get; set; }
        public string TareaArealizar { get; set; } = null!;
        public DateTime? FechaAlta { get; set; }

        public virtual Albanile IdAlbanilNavigation { get; set; } = null!;
        public virtual Obra IdObraNavigation { get; set; } = null!;
    }
}
