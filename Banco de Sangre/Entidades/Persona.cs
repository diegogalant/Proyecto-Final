using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Entidades
{
    public class Persona : EntidadBase
    {
        public Persona()
        {
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public int Dni { get; set; }

        public int Telefono { get; set; }

        public bool Dador { get; set; }

        public bool Receptor { get; set; }

        public string NombreyApellido { get; set; }

        public override string ToString()
        {
            return Apellido + " " + Nombre;
        }

        [JsonIgnore]
        public GrupoSanguineo GrupoSanguineo { get; set; }

        public Guid IdGrupoSanguineo { get; set; }


         public override void Validate()
        {
            const string msgRequired = "El campo [{0}] no puede quedar vacío";

            if (string.IsNullOrEmpty(Apellido))
                throw new ApplicationException(string.Format(msgRequired, "Apellido"));

            if (string.IsNullOrEmpty(Nombre))
                throw new ApplicationException(string.Format(msgRequired, "Nombre"));

            if (string.IsNullOrEmpty(Direccion))
                throw new ApplicationException(string.Format(msgRequired, "Dirección"));

            if (Dni <= 0)
                throw new ApplicationException(string.Format(msgRequired, "Número de documento"));

            if (Dni.ToString().Length <= 6)
                throw new ApplicationException(string.Format("El número de documento tiene un valor inválido"));

            if (Dni.ToString().Length > 8)
                throw new ApplicationException(string.Format("El número de documento tiene un valor inválido"));

            if (Telefono <= 0)
                throw new ApplicationException(string.Format(msgRequired, "Télefono"));

            if (GrupoSanguineo == null)
                throw new ApplicationException(string.Format(msgRequired, "Grupo sanguineo"));
        }



    }
}

