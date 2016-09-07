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


        private void PersonaForm_Load(object sender, EventArgs e)
        {
            personaBindingSource.DataSource = new Persona();

            //var gSanguineo = new GrupoSanguineoRule();
            //grupoSanguineoCombobox.DataSource = gSanguineo.GenerarGruposSanguineos();
            //grupoSanguineoCombobox.DisplayMember = "Descripcion";


            var gsm = new GrupoSanguineoMapper();
            grupoSanguineoCombobox.DataSource = gsm.ObtenerTodas();

        }



        private void aceptarButton_Click(object sender, EventArgs e)
        {
            var personaEnEdicion = (Persona)personaBindingSource.Current;

            var r = new PersonaMapper();
            r.Grabar(personaEnEdicion);

             Close();


            //var personaEnEdicion = (Persona)personaBindingSource.Current;

            // var grupoSanguineo = new GrupoSanguineo();

            // grupoSanguineo.Descripcion = grupoSanguineoCombobox.SelectedItem.ToString();

            // if (factorRhCheckBox.Checked)
            // {
            //     grupoSanguineo.FactorRh = true;
            // }
            // else
            // {
            //     grupoSanguineo.FactorRh = false;
            // }

            // //personaEnEdicion.IdGrupoSanguineo = grupoSanguineo.Id;

            // var r = new PersonaMapper();
            // r.Grabar(personaEnEdicion);

            // Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void factorRhCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var grupo = (GrupoSanguineo) grupoSanguineoCombobox.SelectedItem;

            MessageBox.Show(grupo.Id.ToString());
        }
    }
}
