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
    public partial class Seleccion : FormBase
    {
        private FormBase caller;

        public Seleccion(FormBase caller)
        {
            InitializeComponent();
            this.caller = caller;
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
            caller.mostrar(this.MdiParent, comboBox_Numero_Tarjeta.SelectedValue.ToString());
            Cerrar();
        }

        private void Cerrar()
        {
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

        private void Seleccion_Load(object sender, EventArgs e)
        {
            comboBox_Numero_Tarjeta.ValueMember = "TAR_ID";
            comboBox_Numero_Tarjeta.DisplayMember = "NUMERO";
            comboBox_Numero_Tarjeta.DataSource = DAOTarjeta.getTarjetas();
        }
    }
}
