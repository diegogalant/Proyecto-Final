using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class EntidadBase : IEntidad
    {
        public Guid Id { get; set; }
    }

    //protected EntidadBase()
    //{
    //    Id = Guid.NewGuid();
    //}
         
}
