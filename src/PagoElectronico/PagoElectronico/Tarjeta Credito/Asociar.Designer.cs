namespace PagoElectronico.Tarjeta_Credito
{
    partial class Asociar
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_FechaVencimiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Emisor = new System.Windows.Forms.ComboBox();
            this.textBox_FechaEmision = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.maskedTextBox_numeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_codigo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox_codigo);
            this.groupBox1.Controls.Add(this.maskedTextBox_numeroTarjeta);
            this.groupBox1.Controls.Add(this.textBox_NombreTitular);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_FechaVencimiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Emisor);
            this.groupBox1.Controls.Add(this.textBox_FechaEmision);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 410);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la tarjeta de credito";
            // 
            // textBox_NombreTitular
            // 
            this.textBox_NombreTitular.Location = new System.Drawing.Point(340, 158);
            this.textBox_NombreTitular.Name = "textBox_NombreTitular";
            this.textBox_NombreTitular.Size = new System.Drawing.Size(249, 20);
            this.textBox_NombreTitular.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Codigo de Seguridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nombre del titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Numero de tarjeta";
            // 
            // textBox_FechaVencimiento
            // 
            this.textBox_FechaVencimiento.Enabled = false;
            this.textBox_FechaVencimiento.Location = new System.Drawing.Point(340, 263);
            this.textBox_FechaVencimiento.Name = "textBox_FechaVencimiento";
            this.textBox_FechaVencimiento.Size = new System.Drawing.Size(186, 20);
            this.textBox_FechaVencimiento.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fecha de vencimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Emisor";
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
            this.comboBox_Emisor.Location = new System.Drawing.Point(340, 210);
            this.comboBox_Emisor.Name = "comboBox_Emisor";
            this.comboBox_Emisor.Size = new System.Drawing.Size(186, 21);
            this.comboBox_Emisor.TabIndex = 38;
            // 
            // textBox_FechaEmision
            // 
            this.textBox_FechaEmision.Enabled = false;
            this.textBox_FechaEmision.Location = new System.Drawing.Point(340, 237);
            this.textBox_FechaEmision.Name = "textBox_FechaEmision";
            this.textBox_FechaEmision.Size = new System.Drawing.Size(186, 20);
            this.textBox_FechaEmision.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Fecha de emision";
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 428);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 44;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(585, 428);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 43;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 428);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 42;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // maskedTextBox_numeroTarjeta
            // 
            this.maskedTextBox_numeroTarjeta.Location = new System.Drawing.Point(340, 128);
            this.maskedTextBox_numeroTarjeta.Mask = "9999999999999999";
            this.maskedTextBox_numeroTarjeta.Name = "maskedTextBox_numeroTarjeta";
            this.maskedTextBox_numeroTarjeta.Size = new System.Drawing.Size(114, 20);
            this.maskedTextBox_numeroTarjeta.TabIndex = 62;
            // 
            // maskedTextBox_codigo
            // 
            this.maskedTextBox_codigo.Location = new System.Drawing.Point(340, 184);
            this.maskedTextBox_codigo.Mask = "999";
            this.maskedTextBox_codigo.Name = "maskedTextBox_codigo";
            this.maskedTextBox_codigo.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBox_codigo.TabIndex = 63;
            // 
            // Asociar
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
            this.Name = "Asociar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_FechaVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Emisor;
        private System.Windows.Forms.TextBox textBox_FechaEmision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.TextBox textBox_NombreTitular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numeroTarjeta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_codigo;
    }
}