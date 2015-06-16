namespace PagoElectronico.Tarjeta_Credito
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
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.paner_DatosCuenta = new System.Windows.Forms.GroupBox();
            this.textBox_CodigoSeguridad = new System.Windows.Forms.TextBox();
            this.textBox_numeroTarjeta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paner_DatosCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(672, 288);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 37;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(591, 288);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 38;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // paner_DatosCuenta
            // 
            this.paner_DatosCuenta.Controls.Add(this.textBox_CodigoSeguridad);
            this.paner_DatosCuenta.Controls.Add(this.textBox_numeroTarjeta);
            this.paner_DatosCuenta.Controls.Add(this.label5);
            this.paner_DatosCuenta.Controls.Add(this.label3);
            this.paner_DatosCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_DatosCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_DatosCuenta.Location = new System.Drawing.Point(12, 12);
            this.paner_DatosCuenta.Name = "paner_DatosCuenta";
            this.paner_DatosCuenta.Size = new System.Drawing.Size(735, 270);
            this.paner_DatosCuenta.TabIndex = 43;
            this.paner_DatosCuenta.TabStop = false;
            this.paner_DatosCuenta.Text = "Selección de Tarjeta";
            // 
            // textBox_CodigoSeguridad
            // 
            this.textBox_CodigoSeguridad.Location = new System.Drawing.Point(268, 159);
            this.textBox_CodigoSeguridad.Name = "textBox_CodigoSeguridad";
            this.textBox_CodigoSeguridad.Size = new System.Drawing.Size(67, 20);
            this.textBox_CodigoSeguridad.TabIndex = 46;
            this.textBox_CodigoSeguridad.Text = "997";
            this.textBox_CodigoSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CodigoSeguridad_KeyPress);
            // 
            // textBox_numeroTarjeta
            // 
            this.textBox_numeroTarjeta.Location = new System.Drawing.Point(268, 123);
            this.textBox_numeroTarjeta.MaxLength = 16;
            this.textBox_numeroTarjeta.Name = "textBox_numeroTarjeta";
            this.textBox_numeroTarjeta.Size = new System.Drawing.Size(249, 20);
            this.textBox_numeroTarjeta.TabIndex = 45;
            this.textBox_numeroTarjeta.Text = "5506001896744918";
            this.textBox_numeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numeroTarjeta_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Codigo de Seguridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Numero de tarjeta";
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(760, 320);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.paner_DatosCuenta);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleccion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.paner_DatosCuenta.ResumeLayout(false);
            this.paner_DatosCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.GroupBox paner_DatosCuenta;
        private System.Windows.Forms.TextBox textBox_CodigoSeguridad;
        private System.Windows.Forms.TextBox textBox_numeroTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}