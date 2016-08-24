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
    public partial class Banco_de_Sangre : Form
    {
        private string _action;
        private Persona _persona;


        public Banco_de_Sangre()
        {
            InitializeComponent();
        }

        public void personaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _persona = (Persona)personaBindingSource.Current;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            // eliminar
            //var r = new PersonaRule();
            //r.EliminarPersona(_persona);

            var pMapper = new PersonaMapper();
            var todos = pMapper.ObtenerTodas();

            
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //Agregar
            var pForm = new PersonaForm();
            pForm.ShowDialog();
        }

        private void Banco_de_Sangre_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void personaBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            //Refrescar();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }


        private void Refrescar()
        {
            var r = new PersonaMapper();
            personaBindingSource.DataSource = r.ObtenerTodas();
        }
    }
}
