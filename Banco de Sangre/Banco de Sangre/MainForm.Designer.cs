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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.personaTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.todasRadioButton = new System.Windows.Forms.RadioButton();
            this.buscarButton = new System.Windows.Forms.Button();
            this.personaTextBox = new System.Windows.Forms.TextBox();
            this.porDniRadioButton = new System.Windows.Forms.RadioButton();
            this.porNombreYApellidoRadioButton = new System.Windows.Forms.RadioButton();
            this.personaDataGridView = new System.Windows.Forms.DataGridView();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.agregarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.modificarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.eliminarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refrescarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.limpiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bancoTabPage = new System.Windows.Forms.TabPage();
            this.bancoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bancoTodasRadioButton = new System.Windows.Forms.RadioButton();
            this.porCompatibilidadReceptorRadioButton = new System.Windows.Forms.RadioButton();
            this.PorPersonaRadioButton = new System.Windows.Forms.RadioButton();
            this.PorReceptorRadioButton = new System.Windows.Forms.RadioButton();
            this.BancoPersonaTextBox = new System.Windows.Forms.TextBox();
            this.porDadorRadioButton = new System.Windows.Forms.RadioButton();
            this.porCompatibilidadDonadorRadioButton = new System.Windows.Forms.RadioButton();
            this.bancoBuscarButton = new System.Windows.Forms.Button();
            this.grupoSanguineoComboBox = new System.Windows.Forms.ComboBox();
            this.porGrupoSanguineoRadioButton = new System.Windows.Forms.RadioButton();
            this.extraccionTabPage = new System.Windows.Forms.TabPage();
            this.extraccionDataGridView = new System.Windows.Forms.DataGridView();
            this.extraccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaDesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.porFechasRadioButton = new System.Windows.Forms.RadioButton();
            this.extraccionBuscarButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.agregarExtraccionTSButton = new System.Windows.Forms.ToolStripButton();
            this.modificarExtraccionTSButton = new System.Windows.Forms.ToolStripButton();
            this.eliminarExtraccionTSButton = new System.Windows.Forms.ToolStripButton();
            this.refrescarTStButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoSanguineoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Receptor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.personaTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.bancoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.extraccionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraccionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraccionBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.personaTabPage);
            this.tabControl.Controls.Add(this.bancoTabPage);
            this.tabControl.Controls.Add(this.extraccionTabPage);
            this.tabControl.Location = new System.Drawing.Point(2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(712, 433);
            this.tabControl.TabIndex = 1;
            this.tabControl.Enter += new System.EventHandler(this.tabControl_Enter);
            // 
            // personaTabPage
            // 
            this.personaTabPage.AutoScroll = true;
            this.personaTabPage.Controls.Add(this.panel2);
            this.personaTabPage.Controls.Add(this.personaDataGridView);
            this.personaTabPage.Controls.Add(this.toolStrip2);
            this.personaTabPage.Location = new System.Drawing.Point(4, 22);
            this.personaTabPage.Name = "personaTabPage";
            this.personaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.personaTabPage.Size = new System.Drawing.Size(704, 407);
            this.personaTabPage.TabIndex = 0;
            this.personaTabPage.Text = "Persona";
            this.personaTabPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.todasRadioButton);
            this.panel2.Controls.Add(this.buscarButton);
            this.panel2.Controls.Add(this.personaTextBox);
            this.panel2.Controls.Add(this.porDniRadioButton);
            this.panel2.Controls.Add(this.porNombreYApellidoRadioButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 39);
            this.panel2.TabIndex = 2;
            // 
            // todasRadioButton
            // 
            this.todasRadioButton.AutoSize = true;
            this.todasRadioButton.Location = new System.Drawing.Point(13, 10);
            this.todasRadioButton.Name = "todasRadioButton";
            this.todasRadioButton.Size = new System.Drawing.Size(55, 17);
            this.todasRadioButton.TabIndex = 4;
            this.todasRadioButton.TabStop = true;
            this.todasRadioButton.Text = "Todas";
            this.todasRadioButton.UseVisualStyleBackColor = true;
            this.todasRadioButton.CheckedChanged += new System.EventHandler(this.todasRadioButton_CheckedChanged);
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(519, 7);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // personaTextBox
            // 
            this.personaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personaTextBox.Location = new System.Drawing.Point(309, 9);
            this.personaTextBox.Name = "personaTextBox";
            this.personaTextBox.Size = new System.Drawing.Size(187, 20);
            this.personaTextBox.TabIndex = 2;
            // 
            // porDniRadioButton
            // 
            this.porDniRadioButton.AutoSize = true;
            this.porDniRadioButton.Location = new System.Drawing.Point(206, 10);
            this.porDniRadioButton.Name = "porDniRadioButton";
            this.porDniRadioButton.Size = new System.Drawing.Size(97, 17);
            this.porDniRadioButton.TabIndex = 1;
            this.porDniRadioButton.TabStop = true;
            this.porDniRadioButton.Text = "Por documento";
            this.porDniRadioButton.UseVisualStyleBackColor = true;
            this.porDniRadioButton.CheckedChanged += new System.EventHandler(this.porDniRadioButton_CheckedChanged);
            // 
            // porNombreYApellidoRadioButton
            // 
            this.porNombreYApellidoRadioButton.AutoSize = true;
            this.porNombreYApellidoRadioButton.Location = new System.Drawing.Point(74, 10);
            this.porNombreYApellidoRadioButton.Name = "porNombreYApellidoRadioButton";
            this.porNombreYApellidoRadioButton.Size = new System.Drawing.Size(126, 17);
            this.porNombreYApellidoRadioButton.TabIndex = 0;
            this.porNombreYApellidoRadioButton.TabStop = true;
            this.porNombreYApellidoRadioButton.Text = "Por nombre y apellido";
            this.porNombreYApellidoRadioButton.UseVisualStyleBackColor = true;
            this.porNombreYApellidoRadioButton.CheckedChanged += new System.EventHandler(this.porNombreYApellidoRadioButton_CheckedChanged);
            // 
            // personaDataGridView
            // 
            this.personaDataGridView.AllowUserToAddRows = false;
            this.personaDataGridView.AllowUserToDeleteRows = false;
            this.personaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personaDataGridView.AutoGenerateColumns = false;
            this.personaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.personaDataGridView.DataSource = this.personaBindingSource;
            this.personaDataGridView.Location = new System.Drawing.Point(3, 71);
            this.personaDataGridView.Name = "personaDataGridView";
            this.personaDataGridView.ReadOnly = true;
            this.personaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personaDataGridView.Size = new System.Drawing.Size(698, 333);
            this.personaDataGridView.TabIndex = 1;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Entidades.Persona);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripButton,
            this.modificarToolStripButton,
            this.eliminarToolStripButton,
            this.refrescarToolStripButton,
            this.limpiarToolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(698, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // agregarToolStripButton
            // 
            this.agregarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripButton.Image")));
            this.agregarToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.agregarToolStripButton.Name = "agregarToolStripButton";
            this.agregarToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.agregarToolStripButton.Text = "Agregar ";
            this.agregarToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarToolStripButton.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // modificarToolStripButton
            // 
            this.modificarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripButton.Image")));
            this.modificarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modificarToolStripButton.Name = "modificarToolStripButton";
            this.modificarToolStripButton.Size = new System.Drawing.Size(78, 22);
            this.modificarToolStripButton.Text = "Modificar";
            this.modificarToolStripButton.Click += new System.EventHandler(this.modificarToolStripButton_Click);
            // 
            // eliminarToolStripButton
            // 
            this.eliminarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripButton.Image")));
            this.eliminarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminarToolStripButton.Name = "eliminarToolStripButton";
            this.eliminarToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.eliminarToolStripButton.Text = "Eliminar";
            this.eliminarToolStripButton.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // refrescarToolStripButton
            // 
            this.refrescarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refrescarToolStripButton.Image")));
            this.refrescarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refrescarToolStripButton.Name = "refrescarToolStripButton";
            this.refrescarToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.refrescarToolStripButton.Text = "Refrescar";
            this.refrescarToolStripButton.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // limpiarToolStripButton
            // 
            this.limpiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("limpiarToolStripButton.Image")));
            this.limpiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.limpiarToolStripButton.Name = "limpiarToolStripButton";
            this.limpiarToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.limpiarToolStripButton.Text = "Limpiar ";
            this.limpiarToolStripButton.Click += new System.EventHandler(this.BorrarLista_Click);
            // 
            // bancoTabPage
            // 
            this.bancoTabPage.Controls.Add(this.bancoDataGridView);
            this.bancoTabPage.Controls.Add(this.panel1);
            this.bancoTabPage.Location = new System.Drawing.Point(4, 22);
            this.bancoTabPage.Name = "bancoTabPage";
            this.bancoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bancoTabPage.Size = new System.Drawing.Size(704, 407);
            this.bancoTabPage.TabIndex = 1;
            this.bancoTabPage.Text = "Banco de datos";
            this.bancoTabPage.UseVisualStyleBackColor = true;
            this.bancoTabPage.Enter += new System.EventHandler(this.bancoTabPage_Enter);
            // 
            // bancoDataGridView
            // 
            this.bancoDataGridView.AllowUserToAddRows = false;
            this.bancoDataGridView.AllowUserToDeleteRows = false;
            this.bancoDataGridView.AutoGenerateColumns = false;
            this.bancoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bancoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.Dni,
            this.grupoSanguineoDataGridViewTextBoxColumn,
            this.Dador,
            this.Receptor});
            this.bancoDataGridView.DataSource = this.personaBindingSource;
            this.bancoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bancoDataGridView.Location = new System.Drawing.Point(3, 67);
            this.bancoDataGridView.Name = "bancoDataGridView";
            this.bancoDataGridView.ReadOnly = true;
            this.bancoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bancoDataGridView.Size = new System.Drawing.Size(698, 337);
            this.bancoDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.bancoTodasRadioButton);
            this.panel1.Controls.Add(this.porCompatibilidadReceptorRadioButton);
            this.panel1.Controls.Add(this.PorPersonaRadioButton);
            this.panel1.Controls.Add(this.PorReceptorRadioButton);
            this.panel1.Controls.Add(this.BancoPersonaTextBox);
            this.panel1.Controls.Add(this.porDadorRadioButton);
            this.panel1.Controls.Add(this.porCompatibilidadDonadorRadioButton);
            this.panel1.Controls.Add(this.bancoBuscarButton);
            this.panel1.Controls.Add(this.grupoSanguineoComboBox);
            this.panel1.Controls.Add(this.porGrupoSanguineoRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 64);
            this.panel1.TabIndex = 0;
            // 
            // bancoTodasRadioButton
            // 
            this.bancoTodasRadioButton.AutoSize = true;
            this.bancoTodasRadioButton.Location = new System.Drawing.Point(13, 36);
            this.bancoTodasRadioButton.Name = "bancoTodasRadioButton";
            this.bancoTodasRadioButton.Size = new System.Drawing.Size(55, 17);
            this.bancoTodasRadioButton.TabIndex = 11;
            this.bancoTodasRadioButton.TabStop = true;
            this.bancoTodasRadioButton.Text = "Todas";
            this.bancoTodasRadioButton.UseVisualStyleBackColor = true;
            this.bancoTodasRadioButton.CheckedChanged += new System.EventHandler(this.bancoTodasRadioButton_CheckedChanged);
            // 
            // porCompatibilidadReceptorRadioButton
            // 
            this.porCompatibilidadReceptorRadioButton.AutoSize = true;
            this.porCompatibilidadReceptorRadioButton.Location = new System.Drawing.Point(301, 9);
            this.porCompatibilidadReceptorRadioButton.Name = "porCompatibilidadReceptorRadioButton";
            this.porCompatibilidadReceptorRadioButton.Size = new System.Drawing.Size(153, 17);
            this.porCompatibilidadReceptorRadioButton.TabIndex = 10;
            this.porCompatibilidadReceptorRadioButton.TabStop = true;
            this.porCompatibilidadReceptorRadioButton.Text = "Por compatibilidad receptor";
            this.porCompatibilidadReceptorRadioButton.UseVisualStyleBackColor = true;
            // 
            // PorPersonaRadioButton
            // 
            this.PorPersonaRadioButton.AutoSize = true;
            this.PorPersonaRadioButton.Location = new System.Drawing.Point(231, 36);
            this.PorPersonaRadioButton.Name = "PorPersonaRadioButton";
            this.PorPersonaRadioButton.Size = new System.Drawing.Size(82, 17);
            this.PorPersonaRadioButton.TabIndex = 8;
            this.PorPersonaRadioButton.TabStop = true;
            this.PorPersonaRadioButton.Text = "Por persona";
            this.PorPersonaRadioButton.UseVisualStyleBackColor = true;
            this.PorPersonaRadioButton.CheckedChanged += new System.EventHandler(this.PoPersonaRadioButton_CheckedChanged);
            // 
            // PorReceptorRadioButton
            // 
            this.PorReceptorRadioButton.AutoSize = true;
            this.PorReceptorRadioButton.Location = new System.Drawing.Point(145, 36);
            this.PorReceptorRadioButton.Name = "PorReceptorRadioButton";
            this.PorReceptorRadioButton.Size = new System.Drawing.Size(80, 17);
            this.PorReceptorRadioButton.TabIndex = 7;
            this.PorReceptorRadioButton.TabStop = true;
            this.PorReceptorRadioButton.Text = "Receptores";
            this.PorReceptorRadioButton.UseVisualStyleBackColor = true;
            // 
            // BancoPersonaTextBox
            // 
            this.BancoPersonaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BancoPersonaTextBox.Location = new System.Drawing.Point(319, 35);
            this.BancoPersonaTextBox.Name = "BancoPersonaTextBox";
            this.BancoPersonaTextBox.Size = new System.Drawing.Size(135, 20);
            this.BancoPersonaTextBox.TabIndex = 9;
            this.BancoPersonaTextBox.Click += new System.EventHandler(this.BancoPersonaTextBox_Click);
            // 
            // porDadorRadioButton
            // 
            this.porDadorRadioButton.AutoSize = true;
            this.porDadorRadioButton.Location = new System.Drawing.Point(74, 36);
            this.porDadorRadioButton.Name = "porDadorRadioButton";
            this.porDadorRadioButton.Size = new System.Drawing.Size(65, 17);
            this.porDadorRadioButton.TabIndex = 6;
            this.porDadorRadioButton.TabStop = true;
            this.porDadorRadioButton.Text = "Dadores";
            this.porDadorRadioButton.UseVisualStyleBackColor = true;
            // 
            // porCompatibilidadDonadorRadioButton
            // 
            this.porCompatibilidadDonadorRadioButton.AutoSize = true;
            this.porCompatibilidadDonadorRadioButton.Location = new System.Drawing.Point(142, 9);
            this.porCompatibilidadDonadorRadioButton.Name = "porCompatibilidadDonadorRadioButton";
            this.porCompatibilidadDonadorRadioButton.Size = new System.Drawing.Size(153, 17);
            this.porCompatibilidadDonadorRadioButton.TabIndex = 5;
            this.porCompatibilidadDonadorRadioButton.TabStop = true;
            this.porCompatibilidadDonadorRadioButton.Text = "Por compatibilidad donador";
            this.porCompatibilidadDonadorRadioButton.UseVisualStyleBackColor = true;
            // 
            // bancoBuscarButton
            // 
            this.bancoBuscarButton.Location = new System.Drawing.Point(614, 6);
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
            this.grupoSanguineoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoSanguineoComboBox.FormattingEnabled = true;
            this.grupoSanguineoComboBox.Location = new System.Drawing.Point(460, 8);
            this.grupoSanguineoComboBox.Name = "grupoSanguineoComboBox";
            this.grupoSanguineoComboBox.Size = new System.Drawing.Size(140, 21);
            this.grupoSanguineoComboBox.TabIndex = 1;
            // 
            // porGrupoSanguineoRadioButton
            // 
            this.porGrupoSanguineoRadioButton.AutoSize = true;
            this.porGrupoSanguineoRadioButton.Location = new System.Drawing.Point(13, 9);
            this.porGrupoSanguineoRadioButton.Name = "porGrupoSanguineoRadioButton";
            this.porGrupoSanguineoRadioButton.Size = new System.Drawing.Size(123, 17);
            this.porGrupoSanguineoRadioButton.TabIndex = 0;
            this.porGrupoSanguineoRadioButton.TabStop = true;
            this.porGrupoSanguineoRadioButton.Text = "Por grupo sanguineo";
            this.porGrupoSanguineoRadioButton.UseVisualStyleBackColor = true;
            // 
            // extraccionTabPage
            // 
            this.extraccionTabPage.AutoScroll = true;
            this.extraccionTabPage.Controls.Add(this.extraccionDataGridView);
            this.extraccionTabPage.Controls.Add(this.panel3);
            this.extraccionTabPage.Controls.Add(this.toolStrip1);
            this.extraccionTabPage.Location = new System.Drawing.Point(4, 22);
            this.extraccionTabPage.Name = "extraccionTabPage";
            this.extraccionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.extraccionTabPage.Size = new System.Drawing.Size(704, 407);
            this.extraccionTabPage.TabIndex = 2;
            this.extraccionTabPage.Text = "Extracciones";
            this.extraccionTabPage.UseVisualStyleBackColor = true;
            // 
            // extraccionDataGridView
            // 
            this.extraccionDataGridView.AllowUserToAddRows = false;
            this.extraccionDataGridView.AllowUserToDeleteRows = false;
            this.extraccionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extraccionDataGridView.AutoGenerateColumns = false;
            this.extraccionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extraccionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.extraccionDataGridView.DataSource = this.extraccionBindingSource;
            this.extraccionDataGridView.Location = new System.Drawing.Point(1, 68);
            this.extraccionDataGridView.Name = "extraccionDataGridView";
            this.extraccionDataGridView.ReadOnly = true;
            this.extraccionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.extraccionDataGridView.Size = new System.Drawing.Size(701, 337);
            this.extraccionDataGridView.TabIndex = 5;
            // 
            // extraccionBindingSource
            // 
            this.extraccionBindingSource.DataSource = typeof(Entidades.Extraccion);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.hastaDateTimePicker);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.fechaDesdeDateTimePicker);
            this.panel3.Controls.Add(this.porFechasRadioButton);
            this.panel3.Controls.Add(this.extraccionBuscarButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 39);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDateTimePicker.Location = new System.Drawing.Point(280, 8);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.hastaDateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde";
            // 
            // fechaDesdeDateTimePicker
            // 
            this.fechaDesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDesdeDateTimePicker.Location = new System.Drawing.Point(134, 8);
            this.fechaDesdeDateTimePicker.Name = "fechaDesdeDateTimePicker";
            this.fechaDesdeDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.fechaDesdeDateTimePicker.TabIndex = 5;
            // 
            // porFechasRadioButton
            // 
            this.porFechasRadioButton.AutoSize = true;
            this.porFechasRadioButton.Location = new System.Drawing.Point(13, 10);
            this.porFechasRadioButton.Name = "porFechasRadioButton";
            this.porFechasRadioButton.Size = new System.Drawing.Size(76, 17);
            this.porFechasRadioButton.TabIndex = 4;
            this.porFechasRadioButton.TabStop = true;
            this.porFechasRadioButton.Text = "Por fechas";
            this.porFechasRadioButton.UseVisualStyleBackColor = true;
            // 
            // extraccionBuscarButton
            // 
            this.extraccionBuscarButton.Location = new System.Drawing.Point(401, 7);
            this.extraccionBuscarButton.Name = "extraccionBuscarButton";
            this.extraccionBuscarButton.Size = new System.Drawing.Size(75, 23);
            this.extraccionBuscarButton.TabIndex = 3;
            this.extraccionBuscarButton.Text = "Buscar";
            this.extraccionBuscarButton.UseVisualStyleBackColor = true;
            this.extraccionBuscarButton.Click += new System.EventHandler(this.extraccionBuscarButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarExtraccionTSButton,
            this.modificarExtraccionTSButton,
            this.eliminarExtraccionTSButton,
            this.refrescarTStButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(698, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // agregarExtraccionTSButton
            // 
            this.agregarExtraccionTSButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarExtraccionTSButton.Image")));
            this.agregarExtraccionTSButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarExtraccionTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.agregarExtraccionTSButton.Name = "agregarExtraccionTSButton";
            this.agregarExtraccionTSButton.Size = new System.Drawing.Size(72, 22);
            this.agregarExtraccionTSButton.Text = "Agregar ";
            this.agregarExtraccionTSButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarExtraccionTSButton.Click += new System.EventHandler(this.agregarExtraccionTSButton_Click);
            // 
            // modificarExtraccionTSButton
            // 
            this.modificarExtraccionTSButton.Enabled = false;
            this.modificarExtraccionTSButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarExtraccionTSButton.Image")));
            this.modificarExtraccionTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modificarExtraccionTSButton.Name = "modificarExtraccionTSButton";
            this.modificarExtraccionTSButton.Size = new System.Drawing.Size(78, 22);
            this.modificarExtraccionTSButton.Text = "Modificar";
            // 
            // eliminarExtraccionTSButton
            // 
            this.eliminarExtraccionTSButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarExtraccionTSButton.Image")));
            this.eliminarExtraccionTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminarExtraccionTSButton.Name = "eliminarExtraccionTSButton";
            this.eliminarExtraccionTSButton.Size = new System.Drawing.Size(70, 22);
            this.eliminarExtraccionTSButton.Text = "Eliminar";
            this.eliminarExtraccionTSButton.Click += new System.EventHandler(this.eliminarExtraccionTSButton_Click);
            // 
            // refrescarTStButton
            // 
            this.refrescarTStButton.Image = ((System.Drawing.Image)(resources.GetObject("refrescarTStButton.Image")));
            this.refrescarTStButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refrescarTStButton.Name = "refrescarTStButton";
            this.refrescarTStButton.Size = new System.Drawing.Size(75, 22);
            this.refrescarTStButton.Text = "Refrescar";
            this.refrescarTStButton.Click += new System.EventHandler(this.refrescarTStButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dni";
            this.dataGridViewTextBoxColumn4.HeaderText = "Número documento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "Dni";
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // grupoSanguineoDataGridViewTextBoxColumn
            // 
            this.grupoSanguineoDataGridViewTextBoxColumn.DataPropertyName = "GrupoSanguineo";
            this.grupoSanguineoDataGridViewTextBoxColumn.HeaderText = "Grupo sanguineo";
            this.grupoSanguineoDataGridViewTextBoxColumn.Name = "grupoSanguineoDataGridViewTextBoxColumn";
            this.grupoSanguineoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Dador
            // 
            this.Dador.DataPropertyName = "Dador";
            this.Dador.HeaderText = "Dador";
            this.Dador.Name = "Dador";
            this.Dador.ReadOnly = true;
            // 
            // Receptor
            // 
            this.Receptor.DataPropertyName = "Receptor";
            this.Receptor.HeaderText = "Receptor";
            this.Receptor.Name = "Receptor";
            this.Receptor.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Persona";
            this.dataGridViewTextBoxColumn10.HeaderText = "Persona";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TipoAnalisis";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipo análisis";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Alergias";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Alergias";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DoctorSolicitante";
            this.dataGridViewTextBoxColumn8.HeaderText = "Doctor solicitante";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn9.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 438);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Sangre";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.personaTabPage.ResumeLayout(false);
            this.personaTabPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.bancoTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.extraccionTabPage.ResumeLayout(false);
            this.extraccionTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraccionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraccionBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage personaTabPage;
        private System.Windows.Forms.TabPage bancoTabPage;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton agregarToolStripButton;
        private System.Windows.Forms.ToolStripButton eliminarToolStripButton;
        private System.Windows.Forms.ToolStripButton refrescarToolStripButton;
        private System.Windows.Forms.DataGridView personaDataGridView;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.ToolStripButton limpiarToolStripButton;
        private System.Windows.Forms.DataGridView bancoDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox grupoSanguineoComboBox;
        private System.Windows.Forms.RadioButton porGrupoSanguineoRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox personaTextBox;
        private System.Windows.Forms.RadioButton porDniRadioButton;
        private System.Windows.Forms.RadioButton porNombreYApellidoRadioButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.RadioButton porCompatibilidadDonadorRadioButton;
        private System.Windows.Forms.Button bancoBuscarButton;
        private System.Windows.Forms.RadioButton PorReceptorRadioButton;
        private System.Windows.Forms.RadioButton porDadorRadioButton;
        private System.Windows.Forms.RadioButton PorPersonaRadioButton;
        private System.Windows.Forms.TextBox BancoPersonaTextBox;
        private System.Windows.Forms.RadioButton porCompatibilidadReceptorRadioButton;
        private System.Windows.Forms.ToolStripButton modificarToolStripButton;
        private System.Windows.Forms.RadioButton todasRadioButton;
        private System.Windows.Forms.RadioButton bancoTodasRadioButton;
        private System.Windows.Forms.TabPage extraccionTabPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton porFechasRadioButton;
        private System.Windows.Forms.Button extraccionBuscarButton;
        private System.Windows.Forms.DataGridView extraccionDataGridView;
        private System.Windows.Forms.BindingSource extraccionBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton agregarExtraccionTSButton;
        private System.Windows.Forms.ToolStripButton modificarExtraccionTSButton;
        private System.Windows.Forms.ToolStripButton eliminarExtraccionTSButton;
        private System.Windows.Forms.ToolStripButton refrescarTStButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaDesdeDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoSanguineoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Receptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}