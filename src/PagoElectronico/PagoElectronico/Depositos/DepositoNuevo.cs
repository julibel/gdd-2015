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
        private Tarjeta_Credito.Seleccion seleccionTarjeta;

        private int tarjetaID;

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
            DataTable monedas = CapaDAO.DAODeposito.getMonedas();

            comboBox_Cuentas.ValueMember = "CUE_ID" ;
            comboBox_Cuentas.DisplayMember = "CUE_ID";
            comboBox_Cuentas.DataSource = cuentas;

            comboBox_Moneda.ValueMember = "MON_ID";
            comboBox_Moneda.DisplayMember = "NOMBRE";
            comboBox_Moneda.DataSource = monedas;
        }

        private void button_SeleccionarTarjeta_Click(object sender, EventArgs e)
        {
            seleccionTarjeta = new Tarjeta_Credito.Seleccion(this, textBox_TarjetaCredito);
            seleccionTarjeta.MdiParent = this.MdiParent;
            seleccionTarjeta.Show();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_TarjetaCredito.Text = "";
            tarjetaID = 0;
        }

        private void textBox_TarjetaCredito_TextChanged(object sender, EventArgs e)
        {
            if (textBox_TarjetaCredito.Text != "")
                tarjetaID = seleccionTarjeta.getIDTarjeta();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (!camposCorrectos())
            {
                MessageBox.Show("No están todos los datos obligatorios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CapaDAO.DAODeposito.realizarDeposito(Convert.ToInt64(comboBox_Cuentas.SelectedValue), tarjetaID, Convert.ToDouble(textBox_Importe.Text), Convert.ToInt32(comboBox_Moneda.SelectedValue));

            MessageBox.Show("El depósito fue registrado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private bool camposCorrectos()
        {
            try
            {
                return tarjetaID > 0 && Convert.ToDouble(textBox_Importe.Text) > 0 && comboBox_Cuentas.Text != "" && comboBox_Moneda.Text != "";
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
