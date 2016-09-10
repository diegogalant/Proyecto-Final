using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class EntidadBase : IValidable, IEntidad
    {
        public Guid Id { get; set; }


        protected EntidadBase()
        {
            Id = Guid.NewGuid();
        }

        public virtual void Validate()
        {                    
        }
    }
}
