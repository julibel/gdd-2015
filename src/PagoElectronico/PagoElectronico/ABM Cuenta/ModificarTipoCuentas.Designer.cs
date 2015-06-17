namespace PagoElectronico.ABM_Cuenta
{
    partial class ModificarTipoCuentas
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
            this.paner_TipoCuentas = new System.Windows.Forms.GroupBox();
            this.textBox_CostoModificado = new System.Windows.Forms.TextBox();
            this.label_CostoModificado = new System.Windows.Forms.Label();
            this.textBox_CostoActual = new System.Windows.Forms.TextBox();
            this.label_CostoActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_TipoCuenta = new System.Windows.Forms.ComboBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.paner_TipoCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // paner_TipoCuentas
            // 
            this.paner_TipoCuentas.Controls.Add(this.textBox_CostoModificado);
            this.paner_TipoCuentas.Controls.Add(this.label_CostoModificado);
            this.paner_TipoCuentas.Controls.Add(this.textBox_CostoActual);
            this.paner_TipoCuentas.Controls.Add(this.label_CostoActual);
            this.paner_TipoCuentas.Controls.Add(this.label1);
            this.paner_TipoCuentas.Controls.Add(this.comboBox_TipoCuenta);
            this.paner_TipoCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_TipoCuentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_TipoCuentas.Location = new System.Drawing.Point(12, 12);
            this.paner_TipoCuentas.Name = "paner_TipoCuentas";
            this.paner_TipoCuentas.Size = new System.Drawing.Size(807, 408);
            this.paner_TipoCuentas.TabIndex = 29;
            this.paner_TipoCuentas.TabStop = false;
            this.paner_TipoCuentas.Text = "Modificacion de tipo de cuenta";
            // 
            // textBox_CostoModificado
            // 
            this.textBox_CostoModificado.Location = new System.Drawing.Point(390, 221);
            this.textBox_CostoModificado.Name = "textBox_CostoModificado";
            this.textBox_CostoModificado.Size = new System.Drawing.Size(121, 20);
            this.textBox_CostoModificado.TabIndex = 5;
            // 
            // label_CostoModificado
            // 
            this.label_CostoModificado.AutoSize = true;
            this.label_CostoModificado.Location = new System.Drawing.Point(296, 224);
            this.label_CostoModificado.Name = "label_CostoModificado";
            this.label_CostoModificado.Size = new System.Drawing.Size(88, 13);
            this.label_CostoModificado.TabIndex = 4;
            this.label_CostoModificado.Text = "Costo modificado";
            // 
            // textBox_CostoActual
            // 
            this.textBox_CostoActual.Enabled = false;
            this.textBox_CostoActual.Location = new System.Drawing.Point(390, 195);
            this.textBox_CostoActual.Name = "textBox_CostoActual";
            this.textBox_CostoActual.Size = new System.Drawing.Size(121, 20);
            this.textBox_CostoActual.TabIndex = 3;
            // 
            // label_CostoActual
            // 
            this.label_CostoActual.AutoSize = true;
            this.label_CostoActual.Location = new System.Drawing.Point(318, 198);
            this.label_CostoActual.Name = "label_CostoActual";
            this.label_CostoActual.Size = new System.Drawing.Size(66, 13);
            this.label_CostoActual.TabIndex = 2;
            this.label_CostoActual.Text = "Costo actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Cuenta";
            // 
            // comboBox_TipoCuenta
            // 
            this.comboBox_TipoCuenta.FormattingEnabled = true;
            this.comboBox_TipoCuenta.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce"});
            this.comboBox_TipoCuenta.Location = new System.Drawing.Point(390, 168);
            this.comboBox_TipoCuenta.Name = "comboBox_TipoCuenta";
            this.comboBox_TipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipoCuenta.TabIndex = 0;
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
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(585, 426);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 27;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
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
            // ModificarTipoCuentas
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
            this.Name = "ModificarTipoCuentas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar costos de tipo de cuentas";
            this.paner_TipoCuentas.ResumeLayout(false);
            this.paner_TipoCuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox paner_TipoCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_TipoCuenta;
        private System.Windows.Forms.TextBox textBox_CostoModificado;
        private System.Windows.Forms.Label label_CostoModificado;
        private System.Windows.Forms.TextBox textBox_CostoActual;
        private System.Windows.Forms.Label label_CostoActual;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
    }
}