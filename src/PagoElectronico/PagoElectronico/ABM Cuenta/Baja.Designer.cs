namespace PagoElectronico.ABM_Cuenta
{
    partial class Baja
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label_TipoCuenta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_Pais = new System.Windows.Forms.TextBox();
            this.label_Moneda = new System.Windows.Forms.Label();
            this.label_Pais = new System.Windows.Forms.Label();
            this.label_NumeroCuenta = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.button_borrar = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.paner_DatosCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // paner_DatosCuenta
            // 
            this.paner_DatosCuenta.Controls.Add(this.comboBox2);
            this.paner_DatosCuenta.Controls.Add(this.label_TipoCuenta);
            this.paner_DatosCuenta.Controls.Add(this.comboBox1);
            this.paner_DatosCuenta.Controls.Add(this.textBox_Pais);
            this.paner_DatosCuenta.Controls.Add(this.label_Moneda);
            this.paner_DatosCuenta.Controls.Add(this.label_Pais);
            this.paner_DatosCuenta.Controls.Add(this.label_NumeroCuenta);
            this.paner_DatosCuenta.Controls.Add(this.textBox_Nombre);
            this.paner_DatosCuenta.Enabled = false;
            this.paner_DatosCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_DatosCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_DatosCuenta.Location = new System.Drawing.Point(12, 12);
            this.paner_DatosCuenta.Name = "paner_DatosCuenta";
            this.paner_DatosCuenta.Size = new System.Drawing.Size(810, 410);
            this.paner_DatosCuenta.TabIndex = 36;
            this.paner_DatosCuenta.TabStop = false;
            this.paner_DatosCuenta.Text = "Datos de la cuenta";
            this.paner_DatosCuenta.Enter += new System.EventHandler(this.paner_DatosCuenta_Enter);
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
            this.comboBox2.Location = new System.Drawing.Point(340, 235);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // label_TipoCuenta
            // 
            this.label_TipoCuenta.AutoSize = true;
            this.label_TipoCuenta.Location = new System.Drawing.Point(255, 238);
            this.label_TipoCuenta.Name = "label_TipoCuenta";
            this.label_TipoCuenta.Size = new System.Drawing.Size(79, 13);
            this.label_TipoCuenta.TabIndex = 21;
            this.label_TipoCuenta.Text = "Tipo de cuenta";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dolares"});
            this.comboBox1.Location = new System.Drawing.Point(340, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // textBox_Pais
            // 
            this.textBox_Pais.Enabled = false;
            this.textBox_Pais.Location = new System.Drawing.Point(340, 181);
            this.textBox_Pais.MaxLength = 50;
            this.textBox_Pais.Name = "textBox_Pais";
            this.textBox_Pais.Size = new System.Drawing.Size(232, 20);
            this.textBox_Pais.TabIndex = 19;
            // 
            // label_Moneda
            // 
            this.label_Moneda.AutoSize = true;
            this.label_Moneda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Moneda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Moneda.Location = new System.Drawing.Point(288, 211);
            this.label_Moneda.Name = "label_Moneda";
            this.label_Moneda.Size = new System.Drawing.Size(46, 13);
            this.label_Moneda.TabIndex = 9;
            this.label_Moneda.Text = "Moneda";
            // 
            // label_Pais
            // 
            this.label_Pais.AutoSize = true;
            this.label_Pais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Pais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Pais.Location = new System.Drawing.Point(307, 184);
            this.label_Pais.Name = "label_Pais";
            this.label_Pais.Size = new System.Drawing.Size(27, 13);
            this.label_Pais.TabIndex = 8;
            this.label_Pais.Text = "Pais";
            // 
            // label_NumeroCuenta
            // 
            this.label_NumeroCuenta.AutoSize = true;
            this.label_NumeroCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NumeroCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_NumeroCuenta.Location = new System.Drawing.Point(239, 158);
            this.label_NumeroCuenta.Name = "label_NumeroCuenta";
            this.label_NumeroCuenta.Size = new System.Drawing.Size(95, 13);
            this.label_NumeroCuenta.TabIndex = 1;
            this.label_NumeroCuenta.Text = "Numero de cuenta";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Enabled = false;
            this.textBox_Nombre.Location = new System.Drawing.Point(340, 155);
            this.textBox_Nombre.MaxLength = 255;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // button_borrar
            // 
            this.button_borrar.Location = new System.Drawing.Point(666, 428);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(75, 23);
            this.button_borrar.TabIndex = 31;
            this.button_borrar.Text = "Borrar";
            this.button_borrar.UseVisualStyleBackColor = true;
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(747, 428);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 30;
            this.button_volver.Text = "Cerrar";
            this.button_volver.UseVisualStyleBackColor = true;
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.paner_DatosCuenta);
            this.Controls.Add(this.button_volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Baja";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.paner_DatosCuenta.ResumeLayout(false);
            this.paner_DatosCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox paner_DatosCuenta;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label_TipoCuenta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_Pais;
        private System.Windows.Forms.Label label_Moneda;
        private System.Windows.Forms.Label label_Pais;
        private System.Windows.Forms.Label label_NumeroCuenta;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Button button_volver;
    }
}