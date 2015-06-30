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

namespace PagoElectronico.Transferencias
{
    public partial class Transferencia : FormBase
    {
        private bool open = false;

        public override void mostrar(Form parent, params object[] values)
        {
            if (open == true)
            {
                textBox_Destino.Text = (string)values[0];
                this.Visible = true;
            }
            else
                base.mostrar(parent);
        }

        public Transferencia()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transferencia_Load(object sender, EventArgs e)
        {
            DataTable cuentas = DAOTransferencia.getCuentasHabilitadas();
            DataTable monedas = DAOTransferencia.getMonedas();

            comboBox_Origen.ValueMember = "CUE_ID";
            comboBox_Origen.DisplayMember = "CUE_ID";
            comboBox_Origen.DataSource = cuentas;

            comboBox_Moneda.ValueMember = "MON_ID";
            comboBox_Moneda.DisplayMember = "NOMBRE";
            comboBox_Moneda.DataSource = monedas;

            textBox_Fecha.Text = Globals.getFechaSistema();

            LimpiarCampos();

            open = true;
        }

        private void textBox_Importe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            if (!camposCorrectos())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }

            string ret = DAOTransferencia.realizarTransferencia(Convert.ToInt64(comboBox_Origen.SelectedValue), Convert.ToInt64(textBox_Destino.Text), Convert.ToDateTime(textBox_Fecha.Text), Convert.ToDouble(textBox_Importe.Text), Convert.ToInt32(comboBox_Moneda.SelectedValue));

            if (ret == "s")
                Mensaje_Error("Saldo insuficiente");
            else
            {
                Mensaje_OK("La transferencia fue registrada correctamente");
                LimpiarCampos();
            }
        }

        private bool camposCorrectos()
        {
            try
            {
                if (Convert.ToDouble(textBox_Importe.Text) <= 0)
                {
                    Mensaje_Error("El importe debe ser mayor a 0");
                    return false;
                }
            }
            catch (Exception)
            {
                Mensaje_Error("El importe debe tener formato numérico");
                return false;
            }
            return comboBox_Origen.Text != "" && textBox_Destino.Text != "" && comboBox_Moneda.Text != "";
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBox_Importe.Text = "";
            textBox_Fecha.Text = Globals.getFechaSistema();
            comboBox_Moneda.SelectedIndex = -1;
            comboBox_Origen.SelectedIndex = -1;
            this.ActiveControl = comboBox_Origen;
        }

        private void button_SeleccionarCuentaDestino_Click(object sender, EventArgs e)
        {
            ABM_Cuenta.Seleccion selec = new ABM_Cuenta.Seleccion(this, new List<int>(new int[] {(int)EstadoCuenta.Habilitada, (int)EstadoCuenta.Deshabilitada}));
            selec.mostrar(this.MdiParent);
            this.Visible = false;
        }

    }
}
