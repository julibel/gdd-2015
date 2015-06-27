namespace PagoElectronico.Login
{
    partial class Autentificar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_RespuestaSecreta = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contrasenia = new System.Windows.Forms.Label();
            this.textBox_PreguntaSecreta = new System.Windows.Forms.TextBox();
            this.button_IniciarSesion = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_RespuestaSecreta);
            this.groupBox1.Controls.Add(this.textBox_Username);
            this.groupBox1.Controls.Add(this.label_Usuario);
            this.groupBox1.Controls.Add(this.label_Contrasenia);
            this.groupBox1.Controls.Add(this.textBox_PreguntaSecreta);
            this.groupBox1.Location = new System.Drawing.Point(145, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 299);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // textBox_RespuestaSecreta
            // 
            this.textBox_RespuestaSecreta.Location = new System.Drawing.Point(222, 165);
            this.textBox_RespuestaSecreta.Name = "textBox_RespuestaSecreta";
            this.textBox_RespuestaSecreta.PasswordChar = '*';
            this.textBox_RespuestaSecreta.Size = new System.Drawing.Size(202, 20);
            this.textBox_RespuestaSecreta.TabIndex = 0;
            this.textBox_RespuestaSecreta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_RespuestaSecreta_KeyDown);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Enabled = false;
            this.textBox_Username.Location = new System.Drawing.Point(222, 113);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(202, 20);
            this.textBox_Username.TabIndex = 15;
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(128, 142);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(88, 13);
            this.label_Usuario.TabIndex = 6;
            this.label_Usuario.Text = "Pregunta secreta";
            // 
            // label_Contrasenia
            // 
            this.label_Contrasenia.AutoSize = true;
            this.label_Contrasenia.Location = new System.Drawing.Point(120, 168);
            this.label_Contrasenia.Name = "label_Contrasenia";
            this.label_Contrasenia.Size = new System.Drawing.Size(96, 13);
            this.label_Contrasenia.TabIndex = 7;
            this.label_Contrasenia.Text = "Respuesta secreta";
            // 
            // textBox_PreguntaSecreta
            // 
            this.textBox_PreguntaSecreta.Enabled = false;
            this.textBox_PreguntaSecreta.Location = new System.Drawing.Point(222, 139);
            this.textBox_PreguntaSecreta.Name = "textBox_PreguntaSecreta";
            this.textBox_PreguntaSecreta.Size = new System.Drawing.Size(202, 20);
            this.textBox_PreguntaSecreta.TabIndex = 8;
            // 
            // button_IniciarSesion
            // 
            this.button_IniciarSesion.Location = new System.Drawing.Point(518, 382);
            this.button_IniciarSesion.Name = "button_IniciarSesion";
            this.button_IniciarSesion.Size = new System.Drawing.Size(79, 27);
            this.button_IniciarSesion.TabIndex = 1;
            this.button_IniciarSesion.Text = "Iniciar sesion";
            this.button_IniciarSesion.UseVisualStyleBackColor = true;
            this.button_IniciarSesion.Click += new System.EventHandler(this.button_IniciarSesion_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cerrar.Location = new System.Drawing.Point(603, 382);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(86, 27);
            this.button_Cerrar.TabIndex = 2;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // Autentificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 487);
            this.Controls.Add(this.button_IniciarSesion);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autentificar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificar usuario";
            this.Load += new System.EventHandler(this.Autentificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_RespuestaSecreta;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contrasenia;
        private System.Windows.Forms.TextBox textBox_PreguntaSecreta;
        private System.Windows.Forms.Button button_IniciarSesion;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Username;
    }
}