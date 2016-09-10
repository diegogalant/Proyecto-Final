using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reglas
{
    public class ExtraccionMapper: BaseMapper<Extraccion>
    {
        public override void Grabar(List<Extraccion> extracciones)
        {
            foreach (var extraccion in extracciones)
            {
                if (extraccion.Persona != null)
                {
                    extraccion.IdPersona = extraccion.Persona.Id;
                }
            }

            base.Grabar(extracciones);
        }


        public override IEnumerable<Extraccion> ObtenerTodas()
        {
            var extracciones = base.ObtenerTodas().ToList();
            var pMapper = new PersonaMapper();

            // buscamos los Ids de personas y los recuperamos
            foreach (var extraccion in extracciones)
            {
                var persona = pMapper.ObtenerUna(extraccion.IdPersona);
                if (persona != null)
                {
                    extraccion.Persona = persona;
                }
            }

            return extracciones;
        }


        public  IEnumerable<Extraccion> ObtenerPorFechas(DateTime desde, DateTime hasta)
        {
            var extracciones = base.ObtenerTodas().ToList();
            var extraccionesFiltradas = new List<Extraccion>();
            //var pMapper = new PersonaMapper();

            foreach (var extraccion in extracciones)
            {
                if (extraccion.Fecha >= desde && extraccion.Fecha <= hasta)
                {
                    extraccionesFiltradas.Add(extraccion);
                }
            }

            return extraccionesFiltradas;
        }
    }
}
