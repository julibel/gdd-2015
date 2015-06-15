namespace PagoElectronico.Depositos
{
    partial class DepositoNuevo
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
            this.button_SeleccionarTarjeta = new System.Windows.Forms.Button();
            this.label_Tarjeta = new System.Windows.Forms.Label();
            this.textBox_TarjetaCredito = new System.Windows.Forms.TextBox();
            this.comboBox_Moneda = new System.Windows.Forms.ComboBox();
            this.textBox_Pais = new System.Windows.Forms.TextBox();
            this.label_Moneda = new System.Windows.Forms.Label();
            this.label_Importe = new System.Windows.Forms.Label();
            this.label_NumeroCuenta = new System.Windows.Forms.Label();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.comboBox_Cuentas = new System.Windows.Forms.ComboBox();
            this.paner_DatosCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // paner_DatosCuenta
            // 
            this.paner_DatosCuenta.Controls.Add(this.comboBox_Cuentas);
            this.paner_DatosCuenta.Controls.Add(this.button_SeleccionarTarjeta);
            this.paner_DatosCuenta.Controls.Add(this.label_Tarjeta);
            this.paner_DatosCuenta.Controls.Add(this.textBox_TarjetaCredito);
            this.paner_DatosCuenta.Controls.Add(this.comboBox_Moneda);
            this.paner_DatosCuenta.Controls.Add(this.textBox_Pais);
            this.paner_DatosCuenta.Controls.Add(this.label_Moneda);
            this.paner_DatosCuenta.Controls.Add(this.label_Importe);
            this.paner_DatosCuenta.Controls.Add(this.label_NumeroCuenta);
            this.paner_DatosCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_DatosCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_DatosCuenta.Location = new System.Drawing.Point(12, 12);
            this.paner_DatosCuenta.Name = "paner_DatosCuenta";
            this.paner_DatosCuenta.Size = new System.Drawing.Size(810, 410);
            this.paner_DatosCuenta.TabIndex = 36;
            this.paner_DatosCuenta.TabStop = false;
            this.paner_DatosCuenta.Text = "Deposito de dinero";
            // 
            // button_SeleccionarTarjeta
            // 
            this.button_SeleccionarTarjeta.Location = new System.Drawing.Point(535, 234);
            this.button_SeleccionarTarjeta.Name = "button_SeleccionarTarjeta";
            this.button_SeleccionarTarjeta.Size = new System.Drawing.Size(75, 23);
            this.button_SeleccionarTarjeta.TabIndex = 26;
            this.button_SeleccionarTarjeta.Text = "Seleccionar";
            this.button_SeleccionarTarjeta.UseVisualStyleBackColor = true;
            // 
            // label_Tarjeta
            // 
            this.label_Tarjeta.AutoSize = true;
            this.label_Tarjeta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Tarjeta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Tarjeta.Location = new System.Drawing.Point(200, 239);
            this.label_Tarjeta.Name = "label_Tarjeta";
            this.label_Tarjeta.Size = new System.Drawing.Size(91, 13);
            this.label_Tarjeta.TabIndex = 25;
            this.label_Tarjeta.Text = "Tarjeta de Credito";
            // 
            // textBox_TarjetaCredito
            // 
            this.textBox_TarjetaCredito.Location = new System.Drawing.Point(297, 236);
            this.textBox_TarjetaCredito.MaxLength = 255;
            this.textBox_TarjetaCredito.Name = "textBox_TarjetaCredito";
            this.textBox_TarjetaCredito.Size = new System.Drawing.Size(232, 20);
            this.textBox_TarjetaCredito.TabIndex = 24;
            // 
            // comboBox_Moneda
            // 
            this.comboBox_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Moneda.FormattingEnabled = true;
            this.comboBox_Moneda.Items.AddRange(new object[] {
            "Dolares"});
            this.comboBox_Moneda.Location = new System.Drawing.Point(297, 209);
            this.comboBox_Moneda.Name = "comboBox_Moneda";
            this.comboBox_Moneda.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Moneda.TabIndex = 20;
            // 
            // textBox_Pais
            // 
            this.textBox_Pais.Location = new System.Drawing.Point(297, 182);
            this.textBox_Pais.MaxLength = 50;
            this.textBox_Pais.Name = "textBox_Pais";
            this.textBox_Pais.Size = new System.Drawing.Size(121, 20);
            this.textBox_Pais.TabIndex = 19;
            // 
            // label_Moneda
            // 
            this.label_Moneda.AutoSize = true;
            this.label_Moneda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Moneda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Moneda.Location = new System.Drawing.Point(245, 212);
            this.label_Moneda.Name = "label_Moneda";
            this.label_Moneda.Size = new System.Drawing.Size(46, 13);
            this.label_Moneda.TabIndex = 9;
            this.label_Moneda.Text = "Moneda";
            // 
            // label_Importe
            // 
            this.label_Importe.AutoSize = true;
            this.label_Importe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Importe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Importe.Location = new System.Drawing.Point(249, 185);
            this.label_Importe.Name = "label_Importe";
            this.label_Importe.Size = new System.Drawing.Size(42, 13);
            this.label_Importe.TabIndex = 8;
            this.label_Importe.Text = "Importe";
            // 
            // label_NumeroCuenta
            // 
            this.label_NumeroCuenta.AutoSize = true;
            this.label_NumeroCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NumeroCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_NumeroCuenta.Location = new System.Drawing.Point(250, 159);
            this.label_NumeroCuenta.Name = "label_NumeroCuenta";
            this.label_NumeroCuenta.Size = new System.Drawing.Size(41, 13);
            this.label_NumeroCuenta.TabIndex = 1;
            this.label_NumeroCuenta.Text = "Cuenta";
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 428);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 35;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(585, 428);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 34;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 428);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 33;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // comboBox_Cuentas
            // 
            this.comboBox_Cuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cuentas.FormattingEnabled = true;
            this.comboBox_Cuentas.Location = new System.Drawing.Point(297, 156);
            this.comboBox_Cuentas.Name = "comboBox_Cuentas";
            this.comboBox_Cuentas.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Cuentas.TabIndex = 27;
            // 
            // DepositoNuevo
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
            this.Name = "DepositoNuevo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositoNuevo";
            this.paner_DatosCuenta.ResumeLayout(false);
            this.paner_DatosCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox paner_DatosCuenta;
        private System.Windows.Forms.ComboBox comboBox_Moneda;
        private System.Windows.Forms.TextBox textBox_Pais;
        private System.Windows.Forms.Label label_Moneda;
        private System.Windows.Forms.Label label_Importe;
        private System.Windows.Forms.Label label_NumeroCuenta;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button button_SeleccionarTarjeta;
        private System.Windows.Forms.Label label_Tarjeta;
        private System.Windows.Forms.TextBox textBox_TarjetaCredito;
        private System.Windows.Forms.ComboBox comboBox_Cuentas;
    }
}