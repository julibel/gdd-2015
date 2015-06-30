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
            numericUpDown_Anio.Value = 2017;
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

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button_HacerConsulta_Click(object sender, EventArgs e)
        {
            if (!camposCorrectos())
            {
                MessageBox.Show("No están todos los datos obligatorios", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
            DateTime fInicio = fechaTrimestre(comboBox_Trimestre.SelectedIndex, numericUpDown_Anio.Value);
            DateTime fFin = fechaTrimestre(comboBox_Trimestre.SelectedIndex + 1, numericUpDown_Anio.Value);

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

        private DateTime fechaTrimestre(int trimestre, decimal anio)
        {
            string fecha = "";

            switch (trimestre)
            {
                case 0: fecha = "01/01/"; break;
                case 1: fecha = "01/04/"; break;
                case 2: fecha = "01/07/"; break;
                case 3: fecha = "01/10/"; break;
                case 4: return Convert.ToDateTime("01/01/" + Convert.ToString(anio + 1));
            }

            return Convert.ToDateTime(fecha + Convert.ToString(anio));
        }
    }
}
