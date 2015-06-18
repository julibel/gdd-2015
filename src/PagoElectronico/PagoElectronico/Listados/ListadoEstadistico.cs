using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;
using PagoElectronico.CapaDAO;

namespace PagoElectronico.Listados
{
    public partial class ListadoEstadistico : FormBase
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

        private bool camposCorrectos()
        {
            return numericUpDown_Anio.Value > 0 &&
                    comboBox_Trimestre.Text != "" &&
                    comboBox_TipoListado.Text != "";
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

        private void comboBox_Trimestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_HacerConsulta_Click(object sender, EventArgs e)
        {
            if (!camposCorrectos())
            {
                MessageBox.Show("No están todos los datos obligatorios", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
            string fInicio = fechaInicio(comboBox_Trimestre.SelectedIndex, numericUpDown_Anio.Value);
            string fFin = fechaFin(comboBox_Trimestre.SelectedIndex, numericUpDown_Anio.Value);

            string listado = getListado(comboBox_TipoListado.SelectedIndex);

            dataGridView_Resultado2.DataSource = CapaDAO.DAOListado.ejecutarListado(fInicio, fFin, listado);
        }



        private string getListado(int indice)
        {
            switch (indice)
            {
                case 0: return "CLIENTES_CON_CUENTAS_INHABILITADAS_POR_AUSENCIA_DE_PAGO";
                case 1: return "CLIENTES_CON_MAS_COMISIONES_FACTURADAS";
                case 2: return "CLIENTES_CON_MAYOR_TRANSFERENCIA_ENTRE_CUENTAS_PROPIAS";
                case 3: return "PAISES_CON_MAS_MOVIMIENTOS";
                case 4: return "FACTURADO_PARA_CADA_TIPO";
                default: return null;
            }
        }

        private string fechaInicio(int trimestre, decimal anio)
        {
            string fecha = "";

            switch (trimestre)
            {
                case 0: fecha = "01/01/"; break;
                case 1: fecha = "01/04/"; break;
                case 2: fecha = "01/07/"; break;
                case 3: fecha = "01/10/"; break;
            }

            return fecha + Convert.ToString(anio);
        }

        private string fechaFin(int trimestre, decimal anio)
        {
            string fecha = "";

            switch (trimestre)
            {
                case 0: fecha = "31/03/"; break;
                case 1: fecha = "30/06/"; break;
                case 2: fecha = "30/09/"; break;
                case 3: fecha = "31/12/"; break;
            }

            return fecha + Convert.ToString(anio);
        }
    }
}
