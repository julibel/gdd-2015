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

namespace PagoElectronico.Consulta_Saldos
{
    public partial class Saldo : FormBase
    {
        private long cuentaID;

        public Saldo()
        {
            InitializeComponent();
        }

        public override void mostrar(Form parent, params object[] values)
        {
            cuentaID = Convert.ToInt64(values[0]);
            base.mostrar(parent, values);
        }


        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Saldo_Load(object sender, EventArgs e)
        {
            textBox_SaldoActual.Text = Convert.ToString(CapaDAO.DAOConsultaSaldos.getSaldo(cuentaID));

            dataGridView_Depositos.DataSource = CapaDAO.DAOConsultaSaldos.getUltimosDepositos(cuentaID);
            dataGridView_Retiros.DataSource = CapaDAO.DAOConsultaSaldos.getUltimosRetiros(cuentaID);
            dataGridView_Transferencias.DataSource = CapaDAO.DAOConsultaSaldos.getUltimasTransferencias(cuentaID);
        }

        private void groupBox_Depositos_Enter(object sender, EventArgs e)
        {

        }
    }
}
