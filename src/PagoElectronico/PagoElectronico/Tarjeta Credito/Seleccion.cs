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

namespace PagoElectronico.Tarjeta_Credito
{
    public partial class Seleccion : Form
    {
        private Form formCaller;

        private TextBox textCaller;

        private int tarjetaID;

        public int getIDTarjeta()
        {
            return tarjetaID;
        }

        public Seleccion(Form caller, TextBox textTarjeta)
        {
            comboBox_Numero_Tarjeta.ValueMember = "NUMERO_TARJETA".Substring(12, 16);
            comboBox_Numero_Tarjeta.DisplayMember = "NUMERO_TARJETA";
            comboBox_Numero_Tarjeta.DataSource = DAOCliente.getTarjetasCliente(CapaDAO.DAOTarjeta.getClienteId(Globals.userID));
            InitializeComponent();
            formCaller = caller;
            textCaller = textTarjeta;
            formCaller.Visible = false;
        }

        public Seleccion()
        {
            comboBox_Numero_Tarjeta.DataSource = DAOCliente.getTarjetasCliente(CapaDAO.DAOTarjeta.getClienteId(Globals.userID));
            comboBox_Numero_Tarjeta.ValueMember = "NUMERO_TARJETA";
            comboBox_Numero_Tarjeta.DisplayMember = "NUMERO_TARJETA";
            
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            int idTarjeta = CapaDAO.DAOTarjeta.getID(comboBox_Numero_Tarjeta.SelectedValue.ToString(), textBox_CodigoSeguridad.Text);

            if (idTarjeta <= 0)
            {
                MessageBox.Show("No posee tal tarjeta o expiró", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tarjetaID = idTarjeta;
            textCaller.Text = comboBox_Numero_Tarjeta.SelectedValue.ToString();
            Cerrar();
        }

        private void Cerrar()
        {
            formCaller.Visible = true;
            this.Close();
        }

        private void textBox_numeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_CodigoSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_numeroTarjeta_KeyPress(sender, e);
        }
    }
}
