namespace PagoElectronico.ABM_Cuenta
{
    partial class ModificarCategoriaCuenta
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
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.paner_TipoCuentas = new System.Windows.Forms.GroupBox();
            this.comboBox_TipoCuentaActual = new System.Windows.Forms.ComboBox();
            this.label_TipoCuenta = new System.Windows.Forms.Label();
            this.comboBox_Moneda = new System.Windows.Forms.ComboBox();
            this.textBox_Pais = new System.Windows.Forms.TextBox();
            this.label_Moneda = new System.Windows.Forms.Label();
            this.label_Pais = new System.Windows.Forms.Label();
            this.label_NumeroCuenta = new System.Windows.Forms.Label();
            this.textBox_NumeroCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_TipoCuentaModificada = new System.Windows.Forms.ComboBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.paner_TipoCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 426);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 32;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            // 
            // paner_TipoCuentas
            // 
            this.paner_TipoCuentas.Controls.Add(this.comboBox_TipoCuentaActual);
            this.paner_TipoCuentas.Controls.Add(this.label_TipoCuenta);
            this.paner_TipoCuentas.Controls.Add(this.comboBox_Moneda);
            this.paner_TipoCuentas.Controls.Add(this.textBox_Pais);
            this.paner_TipoCuentas.Controls.Add(this.label_Moneda);
            this.paner_TipoCuentas.Controls.Add(this.label_Pais);
            this.paner_TipoCuentas.Controls.Add(this.label_NumeroCuenta);
            this.paner_TipoCuentas.Controls.Add(this.textBox_NumeroCuenta);
            this.paner_TipoCuentas.Controls.Add(this.label1);
            this.paner_TipoCuentas.Controls.Add(this.comboBox_TipoCuentaModificada);
            this.paner_TipoCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_TipoCuentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_TipoCuentas.Location = new System.Drawing.Point(12, 12);
            this.paner_TipoCuentas.Name = "paner_TipoCuentas";
            this.paner_TipoCuentas.Size = new System.Drawing.Size(807, 408);
            this.paner_TipoCuentas.TabIndex = 33;
            this.paner_TipoCuentas.TabStop = false;
            this.paner_TipoCuentas.Text = "Modificacion de categoria de cuenta";
            // 
            // comboBox_TipoCuentaActual
            // 
            this.comboBox_TipoCuentaActual.Enabled = false;
            this.comboBox_TipoCuentaActual.FormattingEnabled = true;
            this.comboBox_TipoCuentaActual.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBox_TipoCuentaActual.Location = new System.Drawing.Point(357, 220);
            this.comboBox_TipoCuentaActual.Name = "comboBox_TipoCuentaActual";
            this.comboBox_TipoCuentaActual.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipoCuentaActual.TabIndex = 30;
            // 
            // label_TipoCuenta
            // 
            this.label_TipoCuenta.AutoSize = true;
            this.label_TipoCuenta.Location = new System.Drawing.Point(240, 223);
            this.label_TipoCuenta.Name = "label_TipoCuenta";
            this.label_TipoCuenta.Size = new System.Drawing.Size(111, 13);
            this.label_TipoCuenta.TabIndex = 29;
            this.label_TipoCuenta.Text = "Tipo de cuenta actual";
            // 
            // comboBox_Moneda
            // 
            this.comboBox_Moneda.Enabled = false;
            this.comboBox_Moneda.FormattingEnabled = true;
            this.comboBox_Moneda.Items.AddRange(new object[] {
            "Dolares"});
            this.comboBox_Moneda.Location = new System.Drawing.Point(357, 193);
            this.comboBox_Moneda.Name = "comboBox_Moneda";
            this.comboBox_Moneda.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Moneda.TabIndex = 28;
            // 
            // textBox_Pais
            // 
            this.textBox_Pais.Enabled = false;
            this.textBox_Pais.Location = new System.Drawing.Point(357, 166);
            this.textBox_Pais.MaxLength = 50;
            this.textBox_Pais.Name = "textBox_Pais";
            this.textBox_Pais.Size = new System.Drawing.Size(232, 20);
            this.textBox_Pais.TabIndex = 27;
            // 
            // label_Moneda
            // 
            this.label_Moneda.AutoSize = true;
            this.label_Moneda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Moneda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Moneda.Location = new System.Drawing.Point(305, 196);
            this.label_Moneda.Name = "label_Moneda";
            this.label_Moneda.Size = new System.Drawing.Size(46, 13);
            this.label_Moneda.TabIndex = 26;
            this.label_Moneda.Text = "Moneda";
            // 
            // label_Pais
            // 
            this.label_Pais.AutoSize = true;
            this.label_Pais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Pais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Pais.Location = new System.Drawing.Point(324, 169);
            this.label_Pais.Name = "label_Pais";
            this.label_Pais.Size = new System.Drawing.Size(27, 13);
            this.label_Pais.TabIndex = 25;
            this.label_Pais.Text = "Pais";
            // 
            // label_NumeroCuenta
            // 
            this.label_NumeroCuenta.AutoSize = true;
            this.label_NumeroCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NumeroCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_NumeroCuenta.Location = new System.Drawing.Point(256, 143);
            this.label_NumeroCuenta.Name = "label_NumeroCuenta";
            this.label_NumeroCuenta.Size = new System.Drawing.Size(95, 13);
            this.label_NumeroCuenta.TabIndex = 24;
            this.label_NumeroCuenta.Text = "Numero de cuenta";
            // 
            // textBox_NumeroCuenta
            // 
            this.textBox_NumeroCuenta.Enabled = false;
            this.textBox_NumeroCuenta.Location = new System.Drawing.Point(357, 140);
            this.textBox_NumeroCuenta.MaxLength = 255;
            this.textBox_NumeroCuenta.Name = "textBox_NumeroCuenta";
            this.textBox_NumeroCuenta.Size = new System.Drawing.Size(232, 20);
            this.textBox_NumeroCuenta.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Cuenta modificada";
            // 
            // comboBox_TipoCuentaModificada
            // 
            this.comboBox_TipoCuentaModificada.FormattingEnabled = true;
            this.comboBox_TipoCuentaModificada.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBox_TipoCuentaModificada.Location = new System.Drawing.Point(357, 247);
            this.comboBox_TipoCuentaModificada.Name = "comboBox_TipoCuentaModificada";
            this.comboBox_TipoCuentaModificada.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipoCuentaModificada.TabIndex = 0;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(585, 426);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 31;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 30;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // ModificarCategoriaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.paner_TipoCuentas);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarCategoriaCuenta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCategoriaCuenta";
            this.paner_TipoCuentas.ResumeLayout(false);
            this.paner_TipoCuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.GroupBox paner_TipoCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_TipoCuentaModificada;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.ComboBox comboBox_TipoCuentaActual;
        private System.Windows.Forms.Label label_TipoCuenta;
        private System.Windows.Forms.ComboBox comboBox_Moneda;
        private System.Windows.Forms.TextBox textBox_Pais;
        private System.Windows.Forms.Label label_Moneda;
        private System.Windows.Forms.Label label_Pais;
        private System.Windows.Forms.Label label_NumeroCuenta;
        private System.Windows.Forms.TextBox textBox_NumeroCuenta;

    }
}