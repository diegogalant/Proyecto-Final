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
            grupoSanguineoBP.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineoBP);

            //B-
            var grupoSanguineoBN = new GrupoSanguineo();
            grupoSanguineoBN.Descripcion = "B-";
            grupoSanguineoBN.FactorRh = false;

            gruposSanguineos.Add(grupoSanguineoBN);

            //AB+
            var grupoSanguineoABP = new GrupoSanguineo();
            grupoSanguineoABP.Descripcion = "AB+";
            grupoSanguineoABP.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineoABP);

            //AB-
            var grupoSanguineoABN = new GrupoSanguineo();
            grupoSanguineoABN.Descripcion = "AB-";
            grupoSanguineoABN.FactorRh = false;

            gruposSanguineos.Add(grupoSanguineoABN);

            //0+
            var grupoSanguineo0P = new GrupoSanguineo();
            grupoSanguineo0P.Descripcion = "0+";
            grupoSanguineo0P.FactorRh = true;

            gruposSanguineos.Add(grupoSanguineo0P);

            //0-
            var grupoSanguineo0N = new GrupoSanguineo();
            grupoSanguineo0N.Descripcion = "0-";
            grupoSanguineo0N.FactorRh = false;

            gruposSanguineos.Add(grupoSanguineo0N);


            gsm.Grabar(gruposSanguineos);
        }     

    }
}
