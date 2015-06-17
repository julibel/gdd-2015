namespace PagoElectronico.ABM_Cliente
{
    partial class Modificacion
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
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.label_Documento = new System.Windows.Forms.Label();
            this.label_TipoDocumento = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_Domicilio = new System.Windows.Forms.Label();
            this.label_Pais = new System.Windows.Forms.Label();
            this.label_FechaNacimiento = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Calle = new System.Windows.Forms.TextBox();
            this.textBox_Documento = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.dateTimePicker_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label_Piso = new System.Windows.Forms.Label();
            this.textBox_Piso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Depto = new System.Windows.Forms.TextBox();
            this.label_Localidad = new System.Windows.Forms.Label();
            this.textBox_Localidad = new System.Windows.Forms.TextBox();
            this.label_Nacionalidad = new System.Windows.Forms.Label();
            this.comboBox_Pais = new System.Windows.Forms.ComboBox();
            this.comboBox_Tipo_doc = new System.Windows.Forms.ComboBox();
            this.groupBox_AsociarTarjetas = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_numeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_codigo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Emisor = new System.Windows.Forms.ComboBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.dataGridView_Tarjetas = new System.Windows.Forms.DataGridView();
            this.paner_Alta = new System.Windows.Forms.GroupBox();
            this.comboBox_Nacionalidad = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ult_Digitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_AsociarTarjetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tarjetas)).BeginInit();
            this.paner_Alta.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(661, 428);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 31;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(580, 428);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 30;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(742, 428);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 28;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(136, 67);
            this.textBox_Nombre.MaxLength = 255;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(88, 70);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Apellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Apellido.Location = new System.Drawing.Point(88, 96);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label_Apellido.TabIndex = 2;
            this.label_Apellido.Text = "Apellido";
            // 
            // label_Documento
            // 
            this.label_Documento.AutoSize = true;
            this.label_Documento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Documento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Documento.Location = new System.Drawing.Point(70, 145);
            this.label_Documento.Name = "label_Documento";
            this.label_Documento.Size = new System.Drawing.Size(62, 13);
            this.label_Documento.TabIndex = 3;
            this.label_Documento.Text = "Documento";
            // 
            // label_TipoDocumento
            // 
            this.label_TipoDocumento.AutoSize = true;
            this.label_TipoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TipoDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_TipoDocumento.Location = new System.Drawing.Point(33, 121);
            this.label_TipoDocumento.Name = "label_TipoDocumento";
            this.label_TipoDocumento.Size = new System.Drawing.Size(99, 13);
            this.label_TipoDocumento.TabIndex = 4;
            this.label_TipoDocumento.Text = "Tipo de documento";
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Mail.Location = new System.Drawing.Point(97, 171);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(33, 13);
            this.label_Mail.TabIndex = 5;
            this.label_Mail.Text = "EMail";
            // 
            // label_Domicilio
            // 
            this.label_Domicilio.AutoSize = true;
            this.label_Domicilio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Domicilio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Domicilio.Location = new System.Drawing.Point(100, 197);
            this.label_Domicilio.Name = "label_Domicilio";
            this.label_Domicilio.Size = new System.Drawing.Size(30, 13);
            this.label_Domicilio.TabIndex = 7;
            this.label_Domicilio.Text = "Calle";
            // 
            // label_Pais
            // 
            this.label_Pais.AutoSize = true;
            this.label_Pais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Pais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Pais.Location = new System.Drawing.Point(37, 275);
            this.label_Pais.Name = "label_Pais";
            this.label_Pais.Size = new System.Drawing.Size(93, 13);
            this.label_Pais.TabIndex = 8;
            this.label_Pais.Text = "Pais de residencia";
            // 
            // label_FechaNacimiento
            // 
            this.label_FechaNacimiento.AutoSize = true;
            this.label_FechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_FechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_FechaNacimiento.Location = new System.Drawing.Point(24, 326);
            this.label_FechaNacimiento.Name = "label_FechaNacimiento";
            this.label_FechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.label_FechaNacimiento.TabIndex = 9;
            this.label_FechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(136, 93);
            this.textBox_Apellido.MaxLength = 255;
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(232, 20);
            this.textBox_Apellido.TabIndex = 10;
            // 
            // textBox_Calle
            // 
            this.textBox_Calle.Location = new System.Drawing.Point(136, 194);
            this.textBox_Calle.MaxLength = 255;
            this.textBox_Calle.Name = "textBox_Calle";
            this.textBox_Calle.Size = new System.Drawing.Size(232, 20);
            this.textBox_Calle.TabIndex = 11;
            // 
            // textBox_Documento
            // 
            this.textBox_Documento.Location = new System.Drawing.Point(136, 142);
            this.textBox_Documento.MaxLength = 18;
            this.textBox_Documento.Name = "textBox_Documento";
            this.textBox_Documento.Size = new System.Drawing.Size(129, 20);
            this.textBox_Documento.TabIndex = 13;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(136, 168);
            this.textBox_Mail.MaxLength = 255;
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(232, 20);
            this.textBox_Mail.TabIndex = 20;
            // 
            // dateTimePicker_FechaNacimiento
            // 
            this.dateTimePicker_FechaNacimiento.Location = new System.Drawing.Point(136, 324);
            this.dateTimePicker_FechaNacimiento.Name = "dateTimePicker_FechaNacimiento";
            this.dateTimePicker_FechaNacimiento.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker_FechaNacimiento.TabIndex = 21;
            // 
            // label_Piso
            // 
            this.label_Piso.AutoSize = true;
            this.label_Piso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Piso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Piso.Location = new System.Drawing.Point(103, 223);
            this.label_Piso.Name = "label_Piso";
            this.label_Piso.Size = new System.Drawing.Size(27, 13);
            this.label_Piso.TabIndex = 22;
            this.label_Piso.Text = "Piso";
            // 
            // textBox_Piso
            // 
            this.textBox_Piso.Location = new System.Drawing.Point(136, 220);
            this.textBox_Piso.MaxLength = 50;
            this.textBox_Piso.Name = "textBox_Piso";
            this.textBox_Piso.Size = new System.Drawing.Size(90, 20);
            this.textBox_Piso.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(232, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Depto";
            // 
            // textBox_Depto
            // 
            this.textBox_Depto.Location = new System.Drawing.Point(274, 220);
            this.textBox_Depto.MaxLength = 50;
            this.textBox_Depto.Name = "textBox_Depto";
            this.textBox_Depto.Size = new System.Drawing.Size(94, 20);
            this.textBox_Depto.TabIndex = 25;
            // 
            // label_Localidad
            // 
            this.label_Localidad.AutoSize = true;
            this.label_Localidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Localidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Localidad.Location = new System.Drawing.Point(77, 249);
            this.label_Localidad.Name = "label_Localidad";
            this.label_Localidad.Size = new System.Drawing.Size(53, 13);
            this.label_Localidad.TabIndex = 26;
            this.label_Localidad.Text = "Localidad";
            // 
            // textBox_Localidad
            // 
            this.textBox_Localidad.Location = new System.Drawing.Point(136, 246);
            this.textBox_Localidad.MaxLength = 50;
            this.textBox_Localidad.Name = "textBox_Localidad";
            this.textBox_Localidad.Size = new System.Drawing.Size(232, 20);
            this.textBox_Localidad.TabIndex = 27;
            // 
            // label_Nacionalidad
            // 
            this.label_Nacionalidad.AutoSize = true;
            this.label_Nacionalidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nacionalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nacionalidad.Location = new System.Drawing.Point(61, 301);
            this.label_Nacionalidad.Name = "label_Nacionalidad";
            this.label_Nacionalidad.Size = new System.Drawing.Size(69, 13);
            this.label_Nacionalidad.TabIndex = 28;
            this.label_Nacionalidad.Text = "Nacionalidad";
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
            this.comboBox_Pais.Location = new System.Drawing.Point(136, 271);
            this.comboBox_Pais.Name = "comboBox_Pais";
            this.comboBox_Pais.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Pais.TabIndex = 33;
            // 
            // comboBox_Tipo_doc
            // 
            this.comboBox_Tipo_doc.FormattingEnabled = true;
            this.comboBox_Tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "CI",
            "LC",
            "LE",
            "PAS"});
            this.comboBox_Tipo_doc.Location = new System.Drawing.Point(136, 118);
            this.comboBox_Tipo_doc.Name = "comboBox_Tipo_doc";
            this.comboBox_Tipo_doc.Size = new System.Drawing.Size(129, 21);
            this.comboBox_Tipo_doc.TabIndex = 35;
            // 
            // groupBox_AsociarTarjetas
            // 
            this.groupBox_AsociarTarjetas.Controls.Add(this.maskedTextBox_numeroTarjeta);
            this.groupBox_AsociarTarjetas.Controls.Add(this.maskedTextBox_codigo);
            this.groupBox_AsociarTarjetas.Controls.Add(this.label5);
            this.groupBox_AsociarTarjetas.Controls.Add(this.label3);
            this.groupBox_AsociarTarjetas.Controls.Add(this.label6);
            this.groupBox_AsociarTarjetas.Controls.Add(this.comboBox_Emisor);
            this.groupBox_AsociarTarjetas.Controls.Add(this.button_Agregar);
            this.groupBox_AsociarTarjetas.Controls.Add(this.dataGridView_Tarjetas);
            this.groupBox_AsociarTarjetas.Location = new System.Drawing.Point(413, 12);
            this.groupBox_AsociarTarjetas.Name = "groupBox_AsociarTarjetas";
            this.groupBox_AsociarTarjetas.Size = new System.Drawing.Size(435, 410);
            this.groupBox_AsociarTarjetas.TabIndex = 28;
            this.groupBox_AsociarTarjetas.TabStop = false;
            this.groupBox_AsociarTarjetas.Text = "Asociar tarjetas de credito";
            // 
            // maskedTextBox_numeroTarjeta
            // 
            this.maskedTextBox_numeroTarjeta.Location = new System.Drawing.Point(34, 279);
            this.maskedTextBox_numeroTarjeta.Mask = "9999999999999999";
            this.maskedTextBox_numeroTarjeta.Name = "maskedTextBox_numeroTarjeta";
            this.maskedTextBox_numeroTarjeta.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBox_numeroTarjeta.TabIndex = 61;
            // 
            // maskedTextBox_codigo
            // 
            this.maskedTextBox_codigo.Location = new System.Drawing.Point(34, 319);
            this.maskedTextBox_codigo.Mask = "999";
            this.maskedTextBox_codigo.Name = "maskedTextBox_codigo";
            this.maskedTextBox_codigo.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBox_codigo.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Codigo de Seguridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Numero de tarjeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Emisor";
            // 
            // comboBox_Emisor
            // 
            this.comboBox_Emisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Emisor.FormattingEnabled = true;
            this.comboBox_Emisor.Items.AddRange(new object[] {
            "VISA",
            "MASTERCARD",
            "AMEX",
            "CABAL",
            "DINERS"});
            this.comboBox_Emisor.Location = new System.Drawing.Point(202, 276);
            this.comboBox_Emisor.Name = "comboBox_Emisor";
            this.comboBox_Emisor.Size = new System.Drawing.Size(186, 21);
            this.comboBox_Emisor.TabIndex = 50;
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(313, 319);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 27;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click_1);
            // 
            // dataGridView_Tarjetas
            // 
            this.dataGridView_Tarjetas.AllowUserToAddRows = false;
            this.dataGridView_Tarjetas.AllowUserToDeleteRows = false;
            this.dataGridView_Tarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ult_Digitos,
            this.Numero,
            this.Codigo,
            this.Emisor,
            this.Eliminar});
            this.dataGridView_Tarjetas.Location = new System.Drawing.Point(6, 28);
            this.dataGridView_Tarjetas.Name = "dataGridView_Tarjetas";
            this.dataGridView_Tarjetas.Size = new System.Drawing.Size(403, 212);
            this.dataGridView_Tarjetas.TabIndex = 0;
            this.dataGridView_Tarjetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tarjetas_CellContentClick_1);
            // 
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.comboBox_Nacionalidad);
            this.paner_Alta.Controls.Add(this.comboBox_Tipo_doc);
            this.paner_Alta.Controls.Add(this.comboBox_Pais);
            this.paner_Alta.Controls.Add(this.label_Nacionalidad);
            this.paner_Alta.Controls.Add(this.textBox_Localidad);
            this.paner_Alta.Controls.Add(this.label_Localidad);
            this.paner_Alta.Controls.Add(this.textBox_Depto);
            this.paner_Alta.Controls.Add(this.label1);
            this.paner_Alta.Controls.Add(this.textBox_Piso);
            this.paner_Alta.Controls.Add(this.label_Piso);
            this.paner_Alta.Controls.Add(this.dateTimePicker_FechaNacimiento);
            this.paner_Alta.Controls.Add(this.textBox_Mail);
            this.paner_Alta.Controls.Add(this.textBox_Documento);
            this.paner_Alta.Controls.Add(this.textBox_Calle);
            this.paner_Alta.Controls.Add(this.textBox_Apellido);
            this.paner_Alta.Controls.Add(this.label_FechaNacimiento);
            this.paner_Alta.Controls.Add(this.label_Pais);
            this.paner_Alta.Controls.Add(this.label_Domicilio);
            this.paner_Alta.Controls.Add(this.label_Mail);
            this.paner_Alta.Controls.Add(this.label_TipoDocumento);
            this.paner_Alta.Controls.Add(this.label_Documento);
            this.paner_Alta.Controls.Add(this.label_Apellido);
            this.paner_Alta.Controls.Add(this.label_Nombre);
            this.paner_Alta.Controls.Add(this.textBox_Nombre);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_Alta.Location = new System.Drawing.Point(12, 12);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(395, 410);
            this.paner_Alta.TabIndex = 32;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos del Cliente";
            // 
            // comboBox_Nacionalidad
            // 
            this.comboBox_Nacionalidad.FormattingEnabled = true;
            this.comboBox_Nacionalidad.Items.AddRange(new object[] {
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
            this.comboBox_Nacionalidad.Location = new System.Drawing.Point(136, 297);
            this.comboBox_Nacionalidad.Name = "comboBox_Nacionalidad";
            this.comboBox_Nacionalidad.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Nacionalidad.TabIndex = 36;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Ult_Digitos
            // 
            this.Ult_Digitos.HeaderText = "Ult_Digitos";
            this.Ult_Digitos.Name = "Ult_Digitos";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Emisor
            // 
            this.Emisor.HeaderText = "Emisor";
            this.Emisor.Name = "Emisor";
            this.Emisor.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar fila";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox_AsociarTarjetas);
            this.Controls.Add(this.paner_Alta);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            this.groupBox_AsociarTarjetas.ResumeLayout(false);
            this.groupBox_AsociarTarjetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tarjetas)).EndInit();
            this.paner_Alta.ResumeLayout(false);
            this.paner_Alta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.Label label_Documento;
        private System.Windows.Forms.Label label_TipoDocumento;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_Domicilio;
        private System.Windows.Forms.Label label_Pais;
        private System.Windows.Forms.Label label_FechaNacimiento;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Calle;
        private System.Windows.Forms.TextBox textBox_Documento;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaNacimiento;
        private System.Windows.Forms.Label label_Piso;
        private System.Windows.Forms.TextBox textBox_Piso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Depto;
        private System.Windows.Forms.Label label_Localidad;
        private System.Windows.Forms.TextBox textBox_Localidad;
        private System.Windows.Forms.Label label_Nacionalidad;
        private System.Windows.Forms.ComboBox comboBox_Pais;
        private System.Windows.Forms.ComboBox comboBox_Tipo_doc;
        private System.Windows.Forms.GroupBox groupBox_AsociarTarjetas;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numeroTarjeta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Emisor;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.DataGridView dataGridView_Tarjetas;
        private System.Windows.Forms.GroupBox paner_Alta;
        private System.Windows.Forms.ComboBox comboBox_Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ult_Digitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emisor;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}