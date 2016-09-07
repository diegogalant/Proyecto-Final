using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Reglas
{
    public class PersonaMapper : BaseMapper<Persona>
    {
        public override void Grabar(List<Persona> personas)
        {
            foreach (var persona in personas)
            {
                if (persona.GrupoSanguineo != null)
                {
                    persona.IdGrupoSanguineo = persona.GrupoSanguineo.Id;
                }
            }

            base.Grabar(personas);
        }

        public override IEnumerable<Persona> ObtenerTodas()
        {
            var personas = base.ObtenerTodas().ToList();
            var gsMapper = new GrupoSanguineoMapper();

            // buscamos los Ids de personas y los recuperamos
            foreach (var persona in personas)
            {
                var gs = gsMapper.ObtenerUna(persona.IdGrupoSanguineo);
                if (gs != null)
                {
                    persona.GrupoSanguineo = gs;
                }
            }

            return personas;
        }
    }
}


