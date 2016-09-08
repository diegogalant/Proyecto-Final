using Reglas;
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

namespace Banco_de_Sangre
{
    public partial class MainForm : Form
    {
        private Persona _persona;

        public MainForm()
        {
            InitializeComponent();
        }

        public void personaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _persona = (Persona)personaBindingSource.Current;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            var borrar = new PersonaMapper();

            borrar.Eliminar(_persona);

            Refrescar(); 
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //Agregar
            var pForm = new PersonaForm();
            pForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var gSanguineoRule = new GrupoSanguineoRule();
            gSanguineoRule.GenerarGruposSanguineos();

            var gsm = new GrupoSanguineoMapper();
            grupoSanguineoComboBox.DataSource = gsm.ObtenerTodas();

            Refrescar();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }


        private void Refrescar()
        {
            var personaMapper = new PersonaMapper();
            personaBindingSource.DataSource = personaMapper.ObtenerTodas();

            
            if (porGrupoSanguineoRadioButton.Checked)
            {
                var grupoSanguineo = (GrupoSanguineo)grupoSanguineoComboBox.SelectedItem;
                personaBindingSource.DataSource = personaMapper.ObtenerPorGrupoSanguineo(grupoSanguineo);                                  
            }

            if(porCompatibilidadRadioButton.Checked)
            {
                var grupoSanguineo = (GrupoSanguineo)grupoSanguineoComboBox.SelectedItem;
                personaBindingSource.DataSource = personaMapper.ObtenerPorCompatibilidadDonadores(grupoSanguineo);
            }
        }

        private void BorrarLista_Click(object sender, EventArgs e)
        {
            var borrartodo = new PersonaMapper();

            //Muestra un Messagebox si o no
            DialogResult result = MessageBox.Show("¿Seguro que desea borrar la lista completa?", "Borrar todo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                borrartodo.EliminarTodas();
            }
            else if (result == DialogResult.No)
            {
            }
            
            Refrescar();
        }

        private void bancoBuscarButton_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
