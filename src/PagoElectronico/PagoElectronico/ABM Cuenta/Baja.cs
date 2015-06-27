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

namespace PagoElectronico.ABM_Cuenta
{
    public partial class Baja : FormBase
    {
        private long cuenta;

        public override void mostrar(Form parent, params object[] values)
        {
            cuenta = Convert.ToInt64(values[0]);
            base.mostrar(parent);
        }

        public Baja()
        {
            InitializeComponent();
        }

        private void paner_DatosCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void Baja_Load(object sender, EventArgs e)
        {
            DataTable cuenta = DAOCuenta.getCuenta(this.cuenta);
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
            DialogResult resultado;
            if (DAOCuenta.tieneDeudas(cuenta))
                resultado = Mensaje_Pregunta("La cuenta tiene deudas pendientes. ¿Está seguro que quiere darla de baja?", "Deudas Pendientes");
            else
                resultado = Mensaje_Pregunta("¿Está seguro que desea eliminar la cuenta del sistema?", "Eliminar Cuenta");
            if (resultado == DialogResult.Yes)
            {
                DAOCuenta.eliminarCuenta(cuenta);
               
                Mensaje_OK("Los datos han sido eliminados con éxito");
                this.Close();
            }
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<TextBox>()) control.Text = "";
        }
    }
}
