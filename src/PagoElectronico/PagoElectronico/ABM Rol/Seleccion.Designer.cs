namespace PagoElectronico.ABM_Rol
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
            this.groupBox_SeleccionarRol = new System.Windows.Forms.GroupBox();
            this.dataGridView_SeleccionRol = new System.Windows.Forms.DataGridView();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.groupBox_SeleccionarRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SeleccionRol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SeleccionarRol
            // 
            this.groupBox_SeleccionarRol.Controls.Add(this.dataGridView_SeleccionRol);
            this.groupBox_SeleccionarRol.Location = new System.Drawing.Point(12, 12);
            this.groupBox_SeleccionarRol.Name = "groupBox_SeleccionarRol";
            this.groupBox_SeleccionarRol.Size = new System.Drawing.Size(810, 408);
            this.groupBox_SeleccionarRol.TabIndex = 21;
            this.groupBox_SeleccionarRol.TabStop = false;
            this.groupBox_SeleccionarRol.Text = "Seleccionar Rol";
            // 
            // dataGridView_SeleccionRol
            // 
            this.dataGridView_SeleccionRol.AllowUserToAddRows = false;
            this.dataGridView_SeleccionRol.AllowUserToDeleteRows = false;
            this.dataGridView_SeleccionRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SeleccionRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SeleccionRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rol,
            this.Modificar});
            this.dataGridView_SeleccionRol.Location = new System.Drawing.Point(169, 53);
            this.dataGridView_SeleccionRol.Name = "dataGridView_SeleccionRol";
            this.dataGridView_SeleccionRol.Size = new System.Drawing.Size(472, 302);
            this.dataGridView_SeleccionRol.TabIndex = 19;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 37;
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
            this.Controls.Add(this.groupBox_SeleccionarRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleccion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.groupBox_SeleccionarRol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SeleccionRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SeleccionarRol;
        private System.Windows.Forms.DataGridView dataGridView_SeleccionRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.Button button_Cerrar;
    }
}