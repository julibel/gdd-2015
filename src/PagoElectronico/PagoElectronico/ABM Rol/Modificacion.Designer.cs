namespace PagoElectronico.ABM_Rol
{
    partial class Modificacion
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
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.paner_Alta = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Funcionalidad = new System.Windows.Forms.ComboBox();
            this.label_Funcionalidad = new System.Windows.Forms.Label();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.dataGridView_ListaFuncionalidades = new System.Windows.Forms.DataGridView();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.Elimnar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paner_Alta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).BeginInit();
            this.SuspendLayout();
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
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(585, 426);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 4;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 6;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.groupBox1);
            this.paner_Alta.Controls.Add(this.dataGridView_ListaFuncionalidades);
            this.paner_Alta.Controls.Add(this.label_Nombre);
            this.paner_Alta.Controls.Add(this.textBox_Nombre);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paner_Alta.Location = new System.Drawing.Point(12, 12);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(810, 406);
            this.paner_Alta.TabIndex = 35;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos del Rol";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Funcionalidad);
            this.groupBox1.Controls.Add(this.label_Funcionalidad);
            this.groupBox1.Controls.Add(this.button_Agregar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(16, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 155);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Funcionalidad";
            // 
            // comboBox_Funcionalidad
            // 
            this.comboBox_Funcionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Funcionalidad.FormattingEnabled = true;
            this.comboBox_Funcionalidad.Location = new System.Drawing.Point(112, 67);
            this.comboBox_Funcionalidad.Name = "comboBox_Funcionalidad";
            this.comboBox_Funcionalidad.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Funcionalidad.TabIndex = 1;
            // 
            // label_Funcionalidad
            // 
            this.label_Funcionalidad.AutoSize = true;
            this.label_Funcionalidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Funcionalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Funcionalidad.Location = new System.Drawing.Point(33, 70);
            this.label_Funcionalidad.Name = "label_Funcionalidad";
            this.label_Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.label_Funcionalidad.TabIndex = 9;
            this.label_Funcionalidad.Text = "Funcionalidad";
            // 
            // button_Agregar
            // 
            this.button_Agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Agregar.Location = new System.Drawing.Point(296, 126);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 2;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // dataGridView_ListaFuncionalidades
            // 
            this.dataGridView_ListaFuncionalidades.AllowUserToAddRows = false;
            this.dataGridView_ListaFuncionalidades.AllowUserToDeleteRows = false;
            this.dataGridView_ListaFuncionalidades.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_ListaFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elimnar});
            this.dataGridView_ListaFuncionalidades.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView_ListaFuncionalidades.Location = new System.Drawing.Point(411, 19);
            this.dataGridView_ListaFuncionalidades.Name = "dataGridView_ListaFuncionalidades";
            this.dataGridView_ListaFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_ListaFuncionalidades.Size = new System.Drawing.Size(378, 370);
            this.dataGridView_ListaFuncionalidades.TabIndex = 3;
            this.dataGridView_ListaFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListaFuncionalidades_CellContentClick);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(55, 89);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(105, 86);
            this.textBox_Nombre.MaxLength = 15;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // Elimnar
            // 
            this.Elimnar.HeaderText = "Eliminar";
            this.Elimnar.Name = "Elimnar";
            this.Elimnar.Text = "Eliminar Fila";
            this.Elimnar.UseColumnTextForButtonValue = true;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.paner_Alta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion";
            this.paner_Alta.ResumeLayout(false);
            this.paner_Alta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.GroupBox paner_Alta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.DataGridView dataGridView_ListaFuncionalidades;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.ComboBox comboBox_Funcionalidad;
        private System.Windows.Forms.Label label_Funcionalidad;
        private System.Windows.Forms.DataGridViewButtonColumn Elimnar;
    }
}