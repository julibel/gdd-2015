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
            DataTable cuentas = CapaDAO.DAORetiro.getCuentasHabilitadas();
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

            LimpiarCampos();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (var panel in this.Controls.OfType<GroupBox>())
            {
                foreach (var control in panel.Controls.OfType<TextBox>()) control.Text = "";
                foreach (var control in panel.Controls.OfType<ComboBox>()) control.SelectedIndex = -1;
            }
            textBox_Numero.Text = "A generar";
            comboBox_Bancos.Text = "";
            textBox_Fecha.Text = Globals.getFechaSistema();
            this.ActiveControl = comboBox_Cuentas;
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
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }
            if (textBox_Numero.Text != "A generar")
            {
                Mensaje_Error("Limpie los datos de la última operación");
                return;
            }
            if (!DAOCliente.coincideDocumento(comboBox_Tipo_doc.SelectedIndex + 1, textBox_Documento.Text))
            {
                Mensaje_Error("No coincide el documento con el del usuario actual");
                return;
            }

            string ret = DAORetiro.realizarRetiro(Convert.ToInt64(comboBox_Cuentas.SelectedValue), textBox_Fecha.Text, Convert.ToDouble(textBox_Importe.Text), Convert.ToInt32(comboBox_Moneda.SelectedValue), comboBox_Bancos.Text, textBox_Nombre.Text + " " + textBox_Apellido.Text);

            if (ret == "s")
                Mensaje_Error("Saldo insuficiente");
            else
            {
                textBox_Numero.Text = ret;
                Mensaje_OK("El cheque fue generado correctamente");
            }
        }

        private bool camposCorrectos()
        {
            try
            {
                if (Convert.ToDouble(textBox_Importe.Text) <= 0)
                {
                    Mensaje_Error("El importe debe ser mayor a 0");
                    return false;
                }
            }
            catch (Exception)
            {
                Mensaje_Error("El importe debe tener formato numérico");
                return false;
            } 
            return comboBox_Bancos.Text != "" && comboBox_Cuentas.Text != "" && comboBox_Moneda.Text != "";
        }
    }
}
