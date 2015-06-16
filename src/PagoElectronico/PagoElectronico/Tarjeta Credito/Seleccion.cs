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
            int idTarjeta = CapaDAO.DAOTarjeta.getID(textBox_numeroTarjeta.Text, textBox_CodigoSeguridad.Text);

            if (idTarjeta == 0)
            {
                var resp = MessageBox.Show("No posee tal tarjeta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
