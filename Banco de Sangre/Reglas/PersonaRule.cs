using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using Entidades;
using Newtonsoft.Json;

namespace Reglas
{
    public class PersonaRule
    {
        public void AgregarPersona(Persona persona)
        {
            var pMapper = new PersonaMapper();

            pMapper.Grabar(persona);
        }

        public void ModificarPersona(Persona persona)
        {
            var pMapper = new PersonaMapper();

            pMapper.Modificar(persona);
        }

        public void EliminarPersona(Persona persona)
        {
            var pMapper = new PersonaMapper();

            pMapper.Eliminar(persona);
        }

        public void EliminarTodasLasPersonas()
        {
            var pMapper = new PersonaMapper();

            pMapper.EliminarTodas();
        }

        public IEnumerable<Persona> ObtenerTodasLasPersonas()
        {
            var pMapper = new PersonaMapper();

            var todasPersonas = pMapper.ObtenerTodas();

            return todasPersonas;
        }
    }
}