using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class Baja : Form
    {
        private long cuenta;

        public Baja(long cuentaID)
        {
            InitializeComponent();
            cuenta = cuentaID;
        }

        private DialogResult Mensaje_Pregunta(String mensaje, String resumen)
        {
            var resultado = MessageBox.Show(mensaje, resumen, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;

        }
        private void Mensaje_OK(String mensaje, String resumen)
        {
            MessageBox.Show(mensaje, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void paner_DatosCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void Baja_Load(object sender, EventArgs e)
        {
            DataTable cuenta = CapaDAO.DAOCuenta.getCuenta(this.cuenta);
            textBox_NumeroCuenta.Text = Convert.ToString(cuenta.Rows[0]["CUE_ID"]);
            textBox_Moneda.Text = Convert.ToString(cuenta.Rows[0]["MON_NOM"]);
            textBox_Pais.Text = Convert.ToString(cuenta.Rows[0]["PAI_NOM"]);
            textBox_Tipo_Cuenta.Text = Convert.ToString(cuenta.Rows[0]["TIP_NOM"]);
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea eliminar la cuenta del sistema?", "Eliminar Cuenta");
            if (resultado == DialogResult.Yes)
            {

                CapaDAO.DAOCuenta.eliminarCuenta(cuenta);
                LimpiarCampos();
                Mensaje_OK("Los datos han sido eliminados con éxito", "");
            }
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<TextBox>()) control.Text = "";
        }
    }
}
