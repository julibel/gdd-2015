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
    public partial class ModificarCategoriaCuenta : FormBase
    {
        private void LimpiarCampos()
        {
            foreach (var control in this.paner_TipoCuentas.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_TipoCuentas.Controls.OfType<ComboBox>()) control.SelectedIndex = -1;
            this.ActiveControl = comboBox_Cuentas;
        }

        public ModificarCategoriaCuenta()
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

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Esta seguro que desea guardar los datos ingresados en el formulario?", "Guardar Categoria de Cuenta");
            if (resultado == DialogResult.Yes)
            {

                if (!Validaciones()) return;
                try
                {
                    DAOCuenta.modificarTipoCuenta(Convert.ToInt64(comboBox_Cuentas.SelectedValue), Convert.ToInt32(comboBox_TipoCuenta.SelectedValue));                 
                    Mensaje_OK("Los datos han sido almacenados con exito");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    Mensaje_Error("ERROR: " + ex.Message);
                } 
            }
        }

        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

            
            if (ValidarDatosCompletos() != null) listaDeErrores.Add(ValidarDatosCompletos());
            
            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            Mensaje_Error(mensaje);
            return false;
        }

        private Error ValidarDatosCompletos()
        {
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario.") : null;
        }

        private bool ValidarCamposCompletos()
        {
            bool vacio = false;

            if (comboBox_TipoCuenta.Text == String.Empty)
            {
                vacio = true;
            }

            return vacio;

        }

        private void ModificarCategoriaCuenta_Load(object sender, EventArgs e)
        {
            comboBox_Cuentas.ValueMember = "CUE_ID";
            comboBox_Cuentas.DisplayMember = "CUE_ID";
            comboBox_Cuentas.DataSource = DAOOperacion.getCuentas();

            comboBox_TipoCuenta.ValueMember = "TIP_ID";
            comboBox_TipoCuenta.DisplayMember = "NOMBRE";
            comboBox_TipoCuenta.DataSource = DAOCuenta.getTiposCuenta();

            LimpiarCampos();
        }

        private void comboBox_Cuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Cuentas.SelectedValue == null)
            {
                LimpiarCampos();
                return;
            }
           DataTable cuenta = DAOCuenta.getCuenta(Convert.ToInt64(comboBox_Cuentas.SelectedValue));
           textBox_Moneda.Text = Convert.ToString(cuenta.Rows[0]["MON_NOM"]);
           textBox_Pais.Text = Convert.ToString(cuenta.Rows[0]["PAI_NOM"]);
           comboBox_TipoCuenta.SelectedValue = Convert.ToInt32(cuenta.Rows[0]["TIPO"]);
           textBox_TipoCuentaActual.Text = Convert.ToString(cuenta.Rows[0]["TIP_NOM"]);
        }

    }
}
