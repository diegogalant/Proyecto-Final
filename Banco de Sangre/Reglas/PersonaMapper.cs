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

        #region Listas Compatibilidad

        //Compatibilidad si sos donador
        string[] compatibilidadDonadorAPositivo = new string[] { "A+", "AB+" };
        string[] compatibilidadDonadorANegativo = new string[] { "A+", "AB+", "A-", "AB-" };
        string[] compatibilidadDonadorBPositivo = new string[] { "B+", "AB+" };
        string[] compatibilidadDonadorBNegativo = new string[] { "B+", "B-", "AB+", "AB-" };
        string[] compatibilidadDonadorABPositivo = new string[] { "AB+" };
        string[] compatibilidadDonadorABNegativo = new string[] { "AB+", "AB-" };
        string[] compatibilidadDonador0Positivo = new string[] { "A+", "B+", "AB+", "0+" };
        string[] compatibilidadDonador0Negativo = new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" };

        //Compatibilidad si sos receptor
        string[] compatibilidadReceptorAPositivo = new string[] { "A+", "A-", "0+", "0-" };
        string[] compatibilidadReceptorANegativo = new string[] { "A-", "0-" };
        string[] compatibilidadReceptorBPositivo = new string[] { "B+", "B-", "0+", "0-" };
        string[] compatibilidadReceptorBNegativo = new string[] { "B-", "0-" };
        string[] compatibilidadReceptorABPositivo = new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" };
        string[] compatibilidadReceptorABNegativo = new string[] { "A-", "B-", "AB-", "0-" };
        string[] compatibilidadReceptor0Positivo = new string[] { "0+", "0-" };
        string[] compatibilidadReceptor0Negativo = new string[] { "0-" };

        #endregion

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

        #region Obtener compatibilidad donadores

        public IEnumerable<Persona> ObtenerPorCompatibilidadDonadores(GrupoSanguineo grupoSanguineo)
        {
            var personasFiltradas = new List<Persona>();

            var personas = base.ObtenerTodas().ToList();
            var gsMapper = new GrupoSanguineoMapper();

            // buscamos los Ids de personas y los recuperamos
            foreach (var persona in personas)
            {
                if (persona.Receptor == true)
                {
                    var gs = gsMapper.ObtenerUna(persona.IdGrupoSanguineo);

                    if (gs != null)
                    {
                        //Si el donador es A+ puede donar 
                        if (grupoSanguineo.Descripcion == "A+")
                        {
                            foreach (var grupoSang in compatibilidadDonadorAPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es A- puede donar 
                        if (grupoSanguineo.Descripcion == "A-")
                        {
                            foreach (var grupoSang in compatibilidadDonadorANegativo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es B+ puede donar 
                        if (grupoSanguineo.Descripcion == "B+")
                        {
                            foreach (var grupoSang in compatibilidadDonadorBPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es B- puede donar 
                        if (grupoSanguineo.Descripcion == "B-")
                        {
                            foreach (var grupoSang in compatibilidadDonadorBNegativo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es AB+ puede donar 
                        if (grupoSanguineo.Descripcion == "AB+")
                        {
                            foreach (var grupoSang in compatibilidadDonadorABPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es AB- puede donar 
                        if (grupoSanguineo.Descripcion == "AB-")
                        {
                            foreach (var grupoSang in compatibilidadDonadorABNegativo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }


                        //Si el donador es 0+ puede donar 
                        if (grupoSanguineo.Descripcion == "0+")
                        {
                            foreach (var grupoSang in compatibilidadDonador0Negativo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }


                        //Si el donador es 0- puede donar 
                        if (grupoSanguineo.Descripcion == "0-")
                        {
                            foreach (var grupoSang in compatibilidadDonador0Positivo)
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

        #endregion


        #region Obtener compatibilidad Receptores

        public IEnumerable<Persona> ObtenerPorCompatibilidadReceptores(GrupoSanguineo grupoSanguineo)
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
                        //Si el donador es A+ puede donar 
                        if (grupoSanguineo.Descripcion == "A+")
                        {
                            foreach (var grupoSang in compatibilidadReceptorAPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es A- puede donar 
                        if (grupoSanguineo.Descripcion == "A-")
                        {
                            foreach (var grupoSang in compatibilidadReceptorANegativo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es B+ puede donar 
                        if (grupoSanguineo.Descripcion == "B+")
                        {
                            foreach (var grupoSang in compatibilidadReceptorBPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es B- puede donar 
                        if (grupoSanguineo.Descripcion == "B-")
                        {
                            foreach (var grupoSang in compatibilidadReceptorBNegativo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es AB+ puede donar 
                        if (grupoSanguineo.Descripcion == "AB+")
                        {
                            foreach (var grupoSang in compatibilidadReceptorABPositivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }

                        //Si el donador es AB- puede donar 
                        if (grupoSanguineo.Descripcion == "AB-")
                        {
                            foreach (var grupoSang in compatibilidadReceptorABNegativo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }


                        //Si el donador es 0+ puede donar 
                        if (grupoSanguineo.Descripcion == "0+")
                        {
                            foreach (var grupoSang in compatibilidadReceptor0Positivo)
                            {
                                if (gs.Descripcion == grupoSang)
                                {
                                    persona.GrupoSanguineo = gs;
                                    personasFiltradas.Add(persona);
                                }
                            }
                        }


                        //Si el donador es 0- puede donar 
                        if (grupoSanguineo.Descripcion == "0-")
                        {
                            foreach (var grupoSang in compatibilidadReceptor0Negativo)
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

        #endregion


        public IEnumerable<Persona> ObtenerDonadores()
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
                        if (persona.IdGrupoSanguineo == gs.Id)
                        {
                            persona.GrupoSanguineo = gs;
                            personasFiltradas.Add(persona);
                        }
                    }
                }
            }

            return personasFiltradas;
        }

        public IEnumerable<Persona> ObtenerReceptores()
        {
            var personasFiltradas = new List<Persona>();

            var personas = base.ObtenerTodas().ToList();
            var gsMapper = new GrupoSanguineoMapper();

            // buscamos los Ids de personas y los recuperamos
            foreach (var persona in personas)
            {
                if (persona.Receptor == true)
                {
                    var gs = gsMapper.ObtenerUna(persona.IdGrupoSanguineo);

                    if (gs != null)
                    {
                        if (persona.IdGrupoSanguineo == gs.Id)
                        {
                            persona.GrupoSanguineo = gs;
                            personasFiltradas.Add(persona);
                        }
                    }
                }
            }

            return personasFiltradas;
        }

        public IEnumerable<Persona> ObtenerPorPersona(string cadena)
        {
            var espacio = ' ';
            var array = cadena.Split(espacio);

            var personasFiltradas = new List<Persona>();

            var personas = base.ObtenerTodas().ToList();
            var gsMapper = new GrupoSanguineoMapper();

            // buscamos los Ids de personas y los recuperamos
            foreach (var persona in personas)
            {
                foreach (var item in array)
                {
                    if (persona.Nombre.Contains(item) || persona.Apellido.Contains(item))
                    {
                        var gs = gsMapper.ObtenerUna(persona.IdGrupoSanguineo);

                        if (gs != null)
                        {
                            if (persona.IdGrupoSanguineo == gs.Id)
                            {
                                persona.GrupoSanguineo = gs;
                                personasFiltradas.Add(persona);

                                break;
                            }
                        }
                    }
                }
            }

            return personasFiltradas;
        }


        public IEnumerable<Persona> ObtenerPorDni(string cadena)
        {
            var personasFiltradas = new List<Persona>();

            var personas = base.ObtenerTodas().ToList();
            var gsMapper = new GrupoSanguineoMapper();

            // buscamos los Ids de personas y los recuperamos
            foreach (var persona in personas)
            {
                var documento = persona.Dni.ToString();

                if (documento.Contains(cadena))
                {
                    var gs = gsMapper.ObtenerUna(persona.IdGrupoSanguineo);

                    if (gs != null)
                    {
                        if (persona.IdGrupoSanguineo == gs.Id)
                        {
                            persona.GrupoSanguineo = gs;
                            personasFiltradas.Add(persona);

                            break;
                        }
                    }
                }
            }

            return personasFiltradas;
        }
    }
}

