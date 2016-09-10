using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades
{

    public class Extraccion : EntidadBase
    {
        public DateTime Fecha { get; set; }

        public string TipoAnalisis { get; set; }

        public bool Alergias { get; set; }

        public string DoctorSolicitante { get; set; }

        public string Notas { get; set; }

        [JsonIgnore]
        public Persona Persona { get; set; }

        public Guid IdPersona { get; set; }


        public override void Validate()
        {
            const string msgRequired = "El campo [{0}] no puede quedar vacío";

            if (Fecha == null)
                throw new ApplicationException(string.Format(msgRequired, "Fecha"));

            if (TipoAnalisis == "" || TipoAnalisis == null)
                throw new ApplicationException(string.Format(msgRequired, "Tipo análisis"));

            if (string.IsNullOrEmpty(DoctorSolicitante))
                throw new ApplicationException(string.Format(msgRequired, "Doctor solicitante"));
        }
    }
}
