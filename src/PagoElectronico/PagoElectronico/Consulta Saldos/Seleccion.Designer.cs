namespace PagoElectronico.Consulta_Saldos
{
    partial class Seleccion
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
            this.paner_Filtros = new System.Windows.Forms.GroupBox();
            this.comboBox_TipoCuenta = new System.Windows.Forms.ComboBox();
            this.label_TipoCuenta = new System.Windows.Forms.Label();
            this.label_Pais = new System.Windows.Forms.Label();
            this.label_NumeroCuenta = new System.Windows.Forms.Label();
            this.textBox_NumeroCuenta = new System.Windows.Forms.TextBox();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.dataGridView_Seleccion = new System.Windows.Forms.DataGridView();
            this.comboBox_Pais = new System.Windows.Forms.ComboBox();
            this.paner_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // paner_Filtros
            // 
            this.paner_Filtros.Controls.Add(this.comboBox_Pais);
            this.paner_Filtros.Controls.Add(this.comboBox_TipoCuenta);
            this.paner_Filtros.Controls.Add(this.label_TipoCuenta);
            this.paner_Filtros.Controls.Add(this.label_Pais);
            this.paner_Filtros.Controls.Add(this.label_NumeroCuenta);
            this.paner_Filtros.Controls.Add(this.textBox_NumeroCuenta);
            this.paner_Filtros.Controls.Add(this.button_Buscar);
            this.paner_Filtros.Controls.Add(this.button_Limpiar);
            this.paner_Filtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Filtros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_Filtros.Location = new System.Drawing.Point(12, 12);
            this.paner_Filtros.Name = "paner_Filtros";
            this.paner_Filtros.Size = new System.Drawing.Size(810, 163);
            this.paner_Filtros.TabIndex = 37;
            this.paner_Filtros.TabStop = false;
            this.paner_Filtros.Text = "Filtros de busqueda";
            // 
            // comboBox_TipoCuenta
            // 
            this.comboBox_TipoCuenta.FormattingEnabled = true;
            this.comboBox_TipoCuenta.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBox_TipoCuenta.Location = new System.Drawing.Point(340, 97);
            this.comboBox_TipoCuenta.Name = "comboBox_TipoCuenta";
            this.comboBox_TipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipoCuenta.TabIndex = 30;
            // 
            // label_TipoCuenta
            // 
            this.label_TipoCuenta.AutoSize = true;
            this.label_TipoCuenta.Location = new System.Drawing.Point(255, 100);
            this.label_TipoCuenta.Name = "label_TipoCuenta";
            this.label_TipoCuenta.Size = new System.Drawing.Size(79, 13);
            this.label_TipoCuenta.TabIndex = 29;
            this.label_TipoCuenta.Text = "Tipo de cuenta";
            // 
            // label_Pais
            // 
            this.label_Pais.AutoSize = true;
            this.label_Pais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Pais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Pais.Location = new System.Drawing.Point(307, 74);
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
            this.label_NumeroCuenta.Location = new System.Drawing.Point(239, 48);
            this.label_NumeroCuenta.Name = "label_NumeroCuenta";
            this.label_NumeroCuenta.Size = new System.Drawing.Size(95, 13);
            this.label_NumeroCuenta.TabIndex = 24;
            this.label_NumeroCuenta.Text = "Numero de cuenta";
            // 
            // textBox_NumeroCuenta
            // 
            this.textBox_NumeroCuenta.Location = new System.Drawing.Point(340, 45);
            this.textBox_NumeroCuenta.MaxLength = 255;
            this.textBox_NumeroCuenta.Name = "textBox_NumeroCuenta";
            this.textBox_NumeroCuenta.Size = new System.Drawing.Size(232, 20);
            this.textBox_NumeroCuenta.TabIndex = 23;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(715, 125);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 14;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(634, 125);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 13;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 39;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // dataGridView_Seleccion
            // 
            this.dataGridView_Seleccion.AllowUserToAddRows = false;
            this.dataGridView_Seleccion.AllowUserToDeleteRows = false;
            this.dataGridView_Seleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Seleccion.Location = new System.Drawing.Point(12, 190);
            this.dataGridView_Seleccion.Name = "dataGridView_Seleccion";
            this.dataGridView_Seleccion.Size = new System.Drawing.Size(810, 230);
            this.dataGridView_Seleccion.TabIndex = 38;
            // 
            // comboBox_Pais
            // 
            this.comboBox_Pais.FormattingEnabled = true;
            this.comboBox_Pais.Items.AddRange(new object[] {
            "",
            "",
            "Afganistán",
            "",
            "",
            "Albania",
            "",
            "",
            "Alemania",
            "",
            "",
            "Andorra",
            "",
            "",
            "Angola",
            "",
            "",
            "Antigua y Barbuda",
            "",
            "",
            "Arabia Saudita",
            "",
            "",
            "Argelia",
            "",
            "",
            "Argentina",
            "",
            "",
            "Armenia",
            "",
            "",
            "Australia",
            "",
            "",
            "Austria",
            "",
            "",
            "Azerbaiyán",
            "",
            "",
            "Bahamas",
            "",
            "",
            "Bangladés",
            "",
            "",
            "Barbados",
            "",
            "",
            "Baréin",
            "",
            "",
            "Bélgica",
            "",
            "",
            "Belice",
            "",
            "",
            "Benín",
            "",
            "",
            "Bielorrusia",
            "",
            "",
            "Birmania",
            "",
            "",
            "Bolivia",
            "",
            "",
            "Bosnia y Herzegovina",
            "",
            "",
            "Botsuana",
            "",
            "",
            "Brasil",
            "",
            "",
            "Brunéi",
            "",
            "",
            "Bulgaria",
            "",
            "",
            "Burkina Faso",
            "",
            "",
            "Burundi",
            "",
            "",
            "Bután",
            "",
            "",
            "Cabo Verde",
            "",
            "",
            "Camboya",
            "",
            "",
            "Camerún",
            "",
            "",
            "Canadá",
            "",
            "",
            "Catar",
            "",
            "",
            "Chad",
            "",
            "",
            "Chile",
            "",
            "",
            "China",
            "",
            "",
            "Chipre",
            "",
            "",
            "Ciudad del Vaticano",
            "",
            "",
            "Colombia",
            "",
            "",
            "Comoras",
            "",
            "",
            "Corea del Norte",
            "",
            "",
            "Corea del Sur",
            "",
            "",
            "Costa de Marfil",
            "",
            "",
            "Costa Rica",
            "",
            "",
            "Croacia",
            "",
            "",
            "Cuba",
            "",
            "",
            "Dinamarca",
            "",
            "",
            "Dominica",
            "",
            "",
            "Ecuador",
            "",
            "",
            "Egipto",
            "",
            "",
            "El Salvador",
            "",
            "",
            "Emiratos Árabes Unidos",
            "",
            "",
            "Eritrea",
            "",
            "",
            "Eslovaquia",
            "",
            "",
            "Eslovenia",
            "",
            "",
            "España",
            "",
            "",
            "Estados Unidos",
            "",
            "",
            "Estonia",
            "",
            "",
            "Etiopía",
            "",
            "",
            "Filipinas",
            "",
            "",
            "Finlandia",
            "",
            "",
            "Fiyi",
            "",
            "",
            "Francia",
            "",
            "",
            "Gabón",
            "",
            "",
            "Gambia",
            "",
            "",
            "Georgia",
            "",
            "",
            "Ghana",
            "",
            "",
            "Granada",
            "",
            "",
            "Grecia",
            "",
            "",
            "Guatemala",
            "",
            "",
            "Guyana",
            "",
            "",
            "Guinea",
            "",
            "",
            "Guinea ecuatorial",
            "",
            "",
            "Guinea-Bisáu",
            "",
            "",
            "Haití",
            "",
            "",
            "Honduras",
            "",
            "",
            "Hungría",
            "",
            "",
            "India",
            "",
            "",
            "Indonesia",
            "",
            "",
            "Irak",
            "",
            "",
            "Irán",
            "",
            "",
            "Irlanda",
            "",
            "",
            "Islandia",
            "",
            "",
            "Islas Marshall",
            "",
            "",
            "Islas Salomón",
            "",
            "",
            "Israel",
            "",
            "",
            "Italia",
            "",
            "",
            "Jamaica",
            "",
            "",
            "Japón",
            "",
            "",
            "Jordania",
            "",
            "",
            "Kazajistán",
            "",
            "",
            "Kenia",
            "",
            "",
            "Kirguistán",
            "",
            "",
            "Kiribati",
            "",
            "",
            "Kuwait",
            "",
            "",
            "Laos",
            "",
            "",
            "Lesoto",
            "",
            "",
            "Letonia",
            "",
            "",
            "Líbano",
            "",
            "",
            "Liberia",
            "",
            "",
            "Libia",
            "",
            "",
            "Liechtenstein",
            "",
            "",
            "Lituania",
            "",
            "",
            "Luxemburgo",
            "",
            "",
            "Madagascar",
            "",
            "",
            "Malasia",
            "",
            "",
            "Malaui",
            "",
            "",
            "Maldivas",
            "",
            "",
            "Malí",
            "",
            "",
            "Malta",
            "",
            "",
            "Marruecos",
            "",
            "",
            "Mauricio",
            "",
            "",
            "Mauritania",
            "",
            "",
            "México",
            "",
            "",
            "Micronesia",
            "",
            "",
            "Moldavia",
            "",
            "",
            "Mónaco",
            "",
            "",
            "Mongolia",
            "",
            "",
            "Montenegro",
            "",
            "",
            "Mozambique",
            "",
            "",
            "Namibia",
            "",
            "",
            "Nauru",
            "",
            "",
            "Nepal",
            "",
            "",
            "Nicaragua",
            "",
            "",
            "Níger",
            "",
            "",
            "Nigeria",
            "",
            "",
            "Noruega",
            "",
            "",
            "Nueva Zelanda",
            "",
            "",
            "Omán",
            "",
            "",
            "Países Bajos",
            "",
            "",
            "Pakistán",
            "",
            "",
            "Palaos",
            "",
            "",
            "Panamá",
            "",
            "",
            "Papúa Nueva Guinea",
            "",
            "",
            "Paraguay",
            "",
            "",
            "Perú",
            "",
            "",
            "Polonia",
            "",
            "",
            "Portugal",
            "",
            "",
            "Reino Unido",
            "",
            "",
            "República Centroafricana",
            "",
            "",
            "República Checa",
            "",
            "",
            "República de Macedonia",
            "",
            "",
            "República del Congo",
            "",
            "",
            "República Democrática del Congo",
            "",
            "",
            "República Dominicana",
            "",
            "",
            "República Sudafricana",
            "",
            "",
            "Ruanda",
            "",
            "",
            "Rumanía",
            "",
            "",
            "Rusia",
            "",
            "",
            "Samoa",
            "",
            "",
            "San Cristóbal y Nieves",
            "",
            "",
            "San Marino",
            "",
            "",
            "San Vicente y las Granadinas",
            "",
            "",
            "Santa Lucía",
            "",
            "",
            "Santo Tomé y Príncipe",
            "",
            "",
            "Senegal",
            "",
            "",
            "Serbia",
            "",
            "",
            "Seychelles",
            "",
            "",
            "Sierra Leona",
            "",
            "",
            "Singapur",
            "",
            "",
            "Siria",
            "",
            "",
            "Somalia",
            "",
            "",
            "Sri Lanka",
            "",
            "",
            "Suazilandia",
            "",
            "",
            "Sudán",
            "",
            "",
            "Sudán del Sur",
            "",
            "",
            "Suecia",
            "",
            "",
            "Suiza",
            "",
            "",
            "Surinam",
            "",
            "",
            "Tailandia",
            "",
            "",
            "Tanzania",
            "",
            "",
            "Tayikistán",
            "",
            "",
            "Timor Oriental",
            "",
            "",
            "Togo",
            "",
            "",
            "Tonga",
            "",
            "",
            "Trinidad y Tobago",
            "",
            "",
            "Túnez",
            "",
            "",
            "Turkmenistán",
            "",
            "",
            "Turquía",
            "",
            "",
            "Tuvalu",
            "",
            "",
            "Ucrania",
            "",
            "",
            "Uganda",
            "",
            "",
            "Uruguay",
            "",
            "",
            "Uzbekistán",
            "",
            "",
            "Vanuatu",
            "",
            "",
            "Venezuela",
            "",
            "",
            "Vietnam",
            "",
            "",
            "Yemen",
            "",
            "",
            "Yibuti",
            "",
            "",
            "Zambia",
            "",
            "",
            "Zimbabue"});
            this.comboBox_Pais.Location = new System.Drawing.Point(340, 70);
            this.comboBox_Pais.Name = "comboBox_Pais";
            this.comboBox_Pais.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Pais.TabIndex = 31;
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.paner_Filtros);
            this.Controls.Add(this.dataGridView_Seleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleccion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.paner_Filtros.ResumeLayout(false);
            this.paner_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seleccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox paner_Filtros;
        private System.Windows.Forms.ComboBox comboBox_TipoCuenta;
        private System.Windows.Forms.Label label_TipoCuenta;
        private System.Windows.Forms.Label label_Pais;
        private System.Windows.Forms.Label label_NumeroCuenta;
        private System.Windows.Forms.TextBox textBox_NumeroCuenta;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.DataGridView dataGridView_Seleccion;
        private System.Windows.Forms.ComboBox comboBox_Pais;
    }
}