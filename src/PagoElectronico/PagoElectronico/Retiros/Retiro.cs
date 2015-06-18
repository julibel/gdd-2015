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

namespace PagoElectronico.Retiros
{
    public partial class Retiro : FormBase
    {
        public Retiro()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Retiro_Load(object sender, EventArgs e)
        {
            DataTable cuentas = CapaDAO.DAORetiro.getCuentas();
            DataTable monedas = CapaDAO.DAORetiro.getMonedas();
            DataTable bancos = CapaDAO.DAORetiro.getBancos();

            comboBox_Cuentas.ValueMember = "CUE_ID";
            comboBox_Cuentas.DisplayMember = "CUE_ID";
            comboBox_Cuentas.DataSource = cuentas;

            comboBox_Moneda.ValueMember = "MON_ID";
            comboBox_Moneda.DisplayMember = "NOMBRE";
            comboBox_Moneda.DataSource = monedas;

            comboBox_Bancos.ValueMember = "BAN_ID";
            comboBox_Bancos.DisplayMember = "NOMBRE";
            comboBox_Bancos.DataSource = bancos;

            textBox_Fecha.Text = Globals.getFechaSistema();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            foreach (var control in this.groupBox1.Controls.OfType<TextBox>()) control.Text = "";
            textBox_Numero.Text = "A generar";
            textBox_Fecha.Text = Globals.getFechaSistema();
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

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            if (!camposCorrectos())
            {
                MessageBox.Show("No están todos los datos obligatorios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_Numero.Text != "A generar")
            {
                MessageBox.Show("Limpie los datos de la última operación", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ret = CapaDAO.DAORetiro.realizarRetiro(Convert.ToInt64(comboBox_Cuentas.SelectedValue), textBox_Fecha.Text, Convert.ToDouble(textBox_Importe.Text), Convert.ToInt32(comboBox_Moneda.SelectedValue), comboBox_Bancos.Text);

            if (ret == "s")
                MessageBox.Show("Saldo insuficiente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                textBox_Numero.Text = ret;
                MessageBox.Show("El cheque fue generado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private bool camposCorrectos()
        {
            try
            {
                if (Convert.ToDouble(textBox_Importe.Text) <= 0)
                {
                    MessageBox.Show("El importe debe ser mayor a 0", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El importe debe tener formato numérico", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
            return comboBox_Bancos.Text != "" && comboBox_Cuentas.Text != "" && comboBox_Moneda.Text != "";
        }
    }
}
