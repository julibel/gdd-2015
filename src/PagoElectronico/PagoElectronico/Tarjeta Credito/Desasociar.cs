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
    public partial class Desasociar : FormBase
    {
        public Desasociar()
        {
            InitializeComponent();
            comboBox_Numero_Tarjeta.DataSource = DAOCliente.getTarjetasCliente(CapaDAO.DAOTarjeta.getClienteId());
            comboBox_Numero_Tarjeta.ValueMember = "NUMERO_TARJETA";
            comboBox_Numero_Tarjeta.DisplayMember = "NUMERO_TARJETA";
        }

        private void Desasociar_Load(object sender, EventArgs e)
        {

        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Numero_Tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
