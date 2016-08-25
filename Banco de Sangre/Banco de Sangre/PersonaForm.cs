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

        private void aceptarButton_Click(object sender, EventArgs e)
        {
           var personaEnEdicion = (Persona)personaBindingSource.Current;

            var gSanguineo = (GrupoSanguineo)grupoSanguineoCombobox.SelectedItem;

            personaEnEdicion.GrupoSanguineo = gSanguineo.Id;

            var r = new PersonaMapper();
            r.Grabar(personaEnEdicion);

            Close();
        }

        private void PersonaForm_Load(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;

            personaBindingSource.DataSource = new Persona();

            var gSanguineo = new GrupoSanguineoRule();
            grupoSanguineoCombobox.DataSource = gSanguineo.GenerarGruposSanguineos();
            grupoSanguineoCombobox.DisplayMember = "Descripcion";
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grupoSanguineoCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSeleccionado = (GrupoSanguineo)grupoSanguineoCombobox.SelectedItem;

            if (itemSeleccionado.Descripcion == "A+")
            {
                itemSeleccionado.FactorRh = true;
            }   
        }
    }
}
