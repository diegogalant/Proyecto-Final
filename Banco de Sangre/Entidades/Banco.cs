using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Banco
    {

        public DateTime FechaAlta { get; set; }

        public bool DadoBaja { get; set; }

        public DateTime FechaBaja { get; set; }

        public string MotivoBaja { get; set; }

        public bool EsDador { get; set; }

        public bool EsReceptor { get; set; }
    }
}
