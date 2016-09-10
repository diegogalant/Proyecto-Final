using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Reglas;

namespace Banco_de_Sangre
{
    public partial class PersonaForm : Form
    {
        public PersonaForm()
        {
            InitializeComponent();
        }

        public string Action { get; set; }
        public Persona Persona { get; set; }

        private void PersonaForm_Load(object sender, EventArgs e)
        {
            apellidoTextBox.Focus();

            var gsm = new GrupoSanguineoMapper();
            grupoSanguineoComboBox.DataSource = gsm.ObtenerTodas();

            if (Action== "Agregar")
            {
                personaBindingSource.DataSource = new Persona();
            }
            else if(Action == "Modificar")
            {
                personaBindingSource.DataSource = Persona;
                grupoSanguineoComboBox.SelectedItem = Persona.GrupoSanguineo;
            }
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            var personaEnEdicion = (Persona)personaBindingSource.Current;

            var pRule = new PersonaRule();

            if (Action == "Agregar")
            {
                pRule.AgregarPersona(personaEnEdicion);
            }
            else if (Action == "Modificar")
            {
                pRule.ModificarPersona(personaEnEdicion);
            }

            Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
