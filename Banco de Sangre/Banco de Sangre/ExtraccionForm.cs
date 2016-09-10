using Entidades;
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

namespace Banco_de_Sangre
{
    public partial class ExtraccionForm : Form
    {
        public Persona Persona { get; set; }
        public string Action { get; set; }
        public bool EstoyCargandoPersona { get; set; }
        public Extraccion extraccion { get; set; }

        public ExtraccionForm()
        {
            InitializeComponent();
        }

        private void ExtraccionForm_Load(object sender, EventArgs e)
        {
            fechaDateTimePicker.Focus();

            var eRule = new ExtraccionRule();
            tiposAnalisisComboBox.DataSource= eRule.CargarTiposAnalisis();

            var pMapper = new PersonaMapper();
            personaCombobox.DataSource = pMapper.ObtenerTodas();

            if (Action == "Agregar")
            {
                extraccionBindingSource.DataSource = new Extraccion();
            }
            else if (Action == "Modificar")
            {
            }

        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            var extraccionEnEdicion = (Extraccion)extraccionBindingSource.Current;
            extraccionEnEdicion.Persona = (Persona)personaCombobox.SelectedItem;
            var extraccionRule = new ExtraccionRule();

            if (Action == "Agregar")
            {
                extraccionRule.AgregarExtraccion(extraccionEnEdicion);
            }
            else if (Action == "Modificar")
            {
                extraccionRule.ModificarExtraccion(extraccionEnEdicion);
            }

            Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
