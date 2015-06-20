namespace PagoElectronico.Facturacion
{
    partial class Facturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturar));
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Fecha = new System.Windows.Forms.TextBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.textBox_montoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_numeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_codigo = new System.Windows.Forms.MaskedTextBox();
            this.radioButton_MASTERCARD = new System.Windows.Forms.RadioButton();
            this.radioButton_VISA = new System.Windows.Forms.RadioButton();
            this.radioButton_AMEX = new System.Windows.Forms.RadioButton();
            this.textBox_NombreTitular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Seleccion = new System.Windows.Forms.Button();
            this.button_Seleccionar = new System.Windows.Forms.Button();
            this.dataGridView_ComisionesARendir = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ComisionesARendir)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Numero";
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(131, 79);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.ReadOnly = true;
            this.textBox_Numero.Size = new System.Drawing.Size(85, 20);
            this.textBox_Numero.TabIndex = 33;
            this.textBox_Numero.TabStop = false;
            this.textBox_Numero.Text = "A generar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha";
            // 
            // textBox_Fecha
            // 
            this.textBox_Fecha.Location = new System.Drawing.Point(131, 105);
            this.textBox_Fecha.Name = "textBox_Fecha";
            this.textBox_Fecha.Size = new System.Drawing.Size(186, 20);
            this.textBox_Fecha.TabIndex = 29;
            this.textBox_Fecha.TabStop = false;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 426);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 28;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(585, 426);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 27;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 26;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // textBox_montoTotal
            // 
            this.textBox_montoTotal.Location = new System.Drawing.Point(287, 372);
            this.textBox_montoTotal.Name = "textBox_montoTotal";
            this.textBox_montoTotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_montoTotal.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total a Pagar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox_numeroTarjeta);
            this.groupBox2.Controls.Add(this.maskedTextBox_codigo);
            this.groupBox2.Controls.Add(this.radioButton_MASTERCARD);
            this.groupBox2.Controls.Add(this.radioButton_VISA);
            this.groupBox2.Controls.Add(this.radioButton_AMEX);
            this.groupBox2.Controls.Add(this.textBox_NombreTitular);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 197);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // maskedTextBox_numeroTarjeta
            // 
            this.maskedTextBox_numeroTarjeta.Location = new System.Drawing.Point(131, 82);
            this.maskedTextBox_numeroTarjeta.Mask = "9999999999999999";
            this.maskedTextBox_numeroTarjeta.Name = "maskedTextBox_numeroTarjeta";
            this.maskedTextBox_numeroTarjeta.Size = new System.Drawing.Size(113, 20);
            this.maskedTextBox_numeroTarjeta.TabIndex = 63;
            // 
            // maskedTextBox_codigo
            // 
            this.maskedTextBox_codigo.Location = new System.Drawing.Point(131, 138);
            this.maskedTextBox_codigo.Mask = "999";
            this.maskedTextBox_codigo.Name = "maskedTextBox_codigo";
            this.maskedTextBox_codigo.Size = new System.Drawing.Size(37, 20);
            this.maskedTextBox_codigo.TabIndex = 62;
            // 
            // radioButton_MASTERCARD
            // 
            this.radioButton_MASTERCARD.AutoSize = true;
            this.radioButton_MASTERCARD.Image = ((System.Drawing.Image)(resources.GetObject("radioButton_MASTERCARD.Image")));
            this.radioButton_MASTERCARD.Location = new System.Drawing.Point(170, 39);
            this.radioButton_MASTERCARD.Name = "radioButton_MASTERCARD";
            this.radioButton_MASTERCARD.Size = new System.Drawing.Size(62, 30);
            this.radioButton_MASTERCARD.TabIndex = 11;
            this.radioButton_MASTERCARD.TabStop = true;
            this.radioButton_MASTERCARD.UseVisualStyleBackColor = true;
            // 
            // radioButton_VISA
            // 
            this.radioButton_VISA.AutoSize = true;
            this.radioButton_VISA.Image = ((System.Drawing.Image)(resources.GetObject("radioButton_VISA.Image")));
            this.radioButton_VISA.Location = new System.Drawing.Point(88, 39);
            this.radioButton_VISA.Name = "radioButton_VISA";
            this.radioButton_VISA.Size = new System.Drawing.Size(62, 30);
            this.radioButton_VISA.TabIndex = 13;
            this.radioButton_VISA.TabStop = true;
            this.radioButton_VISA.UseVisualStyleBackColor = true;
            // 
            // radioButton_AMEX
            // 
            this.radioButton_AMEX.AutoSize = true;
            this.radioButton_AMEX.Image = ((System.Drawing.Image)(resources.GetObject("radioButton_AMEX.Image")));
            this.radioButton_AMEX.Location = new System.Drawing.Point(249, 39);
            this.radioButton_AMEX.Name = "radioButton_AMEX";
            this.radioButton_AMEX.Size = new System.Drawing.Size(62, 30);
            this.radioButton_AMEX.TabIndex = 15;
            this.radioButton_AMEX.TabStop = true;
            this.radioButton_AMEX.UseVisualStyleBackColor = true;
            // 
            // textBox_NombreTitular
            // 
            this.textBox_NombreTitular.Location = new System.Drawing.Point(131, 112);
            this.textBox_NombreTitular.Name = "textBox_NombreTitular";
            this.textBox_NombreTitular.Size = new System.Drawing.Size(249, 20);
            this.textBox_NombreTitular.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Codigo de Seguridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre del titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero de tarjeta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Seleccion);
            this.groupBox1.Controls.Add(this.button_Seleccionar);
            this.groupBox1.Controls.Add(this.dataGridView_ComisionesARendir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_montoTotal);
            this.groupBox1.Location = new System.Drawing.Point(427, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 408);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comisiones a Rendir";
            // 
            // button_Seleccion
            // 
            this.button_Seleccion.Location = new System.Drawing.Point(6, 369);
            this.button_Seleccion.Name = "button_Seleccion";
            this.button_Seleccion.Size = new System.Drawing.Size(75, 23);
            this.button_Seleccion.TabIndex = 35;
            this.button_Seleccion.Text = "Seleccionar";
            this.button_Seleccion.UseVisualStyleBackColor = true;
            this.button_Seleccion.Click += new System.EventHandler(this.button_Seleccion_Click);
            // 
            // button_Seleccionar
            // 
            this.button_Seleccionar.Location = new System.Drawing.Point(533, 135);
            this.button_Seleccionar.Name = "button_Seleccionar";
            this.button_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.button_Seleccionar.TabIndex = 34;
            this.button_Seleccionar.Text = "Seleccionar";
            this.button_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ComisionesARendir
            // 
            this.dataGridView_ComisionesARendir.AllowUserToAddRows = false;
            this.dataGridView_ComisionesARendir.AllowUserToDeleteRows = false;
            this.dataGridView_ComisionesARendir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_ComisionesARendir.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_ComisionesARendir.Name = "dataGridView_ComisionesARendir";
            this.dataGridView_ComisionesARendir.ReadOnly = true;
            this.dataGridView_ComisionesARendir.Size = new System.Drawing.Size(381, 334);
            this.dataGridView_ComisionesARendir.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Numero);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox_Fecha);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 205);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de factura";
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Facturar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.Facturar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ComisionesARendir)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Fecha;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.TextBox textBox_montoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_ComisionesARendir;
        private System.Windows.Forms.RadioButton radioButton_MASTERCARD;
        private System.Windows.Forms.RadioButton radioButton_VISA;
        private System.Windows.Forms.RadioButton radioButton_AMEX;
        private System.Windows.Forms.TextBox textBox_NombreTitular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Seleccionar;
        private System.Windows.Forms.Button button_Seleccion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numeroTarjeta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_codigo;
    }
}