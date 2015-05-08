namespace PagoElectronico.Tarjeta_Credito
{
    partial class ModificarDatos
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
            this.textBox_NombreTitular = new System.Windows.Forms.TextBox();
            this.textBox_numeroTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Emisor = new System.Windows.Forms.ComboBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CodigoSeguridad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_CodigoSeguridad);
            this.groupBox1.Controls.Add(this.textBox_NombreTitular);
            this.groupBox1.Controls.Add(this.textBox_numeroTarjeta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Emisor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 410);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la tarjeta de credito";
            // 
            // textBox_NombreTitular
            // 
            this.textBox_NombreTitular.Location = new System.Drawing.Point(337, 184);
            this.textBox_NombreTitular.Name = "textBox_NombreTitular";
            this.textBox_NombreTitular.Size = new System.Drawing.Size(249, 20);
            this.textBox_NombreTitular.TabIndex = 46;
            // 
            // textBox_numeroTarjeta
            // 
            this.textBox_numeroTarjeta.Location = new System.Drawing.Point(337, 154);
            this.textBox_numeroTarjeta.Name = "textBox_numeroTarjeta";
            this.textBox_numeroTarjeta.Size = new System.Drawing.Size(249, 20);
            this.textBox_numeroTarjeta.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nombre del titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Numero de tarjeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Emisor";
            // 
            // comboBox_Emisor
            // 
            this.comboBox_Emisor.FormattingEnabled = true;
            this.comboBox_Emisor.Location = new System.Drawing.Point(337, 236);
            this.comboBox_Emisor.Name = "comboBox_Emisor";
            this.comboBox_Emisor.Size = new System.Drawing.Size(186, 21);
            this.comboBox_Emisor.TabIndex = 38;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 428);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 48;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(585, 428);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 47;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 428);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 46;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Codigo de Seguridad";
            // 
            // textBox_CodigoSeguridad
            // 
            this.textBox_CodigoSeguridad.Location = new System.Drawing.Point(337, 210);
            this.textBox_CodigoSeguridad.Name = "textBox_CodigoSeguridad";
            this.textBox_CodigoSeguridad.Size = new System.Drawing.Size(67, 20);
            this.textBox_CodigoSeguridad.TabIndex = 47;
            // 
            // ModificarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarDatos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarDatos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_NombreTitular;
        private System.Windows.Forms.TextBox textBox_numeroTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Emisor;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.TextBox textBox_CodigoSeguridad;
        private System.Windows.Forms.Label label5;
    }
}