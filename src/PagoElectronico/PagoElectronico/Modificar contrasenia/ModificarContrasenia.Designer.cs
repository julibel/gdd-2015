namespace PagoElectronico.Modificar_contrasenia
{
    partial class ModificarContrasenia
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
            this.paner_DatosCuenta = new System.Windows.Forms.GroupBox();
            this.textBox_NuevaPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PasswordActual = new System.Windows.Forms.TextBox();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contrasenia = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.paner_DatosCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // paner_DatosCuenta
            // 
            this.paner_DatosCuenta.Controls.Add(this.textBox_NuevaPassword);
            this.paner_DatosCuenta.Controls.Add(this.label1);
            this.paner_DatosCuenta.Controls.Add(this.textBox_PasswordActual);
            this.paner_DatosCuenta.Controls.Add(this.label_Usuario);
            this.paner_DatosCuenta.Controls.Add(this.label_Contrasenia);
            this.paner_DatosCuenta.Controls.Add(this.textBox_Username);
            this.paner_DatosCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_DatosCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_DatosCuenta.Location = new System.Drawing.Point(12, 12);
            this.paner_DatosCuenta.Name = "paner_DatosCuenta";
            this.paner_DatosCuenta.Size = new System.Drawing.Size(810, 410);
            this.paner_DatosCuenta.TabIndex = 40;
            this.paner_DatosCuenta.TabStop = false;
            this.paner_DatosCuenta.Text = "Modificar contraseña";
            this.paner_DatosCuenta.Enter += new System.EventHandler(this.paner_DatosCuenta_Enter);
            // 
            // textBox_NuevaPassword
            // 
            this.textBox_NuevaPassword.Location = new System.Drawing.Point(351, 221);
            this.textBox_NuevaPassword.Name = "textBox_NuevaPassword";
            this.textBox_NuevaPassword.PasswordChar = '*';
            this.textBox_NuevaPassword.Size = new System.Drawing.Size(202, 20);
            this.textBox_NuevaPassword.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nueva password";
            // 
            // textBox_PasswordActual
            // 
            this.textBox_PasswordActual.Location = new System.Drawing.Point(351, 195);
            this.textBox_PasswordActual.Name = "textBox_PasswordActual";
            this.textBox_PasswordActual.PasswordChar = '*';
            this.textBox_PasswordActual.Size = new System.Drawing.Size(202, 20);
            this.textBox_PasswordActual.TabIndex = 13;
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(290, 172);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(55, 13);
            this.label_Usuario.TabIndex = 10;
            this.label_Usuario.Text = "Username";
            // 
            // label_Contrasenia
            // 
            this.label_Contrasenia.AutoSize = true;
            this.label_Contrasenia.Location = new System.Drawing.Point(260, 198);
            this.label_Contrasenia.Name = "label_Contrasenia";
            this.label_Contrasenia.Size = new System.Drawing.Size(85, 13);
            this.label_Contrasenia.TabIndex = 11;
            this.label_Contrasenia.Text = "Password actual";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Enabled = false;
            this.textBox_Username.Location = new System.Drawing.Point(351, 169);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(202, 20);
            this.textBox_Username.TabIndex = 12;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 428);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 39;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(585, 428);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 38;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 428);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 37;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // ModificarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.paner_DatosCuenta);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarContrasenia";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarContrasenia";
            this.paner_DatosCuenta.ResumeLayout(false);
            this.paner_DatosCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox paner_DatosCuenta;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.TextBox textBox_NuevaPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PasswordActual;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contrasenia;
        private System.Windows.Forms.TextBox textBox_Username;
    }
}