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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_Pais = new System.Windows.Forms.TextBox();
            this.label_Moneda = new System.Windows.Forms.Label();
            this.label_Importe = new System.Windows.Forms.Label();
            this.label_NumeroCuenta = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.button_Seleccionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Tarjeta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paner_DatosCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // paner_DatosCuenta
            // 
            this.paner_DatosCuenta.Controls.Add(this.button1);
            this.paner_DatosCuenta.Controls.Add(this.label_Tarjeta);
            this.paner_DatosCuenta.Controls.Add(this.textBox1);
            this.paner_DatosCuenta.Controls.Add(this.button_Seleccionar);
            this.paner_DatosCuenta.Controls.Add(this.comboBox1);
            this.paner_DatosCuenta.Controls.Add(this.textBox_Pais);
            this.paner_DatosCuenta.Controls.Add(this.label_Moneda);
            this.paner_DatosCuenta.Controls.Add(this.label_Importe);
            this.paner_DatosCuenta.Controls.Add(this.label_NumeroCuenta);
            this.paner_DatosCuenta.Controls.Add(this.textBox_Nombre);
            this.paner_DatosCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_DatosCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_DatosCuenta.Location = new System.Drawing.Point(12, 12);
            this.paner_DatosCuenta.Name = "paner_DatosCuenta";
            this.paner_DatosCuenta.Size = new System.Drawing.Size(810, 410);
            this.paner_DatosCuenta.TabIndex = 36;
            this.paner_DatosCuenta.TabStop = false;
            this.paner_DatosCuenta.Text = "Deposito de dinero";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dolares"});
            this.comboBox1.Location = new System.Drawing.Point(297, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
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
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(297, 156);
            this.textBox_Nombre.MaxLength = 255;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(661, 428);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 35;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(580, 428);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 34;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(742, 428);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 33;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            // 
            // button_Seleccionar
            // 
            this.button_Seleccionar.Location = new System.Drawing.Point(535, 154);
            this.button_Seleccionar.Name = "button_Seleccionar";
            this.button_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.button_Seleccionar.TabIndex = 23;
            this.button_Seleccionar.Text = "Seleccionar";
            this.button_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 236);
            this.textBox1.MaxLength = 255;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 24;
            // 
            // DepositoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.paner_DatosCuenta);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_cerrar);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_Pais;
        private System.Windows.Forms.Label label_Moneda;
        private System.Windows.Forms.Label label_Importe;
        private System.Windows.Forms.Label label_NumeroCuenta;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.Button button_Seleccionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Tarjeta;
        private System.Windows.Forms.TextBox textBox1;
    }
}