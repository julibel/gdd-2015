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

namespace PagoElectronico.Depositos
{
    public partial class DepositoNuevo : FormBase
    {
        public DepositoNuevo()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepositoNuevo_Load(object sender, EventArgs e)
        {
            DataTable cuentas = DAODeposito.getCuentasHabilitadas();
            DataTable tarjetas = DAODeposito.getTarjetas();
            DataTable monedas = DAODeposito.getMonedas();

            comboBox_Cuentas.ValueMember = "CUE_ID" ;
            comboBox_Cuentas.DisplayMember = "CUE_ID";
            comboBox_Cuentas.DataSource = cuentas;

            comboBox_Tarjetas.ValueMember = "TAR_ID";
            comboBox_Tarjetas.DisplayMember = "NUMERO";
            comboBox_Tarjetas.DataSource = tarjetas;

            comboBox_Moneda.ValueMember = "MON_ID";
            comboBox_Moneda.DisplayMember = "NOMBRE";
            comboBox_Moneda.DataSource = monedas;

            LimpiarCampos();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (var control in paner_DatosCuenta.Controls.OfType<ComboBox>()) control.SelectedIndex = -1;
            foreach (var control in paner_DatosCuenta.Controls.OfType<TextBox>()) control.Text = "";
            this.ActiveControl = comboBox_Cuentas;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (!camposCorrectos())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }

            DAODeposito.realizarDeposito(Convert.ToInt64(comboBox_Cuentas.SelectedValue), Convert.ToInt32(comboBox_Tarjetas.SelectedValue), Convert.ToDouble(textBox_Importe.Text), Convert.ToInt32(comboBox_Moneda.SelectedValue));

            Mensaje_OK("El depósito fue registrado correctamente");
            LimpiarCampos();
        }

        private bool camposCorrectos()
        {
            try
            {
                return comboBox_Tarjetas.Text != "" && Convert.ToDouble(textBox_Importe.Text) > 0 && comboBox_Cuentas.Text != "" && comboBox_Moneda.Text != "";
            }
            catch (Exception)
            {
                Mensaje_Error("El importe debe ser mayor a 0");
                return false;
            }
        }

        private void textBox_Importe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
