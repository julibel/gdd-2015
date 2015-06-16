using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Retiros
{
    public partial class Retiro : Form
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
    }
}
