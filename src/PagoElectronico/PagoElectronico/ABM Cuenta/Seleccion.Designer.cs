namespace PagoElectronico.ABM_Cuenta
{
    partial class Seleccion
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
            this.dataGridView_Seleccion = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_NumeroCuenta = new System.Windows.Forms.TextBox();
            this.label_NumeroCuenta = new System.Windows.Forms.Label();
            this.label_Pais = new System.Windows.Forms.Label();
            this.label_TipoCuenta = new System.Windows.Forms.Label();
            this.comboBox_TipoCuenta = new System.Windows.Forms.ComboBox();
            this.paner_Filtros = new System.Windows.Forms.GroupBox();
            this.comboBox_Pais = new System.Windows.Forms.ComboBox();
            this.button_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seleccion)).BeginInit();
            this.paner_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Seleccion
            // 
            this.dataGridView_Seleccion.AllowUserToAddRows = false;
            this.dataGridView_Seleccion.AllowUserToDeleteRows = false;
            this.dataGridView_Seleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Seleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridView_Seleccion.Location = new System.Drawing.Point(12, 190);
            this.dataGridView_Seleccion.Name = "dataGridView_Seleccion";
            this.dataGridView_Seleccion.ReadOnly = true;
            this.dataGridView_Seleccion.Size = new System.Drawing.Size(810, 230);
            this.dataGridView_Seleccion.TabIndex = 5;
            this.dataGridView_Seleccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Seleccion_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            this.Seleccionar.Visible = false;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(715, 125);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 4;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(634, 125);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 3;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_NumeroCuenta
            // 
            this.textBox_NumeroCuenta.Location = new System.Drawing.Point(340, 45);
            this.textBox_NumeroCuenta.MaxLength = 255;
            this.textBox_NumeroCuenta.Name = "textBox_NumeroCuenta";
            this.textBox_NumeroCuenta.Size = new System.Drawing.Size(232, 20);
            this.textBox_NumeroCuenta.TabIndex = 0;
            this.textBox_NumeroCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_NumeroCuenta_KeyDown);
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
            // label_Pais
            // 
            this.label_Pais.AutoSize = true;
            this.label_Pais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Pais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Pais.Location = new System.Drawing.Point(307, 74);
            this.label_Pais.Name = "label_Pais";
            this.label_Pais.Size = new System.Drawing.Size(27, 13);
            this.label_Pais.TabIndex = 25;
            this.label_Pais.Text = "Pais";
            // 
            // label_TipoCuenta
            // 
            this.label_TipoCuenta.AutoSize = true;
            this.label_TipoCuenta.Location = new System.Drawing.Point(255, 100);
            this.label_TipoCuenta.Name = "label_TipoCuenta";
            this.label_TipoCuenta.Size = new System.Drawing.Size(79, 13);
            this.label_TipoCuenta.TabIndex = 29;
            this.label_TipoCuenta.Text = "Tipo de cuenta";
            // 
            // comboBox_TipoCuenta
            // 
            this.comboBox_TipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TipoCuenta.FormattingEnabled = true;
            this.comboBox_TipoCuenta.Location = new System.Drawing.Point(340, 97);
            this.comboBox_TipoCuenta.Name = "comboBox_TipoCuenta";
            this.comboBox_TipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipoCuenta.TabIndex = 2;
            this.comboBox_TipoCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_NumeroCuenta_KeyDown);
            // 
            // paner_Filtros
            // 
            this.paner_Filtros.Controls.Add(this.comboBox_Pais);
            this.paner_Filtros.Controls.Add(this.comboBox_TipoCuenta);
            this.paner_Filtros.Controls.Add(this.label_TipoCuenta);
            this.paner_Filtros.Controls.Add(this.label_Pais);
            this.paner_Filtros.Controls.Add(this.label_NumeroCuenta);
            this.paner_Filtros.Controls.Add(this.textBox_NumeroCuenta);
            this.paner_Filtros.Controls.Add(this.button_Buscar);
            this.paner_Filtros.Controls.Add(this.button_Limpiar);
            this.paner_Filtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Filtros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_Filtros.Location = new System.Drawing.Point(12, 12);
            this.paner_Filtros.Name = "paner_Filtros";
            this.paner_Filtros.Size = new System.Drawing.Size(810, 163);
            this.paner_Filtros.TabIndex = 35;
            this.paner_Filtros.TabStop = false;
            this.paner_Filtros.Text = "Filtros de busqueda";
            // 
            // comboBox_Pais
            // 
            this.comboBox_Pais.FormattingEnabled = true;
            this.comboBox_Pais.Location = new System.Drawing.Point(340, 71);
            this.comboBox_Pais.Name = "comboBox_Pais";
            this.comboBox_Pais.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Pais.TabIndex = 1;
            this.comboBox_Pais.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_NumeroCuenta_KeyDown);
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
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.paner_Filtros);
            this.Controls.Add(this.dataGridView_Seleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleccion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.Load += new System.EventHandler(this.Seleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seleccion)).EndInit();
            this.paner_Filtros.ResumeLayout(false);
            this.paner_Filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Seleccion;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_NumeroCuenta;
        private System.Windows.Forms.Label label_NumeroCuenta;
        private System.Windows.Forms.Label label_Pais;
        private System.Windows.Forms.Label label_TipoCuenta;
        private System.Windows.Forms.ComboBox comboBox_TipoCuenta;
        private System.Windows.Forms.GroupBox paner_Filtros;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.ComboBox comboBox_Pais;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;


    }
}