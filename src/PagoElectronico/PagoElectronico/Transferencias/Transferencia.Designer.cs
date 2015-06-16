namespace PagoElectronico.Transferencias
{
    partial class Transferencia
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
            this.textBox_Fecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Moneda = new System.Windows.Forms.ComboBox();
            this.textBox_Importe = new System.Windows.Forms.TextBox();
            this.label_Moneda = new System.Windows.Forms.Label();
            this.label_Importe = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_Destino = new System.Windows.Forms.TextBox();
            this.button_SeleccionarCuentaDestino = new System.Windows.Forms.Button();
            this.comboBox_Origen = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Fecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_Moneda);
            this.groupBox1.Controls.Add(this.textBox_Importe);
            this.groupBox1.Controls.Add(this.label_Moneda);
            this.groupBox1.Controls.Add(this.label_Importe);
            this.groupBox1.Location = new System.Drawing.Point(425, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 408);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de transferencia";
            // 
            // textBox_Fecha
            // 
            this.textBox_Fecha.Enabled = false;
            this.textBox_Fecha.Location = new System.Drawing.Point(131, 167);
            this.textBox_Fecha.Name = "textBox_Fecha";
            this.textBox_Fecha.Size = new System.Drawing.Size(186, 20);
            this.textBox_Fecha.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Fecha";
            // 
            // comboBox_Moneda
            // 
            this.comboBox_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Moneda.FormattingEnabled = true;
            this.comboBox_Moneda.Location = new System.Drawing.Point(131, 220);
            this.comboBox_Moneda.Name = "comboBox_Moneda";
            this.comboBox_Moneda.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Moneda.TabIndex = 24;
            // 
            // textBox_Importe
            // 
            this.textBox_Importe.Location = new System.Drawing.Point(131, 193);
            this.textBox_Importe.MaxLength = 50;
            this.textBox_Importe.Name = "textBox_Importe";
            this.textBox_Importe.Size = new System.Drawing.Size(121, 20);
            this.textBox_Importe.TabIndex = 23;
            this.textBox_Importe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Importe_KeyPress);
            // 
            // label_Moneda
            // 
            this.label_Moneda.AutoSize = true;
            this.label_Moneda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Moneda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Moneda.Location = new System.Drawing.Point(79, 223);
            this.label_Moneda.Name = "label_Moneda";
            this.label_Moneda.Size = new System.Drawing.Size(46, 13);
            this.label_Moneda.TabIndex = 22;
            this.label_Moneda.Text = "Moneda";
            // 
            // label_Importe
            // 
            this.label_Importe.AutoSize = true;
            this.label_Importe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Importe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Importe.Location = new System.Drawing.Point(83, 196);
            this.label_Importe.Name = "label_Importe";
            this.label_Importe.Size = new System.Drawing.Size(42, 13);
            this.label_Importe.TabIndex = 21;
            this.label_Importe.Text = "Importe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Origen);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 198);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta origen";
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 427);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 44;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(585, 427);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 43;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 427);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 42;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Destino);
            this.groupBox3.Controls.Add(this.button_SeleccionarCuentaDestino);
            this.groupBox3.Location = new System.Drawing.Point(12, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 205);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuenta destino";
            // 
            // textBox_Destino
            // 
            this.textBox_Destino.Enabled = false;
            this.textBox_Destino.Location = new System.Drawing.Point(26, 93);
            this.textBox_Destino.MaxLength = 255;
            this.textBox_Destino.Name = "textBox_Destino";
            this.textBox_Destino.Size = new System.Drawing.Size(262, 20);
            this.textBox_Destino.TabIndex = 0;
            this.textBox_Destino.Text = "1111111111111111";
            // 
            // button_SeleccionarCuentaDestino
            // 
            this.button_SeleccionarCuentaDestino.Location = new System.Drawing.Point(294, 91);
            this.button_SeleccionarCuentaDestino.Name = "button_SeleccionarCuentaDestino";
            this.button_SeleccionarCuentaDestino.Size = new System.Drawing.Size(75, 23);
            this.button_SeleccionarCuentaDestino.TabIndex = 23;
            this.button_SeleccionarCuentaDestino.Text = "Seleccionar";
            this.button_SeleccionarCuentaDestino.UseVisualStyleBackColor = true;
            // 
            // comboBox_Origen
            // 
            this.comboBox_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Origen.FormattingEnabled = true;
            this.comboBox_Origen.Location = new System.Drawing.Point(26, 89);
            this.comboBox_Origen.Name = "comboBox_Origen";
            this.comboBox_Origen.Size = new System.Drawing.Size(262, 21);
            this.comboBox_Origen.TabIndex = 1;
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transferencia";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencia";
            this.Load += new System.EventHandler(this.Transferencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Moneda;
        private System.Windows.Forms.TextBox textBox_Importe;
        private System.Windows.Forms.Label label_Moneda;
        private System.Windows.Forms.Label label_Importe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Destino;
        private System.Windows.Forms.Button button_SeleccionarCuentaDestino;
        private System.Windows.Forms.ComboBox comboBox_Origen;
    }
}