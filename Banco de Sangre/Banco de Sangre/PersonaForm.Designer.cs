using Entidades;

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
            System.Windows.Forms.Label dadorLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label receptorLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonaForm));
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.grupoSanguineoComboBox = new System.Windows.Forms.ComboBox();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.dadorCheckBox = new System.Windows.Forms.CheckBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.receptorCheckBox = new System.Windows.Forms.CheckBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            apellidoLabel = new System.Windows.Forms.Label();
            dadorLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            receptorLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(26, 15);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 26;
            apellidoLabel.Text = "Apellido:";
            // 
            // dadorLabel
            // 
            dadorLabel.AutoSize = true;
            dadorLabel.Location = new System.Drawing.Point(26, 198);
            dadorLabel.Name = "dadorLabel";
            dadorLabel.Size = new System.Drawing.Size(39, 13);
            dadorLabel.TabIndex = 28;
            dadorLabel.Text = "Dador:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(26, 93);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 30;
            direccionLabel.Text = "Direccion:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(26, 67);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(26, 13);
            dniLabel.TabIndex = 32;
            dniLabel.Text = "Dni:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 41);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 38;
            nombreLabel.Text = "Nombre:";
            // 
            // receptorLabel
            // 
            receptorLabel.AutoSize = true;
            receptorLabel.Location = new System.Drawing.Point(26, 174);
            receptorLabel.Name = "receptorLabel";
            receptorLabel.Size = new System.Drawing.Size(54, 13);
            receptorLabel.TabIndex = 40;
            receptorLabel.Text = "Receptor:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(26, 119);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 42;
            telefonoLabel.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 145);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 13);
            label1.TabIndex = 44;
            label1.Text = "Grupo Sanguineo:";
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(125, 227);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 8;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(206, 227);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 9;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // grupoSanguineoComboBox
            // 
            this.grupoSanguineoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.personaBindingSource, "GrupoSanguineo", true));
            this.grupoSanguineoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grupoSanguineoComboBox.FormattingEnabled = true;
            this.grupoSanguineoComboBox.Location = new System.Drawing.Point(142, 142);
            this.grupoSanguineoComboBox.Name = "grupoSanguineoComboBox";
            this.grupoSanguineoComboBox.Size = new System.Drawing.Size(104, 21);
            this.grupoSanguineoComboBox.TabIndex = 5;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Entidades.Persona);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(142, 12);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(104, 20);
            this.apellidoTextBox.TabIndex = 0;
            // 
            // dadorCheckBox
            // 
            this.dadorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personaBindingSource, "Dador", true));
            this.dadorCheckBox.Location = new System.Drawing.Point(142, 193);
            this.dadorCheckBox.Name = "dadorCheckBox";
            this.dadorCheckBox.Size = new System.Drawing.Size(15, 24);
            this.dadorCheckBox.TabIndex = 7;
            this.dadorCheckBox.UseVisualStyleBackColor = true;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(142, 90);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(104, 20);
            this.direccionTextBox.TabIndex = 3;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(142, 64);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(104, 20);
            this.dniTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(142, 38);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // receptorCheckBox
            // 
            this.receptorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personaBindingSource, "Receptor", true));
            this.receptorCheckBox.Location = new System.Drawing.Point(142, 169);
            this.receptorCheckBox.Name = "receptorCheckBox";
            this.receptorCheckBox.Size = new System.Drawing.Size(19, 24);
            this.receptorCheckBox.TabIndex = 6;
            this.receptorCheckBox.UseVisualStyleBackColor = true;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(142, 116);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(104, 20);
            this.telefonoTextBox.TabIndex = 4;
            // 
            // PersonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 262);
            this.Controls.Add(label1);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(dniLabel);
            this.Controls.Add(dadorLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(receptorLabel);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.grupoSanguineoComboBox);
            this.Controls.Add(this.receptorCheckBox);
            this.Controls.Add(this.dadorCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Donantes";
            this.Load += new System.EventHandler(this.PersonaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.ComboBox grupoSanguineoComboBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.CheckBox dadorCheckBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.CheckBox receptorCheckBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
    }
}

