using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class Alta : Form
    {
        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox_Alta.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox_Usuario.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox_Alta.Controls.OfType<RadioButton>()) control.Checked = false;      
            comboBox_Pais.Text = "";
            dataGridView_Tarjetas.Rows.Clear();
            dateTimePicker_FechaNacimiento.Value = DateTime.Now;
        }

        private void Mensaje_OK(String mensaje, String resumen)
        {
            MessageBox.Show(mensaje, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private DialogResult Mensaje_Pregunta(String mensaje, String resumen)
        {
            var resultado = MessageBox.Show(mensaje, resumen, MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            return resultado;

        }


        public Alta()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Esta seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cliente");
            if (resultado == DialogResult.Yes)
            {






                Mensaje_OK("Los datos han sido almacenados con exito", "");
            }
        
        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
