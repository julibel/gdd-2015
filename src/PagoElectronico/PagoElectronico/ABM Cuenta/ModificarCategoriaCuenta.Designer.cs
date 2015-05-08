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
            this.button_limpiar = new System.Windows.Forms.Button();
            this.paner_TipoCuentas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label_TipoCuenta = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox_Pais = new System.Windows.Forms.TextBox();
            this.label_Moneda = new System.Windows.Forms.Label();
            this.label_Pais = new System.Windows.Forms.Label();
            this.label_NumeroCuenta = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.paner_TipoCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(666, 426);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 32;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // paner_TipoCuentas
            // 
            this.paner_TipoCuentas.Controls.Add(this.comboBox2);
            this.paner_TipoCuentas.Controls.Add(this.label_TipoCuenta);
            this.paner_TipoCuentas.Controls.Add(this.comboBox3);
            this.paner_TipoCuentas.Controls.Add(this.textBox_Pais);
            this.paner_TipoCuentas.Controls.Add(this.label_Moneda);
            this.paner_TipoCuentas.Controls.Add(this.label_Pais);
            this.paner_TipoCuentas.Controls.Add(this.label_NumeroCuenta);
            this.paner_TipoCuentas.Controls.Add(this.textBox_Nombre);
            this.paner_TipoCuentas.Controls.Add(this.label1);
            this.paner_TipoCuentas.Controls.Add(this.comboBox1);
            this.paner_TipoCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_TipoCuentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_TipoCuentas.Location = new System.Drawing.Point(12, 12);
            this.paner_TipoCuentas.Name = "paner_TipoCuentas";
            this.paner_TipoCuentas.Size = new System.Drawing.Size(807, 408);
            this.paner_TipoCuentas.TabIndex = 33;
            this.paner_TipoCuentas.TabStop = false;
            this.paner_TipoCuentas.Text = "Modificacion de categoria de cuenta";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBox1.Location = new System.Drawing.Point(357, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(585, 426);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 31;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 30;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBox2.Location = new System.Drawing.Point(357, 220);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 30;
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
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Dolares"});
            this.comboBox3.Location = new System.Drawing.Point(357, 193);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 28;
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
            // textBox_Nombre
            // 
            this.textBox_Nombre.Enabled = false;
            this.textBox_Nombre.Location = new System.Drawing.Point(357, 140);
            this.textBox_Nombre.MaxLength = 255;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 23;
            // 
            // ModificarCategoriaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.paner_TipoCuentas);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_cerrar);
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

        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.GroupBox paner_TipoCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label_TipoCuenta;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox_Pais;
        private System.Windows.Forms.Label label_Moneda;
        private System.Windows.Forms.Label label_Pais;
        private System.Windows.Forms.Label label_NumeroCuenta;
        private System.Windows.Forms.TextBox textBox_Nombre;

    }
}