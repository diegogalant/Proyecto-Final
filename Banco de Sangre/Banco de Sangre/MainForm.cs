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
        private Persona _personaEnEdicion;
        private Extraccion _extraccionEnEdicion;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //Agregar
            var personaForm = new PersonaForm();
            personaForm.Action = "Agregar";
            personaForm.ShowDialog();


            todasRadioButton.Checked = true;
        }

        private void modificarToolStripButton_Click(object sender, EventArgs e)
        {
            _personaEnEdicion = (Persona)personaBindingSource.Current;

            var personaForm = new PersonaForm();
            personaForm.Action = "Modificar";
            personaForm.Persona = _personaEnEdicion;
            personaForm.ShowDialog();

            todasRadioButton.Checked = true;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            _personaEnEdicion = (Persona)personaBindingSource.Current;

            var pRule = new PersonaRule();

            pRule.EliminarPersona(_personaEnEdicion);

            todasRadioButton.Checked = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var gSRule = new GrupoSanguineoRule();
            gSRule.GenerarGruposSanguineos();
            grupoSanguineoComboBox.DataSource = gSRule.ObtenerTodosLosGrupos();

            var eRule= new ExtraccionRule();
            extraccionBindingSource.DataSource = eRule.ObtenerTodasLasExtracciones();
           Refrescar();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }


        private void Refrescar()
        {
            var extraccionMapper = new ExtraccionMapper();

            var pMapper = new PersonaMapper();
            if (porGrupoSanguineoRadioButton.Checked)
            {
                var grupoSanguineo = (GrupoSanguineo)grupoSanguineoComboBox.SelectedItem;
                personaBindingSource.DataSource = pMapper.ObtenerPorGrupoSanguineo(grupoSanguineo);                                  
            }

            if(porCompatibilidadDonadorRadioButton.Checked)
            {
                var grupoSanguineo = (GrupoSanguineo)grupoSanguineoComboBox.SelectedItem;
                personaBindingSource.DataSource = pMapper.ObtenerPorCompatibilidadDonadores(grupoSanguineo);
            }

            if (porCompatibilidadReceptorRadioButton.Checked)
            {
                var grupoSanguineo = (GrupoSanguineo)grupoSanguineoComboBox.SelectedItem;
                personaBindingSource.DataSource = pMapper.ObtenerPorCompatibilidadReceptores(grupoSanguineo);
            }

            if (PorReceptorRadioButton.Checked)
            {
                personaBindingSource.DataSource = pMapper.ObtenerReceptores();
            }

            if (porDadorRadioButton.Checked)
            {
                personaBindingSource.DataSource = pMapper.ObtenerDonadores();
            }

            if (PorPersonaRadioButton.Checked)
            {
                personaBindingSource.DataSource = pMapper.ObtenerPorPersona(BancoPersonaTextBox.Text);
            }

            if (porNombreYApellidoRadioButton.Checked)
            {
                personaBindingSource.DataSource = pMapper.ObtenerPorPersona(personaTextBox.Text);
            }


            if (porDniRadioButton.Checked)
            {
                personaBindingSource.DataSource = pMapper.ObtenerPorDni(personaTextBox.Text);
            }

            if (todasRadioButton.Checked)
            {
                personaBindingSource.DataSource = pMapper.ObtenerTodas();
            }

            if (bancoTodasRadioButton.Checked)
            {
                personaBindingSource.DataSource = pMapper.ObtenerTodas();
            }

            if (porFechasRadioButton.Checked)
            {
                extraccionBindingSource.DataSource = extraccionMapper.ObtenerPorFechas(fechaDesdeDateTimePicker.Value, hastaDateTimePicker.Value);
            }
        }

        private void BorrarLista_Click(object sender, EventArgs e)
        {
            var pRule = new PersonaRule();

            //Muestra un Messagebox si o no
            DialogResult result = MessageBox.Show("¿Seguro que desea borrar la lista completa?", "Borrar todo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                pRule.EliminarTodasLasPersonas();
            }

            Refrescar();
        }

        private void bancoBuscarButton_Click(object sender, EventArgs e)
        {
            BancoPersonaTextBox.Text = "";
            Refrescar();
        }

        private void PoPersonaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PorPersonaRadioButton.Checked)
            {
                BancoPersonaTextBox.Enabled = true;
                BancoPersonaTextBox.Focus();
            }
            else
            {
                BancoPersonaTextBox.Enabled = false;
                BancoPersonaTextBox.Clear();
            }
        }

        private void porDniRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (porDniRadioButton.Checked)
            {
                personaTextBox.Focus();
            }
            else
            {
                personaTextBox.Clear();
            }
        }

        private void porNombreYApellidoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (porNombreYApellidoRadioButton.Checked)
            {
                personaTextBox.Focus();
            }
            else
            {
                personaTextBox.Clear();
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void BancoPersonaTextBox_Click(object sender, EventArgs e)
        {
            PorPersonaRadioButton.Checked = true;
        }

        private void grupoSanguineoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            PorPersonaRadioButton.Checked = true;
        }

        private void todasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var pMapper = new PersonaMapper();
            personaBindingSource.DataSource = pMapper.ObtenerTodas();
        }

        private void bancoTodasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var pMapper = new PersonaMapper();
            personaBindingSource.DataSource = pMapper.ObtenerTodas();
        }

        private void bancoTabPage_Enter(object sender, EventArgs e)
        {
            todasRadioButton.Checked = false;
        }

        private void tabControl_Enter(object sender, EventArgs e)
        {
            todasRadioButton.Checked = false;
        }

        private void agregarExtraccionTSButton_Click(object sender, EventArgs e)
        {
            //Agregar
            var extraccionForm = new ExtraccionForm();
            extraccionForm.Action = "Agregar";
            extraccionForm.ShowDialog();

            Refrescar();
        }

        private void eliminarExtraccionTSButton_Click(object sender, EventArgs e)
        {
            _extraccionEnEdicion = (Extraccion)extraccionBindingSource.Current;

            var eRule = new ExtraccionRule();

            eRule.EliminarExtraccion(_extraccionEnEdicion);

            todasRadioButton.Checked = true;

            Refrescar();
        }

        private void refrescarTStButton_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void extraccionBuscarButton_Click(object sender, EventArgs e)
        {
            Refrescar();
        }


        //private void personaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var extraccionForm = new ExtraccionForm();

        //    extraccionForm.Persona = (Persona)personaBindingSource.Current;
        //    extraccionForm.Action = "Cargar";
        //    extraccionForm.EstoyCargandoPersona = true;

        //    extraccionForm.Show();
        //}
    }
}
