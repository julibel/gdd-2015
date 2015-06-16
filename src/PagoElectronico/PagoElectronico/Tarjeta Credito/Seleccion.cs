using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            InitializeComponent();
            formCaller = caller;
            textCaller = textTarjeta;
            formCaller.Visible = false;
        }

        public Seleccion()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            if (textBox_numeroTarjeta.Text.Length < 16)
            {
                MessageBox.Show("El número de tarjeta es de 16 dígitos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idTarjeta = CapaDAO.DAOTarjeta.getID(textBox_numeroTarjeta.Text, textBox_CodigoSeguridad.Text);

            if (idTarjeta <= 0)
            {
                MessageBox.Show("No posee tal tarjeta o expiró", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tarjetaID = idTarjeta;
            textCaller.Text = textBox_numeroTarjeta.Text;
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
