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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CostoActual = new System.Windows.Forms.Label();
            this.textBox_CostoActual = new System.Windows.Forms.TextBox();
            this.textBox_CostoModificado = new System.Windows.Forms.TextBox();
            this.label_CostoModificado = new System.Windows.Forms.Label();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
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
            this.paner_TipoCuentas.Controls.Add(this.comboBox1);
            this.paner_TipoCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_TipoCuentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_TipoCuentas.Location = new System.Drawing.Point(12, 12);
            this.paner_TipoCuentas.Name = "paner_TipoCuentas";
            this.paner_TipoCuentas.Size = new System.Drawing.Size(807, 408);
            this.paner_TipoCuentas.TabIndex = 29;
            this.paner_TipoCuentas.TabStop = false;
            this.paner_TipoCuentas.Text = "Modificacion de tipo de cuenta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce"});
            this.comboBox1.Location = new System.Drawing.Point(390, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
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
            // label_CostoActual
            // 
            this.label_CostoActual.AutoSize = true;
            this.label_CostoActual.Location = new System.Drawing.Point(318, 198);
            this.label_CostoActual.Name = "label_CostoActual";
            this.label_CostoActual.Size = new System.Drawing.Size(66, 13);
            this.label_CostoActual.TabIndex = 2;
            this.label_CostoActual.Text = "Costo actual";
            // 
            // textBox_CostoActual
            // 
            this.textBox_CostoActual.Enabled = false;
            this.textBox_CostoActual.Location = new System.Drawing.Point(390, 195);
            this.textBox_CostoActual.Name = "textBox_CostoActual";
            this.textBox_CostoActual.Size = new System.Drawing.Size(121, 20);
            this.textBox_CostoActual.TabIndex = 3;
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
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(666, 426);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 28;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(585, 426);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 27;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 26;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            // 
            // ModificarTipoCuentas
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_CostoModificado;
        private System.Windows.Forms.Label label_CostoModificado;
        private System.Windows.Forms.TextBox textBox_CostoActual;
        private System.Windows.Forms.Label label_CostoActual;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cerrar;
    }
}