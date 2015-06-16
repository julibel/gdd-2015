namespace PagoElectronico.Consulta_Saldos
{
    partial class SeleccionCliente
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
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.label_NumeroCuenta = new System.Windows.Forms.Label();
            this.paner_Filtros = new System.Windows.Forms.GroupBox();
            this.comboBox_Cuentas = new System.Windows.Forms.ComboBox();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.paner_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(715, 125);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 14;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // label_NumeroCuenta
            // 
            this.label_NumeroCuenta.AutoSize = true;
            this.label_NumeroCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NumeroCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_NumeroCuenta.Location = new System.Drawing.Point(239, 48);
            this.label_NumeroCuenta.Name = "label_NumeroCuenta";
            this.label_NumeroCuenta.Size = new System.Drawing.Size(95, 13);
            this.label_NumeroCuenta.TabIndex = 24;
            this.label_NumeroCuenta.Text = "Numero de cuenta";
            // 
            // paner_Filtros
            // 
            this.paner_Filtros.Controls.Add(this.label_NumeroCuenta);
            this.paner_Filtros.Controls.Add(this.button_Aceptar);
            this.paner_Filtros.Controls.Add(this.comboBox_Cuentas);
            this.paner_Filtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Filtros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_Filtros.Location = new System.Drawing.Point(12, 12);
            this.paner_Filtros.Name = "paner_Filtros";
            this.paner_Filtros.Size = new System.Drawing.Size(810, 163);
            this.paner_Filtros.TabIndex = 35;
            this.paner_Filtros.TabStop = false;
            this.paner_Filtros.Text = "Seleccionar cuenta";
            // 
            // comboBox_Cuentas
            // 
            this.comboBox_Cuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cuentas.FormattingEnabled = true;
            this.comboBox_Cuentas.Location = new System.Drawing.Point(340, 44);
            this.comboBox_Cuentas.Name = "comboBox_Cuentas";
            this.comboBox_Cuentas.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Cuentas.TabIndex = 25;
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(727, 181);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 37;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // SeleccionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 207);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.paner_Filtros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.Load += new System.EventHandler(this.SeleccionCliente_Load);
            this.paner_Filtros.ResumeLayout(false);
            this.paner_Filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Label label_NumeroCuenta;
        private System.Windows.Forms.GroupBox paner_Filtros;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.ComboBox comboBox_Cuentas;


    }
}