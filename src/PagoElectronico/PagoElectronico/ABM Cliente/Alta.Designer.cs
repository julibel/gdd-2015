namespace PagoElectronico.ABM_Cliente
{
    partial class Alta
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
            this.groupBox_Usuario = new System.Windows.Forms.GroupBox();
            this.textBox_PreguntaSecreta = new System.Windows.Forms.TextBox();
            this.label_PreguntaSecreta = new System.Windows.Forms.Label();
            this.textBox_RespuestaSecreta = new System.Windows.Forms.TextBox();
            this.label_RespuestaSecreta = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.groupBox_Alta = new System.Windows.Forms.GroupBox();
            this.comboBox_Nacionalidad = new System.Windows.Forms.ComboBox();
            this.comboBox_Tipo_doc = new System.Windows.Forms.ComboBox();
            this.comboBox_Pais = new System.Windows.Forms.ComboBox();
            this.textBox_Calle = new System.Windows.Forms.TextBox();
            this.label_Domicilio = new System.Windows.Forms.Label();
            this.label_Nacionalidad = new System.Windows.Forms.Label();
            this.textBox_Localidad = new System.Windows.Forms.TextBox();
            this.label_Localidad = new System.Windows.Forms.Label();
            this.textBox_Depto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Piso = new System.Windows.Forms.TextBox();
            this.label_Piso = new System.Windows.Forms.Label();
            this.dateTimePicker_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Documento = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label_FechaNacimiento = new System.Windows.Forms.Label();
            this.label_Pais = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_TipoDocumento = new System.Windows.Forms.Label();
            this.label_Documento = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.groupBox_AsociarTarjetas = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox_numeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_codigo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Emisor = new System.Windows.Forms.ComboBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.dataGridView_Tarjetas = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_Usuario.SuspendLayout();
            this.groupBox_Alta.SuspendLayout();
            this.groupBox_AsociarTarjetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(661, 428);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 23;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(580, 428);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 22;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(742, 428);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 24;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // groupBox_Usuario
            // 
            this.groupBox_Usuario.Controls.Add(this.textBox_PreguntaSecreta);
            this.groupBox_Usuario.Controls.Add(this.label_PreguntaSecreta);
            this.groupBox_Usuario.Controls.Add(this.textBox_RespuestaSecreta);
            this.groupBox_Usuario.Controls.Add(this.label_RespuestaSecreta);
            this.groupBox_Usuario.Controls.Add(this.textBox_Password);
            this.groupBox_Usuario.Controls.Add(this.label_Password);
            this.groupBox_Usuario.Controls.Add(this.label_Username);
            this.groupBox_Usuario.Controls.Add(this.textBox_Username);
            this.groupBox_Usuario.Location = new System.Drawing.Point(382, 12);
            this.groupBox_Usuario.Name = "groupBox_Usuario";
            this.groupBox_Usuario.Size = new System.Drawing.Size(435, 134);
            this.groupBox_Usuario.TabIndex = 22;
            this.groupBox_Usuario.TabStop = false;
            this.groupBox_Usuario.Text = "Datos de Usuario";
            // 
            // textBox_PreguntaSecreta
            // 
            this.textBox_PreguntaSecreta.Location = new System.Drawing.Point(152, 70);
            this.textBox_PreguntaSecreta.MaxLength = 255;
            this.textBox_PreguntaSecreta.Name = "textBox_PreguntaSecreta";
            this.textBox_PreguntaSecreta.Size = new System.Drawing.Size(232, 20);
            this.textBox_PreguntaSecreta.TabIndex = 14;
            // 
            // label_PreguntaSecreta
            // 
            this.label_PreguntaSecreta.AutoSize = true;
            this.label_PreguntaSecreta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PreguntaSecreta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_PreguntaSecreta.Location = new System.Drawing.Point(58, 73);
            this.label_PreguntaSecreta.Name = "label_PreguntaSecreta";
            this.label_PreguntaSecreta.Size = new System.Drawing.Size(88, 13);
            this.label_PreguntaSecreta.TabIndex = 19;
            this.label_PreguntaSecreta.Text = "Pregunta secreta";
            // 
            // textBox_RespuestaSecreta
            // 
            this.textBox_RespuestaSecreta.Location = new System.Drawing.Point(152, 96);
            this.textBox_RespuestaSecreta.MaxLength = 255;
            this.textBox_RespuestaSecreta.Name = "textBox_RespuestaSecreta";
            this.textBox_RespuestaSecreta.Size = new System.Drawing.Size(232, 20);
            this.textBox_RespuestaSecreta.TabIndex = 15;
            this.textBox_RespuestaSecreta.UseSystemPasswordChar = true;
            // 
            // label_RespuestaSecreta
            // 
            this.label_RespuestaSecreta.AutoSize = true;
            this.label_RespuestaSecreta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_RespuestaSecreta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_RespuestaSecreta.Location = new System.Drawing.Point(50, 99);
            this.label_RespuestaSecreta.Name = "label_RespuestaSecreta";
            this.label_RespuestaSecreta.Size = new System.Drawing.Size(96, 13);
            this.label_RespuestaSecreta.TabIndex = 17;
            this.label_RespuestaSecreta.Text = "Respuesta secreta";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(152, 44);
            this.textBox_Password.MaxLength = 255;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(232, 20);
            this.textBox_Password.TabIndex = 13;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Password.Location = new System.Drawing.Point(93, 47);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 13;
            this.label_Password.Text = "Password";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Username.Location = new System.Drawing.Point(91, 21);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(55, 13);
            this.label_Username.TabIndex = 12;
            this.label_Username.Text = "Username";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(152, 18);
            this.textBox_Username.MaxLength = 255;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(232, 20);
            this.textBox_Username.TabIndex = 12;
            // 
            // groupBox_Alta
            // 
            this.groupBox_Alta.Controls.Add(this.comboBox_Nacionalidad);
            this.groupBox_Alta.Controls.Add(this.comboBox_Tipo_doc);
            this.groupBox_Alta.Controls.Add(this.comboBox_Pais);
            this.groupBox_Alta.Controls.Add(this.textBox_Calle);
            this.groupBox_Alta.Controls.Add(this.label_Domicilio);
            this.groupBox_Alta.Controls.Add(this.label_Nacionalidad);
            this.groupBox_Alta.Controls.Add(this.textBox_Localidad);
            this.groupBox_Alta.Controls.Add(this.label_Localidad);
            this.groupBox_Alta.Controls.Add(this.textBox_Depto);
            this.groupBox_Alta.Controls.Add(this.label1);
            this.groupBox_Alta.Controls.Add(this.textBox_Piso);
            this.groupBox_Alta.Controls.Add(this.label_Piso);
            this.groupBox_Alta.Controls.Add(this.dateTimePicker_FechaNacimiento);
            this.groupBox_Alta.Controls.Add(this.textBox_Mail);
            this.groupBox_Alta.Controls.Add(this.textBox_Documento);
            this.groupBox_Alta.Controls.Add(this.textBox_Apellido);
            this.groupBox_Alta.Controls.Add(this.label_FechaNacimiento);
            this.groupBox_Alta.Controls.Add(this.label_Pais);
            this.groupBox_Alta.Controls.Add(this.label_Mail);
            this.groupBox_Alta.Controls.Add(this.label_TipoDocumento);
            this.groupBox_Alta.Controls.Add(this.label_Documento);
            this.groupBox_Alta.Controls.Add(this.label_Apellido);
            this.groupBox_Alta.Controls.Add(this.label_Nombre);
            this.groupBox_Alta.Controls.Add(this.textBox_Nombre);
            this.groupBox_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_Alta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Alta.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Alta.Name = "groupBox_Alta";
            this.groupBox_Alta.Size = new System.Drawing.Size(364, 410);
            this.groupBox_Alta.TabIndex = 26;
            this.groupBox_Alta.TabStop = false;
            this.groupBox_Alta.Text = "Datos del Cliente";
            // 
            // comboBox_Nacionalidad
            // 
            this.comboBox_Nacionalidad.FormattingEnabled = true;
            this.comboBox_Nacionalidad.Location = new System.Drawing.Point(122, 298);
            this.comboBox_Nacionalidad.Name = "comboBox_Nacionalidad";
            this.comboBox_Nacionalidad.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Nacionalidad.TabIndex = 10;
            // 
            // comboBox_Tipo_doc
            // 
            this.comboBox_Tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tipo_doc.FormattingEnabled = true;
            this.comboBox_Tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "CI",
            "LC",
            "LE",
            "PAS"});
            this.comboBox_Tipo_doc.Location = new System.Drawing.Point(122, 117);
            this.comboBox_Tipo_doc.Name = "comboBox_Tipo_doc";
            this.comboBox_Tipo_doc.Size = new System.Drawing.Size(129, 21);
            this.comboBox_Tipo_doc.TabIndex = 2;
            // 
            // comboBox_Pais
            // 
            this.comboBox_Pais.FormattingEnabled = true;
            this.comboBox_Pais.Location = new System.Drawing.Point(122, 271);
            this.comboBox_Pais.Name = "comboBox_Pais";
            this.comboBox_Pais.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Pais.TabIndex = 9;
            // 
            // textBox_Calle
            // 
            this.textBox_Calle.Location = new System.Drawing.Point(122, 194);
            this.textBox_Calle.MaxLength = 255;
            this.textBox_Calle.Name = "textBox_Calle";
            this.textBox_Calle.Size = new System.Drawing.Size(232, 20);
            this.textBox_Calle.TabIndex = 5;
            // 
            // label_Domicilio
            // 
            this.label_Domicilio.AutoSize = true;
            this.label_Domicilio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Domicilio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Domicilio.Location = new System.Drawing.Point(86, 197);
            this.label_Domicilio.Name = "label_Domicilio";
            this.label_Domicilio.Size = new System.Drawing.Size(30, 13);
            this.label_Domicilio.TabIndex = 30;
            this.label_Domicilio.Text = "Calle";
            // 
            // label_Nacionalidad
            // 
            this.label_Nacionalidad.AutoSize = true;
            this.label_Nacionalidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nacionalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nacionalidad.Location = new System.Drawing.Point(47, 301);
            this.label_Nacionalidad.Name = "label_Nacionalidad";
            this.label_Nacionalidad.Size = new System.Drawing.Size(69, 13);
            this.label_Nacionalidad.TabIndex = 28;
            this.label_Nacionalidad.Text = "Nacionalidad";
            // 
            // textBox_Localidad
            // 
            this.textBox_Localidad.Location = new System.Drawing.Point(122, 246);
            this.textBox_Localidad.MaxLength = 50;
            this.textBox_Localidad.Name = "textBox_Localidad";
            this.textBox_Localidad.Size = new System.Drawing.Size(232, 20);
            this.textBox_Localidad.TabIndex = 8;
            // 
            // label_Localidad
            // 
            this.label_Localidad.AutoSize = true;
            this.label_Localidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Localidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Localidad.Location = new System.Drawing.Point(63, 249);
            this.label_Localidad.Name = "label_Localidad";
            this.label_Localidad.Size = new System.Drawing.Size(53, 13);
            this.label_Localidad.TabIndex = 26;
            this.label_Localidad.Text = "Localidad";
            // 
            // textBox_Depto
            // 
            this.textBox_Depto.Location = new System.Drawing.Point(260, 220);
            this.textBox_Depto.MaxLength = 50;
            this.textBox_Depto.Name = "textBox_Depto";
            this.textBox_Depto.Size = new System.Drawing.Size(94, 20);
            this.textBox_Depto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(218, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Depto";
            // 
            // textBox_Piso
            // 
            this.textBox_Piso.Location = new System.Drawing.Point(122, 220);
            this.textBox_Piso.MaxLength = 50;
            this.textBox_Piso.Name = "textBox_Piso";
            this.textBox_Piso.Size = new System.Drawing.Size(90, 20);
            this.textBox_Piso.TabIndex = 6;
            // 
            // label_Piso
            // 
            this.label_Piso.AutoSize = true;
            this.label_Piso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Piso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Piso.Location = new System.Drawing.Point(89, 223);
            this.label_Piso.Name = "label_Piso";
            this.label_Piso.Size = new System.Drawing.Size(27, 13);
            this.label_Piso.TabIndex = 22;
            this.label_Piso.Text = "Piso";
            // 
            // dateTimePicker_FechaNacimiento
            // 
            this.dateTimePicker_FechaNacimiento.Location = new System.Drawing.Point(122, 324);
            this.dateTimePicker_FechaNacimiento.Name = "dateTimePicker_FechaNacimiento";
            this.dateTimePicker_FechaNacimiento.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker_FechaNacimiento.TabIndex = 11;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(122, 168);
            this.textBox_Mail.MaxLength = 255;
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(232, 20);
            this.textBox_Mail.TabIndex = 4;
            // 
            // textBox_Documento
            // 
            this.textBox_Documento.Location = new System.Drawing.Point(122, 142);
            this.textBox_Documento.MaxLength = 10;
            this.textBox_Documento.Name = "textBox_Documento";
            this.textBox_Documento.Size = new System.Drawing.Size(129, 20);
            this.textBox_Documento.TabIndex = 3;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(122, 93);
            this.textBox_Apellido.MaxLength = 255;
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(232, 20);
            this.textBox_Apellido.TabIndex = 1;
            // 
            // label_FechaNacimiento
            // 
            this.label_FechaNacimiento.AutoSize = true;
            this.label_FechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_FechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_FechaNacimiento.Location = new System.Drawing.Point(10, 326);
            this.label_FechaNacimiento.Name = "label_FechaNacimiento";
            this.label_FechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.label_FechaNacimiento.TabIndex = 9;
            this.label_FechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // label_Pais
            // 
            this.label_Pais.AutoSize = true;
            this.label_Pais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Pais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Pais.Location = new System.Drawing.Point(23, 275);
            this.label_Pais.Name = "label_Pais";
            this.label_Pais.Size = new System.Drawing.Size(93, 13);
            this.label_Pais.TabIndex = 8;
            this.label_Pais.Text = "Pais de residencia";
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Mail.Location = new System.Drawing.Point(83, 171);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(33, 13);
            this.label_Mail.TabIndex = 5;
            this.label_Mail.Text = "EMail";
            // 
            // label_TipoDocumento
            // 
            this.label_TipoDocumento.AutoSize = true;
            this.label_TipoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TipoDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_TipoDocumento.Location = new System.Drawing.Point(19, 121);
            this.label_TipoDocumento.Name = "label_TipoDocumento";
            this.label_TipoDocumento.Size = new System.Drawing.Size(99, 13);
            this.label_TipoDocumento.TabIndex = 4;
            this.label_TipoDocumento.Text = "Tipo de documento";
            // 
            // label_Documento
            // 
            this.label_Documento.AutoSize = true;
            this.label_Documento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Documento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Documento.Location = new System.Drawing.Point(56, 145);
            this.label_Documento.Name = "label_Documento";
            this.label_Documento.Size = new System.Drawing.Size(62, 13);
            this.label_Documento.TabIndex = 3;
            this.label_Documento.Text = "Documento";
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Apellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Apellido.Location = new System.Drawing.Point(74, 96);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label_Apellido.TabIndex = 2;
            this.label_Apellido.Text = "Apellido";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(74, 70);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(122, 67);
            this.textBox_Nombre.MaxLength = 255;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // groupBox_AsociarTarjetas
            // 
            this.groupBox_AsociarTarjetas.Controls.Add(this.maskedTextBox1);
            this.groupBox_AsociarTarjetas.Controls.Add(this.label8);
            this.groupBox_AsociarTarjetas.Controls.Add(this.maskedTextBox_numeroTarjeta);
            this.groupBox_AsociarTarjetas.Controls.Add(this.maskedTextBox_codigo);
            this.groupBox_AsociarTarjetas.Controls.Add(this.label5);
            this.groupBox_AsociarTarjetas.Controls.Add(this.label3);
            this.groupBox_AsociarTarjetas.Controls.Add(this.label6);
            this.groupBox_AsociarTarjetas.Controls.Add(this.comboBox_Emisor);
            this.groupBox_AsociarTarjetas.Controls.Add(this.button_Agregar);
            this.groupBox_AsociarTarjetas.Controls.Add(this.dataGridView_Tarjetas);
            this.groupBox_AsociarTarjetas.Location = new System.Drawing.Point(382, 152);
            this.groupBox_AsociarTarjetas.Name = "groupBox_AsociarTarjetas";
            this.groupBox_AsociarTarjetas.Size = new System.Drawing.Size(435, 268);
            this.groupBox_AsociarTarjetas.TabIndex = 23;
            this.groupBox_AsociarTarjetas.TabStop = false;
            this.groupBox_AsociarTarjetas.Text = "Asociar tarjetas de credito";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(152, 221);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(81, 20);
            this.maskedTextBox1.TabIndex = 20;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Fecha de emisión";
            // 
            // maskedTextBox_numeroTarjeta
            // 
            this.maskedTextBox_numeroTarjeta.Location = new System.Drawing.Point(42, 181);
            this.maskedTextBox_numeroTarjeta.Mask = "9999999999999999";
            this.maskedTextBox_numeroTarjeta.Name = "maskedTextBox_numeroTarjeta";
            this.maskedTextBox_numeroTarjeta.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBox_numeroTarjeta.TabIndex = 17;
            this.maskedTextBox_numeroTarjeta.Click += new System.EventHandler(this.maskedTextBox_numeroTarjeta_Click);
            // 
            // maskedTextBox_codigo
            // 
            this.maskedTextBox_codigo.Location = new System.Drawing.Point(42, 221);
            this.maskedTextBox_codigo.Mask = "999";
            this.maskedTextBox_codigo.Name = "maskedTextBox_codigo";
            this.maskedTextBox_codigo.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBox_codigo.TabIndex = 18;
            this.maskedTextBox_codigo.Click += new System.EventHandler(this.maskedTextBox_codigo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Codigo de Seguridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Numero de tarjeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 162);
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
            this.comboBox_Emisor.Location = new System.Drawing.Point(210, 178);
            this.comboBox_Emisor.Name = "comboBox_Emisor";
            this.comboBox_Emisor.Size = new System.Drawing.Size(186, 21);
            this.comboBox_Emisor.TabIndex = 19;
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(321, 221);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 21;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // dataGridView_Tarjetas
            // 
            this.dataGridView_Tarjetas.AllowUserToAddRows = false;
            this.dataGridView_Tarjetas.AllowUserToDeleteRows = false;
            this.dataGridView_Tarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Codigo,
            this.Emisor,
            this.FechaEmision,
            this.FechaVencimiento,
            this.Eliminar});
            this.dataGridView_Tarjetas.Location = new System.Drawing.Point(6, 28);
            this.dataGridView_Tarjetas.Name = "dataGridView_Tarjetas";
            this.dataGridView_Tarjetas.Size = new System.Drawing.Size(423, 120);
            this.dataGridView_Tarjetas.TabIndex = 16;
            this.dataGridView_Tarjetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tarjetas_CellContentClick);
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
            // FechaEmision
            // 
            this.FechaEmision.HeaderText = "Fecha Emisión";
            this.FechaEmision.Name = "FechaEmision";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar fila";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox_AsociarTarjetas);
            this.Controls.Add(this.groupBox_Alta);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.groupBox_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            this.groupBox_Usuario.ResumeLayout(false);
            this.groupBox_Usuario.PerformLayout();
            this.groupBox_Alta.ResumeLayout(false);
            this.groupBox_Alta.PerformLayout();
            this.groupBox_AsociarTarjetas.ResumeLayout(false);
            this.groupBox_AsociarTarjetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.GroupBox groupBox_Usuario;
        private System.Windows.Forms.GroupBox groupBox_Alta;
        private System.Windows.Forms.Label label_Nacionalidad;
        private System.Windows.Forms.TextBox textBox_Localidad;
        private System.Windows.Forms.Label label_Localidad;
        private System.Windows.Forms.TextBox textBox_Depto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Piso;
        private System.Windows.Forms.Label label_Piso;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaNacimiento;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Documento;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label_FechaNacimiento;
        private System.Windows.Forms.Label label_Pais;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_TipoDocumento;
        private System.Windows.Forms.Label label_Documento;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_PreguntaSecreta;
        private System.Windows.Forms.Label label_PreguntaSecreta;
        private System.Windows.Forms.TextBox textBox_RespuestaSecreta;
        private System.Windows.Forms.Label label_RespuestaSecreta;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.GroupBox groupBox_AsociarTarjetas;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.DataGridView dataGridView_Tarjetas;
        private System.Windows.Forms.TextBox textBox_Calle;
        private System.Windows.Forms.Label label_Domicilio;
        private System.Windows.Forms.ComboBox comboBox_Pais;
        private System.Windows.Forms.ComboBox comboBox_Nacionalidad;
        private System.Windows.Forms.ComboBox comboBox_Tipo_doc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Emisor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numeroTarjeta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_codigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}