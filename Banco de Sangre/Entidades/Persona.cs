﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Persona : EntidadBase
{

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Direccion { get; set; }

    public int Dni { get; set; }

    public int Telefono { get; set; }

    public Guid GrupoSanguineo { get; set; }
    
}

