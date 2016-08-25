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
        public IEnumerable<GrupoSanguineo> GenerarGruposSanguineos()
        {
            var gruposSanguineos = new List<GrupoSanguineo>();

            //A+
            var grupoSanguineoAP = new GrupoSanguineo();
            grupoSanguineoAP.Descripcion = "A+";
            grupoSanguineoAP.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineoAP);

            //A-
            var grupoSanguineoAN = new GrupoSanguineo();
            grupoSanguineoAN.Descripcion = "A-";
            grupoSanguineoAN.FactorRh = false;

            gruposSanguineos.Add(grupoSanguineoAN);

            //B+
            var grupoSanguineoBP = new GrupoSanguineo();
            grupoSanguineoBP.Descripcion = "B+";
            grupoSanguineoAN.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineoBP);

            //B-
            var grupoSanguineoBN = new GrupoSanguineo();
            grupoSanguineoBN.Descripcion = "B-";
            grupoSanguineoAN.FactorRh = false;

            gruposSanguineos.Add(grupoSanguineoBN);

            //AB+
            var grupoSanguineoAB = new GrupoSanguineo();
            grupoSanguineoAB.Descripcion = "AB+";
            grupoSanguineoAN.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineoAB);

            //AB-
            var grupoSanguineoABN = new GrupoSanguineo();
            grupoSanguineoAB.Descripcion = "AB-";
            grupoSanguineoAN.FactorRh = false;

            gruposSanguineos.Add(grupoSanguineoAB);

            //0+
            var grupoSanguineo0P = new GrupoSanguineo();
            grupoSanguineo0P.Descripcion = "0+";
            grupoSanguineo0P.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineo0P);

            //0-
            var grupoSanguineo0N = new GrupoSanguineo();
            grupoSanguineo0N.Descripcion = "0-";
            grupoSanguineo0N.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineo0N);



            return gruposSanguineos;
        }     

    }
}
