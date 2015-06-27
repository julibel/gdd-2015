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

namespace PagoElectronico.ABM_Cuenta
{
    public partial class Modificacion : FormBase
    {
        private long cuenta;

        private int cliente = 0;

        public override void mostrar(Form parent, params object[] values)
        {
            cuenta = Convert.ToInt64(values[0]);
            base.mostrar(parent);
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<ComboBox>()) control.Text = "";
        }

        public Modificacion()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (!camposCorrectos())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }

            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cuenta");
            if (resultado == DialogResult.Yes)
            {
                DAOCuenta.modificarCuenta(cuenta, cliente, Convert.ToInt32(comboBox_Moneda.SelectedValue), Convert.ToInt32(comboBox_Pais.SelectedValue), Convert.ToInt32(comboBox_TipoCuenta.SelectedValue), Convert.ToInt32(checkBox_Estado.Checked));
                Mensaje_OK("Los datos han sido almacenados con éxito");
                this.Close();
            }
        }

        private bool camposCorrectos()
        {
            return textBox_NumeroCuenta.Text != "" && comboBox_Pais.Text != "" && comboBox_Moneda.Text != "" && comboBox_TipoCuenta.Text != "";
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            comboBox_Moneda.ValueMember = "MON_ID";
            comboBox_Moneda.DisplayMember = "NOMBRE";
            comboBox_Moneda.DataSource = DAOCuenta.getMonedas();

            comboBox_Pais.ValueMember = "PAI_ID";
            comboBox_Pais.DisplayMember = "NOMBRE";
            comboBox_Pais.DataSource = DAOCuenta.getPaises();

            comboBox_TipoCuenta.ValueMember = "TIP_ID";
            comboBox_TipoCuenta.DisplayMember = "NOMBRE";
            comboBox_TipoCuenta.DataSource = DAOCuenta.getTiposCuenta();
            
            DataTable cuenta = DAOCuenta.getCuenta(this.cuenta);
            cliente = Convert.ToInt32(cuenta.Rows[0]["CLIENTE"]);
            textBox_NumeroCuenta.Text = Convert.ToString(cuenta.Rows[0]["CUE_ID"]);
            comboBox_Moneda.SelectedValue = Convert.ToInt32(cuenta.Rows[0]["MONEDA"]);
            comboBox_Pais.SelectedValue = Convert.ToInt32(cuenta.Rows[0]["PAIS"]);
            comboBox_TipoCuenta.SelectedValue = Convert.ToInt32(cuenta.Rows[0]["TIPO"]);
            
            int estado = Convert.ToInt32(cuenta.Rows[0]["ESTADO"]);
            if (estado == 4)
            {
                checkBox_Estado.Visible = true;
                checkBox_Estado.Checked = false;
                label1.Visible = true;
            }
        }
    }
}
