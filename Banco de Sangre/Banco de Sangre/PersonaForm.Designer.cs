namespace Banco_de_Sangre
{
    partial class PersonaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label esDonanteLabel;
            System.Windows.Forms.Label factorRhLabel;
            System.Windows.Forms.Label grupoSanguineoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonaForm));
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.esDonanteCheckBox = new System.Windows.Forms.CheckBox();
            this.factorRhTextBox = new System.Windows.Forms.TextBox();
            this.grupoSanguineoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            apellidoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            esDonanteLabel = new System.Windows.Forms.Label();
            factorRhLabel = new System.Windows.Forms.Label();
            grupoSanguineoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(32, 46);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 0;
            apellidoLabel.Text = "Apellido:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(32, 102);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Direccion:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(32, 72);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(26, 13);
            dniLabel.TabIndex = 4;
            dniLabel.Text = "Dni:";
            // 
            // esDonanteLabel
            // 
            esDonanteLabel.AutoSize = true;
            esDonanteLabel.Location = new System.Drawing.Point(32, 208);
            esDonanteLabel.Name = "esDonanteLabel";
            esDonanteLabel.Size = new System.Drawing.Size(66, 13);
            esDonanteLabel.TabIndex = 6;
            esDonanteLabel.Text = "Es Donante:";
            // 
            // factorRhLabel
            // 
            factorRhLabel.AutoSize = true;
            factorRhLabel.Location = new System.Drawing.Point(32, 180);
            factorRhLabel.Name = "factorRhLabel";
            factorRhLabel.Size = new System.Drawing.Size(57, 13);
            factorRhLabel.TabIndex = 8;
            factorRhLabel.Text = "Factor Rh:";
            // 
            // grupoSanguineoLabel
            // 
            grupoSanguineoLabel.AutoSize = true;
            grupoSanguineoLabel.Location = new System.Drawing.Point(32, 154);
            grupoSanguineoLabel.Name = "grupoSanguineoLabel";
            grupoSanguineoLabel.Size = new System.Drawing.Size(93, 13);
            grupoSanguineoLabel.TabIndex = 10;
            grupoSanguineoLabel.Text = "Grupo Sanguineo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(32, 20);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(32, 128);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "Telefono:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(131, 43);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(104, 20);
            this.apellidoTextBox.TabIndex = 1;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Persona);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(131, 99);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(104, 20);
            this.direccionTextBox.TabIndex = 3;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(131, 69);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(104, 20);
            this.dniTextBox.TabIndex = 5;
            // 
            // esDonanteCheckBox
            // 
            this.esDonanteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personaBindingSource, "EsDonante", true));
            this.esDonanteCheckBox.Location = new System.Drawing.Point(131, 203);
            this.esDonanteCheckBox.Name = "esDonanteCheckBox";
            this.esDonanteCheckBox.Size = new System.Drawing.Size(104, 24);
            this.esDonanteCheckBox.TabIndex = 7;
            this.esDonanteCheckBox.UseVisualStyleBackColor = true;
            // 
            // factorRhTextBox
            // 
            this.factorRhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "FactorRh", true));
            this.factorRhTextBox.Location = new System.Drawing.Point(131, 177);
            this.factorRhTextBox.Name = "factorRhTextBox";
            this.factorRhTextBox.Size = new System.Drawing.Size(104, 20);
            this.factorRhTextBox.TabIndex = 9;
            // 
            // grupoSanguineoTextBox
            // 
            this.grupoSanguineoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "GrupoSanguineo", true));
            this.grupoSanguineoTextBox.Location = new System.Drawing.Point(131, 151);
            this.grupoSanguineoTextBox.Name = "grupoSanguineoTextBox";
            this.grupoSanguineoTextBox.Size = new System.Drawing.Size(104, 20);
            this.grupoSanguineoTextBox.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(131, 17);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreTextBox.TabIndex = 13;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(131, 125);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(104, 20);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(193, 238);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 16;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(274, 238);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 17;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // PersonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 268);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(esDonanteLabel);
            this.Controls.Add(this.esDonanteCheckBox);
            this.Controls.Add(factorRhLabel);
            this.Controls.Add(this.factorRhTextBox);
            this.Controls.Add(grupoSanguineoLabel);
            this.Controls.Add(this.grupoSanguineoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonaForm";
            this.Text = "Registro de Donantes";
            this.Load += new System.EventHandler(this.PersonaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.CheckBox esDonanteCheckBox;
        private System.Windows.Forms.TextBox factorRhTextBox;
        private System.Windows.Forms.TextBox grupoSanguineoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}

