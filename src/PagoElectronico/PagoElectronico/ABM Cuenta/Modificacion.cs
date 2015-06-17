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
    public partial class Modificacion : Form
    {
        private long cuenta = 0;

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<ComboBox>()) control.Text = "";
        }

        private void Mensaje_OK(String mensaje, String resumen)
        {
            MessageBox.Show(mensaje, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private DialogResult Mensaje_Pregunta(String mensaje, String resumen)
        {
            var resultado = MessageBox.Show(mensaje, resumen, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;

        }

        public Modificacion(long cuentaID)
        {
            InitializeComponent();
            cuenta = cuentaID;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Esta seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cuenta");
            if (resultado == DialogResult.Yes)
            {






                Mensaje_OK("Los datos han sido almacenados con exito", "");
            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            comboBox_Moneda.ValueMember = "MON_ID";
            comboBox_Moneda.DisplayMember = "NOMBRE";
            comboBox_Moneda.DataSource = CapaDAO.DAOCuenta.getMonedas();

            comboBox_Pais.ValueMember = "PAI_ID";
            comboBox_Pais.DisplayMember = "NOMBRE";
            comboBox_Pais.DataSource = CapaDAO.DAOCuenta.getPaises();

            comboBox_TipoCuenta.ValueMember = "TIP_ID";
            comboBox_TipoCuenta.DisplayMember = "NOMBRE";
            comboBox_TipoCuenta.DataSource = CapaDAO.DAOCuenta.getTiposCuenta();
            
            DataTable cuenta = CapaDAO.DAOCuenta.getCuenta(this.cuenta);
            textBox_NumeroCuenta.Text = Convert.ToString(cuenta.Rows[0]["CUE_ID"]);
            comboBox_Moneda.SelectedValue = Convert.ToInt32(cuenta.Rows[0]["MONEDA"]);
            comboBox_Pais.SelectedValue = Convert.ToInt32(cuenta.Rows[0]["PAIS"]);
            comboBox_TipoCuenta.SelectedValue = Convert.ToInt32(cuenta.Rows[0]["TIPO"]);
        }
    }
}
