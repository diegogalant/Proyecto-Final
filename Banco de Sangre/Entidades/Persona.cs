using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Persona
{
    public int PersonaId { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Direccion { get; set; }

    public string Dni { get; set; }

    public int Telefono { get; set; }

    public GrupoSanguineo GrupoSanguineo { get; set; }
    
}

