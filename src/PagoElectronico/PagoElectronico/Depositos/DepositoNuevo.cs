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
            Tarjeta_Credito.Seleccion nuevo_form = new Tarjeta_Credito.Seleccion(this, textBox_TarjetaCredito);
            nuevo_form.MdiParent = this.MdiParent;
            nuevo_form.Show();
        }
    }
}
