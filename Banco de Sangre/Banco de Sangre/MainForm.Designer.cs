using Entidades;

namespace Banco_de_Sangre
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscarButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.porDniRadioButton = new System.Windows.Forms.RadioButton();
            this.porNombreRadioButton = new System.Windows.Forms.RadioButton();
            this.personaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Agregar = new System.Windows.Forms.ToolStripButton();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.Actualizar = new System.Windows.Forms.ToolStripButton();
            this.BorrarLista = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoSanguineoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personaTextBox = new System.Windows.Forms.TextBox();
            this.PoPersonaRadioButton = new System.Windows.Forms.RadioButton();
            this.PorReceptorRadioButton = new System.Windows.Forms.RadioButton();
            this.porDadorRadioButton = new System.Windows.Forms.RadioButton();
            this.porCompatibilidadRadioButton = new System.Windows.Forms.RadioButton();
            this.bancoBuscarButton = new System.Windows.Forms.Button();
            this.grupoSanguineoComboBox = new System.Windows.Forms.ComboBox();
            this.porGrupoSanguineoRadioButton = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 304);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.personaDataGridView);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Persona";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.buscarButton);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.porDniRadioButton);
            this.panel2.Controls.Add(this.porNombreRadioButton);
            this.panel2.Location = new System.Drawing.Point(6, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 34);
            this.panel2.TabIndex = 2;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(331, 5);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // porDniRadioButton
            // 
            this.porDniRadioButton.AutoSize = true;
            this.porDniRadioButton.Location = new System.Drawing.Point(109, 7);
            this.porDniRadioButton.Name = "porDniRadioButton";
            this.porDniRadioButton.Size = new System.Drawing.Size(97, 17);
            this.porDniRadioButton.TabIndex = 1;
            this.porDniRadioButton.TabStop = true;
            this.porDniRadioButton.Text = "Por documento";
            this.porDniRadioButton.UseVisualStyleBackColor = true;
            // 
            // porNombreRadioButton
            // 
            this.porNombreRadioButton.AutoSize = true;
            this.porNombreRadioButton.Location = new System.Drawing.Point(13, 8);
            this.porNombreRadioButton.Name = "porNombreRadioButton";
            this.porNombreRadioButton.Size = new System.Drawing.Size(79, 17);
            this.porNombreRadioButton.TabIndex = 0;
            this.porNombreRadioButton.TabStop = true;
            this.porNombreRadioButton.Text = "Por nombre";
            this.porNombreRadioButton.UseVisualStyleBackColor = true;
            // 
            // personaDataGridView
            // 
            this.personaDataGridView.AllowUserToAddRows = false;
            this.personaDataGridView.AllowUserToDeleteRows = false;
            this.personaDataGridView.AutoGenerateColumns = false;
            this.personaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.personaDataGridView.DataSource = this.personaBindingSource;
            this.personaDataGridView.Location = new System.Drawing.Point(6, 71);
            this.personaDataGridView.Name = "personaDataGridView";
            this.personaDataGridView.ReadOnly = true;
            this.personaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personaDataGridView.Size = new System.Drawing.Size(835, 201);
            this.personaDataGridView.TabIndex = 1;
            this.personaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dni";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dni";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Entidades.Persona);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Agregar,
            this.Eliminar,
            this.Actualizar,
            this.BorrarLista});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(843, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Agregar
            // 
            this.Agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Agregar.Image = ((System.Drawing.Image)(resources.GetObject("Agregar.Image")));
            this.Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(23, 22);
            this.Agregar.Text = "AgregarButton";
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(23, 22);
            this.Eliminar.Text = "EliminarButton";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Actualizar.Image")));
            this.Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(23, 22);
            this.Actualizar.Text = "ActualizarButton";
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // BorrarLista
            // 
            this.BorrarLista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorrarLista.Image = ((System.Drawing.Image)(resources.GetObject("BorrarLista.Image")));
            this.BorrarLista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarLista.Name = "BorrarLista";
            this.BorrarLista.Size = new System.Drawing.Size(23, 22);
            this.BorrarLista.Text = "BorrarTodoButton";
            this.BorrarLista.Click += new System.EventHandler(this.BorrarLista_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(908, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Banco";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.grupoSanguineoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(899, 235);
            this.dataGridView1.TabIndex = 1;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupoSanguineoDataGridViewTextBoxColumn
            // 
            this.grupoSanguineoDataGridViewTextBoxColumn.DataPropertyName = "GrupoSanguineo";
            this.grupoSanguineoDataGridViewTextBoxColumn.HeaderText = "GrupoSanguineo";
            this.grupoSanguineoDataGridViewTextBoxColumn.Name = "grupoSanguineoDataGridViewTextBoxColumn";
            this.grupoSanguineoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.personaTextBox);
            this.panel1.Controls.Add(this.PoPersonaRadioButton);
            this.panel1.Controls.Add(this.PorReceptorRadioButton);
            this.panel1.Controls.Add(this.porDadorRadioButton);
            this.panel1.Controls.Add(this.porCompatibilidadRadioButton);
            this.panel1.Controls.Add(this.bancoBuscarButton);
            this.panel1.Controls.Add(this.grupoSanguineoComboBox);
            this.panel1.Controls.Add(this.porGrupoSanguineoRadioButton);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 34);
            this.panel1.TabIndex = 0;
            // 
            // personaTextBox
            // 
            this.personaTextBox.Location = new System.Drawing.Point(692, 6);
            this.personaTextBox.Name = "personaTextBox";
            this.personaTextBox.Size = new System.Drawing.Size(121, 20);
            this.personaTextBox.TabIndex = 9;
            // 
            // PoPersonaRadioButton
            // 
            this.PoPersonaRadioButton.AutoSize = true;
            this.PoPersonaRadioButton.Location = new System.Drawing.Point(604, 9);
            this.PoPersonaRadioButton.Name = "PoPersonaRadioButton";
            this.PoPersonaRadioButton.Size = new System.Drawing.Size(82, 17);
            this.PoPersonaRadioButton.TabIndex = 8;
            this.PoPersonaRadioButton.TabStop = true;
            this.PoPersonaRadioButton.Text = "Por persona";
            this.PoPersonaRadioButton.UseVisualStyleBackColor = true;
            // 
            // PorReceptorRadioButton
            // 
            this.PorReceptorRadioButton.AutoSize = true;
            this.PorReceptorRadioButton.Location = new System.Drawing.Point(504, 9);
            this.PorReceptorRadioButton.Name = "PorReceptorRadioButton";
            this.PorReceptorRadioButton.Size = new System.Drawing.Size(94, 17);
            this.PorReceptorRadioButton.TabIndex = 7;
            this.PorReceptorRadioButton.TabStop = true;
            this.PorReceptorRadioButton.Text = "Por receptores";
            this.PorReceptorRadioButton.UseVisualStyleBackColor = true;
            // 
            // porDadorRadioButton
            // 
            this.porDadorRadioButton.AutoSize = true;
            this.porDadorRadioButton.Location = new System.Drawing.Point(416, 9);
            this.porDadorRadioButton.Name = "porDadorRadioButton";
            this.porDadorRadioButton.Size = new System.Drawing.Size(82, 17);
            this.porDadorRadioButton.TabIndex = 6;
            this.porDadorRadioButton.TabStop = true;
            this.porDadorRadioButton.Text = "Por dadores";
            this.porDadorRadioButton.UseVisualStyleBackColor = true;
            // 
            // porCompatibilidadRadioButton
            // 
            this.porCompatibilidadRadioButton.AutoSize = true;
            this.porCompatibilidadRadioButton.Location = new System.Drawing.Point(141, 9);
            this.porCompatibilidadRadioButton.Name = "porCompatibilidadRadioButton";
            this.porCompatibilidadRadioButton.Size = new System.Drawing.Size(164, 17);
            this.porCompatibilidadRadioButton.TabIndex = 5;
            this.porCompatibilidadRadioButton.TabStop = true;
            this.porCompatibilidadRadioButton.Text = "Por compatibilidad donadores";
            this.porCompatibilidadRadioButton.UseVisualStyleBackColor = true;
            // 
            // bancoBuscarButton
            // 
            this.bancoBuscarButton.Location = new System.Drawing.Point(819, 5);
            this.bancoBuscarButton.Name = "bancoBuscarButton";
            this.bancoBuscarButton.Size = new System.Drawing.Size(75, 23);
            this.bancoBuscarButton.TabIndex = 4;
            this.bancoBuscarButton.Text = "Buscar";
            this.bancoBuscarButton.UseVisualStyleBackColor = true;
            this.bancoBuscarButton.Click += new System.EventHandler(this.bancoBuscarButton_Click);
            // 
            // grupoSanguineoComboBox
            // 
            this.grupoSanguineoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grupoSanguineoComboBox.FormattingEnabled = true;
            this.grupoSanguineoComboBox.Location = new System.Drawing.Point(308, 7);
            this.grupoSanguineoComboBox.Name = "grupoSanguineoComboBox";
            this.grupoSanguineoComboBox.Size = new System.Drawing.Size(102, 21);
            this.grupoSanguineoComboBox.TabIndex = 1;
            // 
            // porGrupoSanguineoRadioButton
            // 
            this.porGrupoSanguineoRadioButton.AutoSize = true;
            this.porGrupoSanguineoRadioButton.Location = new System.Drawing.Point(12, 9);
            this.porGrupoSanguineoRadioButton.Name = "porGrupoSanguineoRadioButton";
            this.porGrupoSanguineoRadioButton.Size = new System.Drawing.Size(123, 17);
            this.porGrupoSanguineoRadioButton.TabIndex = 0;
            this.porGrupoSanguineoRadioButton.TabStop = true;
            this.porGrupoSanguineoRadioButton.Text = "Por grupo sanguineo";
            this.porGrupoSanguineoRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 311);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Banco de Sangre";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Agregar;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripButton Actualizar;
        private System.Windows.Forms.DataGridView personaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.ToolStripButton BorrarLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox grupoSanguineoComboBox;
        private System.Windows.Forms.RadioButton porGrupoSanguineoRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton porDniRadioButton;
        private System.Windows.Forms.RadioButton porNombreRadioButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.RadioButton porCompatibilidadRadioButton;
        private System.Windows.Forms.Button bancoBuscarButton;
        private System.Windows.Forms.RadioButton PorReceptorRadioButton;
        private System.Windows.Forms.RadioButton porDadorRadioButton;
        private System.Windows.Forms.RadioButton PoPersonaRadioButton;
        private System.Windows.Forms.TextBox personaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoSanguineoDataGridViewTextBoxColumn;
    }
}