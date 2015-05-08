namespace PagoElectronico.Consulta_Saldos
{
    partial class Saldo
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
            this.label_Saldo = new System.Windows.Forms.Label();
            this.textBox_Saldo = new System.Windows.Forms.TextBox();
            this.paner_Alta = new System.Windows.Forms.GroupBox();
            this.dataGridView_Depositos = new System.Windows.Forms.DataGridView();
            this.dataGridView_Transferencias = new System.Windows.Forms.DataGridView();
            this.groupBox_Depositos = new System.Windows.Forms.GroupBox();
            this.groupBox_Transferencias = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Retiros = new System.Windows.Forms.DataGridView();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.paner_Alta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Depositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transferencias)).BeginInit();
            this.groupBox_Depositos.SuspendLayout();
            this.groupBox_Transferencias.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Retiros)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Saldo
            // 
            this.label_Saldo.AutoSize = true;
            this.label_Saldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Saldo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Saldo.Location = new System.Drawing.Point(100, 56);
            this.label_Saldo.Name = "label_Saldo";
            this.label_Saldo.Size = new System.Drawing.Size(66, 13);
            this.label_Saldo.TabIndex = 3;
            this.label_Saldo.Text = "Saldo actual";
            // 
            // textBox_Saldo
            // 
            this.textBox_Saldo.Enabled = false;
            this.textBox_Saldo.Location = new System.Drawing.Point(172, 53);
            this.textBox_Saldo.MaxLength = 15;
            this.textBox_Saldo.Name = "textBox_Saldo";
            this.textBox_Saldo.Size = new System.Drawing.Size(123, 20);
            this.textBox_Saldo.TabIndex = 2;
            // 
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.textBox_Saldo);
            this.paner_Alta.Controls.Add(this.label_Saldo);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_Alta.Location = new System.Drawing.Point(12, 12);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(395, 127);
            this.paner_Alta.TabIndex = 34;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Consulta de saldo";
            // 
            // dataGridView_Depositos
            // 
            this.dataGridView_Depositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Depositos.Enabled = false;
            this.dataGridView_Depositos.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Depositos.Name = "dataGridView_Depositos";
            this.dataGridView_Depositos.Size = new System.Drawing.Size(383, 170);
            this.dataGridView_Depositos.TabIndex = 36;
            // 
            // dataGridView_Transferencias
            // 
            this.dataGridView_Transferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Transferencias.Enabled = false;
            this.dataGridView_Transferencias.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Transferencias.Name = "dataGridView_Transferencias";
            this.dataGridView_Transferencias.Size = new System.Drawing.Size(383, 250);
            this.dataGridView_Transferencias.TabIndex = 35;
            // 
            // groupBox_Depositos
            // 
            this.groupBox_Depositos.Controls.Add(this.dataGridView_Depositos);
            this.groupBox_Depositos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_Depositos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Depositos.Location = new System.Drawing.Point(427, 12);
            this.groupBox_Depositos.Name = "groupBox_Depositos";
            this.groupBox_Depositos.Size = new System.Drawing.Size(395, 195);
            this.groupBox_Depositos.TabIndex = 35;
            this.groupBox_Depositos.TabStop = false;
            this.groupBox_Depositos.Text = "Ultimos depositos";
            // 
            // groupBox_Transferencias
            // 
            this.groupBox_Transferencias.Controls.Add(this.dataGridView_Transferencias);
            this.groupBox_Transferencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_Transferencias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Transferencias.Location = new System.Drawing.Point(12, 145);
            this.groupBox_Transferencias.Name = "groupBox_Transferencias";
            this.groupBox_Transferencias.Size = new System.Drawing.Size(395, 275);
            this.groupBox_Transferencias.TabIndex = 38;
            this.groupBox_Transferencias.TabStop = false;
            this.groupBox_Transferencias.Text = "Ultimas transferencias de fondos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_Retiros);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(427, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 196);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ultimos retiros";
            // 
            // dataGridView_Retiros
            // 
            this.dataGridView_Retiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Retiros.Enabled = false;
            this.dataGridView_Retiros.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Retiros.Name = "dataGridView_Retiros";
            this.dataGridView_Retiros.Size = new System.Drawing.Size(383, 171);
            this.dataGridView_Retiros.TabIndex = 36;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(747, 426);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 40;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Transferencias);
            this.Controls.Add(this.groupBox_Depositos);
            this.Controls.Add(this.paner_Alta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saldo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldo";
            this.paner_Alta.ResumeLayout(false);
            this.paner_Alta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Depositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transferencias)).EndInit();
            this.groupBox_Depositos.ResumeLayout(false);
            this.groupBox_Transferencias.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Retiros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Saldo;
        private System.Windows.Forms.TextBox textBox_Saldo;
        private System.Windows.Forms.GroupBox paner_Alta;
        private System.Windows.Forms.DataGridView dataGridView_Depositos;
        private System.Windows.Forms.DataGridView dataGridView_Transferencias;
        private System.Windows.Forms.GroupBox groupBox_Depositos;
        private System.Windows.Forms.GroupBox groupBox_Transferencias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_Retiros;
        private System.Windows.Forms.Button button_cerrar;
    }
}