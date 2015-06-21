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
            this.maskedTextBox_fechaEmision = new System.Windows.Forms.MaskedTextBox();
            this.textBox_FechaVencimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox_numeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Numero_Tarjeta = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_codigo = new System.Windows.Forms.MaskedTextBox();
            this.textBox_NombreTitular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Emisores = new System.Windows.Forms.ComboBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.checkBox_habilitada = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_habilitada);
            this.groupBox1.Controls.Add(this.maskedTextBox_fechaEmision);
            this.groupBox1.Controls.Add(this.textBox_FechaVencimiento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maskedTextBox_numeroTarjeta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Numero_Tarjeta);
            this.groupBox1.Controls.Add(this.maskedTextBox_codigo);
            this.groupBox1.Controls.Add(this.textBox_NombreTitular);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Emisores);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la tarjeta de crédito";
            // 
            // maskedTextBox_fechaEmision
            // 
            this.maskedTextBox_fechaEmision.Location = new System.Drawing.Point(353, 265);
            this.maskedTextBox_fechaEmision.Mask = "00/00/0000";
            this.maskedTextBox_fechaEmision.Name = "maskedTextBox_fechaEmision";
            this.maskedTextBox_fechaEmision.Size = new System.Drawing.Size(81, 20);
            this.maskedTextBox_fechaEmision.TabIndex = 58;
            this.maskedTextBox_fechaEmision.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_fechaEmision.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.maskedTextBox_fechaEmision.Click += new System.EventHandler(this.maskedTextBox_fechaEmision_Click);
            // 
            // textBox_FechaVencimiento
            // 
            this.textBox_FechaVencimiento.Location = new System.Drawing.Point(353, 291);
            this.textBox_FechaVencimiento.Name = "textBox_FechaVencimiento";
            this.textBox_FechaVencimiento.ReadOnly = true;
            this.textBox_FechaVencimiento.Size = new System.Drawing.Size(81, 20);
            this.textBox_FechaVencimiento.TabIndex = 61;
            this.textBox_FechaVencimiento.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Fecha de vencimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Fecha de emisión";
            // 
            // maskedTextBox_numeroTarjeta
            // 
            this.maskedTextBox_numeroTarjeta.Location = new System.Drawing.Point(352, 162);
            this.maskedTextBox_numeroTarjeta.Mask = "9999999999999999";
            this.maskedTextBox_numeroTarjeta.Name = "maskedTextBox_numeroTarjeta";
            this.maskedTextBox_numeroTarjeta.Size = new System.Drawing.Size(114, 20);
            this.maskedTextBox_numeroTarjeta.TabIndex = 1;
            this.maskedTextBox_numeroTarjeta.Click += new System.EventHandler(this.maskedTextBox_numeroTarjeta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Número de tarjeta completo";
            // 
            // comboBox_Numero_Tarjeta
            // 
            this.comboBox_Numero_Tarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Numero_Tarjeta.FormattingEnabled = true;
            this.comboBox_Numero_Tarjeta.Location = new System.Drawing.Point(352, 130);
            this.comboBox_Numero_Tarjeta.Name = "comboBox_Numero_Tarjeta";
            this.comboBox_Numero_Tarjeta.Size = new System.Drawing.Size(248, 21);
            this.comboBox_Numero_Tarjeta.TabIndex = 0;
            this.comboBox_Numero_Tarjeta.SelectedIndexChanged += new System.EventHandler(this.comboBox_Numero_Tarjeta_SelectedIndexChanged);
            // 
            // maskedTextBox_codigo
            // 
            this.maskedTextBox_codigo.Location = new System.Drawing.Point(352, 214);
            this.maskedTextBox_codigo.Mask = "999";
            this.maskedTextBox_codigo.Name = "maskedTextBox_codigo";
            this.maskedTextBox_codigo.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBox_codigo.TabIndex = 3;
            this.maskedTextBox_codigo.Click += new System.EventHandler(this.maskedTextBox_codigo_Click);
            // 
            // textBox_NombreTitular
            // 
            this.textBox_NombreTitular.Location = new System.Drawing.Point(352, 188);
            this.textBox_NombreTitular.Name = "textBox_NombreTitular";
            this.textBox_NombreTitular.Size = new System.Drawing.Size(249, 20);
            this.textBox_NombreTitular.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Código de seguridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nombre del titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Número de tarjeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Emisor";
            // 
            // comboBox_Emisores
            // 
            this.comboBox_Emisores.FormattingEnabled = true;
            this.comboBox_Emisores.Location = new System.Drawing.Point(352, 240);
            this.comboBox_Emisores.Name = "comboBox_Emisores";
            this.comboBox_Emisores.Size = new System.Drawing.Size(186, 21);
            this.comboBox_Emisores.TabIndex = 4;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 428);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 6;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(585, 428);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 5;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 428);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 7;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // checkBox_habilitada
            // 
            this.checkBox_habilitada.AutoSize = true;
            this.checkBox_habilitada.Location = new System.Drawing.Point(355, 322);
            this.checkBox_habilitada.Name = "checkBox_habilitada";
            this.checkBox_habilitada.Size = new System.Drawing.Size(73, 17);
            this.checkBox_habilitada.TabIndex = 62;
            this.checkBox_habilitada.Text = "Habilitada";
            this.checkBox_habilitada.UseVisualStyleBackColor = true;
            this.checkBox_habilitada.Visible = false;
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
            this.Load += new System.EventHandler(this.ModificarDatos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numeroTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Numero_Tarjeta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_codigo;
        private System.Windows.Forms.TextBox textBox_NombreTitular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Emisores;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fechaEmision;
        private System.Windows.Forms.TextBox textBox_FechaVencimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_habilitada;
    }
}