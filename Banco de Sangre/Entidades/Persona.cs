using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class Persona : EntidadBase
{

    public Persona()
    {
       GruposSanguineos = new List<GrupoSanguineo>();
       IdGruposSanguineos = new List<Guid>();
    }


    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Direccion { get; set; }

    public int Dni { get; set; }

    public int Telefono { get; set; }

    [JsonIgnore]
    public List<GrupoSanguineo> GruposSanguineos { get; private set; }

    public List<Guid> IdGruposSanguineos { get; set; }

}

