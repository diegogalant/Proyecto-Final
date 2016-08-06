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
            // Obtengo la lista
            var personas = ObtenerPersonas();

            // Le agrego el cliente
            personas.Add(persona);

            //Grabamos
            GrabarPersona(personas);
        }

        public void ModificarPersona(Persona persona)
        {

        }

        public void EliminarPersona(Persona persona)
        {

        }

        public List<Persona> ObtenerPersonas()
        {
            var path = System.Windows.Forms.Application.StartupPath;
            path += "\\Personas.Json";

            if (!System.IO.File.Exists(path))
            {
                return new List<Persona>();
            }

            var contenido = System.IO.File.ReadAllText(path);

            var lista = JsonConvert.DeserializeObject<List<Persona>>(contenido);

            return lista;
        }

        private void GrabarPersona(List<Persona> personas)
        {
            var personasSerializados = JsonConvert.SerializeObject(personas);

            var path = System.Windows.Forms.Application.StartupPath;
            path += "\\Personas.Json";
            System.IO.File.WriteAllText(path, personasSerializados);
        }

    }
}