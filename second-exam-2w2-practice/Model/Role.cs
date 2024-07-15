﻿using System;
using System.Collections.Generic;

namespace second_exam_2w2_practice.Model
{
    public partial class Role
    {
        public Role()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int KeyRol { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
