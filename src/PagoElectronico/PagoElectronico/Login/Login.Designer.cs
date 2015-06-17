namespace PagoElectronico.Login
{
    partial class Login
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
            this.button_IniciarSesion = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Contrasenia = new System.Windows.Forms.Label();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Roles = new System.Windows.Forms.ComboBox();
            this.label_Rol = new System.Windows.Forms.Label();
            this.button_OlvidoContrasenia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_IniciarSesion
            // 
            this.button_IniciarSesion.Location = new System.Drawing.Point(385, 317);
            this.button_IniciarSesion.Name = "button_IniciarSesion";
            this.button_IniciarSesion.Size = new System.Drawing.Size(79, 27);
            this.button_IniciarSesion.TabIndex = 11;
            this.button_IniciarSesion.Text = "Iniciar sesion";
            this.button_IniciarSesion.UseVisualStyleBackColor = true;
            this.button_IniciarSesion.Click += new System.EventHandler(this.button_IniciarSesion_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cerrar.Location = new System.Drawing.Point(470, 317);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(86, 27);
            this.button_Cerrar.TabIndex = 10;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(202, 191);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(202, 20);
            this.textBox_password.TabIndex = 9;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(202, 156);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(202, 20);
            this.textBox_Username.TabIndex = 8;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // label_Contrasenia
            // 
            this.label_Contrasenia.AutoSize = true;
            this.label_Contrasenia.Location = new System.Drawing.Point(143, 194);
            this.label_Contrasenia.Name = "label_Contrasenia";
            this.label_Contrasenia.Size = new System.Drawing.Size(53, 13);
            this.label_Contrasenia.TabIndex = 7;
            this.label_Contrasenia.Text = "Password";
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(141, 159);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(55, 13);
            this.label_Usuario.TabIndex = 6;
            this.label_Usuario.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Roles);
            this.groupBox1.Controls.Add(this.label_Rol);
            this.groupBox1.Controls.Add(this.button_OlvidoContrasenia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.label_Usuario);
            this.groupBox1.Controls.Add(this.label_Contrasenia);
            this.groupBox1.Controls.Add(this.textBox_Username);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 299);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_Roles
            // 
            this.comboBox_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Roles.FormattingEnabled = true;
            this.comboBox_Roles.Location = new System.Drawing.Point(202, 225);
            this.comboBox_Roles.Name = "comboBox_Roles";
            this.comboBox_Roles.Size = new System.Drawing.Size(202, 21);
            this.comboBox_Roles.TabIndex = 14;
            // 
            // label_Rol
            // 
            this.label_Rol.AutoSize = true;
            this.label_Rol.Location = new System.Drawing.Point(155, 228);
            this.label_Rol.Name = "label_Rol";
            this.label_Rol.Size = new System.Drawing.Size(23, 13);
            this.label_Rol.TabIndex = 13;
            this.label_Rol.Text = "Rol";
            // 
            // button_OlvidoContrasenia
            // 
            this.button_OlvidoContrasenia.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_OlvidoContrasenia.FlatAppearance.BorderSize = 0;
            this.button_OlvidoContrasenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OlvidoContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OlvidoContrasenia.Location = new System.Drawing.Point(275, 253);
            this.button_OlvidoContrasenia.Name = "button_OlvidoContrasenia";
            this.button_OlvidoContrasenia.Size = new System.Drawing.Size(129, 23);
            this.button_OlvidoContrasenia.TabIndex = 12;
            this.button_OlvidoContrasenia.Text = "¿Olvido su contraseña?";
            this.button_OlvidoContrasenia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_OlvidoContrasenia.UseVisualStyleBackColor = true;
            this.button_OlvidoContrasenia.Click += new System.EventHandler(this.button_OlvidoContrasenia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bienvenido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pago Electronico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_IniciarSesion);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese al sistema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_IniciarSesion;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Contrasenia;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OlvidoContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Rol;
        private System.Windows.Forms.ComboBox comboBox_Roles;
    }
}