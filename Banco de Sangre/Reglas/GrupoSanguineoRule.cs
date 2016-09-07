using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reglas
{
    public class GrupoSanguineoRule
    {
        public void GenerarGruposSanguineos()
        {
            var gsm = new GrupoSanguineoMapper();
            var grupos = gsm.ObtenerTodas();

            if (grupos.Any())
                return;

            // si no hay nada, generamos por unica vez    

            var gruposSanguineos = new List<GrupoSanguineo>();

            //A-
            var grupoSanguineoA = new GrupoSanguineo();
            grupoSanguineoA.Descripcion = "A-";
            grupoSanguineoA.FactorRh = false;

            gruposSanguineos.Add(grupoSanguineoA);

            //B
            var grupoSanguineoB = new GrupoSanguineo();
            grupoSanguineoB.Descripcion = "B";
            grupoSanguineoA.FactorRh = true;


            gruposSanguineos.Add(grupoSanguineoB);

            //AB+
            var grupoSanguineoAB = new GrupoSanguineo();
            grupoSanguineoAB.Descripcion = "AB";
            grupoSanguineoAB.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineoAB);

            //0+
            var grupoSanguineo0 = new GrupoSanguineo();
            grupoSanguineo0.Descripcion = "0";
            grupoSanguineo0.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineo0);


            gsm.Grabar(gruposSanguineos);
        }     

    }
}
