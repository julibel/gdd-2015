using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class ModificarTipoCuentas : Form
    {
        private void LimpiarCampos()
        {
            foreach (var control in this.paner_TipoCuentas.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_TipoCuentas.Controls.OfType<ComboBox>()) control.SelectedIndex = -1;
        }

        private void Mensaje_OK(String mensaje, String resumen)
        {
            MessageBox.Show(mensaje, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private DialogResult Mensaje_Pregunta(String mensaje, String resumen)
        {
            var resultado = MessageBox.Show(mensaje, resumen, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;

        }

        public ModificarTipoCuentas()
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
            var resultado = Mensaje_Pregunta("¿Esta seguro que desea guardar los datos ingresados en el formulario?", "Guardar Tipo de Cuenta");
            if (resultado == DialogResult.Yes)
            {
                if (!Validaciones()) return;

                //try
                //{
                    CapaDAO.DAOCuenta.modificarCostosTipo(Convert.ToInt32(comboBox_TipoCuenta.SelectedValue), Convert.ToDouble(textBox_CostoMantModificado.Text), Convert.ToDouble(textBox_CostoTranModificado.Text));
                    Mensaje_OK("Los datos han sido almacenados con exito", "");
                    LimpiarCampos();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("ERROR.-" + ex.Message);
                //}       

            }
        }
        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

            if (ValidarDatosCompletos() != null) listaDeErrores.Add(ValidarDatosCompletos());
            
            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarDatosCompletos()
        {
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario.") : null;
        }

        private bool ValidarCamposCompletos()
        {
            bool vacio = false;

            foreach (var control in this.paner_TipoCuentas.Controls.OfType<TextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
           
            return vacio;

        }
        private void ModificarTipoCuentas_Load(object sender, EventArgs e)
        {
            comboBox_TipoCuenta.ValueMember = "TIP_ID";
            comboBox_TipoCuenta.DisplayMember = "NOMBRE";
            comboBox_TipoCuenta.DataSource = CapaDAO.DAOCuenta.getTiposCuenta();
            LimpiarCampos();

        }

        private void comboBox_TipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TipoCuenta.SelectedIndex == -1) return;
            DataTable cuenta = CapaDAO.DAOCuenta.getCostoTipo(Convert.ToInt32(comboBox_TipoCuenta.SelectedValue));
            textBox_CostoMantActual.Text = Convert.ToString(cuenta.Rows[0]["COSTO_MANTENIMIENTO"]);
            textBox_CostTranActual.Text = Convert.ToString(cuenta.Rows[0]["COSTO_TRANSACCION"]);
           
           
        }

        private void textBox_CostoMantModificado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_CostoTranModificado_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
