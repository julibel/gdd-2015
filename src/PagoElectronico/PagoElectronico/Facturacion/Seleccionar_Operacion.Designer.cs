namespace PagoElectronico.Facturacion
{
    partial class Seleccionar_Operacion
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
            this.dataGridView_ListadoOperaciones = new System.Windows.Forms.DataGridView();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListadoOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ListadoOperaciones
            // 
            this.dataGridView_ListadoOperaciones.AllowUserToAddRows = false;
            this.dataGridView_ListadoOperaciones.AllowUserToDeleteRows = false;
            this.dataGridView_ListadoOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListadoOperaciones.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_ListadoOperaciones.Name = "dataGridView_ListadoOperaciones";
            this.dataGridView_ListadoOperaciones.ReadOnly = true;
            this.dataGridView_ListadoOperaciones.Size = new System.Drawing.Size(615, 395);
            this.dataGridView_ListadoOperaciones.TabIndex = 0;
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(471, 413);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 31;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(552, 413);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 30;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // Seleccionar_Operacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(639, 443);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.dataGridView_ListadoOperaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleccionar_Operacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar operaciones a facturar";
            this.Load += new System.EventHandler(this.Seleccionar_Operacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListadoOperaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ListadoOperaciones;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cerrar;
    }
}