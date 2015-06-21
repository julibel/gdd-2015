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
    public partial class SeleccionCliente : FormBase
    {
        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<ComboBox>()) control.SelectedIndex = -1;
        }


        public SeleccionCliente()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionCliente_Load(object sender, EventArgs e)
        {
            comboBox_Cuentas.ValueMember = "CUE_ID";
            comboBox_Cuentas.DisplayMember = "CUE_ID";
            comboBox_Cuentas.DataSource = DAOConsultaSaldos.getCuentas();

            LimpiarCampos();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            Consulta_Saldos.Saldo saldoForm = new Consulta_Saldos.Saldo();
            saldoForm.mostrar(this.MdiParent, Convert.ToInt64(comboBox_Cuentas.SelectedValue));
            this.Close();
        }
    }
}
