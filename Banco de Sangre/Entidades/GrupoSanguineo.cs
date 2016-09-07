﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GrupoSanguineo : EntidadBase
    {
        public string Descripcion { get; set; }

        public bool FactorRh { get; set; }


        public override string ToString()
        {
            return Descripcion;
        }
    }
}
