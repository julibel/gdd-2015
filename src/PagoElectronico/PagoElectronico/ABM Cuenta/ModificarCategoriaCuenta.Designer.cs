namespace PagoElectronico.Consulta_Saldos
{
    partial class ModificarCategoriaCuenta
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
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.paner_TipoCuentas = new System.Windows.Forms.GroupBox();
            this.textBox_TipoCuentaActual = new System.Windows.Forms.TextBox();
            this.textBox_Moneda = new System.Windows.Forms.TextBox();
            this.label_TipoCuenta = new System.Windows.Forms.Label();
            this.label_Moneda = new System.Windows.Forms.Label();
            this.label_Pais = new System.Windows.Forms.Label();
            this.label_NumeroCuenta = new System.Windows.Forms.Label();
            this.textBox_NumeroCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_TipoCuentaModificada = new System.Windows.Forms.ComboBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.comboBox_Pais = new System.Windows.Forms.ComboBox();
            this.paner_TipoCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 426);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 32;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // paner_TipoCuentas
            // 
            this.paner_TipoCuentas.Controls.Add(this.comboBox_Pais);
            this.paner_TipoCuentas.Controls.Add(this.textBox_TipoCuentaActual);
            this.paner_TipoCuentas.Controls.Add(this.textBox_Moneda);
            this.paner_TipoCuentas.Controls.Add(this.label_TipoCuenta);
            this.paner_TipoCuentas.Controls.Add(this.label_Moneda);
            this.paner_TipoCuentas.Controls.Add(this.label_Pais);
            this.paner_TipoCuentas.Controls.Add(this.label_NumeroCuenta);
            this.paner_TipoCuentas.Controls.Add(this.textBox_NumeroCuenta);
            this.paner_TipoCuentas.Controls.Add(this.label1);
            this.paner_TipoCuentas.Controls.Add(this.comboBox_TipoCuentaModificada);
            this.paner_TipoCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_TipoCuentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_TipoCuentas.Location = new System.Drawing.Point(12, 12);
            this.paner_TipoCuentas.Name = "paner_TipoCuentas";
            this.paner_TipoCuentas.Size = new System.Drawing.Size(807, 408);
            this.paner_TipoCuentas.TabIndex = 33;
            this.paner_TipoCuentas.TabStop = false;
            this.paner_TipoCuentas.Text = "Modificacion de categoria de cuenta";
            // 
            // textBox_TipoCuentaActual
            // 
            this.textBox_TipoCuentaActual.Enabled = false;
            this.textBox_TipoCuentaActual.Location = new System.Drawing.Point(357, 220);
            this.textBox_TipoCuentaActual.Name = "textBox_TipoCuentaActual";
            this.textBox_TipoCuentaActual.Size = new System.Drawing.Size(121, 20);
            this.textBox_TipoCuentaActual.TabIndex = 33;
            // 
            // textBox_Moneda
            // 
            this.textBox_Moneda.Enabled = false;
            this.textBox_Moneda.Location = new System.Drawing.Point(357, 193);
            this.textBox_Moneda.Name = "textBox_Moneda";
            this.textBox_Moneda.Size = new System.Drawing.Size(121, 20);
            this.textBox_Moneda.TabIndex = 32;
            // 
            // label_TipoCuenta
            // 
            this.label_TipoCuenta.AutoSize = true;
            this.label_TipoCuenta.Location = new System.Drawing.Point(240, 223);
            this.label_TipoCuenta.Name = "label_TipoCuenta";
            this.label_TipoCuenta.Size = new System.Drawing.Size(111, 13);
            this.label_TipoCuenta.TabIndex = 29;
            this.label_TipoCuenta.Text = "Tipo de cuenta actual";
            // 
            // label_Moneda
            // 
            this.label_Moneda.AutoSize = true;
            this.label_Moneda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Moneda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Moneda.Location = new System.Drawing.Point(305, 196);
            this.label_Moneda.Name = "label_Moneda";
            this.label_Moneda.Size = new System.Drawing.Size(46, 13);
            this.label_Moneda.TabIndex = 26;
            this.label_Moneda.Text = "Moneda";
            // 
            // label_Pais
            // 
            this.label_Pais.AutoSize = true;
            this.label_Pais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Pais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Pais.Location = new System.Drawing.Point(324, 169);
            this.label_Pais.Name = "label_Pais";
            this.label_Pais.Size = new System.Drawing.Size(27, 13);
            this.label_Pais.TabIndex = 25;
            this.label_Pais.Text = "Pais";
            // 
            // label_NumeroCuenta
            // 
            this.label_NumeroCuenta.AutoSize = true;
            this.label_NumeroCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NumeroCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_NumeroCuenta.Location = new System.Drawing.Point(256, 143);
            this.label_NumeroCuenta.Name = "label_NumeroCuenta";
            this.label_NumeroCuenta.Size = new System.Drawing.Size(95, 13);
            this.label_NumeroCuenta.TabIndex = 24;
            this.label_NumeroCuenta.Text = "Numero de cuenta";
            // 
            // textBox_NumeroCuenta
            // 
            this.textBox_NumeroCuenta.Enabled = false;
            this.textBox_NumeroCuenta.Location = new System.Drawing.Point(357, 140);
            this.textBox_NumeroCuenta.MaxLength = 255;
            this.textBox_NumeroCuenta.Name = "textBox_NumeroCuenta";
            this.textBox_NumeroCuenta.Size = new System.Drawing.Size(232, 20);
            this.textBox_NumeroCuenta.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Cuenta modificada";
            // 
            // comboBox_TipoCuentaModificada
            // 
            this.comboBox_TipoCuentaModificada.FormattingEnabled = true;
            this.comboBox_TipoCuentaModificada.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBox_TipoCuentaModificada.Location = new System.Drawing.Point(357, 247);
            this.comboBox_TipoCuentaModificada.Name = "comboBox_TipoCuentaModificada";
            this.comboBox_TipoCuentaModificada.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipoCuentaModificada.TabIndex = 0;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(585, 426);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 31;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 30;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // comboBox_Pais
            // 
            this.comboBox_Pais.FormattingEnabled = true;
            this.comboBox_Pais.Items.AddRange(new object[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Ciudad del Vaticano",
            "Colombia",
            "Comoras",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guyana",
            "Guinea",
            "Guinea ecuatorial",
            "Guinea-Bisáu",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República de Macedonia",
            "República del Congo",
            "República Democrática del Congo",
            "República Dominicana",
            "República Sudafricana",
            "Ruanda",
            "Rumanía",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.comboBox_Pais.Location = new System.Drawing.Point(357, 166);
            this.comboBox_Pais.Name = "comboBox_Pais";
            this.comboBox_Pais.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Pais.TabIndex = 34;
            // 
            // ModificarCategoriaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.paner_TipoCuentas);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarCategoriaCuenta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCategoriaCuenta";
            this.paner_TipoCuentas.ResumeLayout(false);
            this.paner_TipoCuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.GroupBox paner_TipoCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_TipoCuentaModificada;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Label label_TipoCuenta;
        private System.Windows.Forms.Label label_Moneda;
        private System.Windows.Forms.Label label_Pais;
        private System.Windows.Forms.Label label_NumeroCuenta;
        private System.Windows.Forms.TextBox textBox_NumeroCuenta;
        private System.Windows.Forms.TextBox textBox_TipoCuentaActual;
        private System.Windows.Forms.TextBox textBox_Moneda;
        private System.Windows.Forms.ComboBox comboBox_Pais;

    }
}