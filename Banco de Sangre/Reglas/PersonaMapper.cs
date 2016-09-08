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
       string [] compatibilidadAPositivo = new string[] {"A+", "AB+"};

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


        public IEnumerable<Persona> ObtenerPorGrupoSanguineo(GrupoSanguineo grupoSanguineo)
        {
            var personasFiltradas = new List<Persona>();

            var personas = base.ObtenerTodas().ToList();
            var gsMapper = new GrupoSanguineoMapper();

            // buscamos los Ids de personas y los recuperamos
            foreach (var persona in personas)
            {
                var gs = gsMapper.ObtenerUna(persona.IdGrupoSanguineo);

                if (gs != null)
                {
                    if (grupoSanguineo.Id == gs.Id)
                    {
                        persona.GrupoSanguineo = gs;
                        personasFiltradas.Add(persona);
                    }
                }
            }

            return personasFiltradas;
        }

        public IEnumerable<Persona> ObtenerPorCompatibilidadDonadores(GrupoSanguineo grupoSanguineo)
        {
            var personasFiltradas = new List<Persona>();

            var personas = base.ObtenerTodas().ToList();
            var gsMapper = new GrupoSanguineoMapper();

            // buscamos los Ids de personas y los recuperamos
            foreach (var persona in personas)
            {
                if (persona.Dador == true)
                {
                    var gs = gsMapper.ObtenerUna(persona.IdGrupoSanguineo);

                    if (gs != null)
                    {
                        //Si el grupo es A+ puede donar 
                        if (grupoSanguineo.Descripcion == "A+")
                        {
                            foreach(var grupoSang in compatibilidadAPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el grupo es A- puede donar 
                        if (grupoSanguineo.Descripcion == "A-")
                        {
                            foreach (var grupoSang in compatibilidadAPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el grupo es B+ puede donar 
                        if (grupoSanguineo.Descripcion == "B+")
                        {
                            foreach (var grupoSang in compatibilidadAPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el grupo es B- puede donar 
                        if (grupoSanguineo.Descripcion == "B-")
                        {
                            foreach (var grupoSang in compatibilidadAPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }
                    }
                }
            }
            return personasFiltradas;
        }
    }
}


