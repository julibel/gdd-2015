using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Consulta_Saldos
{
    public partial class SeleccionCliente : Form
    {
        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_Filtros.Controls.OfType<ComboBox>()) control.Text = "";
        }


        public SeleccionCliente()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void SeleccionCliente_Load(object sender, EventArgs e)
        {
            comboBox_Cuentas.ValueMember = "CUE_ID";
            comboBox_Cuentas.DisplayMember = "CUE_ID";
            comboBox_Cuentas.DataSource = CapaDAO.DAOConsultaSaldos.getCuentas();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            Consulta_Saldos.Saldo saldoForm = new Consulta_Saldos.Saldo(Convert.ToInt64(comboBox_Cuentas.SelectedValue));
            saldoForm.MdiParent = this.MdiParent;
            saldoForm.Show();
            this.Close();
        }
    }
}
