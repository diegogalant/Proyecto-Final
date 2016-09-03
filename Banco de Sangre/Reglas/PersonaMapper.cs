using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reglas
{
    public class PersonaMapper : BaseMapper<Persona>
    {
        public override void Grabar(List<Persona> personas)
        {
           base.Grabar(personas);
        }

        public override IEnumerable<Persona> ObtenerTodas()
        {
            var personas = base.ObtenerTodas();
            var gMapper = new GrupoSanguineoMapper();

            // buscamos los Ids de personas y los recuperamos
            foreach (var persona in personas)
            {
                foreach (var guid in persona.IdGruposSanguineos)
                {
                    var gS = gMapper.ObtenerUna(guid);
                    persona.GruposSanguineos.Add(gS);
                }
            }

            return personas;
        }
    }
}


