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
            this.textBox_CostoMantModificado = new System.Windows.Forms.TextBox();
            this.label_CostoModificado = new System.Windows.Forms.Label();
            this.textBox_CostoMantActual = new System.Windows.Forms.TextBox();
            this.label_CostoActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.comboBox_TipoCuenta = new System.Windows.Forms.ComboBox();
            this.textBox_CostoTranModificado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CostTranActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paner_TipoCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // paner_TipoCuentas
            // 
            this.paner_TipoCuentas.Controls.Add(this.textBox_CostoTranModificado);
            this.paner_TipoCuentas.Controls.Add(this.label2);
            this.paner_TipoCuentas.Controls.Add(this.textBox_CostTranActual);
            this.paner_TipoCuentas.Controls.Add(this.label3);
            this.paner_TipoCuentas.Controls.Add(this.comboBox_TipoCuenta);
            this.paner_TipoCuentas.Controls.Add(this.textBox_CostoMantModificado);
            this.paner_TipoCuentas.Controls.Add(this.label_CostoModificado);
            this.paner_TipoCuentas.Controls.Add(this.textBox_CostoMantActual);
            this.paner_TipoCuentas.Controls.Add(this.label_CostoActual);
            this.paner_TipoCuentas.Controls.Add(this.label1);
            this.paner_TipoCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_TipoCuentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_TipoCuentas.Location = new System.Drawing.Point(12, 12);
            this.paner_TipoCuentas.Name = "paner_TipoCuentas";
            this.paner_TipoCuentas.Size = new System.Drawing.Size(807, 408);
            this.paner_TipoCuentas.TabIndex = 29;
            this.paner_TipoCuentas.TabStop = false;
            this.paner_TipoCuentas.Text = "Modificacion de tipo de cuenta";
            // 
            // textBox_CostoMantModificado
            // 
            this.textBox_CostoMantModificado.Location = new System.Drawing.Point(282, 245);
            this.textBox_CostoMantModificado.Name = "textBox_CostoMantModificado";
            this.textBox_CostoMantModificado.Size = new System.Drawing.Size(121, 20);
            this.textBox_CostoMantModificado.TabIndex = 5;
            this.textBox_CostoMantModificado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CostoMantModificado_KeyPress);
            // 
            // label_CostoModificado
            // 
            this.label_CostoModificado.AutoSize = true;
            this.label_CostoModificado.Location = new System.Drawing.Point(117, 248);
            this.label_CostoModificado.Name = "label_CostoModificado";
            this.label_CostoModificado.Size = new System.Drawing.Size(159, 13);
            this.label_CostoModificado.TabIndex = 4;
            this.label_CostoModificado.Text = "Costo mantenimiento modificado";
            // 
            // textBox_CostoMantActual
            // 
            this.textBox_CostoMantActual.Enabled = false;
            this.textBox_CostoMantActual.Location = new System.Drawing.Point(282, 219);
            this.textBox_CostoMantActual.Name = "textBox_CostoMantActual";
            this.textBox_CostoMantActual.Size = new System.Drawing.Size(121, 20);
            this.textBox_CostoMantActual.TabIndex = 3;
            // 
            // label_CostoActual
            // 
            this.label_CostoActual.AutoSize = true;
            this.label_CostoActual.Location = new System.Drawing.Point(139, 222);
            this.label_CostoActual.Name = "label_CostoActual";
            this.label_CostoActual.Size = new System.Drawing.Size(137, 13);
            this.label_CostoActual.TabIndex = 2;
            this.label_CostoActual.Text = "Costo mantenimiento actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Cuenta";
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
            // comboBox_TipoCuenta
            // 
            this.comboBox_TipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TipoCuenta.FormattingEnabled = true;
            this.comboBox_TipoCuenta.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce",
            "Gratuita"});
            this.comboBox_TipoCuenta.Location = new System.Drawing.Point(386, 168);
            this.comboBox_TipoCuenta.Name = "comboBox_TipoCuenta";
            this.comboBox_TipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipoCuenta.TabIndex = 23;
            this.comboBox_TipoCuenta.SelectedIndexChanged += new System.EventHandler(this.comboBox_TipoCuenta_SelectedIndexChanged);
            // 
            // textBox_CostoTranModificado
            // 
            this.textBox_CostoTranModificado.Location = new System.Drawing.Point(569, 245);
            this.textBox_CostoTranModificado.Name = "textBox_CostoTranModificado";
            this.textBox_CostoTranModificado.Size = new System.Drawing.Size(121, 20);
            this.textBox_CostoTranModificado.TabIndex = 27;
            this.textBox_CostoTranModificado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CostoTranModificado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Costo transaccion modificado";
            // 
            // textBox_CostTranActual
            // 
            this.textBox_CostTranActual.Enabled = false;
            this.textBox_CostTranActual.Location = new System.Drawing.Point(569, 219);
            this.textBox_CostTranActual.Name = "textBox_CostTranActual";
            this.textBox_CostTranActual.Size = new System.Drawing.Size(121, 20);
            this.textBox_CostTranActual.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Costo transaccion actual";
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
            this.Load += new System.EventHandler(this.ModificarTipoCuentas_Load);
            this.paner_TipoCuentas.ResumeLayout(false);
            this.paner_TipoCuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox paner_TipoCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CostoMantModificado;
        private System.Windows.Forms.Label label_CostoModificado;
        private System.Windows.Forms.TextBox textBox_CostoMantActual;
        private System.Windows.Forms.Label label_CostoActual;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.ComboBox comboBox_TipoCuenta;
        private System.Windows.Forms.TextBox textBox_CostoTranModificado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CostTranActual;
        private System.Windows.Forms.Label label3;
    }
}