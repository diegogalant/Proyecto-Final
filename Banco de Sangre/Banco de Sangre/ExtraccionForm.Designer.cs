namespace Banco_de_Sangre
{
    partial class ExtraccionForm
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
            System.Windows.Forms.Label alergiasLabel;
            System.Windows.Forms.Label tipoAnalisisLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label personaLabelS;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label doctorSolicitanteLabel;
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.doctorSolicitanteTextBox = new System.Windows.Forms.TextBox();
            this.alergiasCheckBox = new System.Windows.Forms.CheckBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.tiposAnalisisComboBox = new System.Windows.Forms.ComboBox();
            this.personaCombobox = new System.Windows.Forms.ComboBox();
            this.extraccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            alergiasLabel = new System.Windows.Forms.Label();
            tipoAnalisisLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            personaLabelS = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            doctorSolicitanteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.extraccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alergiasLabel
            // 
            alergiasLabel.AutoSize = true;
            alergiasLabel.Location = new System.Drawing.Point(17, 92);
            alergiasLabel.Name = "alergiasLabel";
            alergiasLabel.Size = new System.Drawing.Size(47, 13);
            alergiasLabel.TabIndex = 1;
            alergiasLabel.Text = "Alergias:";
            // 
            // tipoAnalisisLabel
            // 
            tipoAnalisisLabel.AutoSize = true;
            tipoAnalisisLabel.Location = new System.Drawing.Point(15, 65);
            tipoAnalisisLabel.Name = "tipoAnalisisLabel";
            tipoAnalisisLabel.Size = new System.Drawing.Size(69, 13);
            tipoAnalisisLabel.TabIndex = 11;
            tipoAnalisisLabel.Text = "Tipo Analisis:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(15, 144);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 9;
            notasLabel.Text = "Notas:";
            // 
            // personaLabelS
            // 
            personaLabelS.AutoSize = true;
            personaLabelS.Location = new System.Drawing.Point(15, 9);
            personaLabelS.Name = "personaLabelS";
            personaLabelS.Size = new System.Drawing.Size(49, 13);
            personaLabelS.TabIndex = 7;
            personaLabelS.Text = "Persona:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(17, 39);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // doctorSolicitanteLabel
            // 
            doctorSolicitanteLabel.AutoSize = true;
            doctorSolicitanteLabel.Location = new System.Drawing.Point(15, 118);
            doctorSolicitanteLabel.Name = "doctorSolicitanteLabel";
            doctorSolicitanteLabel.Size = new System.Drawing.Size(94, 13);
            doctorSolicitanteLabel.TabIndex = 3;
            doctorSolicitanteLabel.Text = "Doctor Solicitante:";
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extraccionBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(118, 141);
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(200, 20);
            this.notasTextBox.TabIndex = 5;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.extraccionBindingSource, "Fecha", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(118, 33);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.fechaDateTimePicker.TabIndex = 1;
            // 
            // doctorSolicitanteTextBox
            // 
            this.doctorSolicitanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extraccionBindingSource, "DoctorSolicitante", true));
            this.doctorSolicitanteTextBox.Location = new System.Drawing.Point(118, 115);
            this.doctorSolicitanteTextBox.Name = "doctorSolicitanteTextBox";
            this.doctorSolicitanteTextBox.Size = new System.Drawing.Size(200, 20);
            this.doctorSolicitanteTextBox.TabIndex = 4;
            // 
            // alergiasCheckBox
            // 
            this.alergiasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.extraccionBindingSource, "Alergias", true));
            this.alergiasCheckBox.Location = new System.Drawing.Point(118, 87);
            this.alergiasCheckBox.Name = "alergiasCheckBox";
            this.alergiasCheckBox.Size = new System.Drawing.Size(200, 24);
            this.alergiasCheckBox.TabIndex = 3;
            this.alergiasCheckBox.UseVisualStyleBackColor = true;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(177, 173);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 6;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(258, 173);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // tiposAnalisisComboBox
            // 
            this.tiposAnalisisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extraccionBindingSource, "TipoAnalisis", true));
            this.tiposAnalisisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiposAnalisisComboBox.FormattingEnabled = true;
            this.tiposAnalisisComboBox.Location = new System.Drawing.Point(118, 61);
            this.tiposAnalisisComboBox.Name = "tiposAnalisisComboBox";
            this.tiposAnalisisComboBox.Size = new System.Drawing.Size(200, 21);
            this.tiposAnalisisComboBox.TabIndex = 12;
            // 
            // personaCombobox
            // 
            this.personaCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personaCombobox.FormattingEnabled = true;
            this.personaCombobox.Location = new System.Drawing.Point(118, 6);
            this.personaCombobox.Name = "personaCombobox";
            this.personaCombobox.Size = new System.Drawing.Size(200, 21);
            this.personaCombobox.TabIndex = 13;
            // 
            // extraccionBindingSource
            // 
            this.extraccionBindingSource.DataSource = typeof(Entidades.Extraccion);
            // 
            // ExtraccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 202);
            this.Controls.Add(this.personaCombobox);
            this.Controls.Add(this.tiposAnalisisComboBox);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(alergiasLabel);
            this.Controls.Add(this.alergiasCheckBox);
            this.Controls.Add(doctorSolicitanteLabel);
            this.Controls.Add(this.doctorSolicitanteTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(personaLabelS);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(tipoAnalisisLabel);
            this.Name = "ExtraccionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de extracciones";
            this.Load += new System.EventHandler(this.ExtraccionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.extraccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource extraccionBindingSource;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox doctorSolicitanteTextBox;
        private System.Windows.Forms.CheckBox alergiasCheckBox;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.ComboBox tiposAnalisisComboBox;
        private System.Windows.Forms.ComboBox personaCombobox;
    }
}