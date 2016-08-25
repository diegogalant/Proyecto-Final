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

            foreach (var item in personas)
            {
                if (item.Id == persona.Id)
                {
                    throw new ApplicationException("No se puede agregar la persona porque ya existe");
                }
            }

            // Le agrego el cliente
           // personas;

            //Grabamos
            var pMapper = new PersonaMapper();

            //pMapper.Grabar(personas);


        }

        public void ModificarPersona(Persona persona)
        {

        }

        public void EliminarPersona(Persona persona)
        {
        }

        public IEnumerable<Persona> ObtenerPersonas()
        {
            var pMapper = new PersonaMapper();

            var todasPersonas = pMapper.ObtenerTodas();

            return todasPersonas;
        }

        public void GrabarPersona(List<Persona> personas)
        {
            var persistor = new EntityPersistor<Persona>();

            persistor.Grabar(personas);
        }

    }
}