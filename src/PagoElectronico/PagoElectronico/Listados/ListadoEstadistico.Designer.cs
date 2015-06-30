namespace PagoElectronico.Listados
{
    partial class ListadoEstadistico
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
            this.dataGridView_Resultado2 = new System.Windows.Forms.DataGridView();
            this.groupBox_Consultas = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Anio = new System.Windows.Forms.NumericUpDown();
            this.label_Trimestre = new System.Windows.Forms.Label();
            this.comboBox_TipoListado = new System.Windows.Forms.ComboBox();
            this.label_TipoListado = new System.Windows.Forms.Label();
            this.comboBox_Trimestre = new System.Windows.Forms.ComboBox();
            this.label_Anio = new System.Windows.Forms.Label();
            this.button_HacerConsulta = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resultado2)).BeginInit();
            this.groupBox_Consultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Anio)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Resultado2
            // 
            this.dataGridView_Resultado2.AllowUserToAddRows = false;
            this.dataGridView_Resultado2.AllowUserToDeleteRows = false;
            this.dataGridView_Resultado2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Resultado2.Location = new System.Drawing.Point(12, 133);
            this.dataGridView_Resultado2.Name = "dataGridView_Resultado2";
            this.dataGridView_Resultado2.Size = new System.Drawing.Size(810, 287);
            this.dataGridView_Resultado2.TabIndex = 4;
            // 
            // groupBox_Consultas
            // 
            this.groupBox_Consultas.Controls.Add(this.numericUpDown_Anio);
            this.groupBox_Consultas.Controls.Add(this.label_Trimestre);
            this.groupBox_Consultas.Controls.Add(this.comboBox_TipoListado);
            this.groupBox_Consultas.Controls.Add(this.label_TipoListado);
            this.groupBox_Consultas.Controls.Add(this.comboBox_Trimestre);
            this.groupBox_Consultas.Controls.Add(this.label_Anio);
            this.groupBox_Consultas.Controls.Add(this.button_HacerConsulta);
            this.groupBox_Consultas.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Consultas.Name = "groupBox_Consultas";
            this.groupBox_Consultas.Size = new System.Drawing.Size(810, 115);
            this.groupBox_Consultas.TabIndex = 0;
            this.groupBox_Consultas.TabStop = false;
            this.groupBox_Consultas.Text = "Consultas";
            this.groupBox_Consultas.Enter += new System.EventHandler(this.groupBox_Consultas_Enter);
            // 
            // numericUpDown_Anio
            // 
            this.numericUpDown_Anio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown_Anio.Location = new System.Drawing.Point(191, 34);
            this.numericUpDown_Anio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_Anio.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericUpDown_Anio.Name = "numericUpDown_Anio";
            this.numericUpDown_Anio.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Anio.TabIndex = 0;
            this.numericUpDown_Anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Anio.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDown_Anio.ValueChanged += new System.EventHandler(this.numericUpDown_Anio_ValueChanged);
            // 
            // label_Trimestre
            // 
            this.label_Trimestre.AutoSize = true;
            this.label_Trimestre.Location = new System.Drawing.Point(317, 36);
            this.label_Trimestre.Name = "label_Trimestre";
            this.label_Trimestre.Size = new System.Drawing.Size(50, 13);
            this.label_Trimestre.TabIndex = 4;
            this.label_Trimestre.Text = "Trimestre";
            // 
            // comboBox_TipoListado
            // 
            this.comboBox_TipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TipoListado.FormattingEnabled = true;
            this.comboBox_TipoListado.Items.AddRange(new object[] {
            "Clientes con más cuentas inhabilitadas por no pagar las facturas",
            "Clientes con mayor cantidad de comisiones facturadas en todas sus cuentas",
            "Clientes con mayor cantidad de transacciones realizadas entre cuentras propias",
            "Países con mayor cantidad de movimientos",
            "Total facturado para los distintos tipos de cuentas"});
            this.comboBox_TipoListado.Location = new System.Drawing.Point(191, 60);
            this.comboBox_TipoListado.Name = "comboBox_TipoListado";
            this.comboBox_TipoListado.Size = new System.Drawing.Size(419, 21);
            this.comboBox_TipoListado.TabIndex = 2;
            // 
            // label_TipoListado
            // 
            this.label_TipoListado.AutoSize = true;
            this.label_TipoListado.Location = new System.Drawing.Point(109, 63);
            this.label_TipoListado.Name = "label_TipoListado";
            this.label_TipoListado.Size = new System.Drawing.Size(76, 13);
            this.label_TipoListado.TabIndex = 7;
            this.label_TipoListado.Text = "Tipo de listado";
            // 
            // comboBox_Trimestre
            // 
            this.comboBox_Trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Trimestre.FormattingEnabled = true;
            this.comboBox_Trimestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto"});
            this.comboBox_Trimestre.Location = new System.Drawing.Point(373, 33);
            this.comboBox_Trimestre.Name = "comboBox_Trimestre";
            this.comboBox_Trimestre.Size = new System.Drawing.Size(127, 21);
            this.comboBox_Trimestre.TabIndex = 1;
            this.comboBox_Trimestre.SelectedIndexChanged += new System.EventHandler(this.comboBox_Trimestre_SelectedIndexChanged);
            // 
            // label_Anio
            // 
            this.label_Anio.AutoSize = true;
            this.label_Anio.Location = new System.Drawing.Point(159, 36);
            this.label_Anio.Name = "label_Anio";
            this.label_Anio.Size = new System.Drawing.Size(26, 13);
            this.label_Anio.TabIndex = 3;
            this.label_Anio.Text = "Año";
            // 
            // button_HacerConsulta
            // 
            this.button_HacerConsulta.Location = new System.Drawing.Point(627, 40);
            this.button_HacerConsulta.Name = "button_HacerConsulta";
            this.button_HacerConsulta.Size = new System.Drawing.Size(75, 35);
            this.button_HacerConsulta.TabIndex = 3;
            this.button_HacerConsulta.Text = "Hacer consulta";
            this.button_HacerConsulta.UseVisualStyleBackColor = true;
            this.button_HacerConsulta.Click += new System.EventHandler(this.button_HacerConsulta_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 6;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(666, 426);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 5;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.dataGridView_Resultado2);
            this.Controls.Add(this.groupBox_Consultas);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoEstadistico";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoEstadistico";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resultado2)).EndInit();
            this.groupBox_Consultas.ResumeLayout(false);
            this.groupBox_Consultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Anio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Resultado2;
        private System.Windows.Forms.GroupBox groupBox_Consultas;
        private System.Windows.Forms.Label label_Trimestre;
        private System.Windows.Forms.ComboBox comboBox_TipoListado;
        private System.Windows.Forms.Label label_TipoListado;
        private System.Windows.Forms.ComboBox comboBox_Trimestre;
        private System.Windows.Forms.Label label_Anio;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_HacerConsulta;
        private System.Windows.Forms.NumericUpDown numericUpDown_Anio;
    }
}