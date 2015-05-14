using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Listados
{
    public partial class ListadoEstadistico : Form
    {
        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox_Consultas.Controls.OfType<ComboBox>()) control.Text = "";
            numericUpDown_Anio.Value = 2015;
        }


        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void groupBox_Consultas_Enter(object sender, EventArgs e)
        {

        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void numericUpDown_Anio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
