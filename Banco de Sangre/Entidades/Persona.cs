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

        [JsonIgnore]
        public GrupoSanguineo GrupoSanguineo { get;  set; }

        public Guid IdGrupoSanguineo { get; set; }

    }
}

