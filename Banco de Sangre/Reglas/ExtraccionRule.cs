using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reglas
{
    public class ExtraccionRule
    {
        public void AgregarExtraccion(Extraccion extraccion)
        {
            var eMapper = new ExtraccionMapper();

            eMapper.Grabar(extraccion);
        }

        public void ModificarExtraccion(Extraccion extraccion)
        {
            var eMapper = new ExtraccionMapper();

            eMapper.Modificar(extraccion);
        }

        public void EliminarExtraccion(Extraccion extraccion)
        {
            var eMapper = new ExtraccionMapper();

            eMapper.Eliminar(extraccion);
        }


        public IEnumerable<Extraccion> ObtenerTodasLasExtracciones()
        {
            var eMapper = new ExtraccionMapper();

            var todasExtracciones = eMapper.ObtenerTodas();

            return todasExtracciones;
        }

        public IEnumerable<string> CargarTiposAnalisis()
        {
            var tiposAnalisis = new List<string>();

            tiposAnalisis.Add("25-hidroxi vitamina D");
            tiposAnalisis.Add("5'-N'Tasa");
            tiposAnalisis.Add("Absorción de la D-xilosa");
            tiposAnalisis.Add("ACE");
            tiposAnalisis.Add("Ácido metilmalónico");
            tiposAnalisis.Add("Albúmina");
            tiposAnalisis.Add("Aldolasa");
            tiposAnalisis.Add("Anticuerpo");
            tiposAnalisis.Add("Grupo sanguineo");

            return tiposAnalisis;
        }
    }
}
