using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Depositos
{
    public partial class DepositoNuevo : Form
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
            DataTable cuentas = CapaDAO.DAODeposito.getCuentas();
            DataTable tarjetas = CapaDAO.DAODeposito.getTarjetas();
            DataTable monedas = CapaDAO.DAODeposito.getMonedas();

            comboBox_Cuentas.ValueMember = "CUE_ID" ;
            comboBox_Cuentas.DisplayMember = "CUE_ID";
            comboBox_Cuentas.DataSource = cuentas;

            comboBox_Tarjetas.ValueMember = "TAR_ID";
            comboBox_Tarjetas.DisplayMember = "NUMERO";
            comboBox_Tarjetas.DataSource = tarjetas;

            comboBox_Moneda.ValueMember = "MON_ID";
            comboBox_Moneda.DisplayMember = "NOMBRE";
            comboBox_Moneda.DataSource = monedas;
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Importe.Text = "";
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (!camposCorrectos())
            {
                MessageBox.Show("No están todos los datos obligatorios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CapaDAO.DAODeposito.realizarDeposito(Convert.ToInt64(comboBox_Cuentas.SelectedValue), Convert.ToInt32(comboBox_Tarjetas.SelectedValue), Convert.ToDouble(textBox_Importe.Text), Convert.ToInt32(comboBox_Moneda.SelectedValue));

            MessageBox.Show("El depósito fue registrado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private bool camposCorrectos()
        {
            try
            {
                return comboBox_Tarjetas.Text != "" && Convert.ToDouble(textBox_Importe.Text) > 0 && comboBox_Cuentas.Text != "" && comboBox_Moneda.Text != "";
            }
            catch (Exception)
            {
                MessageBox.Show("El importe debe tener formato numérico", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
