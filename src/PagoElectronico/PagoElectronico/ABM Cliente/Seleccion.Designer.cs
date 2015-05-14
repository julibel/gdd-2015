namespace PagoElectronico.ABM_Cliente
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
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.paner_Filtros = new System.Windows.Forms.GroupBox();
            this.comboBox_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.label_Documento = new System.Windows.Forms.Label();
            this.label_TipoDocumento = new System.Windows.Forms.Label();
            this.textBox_Documento = new System.Windows.Forms.TextBox();
            this.label_Mail = new System.Windows.Forms.Label();
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
            this.dataGridView_Seleccion.Location = new System.Drawing.Point(12, 190);
            this.dataGridView_Seleccion.Name = "dataGridView_Seleccion";
            this.dataGridView_Seleccion.Size = new System.Drawing.Size(810, 230);
            this.dataGridView_Seleccion.TabIndex = 15;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(715, 125);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 14;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(634, 125);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 13;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // paner_Filtros
            // 
            this.paner_Filtros.Controls.Add(this.comboBox_TipoDocumento);
            this.paner_Filtros.Controls.Add(this.textBox_Nombre);
            this.paner_Filtros.Controls.Add(this.button_Buscar);
            this.paner_Filtros.Controls.Add(this.textBox_Apellido);
            this.paner_Filtros.Controls.Add(this.button_Limpiar);
            this.paner_Filtros.Controls.Add(this.label_Nombre);
            this.paner_Filtros.Controls.Add(this.label_Apellido);
            this.paner_Filtros.Controls.Add(this.textBox_Mail);
            this.paner_Filtros.Controls.Add(this.label_Documento);
            this.paner_Filtros.Controls.Add(this.label_TipoDocumento);
            this.paner_Filtros.Controls.Add(this.textBox_Documento);
            this.paner_Filtros.Controls.Add(this.label_Mail);
            this.paner_Filtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Filtros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_Filtros.Location = new System.Drawing.Point(12, 12);
            this.paner_Filtros.Name = "paner_Filtros";
            this.paner_Filtros.Size = new System.Drawing.Size(810, 163);
            this.paner_Filtros.TabIndex = 33;
            this.paner_Filtros.TabStop = false;
            this.paner_Filtros.Text = "Filtros de busqueda";
            // 
            // comboBox_TipoDocumento
            // 
            this.comboBox_TipoDocumento.FormattingEnabled = true;
            this.comboBox_TipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "CI",
            "LC",
            "LE",
            "PAS"});
            this.comboBox_TipoDocumento.Location = new System.Drawing.Point(523, 38);
            this.comboBox_TipoDocumento.Name = "comboBox_TipoDocumento";
            this.comboBox_TipoDocumento.Size = new System.Drawing.Size(129, 21);
            this.comboBox_TipoDocumento.TabIndex = 31;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(180, 39);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 22;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(180, 65);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(232, 20);
            this.textBox_Apellido.TabIndex = 28;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(130, 42);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 23;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Apellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Apellido.Location = new System.Drawing.Point(130, 68);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label_Apellido.TabIndex = 24;
            this.label_Apellido.Text = "Apellido";
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(180, 92);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(232, 20);
            this.textBox_Mail.TabIndex = 30;
            // 
            // label_Documento
            // 
            this.label_Documento.AutoSize = true;
            this.label_Documento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Documento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Documento.Location = new System.Drawing.Point(455, 68);
            this.label_Documento.Name = "label_Documento";
            this.label_Documento.Size = new System.Drawing.Size(62, 13);
            this.label_Documento.TabIndex = 25;
            this.label_Documento.Text = "Documento";
            // 
            // label_TipoDocumento
            // 
            this.label_TipoDocumento.AutoSize = true;
            this.label_TipoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TipoDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_TipoDocumento.Location = new System.Drawing.Point(418, 42);
            this.label_TipoDocumento.Name = "label_TipoDocumento";
            this.label_TipoDocumento.Size = new System.Drawing.Size(99, 13);
            this.label_TipoDocumento.TabIndex = 26;
            this.label_TipoDocumento.Text = "Tipo de documento";
            // 
            // textBox_Documento
            // 
            this.textBox_Documento.Location = new System.Drawing.Point(523, 65);
            this.textBox_Documento.Name = "textBox_Documento";
            this.textBox_Documento.Size = new System.Drawing.Size(129, 20);
            this.textBox_Documento.TabIndex = 29;
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Mail.Location = new System.Drawing.Point(141, 95);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(33, 13);
            this.label_Mail.TabIndex = 27;
            this.label_Mail.Text = "EMail";
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 34;
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
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.GroupBox paner_Filtros;
        private System.Windows.Forms.ComboBox comboBox_TipoDocumento;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.Label label_Documento;
        private System.Windows.Forms.Label label_TipoDocumento;
        private System.Windows.Forms.TextBox textBox_Documento;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Button button_Cerrar;
    }
}