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
    public partial class ModificarCategoriaCuenta : Form
    {
        private void LimpiarCampos()
        {
            foreach (var control in this.paner_TipoCuentas.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_TipoCuentas.Controls.OfType<ComboBox>()) control.Text = "";
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
                    CapaDAO.DAOCuenta.modificarTipoCuenta(Convert.ToInt64(comboBox_Cuentas.SelectedValue), Convert.ToInt32(comboBox_TipoCuenta.SelectedValue));                 
                    Mensaje_OK("Los datos han sido almacenados con exito", "");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR.-" + ex.Message);
                } 



                Mensaje_OK("Los datos han sido almacenados con exito", "");
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
            comboBox_Cuentas.DataSource = CapaDAO.DAOOperacion.getCuentas();

            comboBox_TipoCuenta.ValueMember = "TIP_ID";
            comboBox_TipoCuenta.DisplayMember = "NOMBRE";
            comboBox_TipoCuenta.DataSource = CapaDAO.DAOCuenta.getTiposCuenta();

        }

        private void comboBox_Cuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
           DataTable cuenta = CapaDAO.DAOCuenta.getCuenta(Convert.ToInt64(comboBox_Cuentas.SelectedValue));
           textBox_Moneda.Text = Convert.ToString(cuenta.Rows[0]["MON_NOM"]);
           textBox_Pais.Text = Convert.ToString(cuenta.Rows[0]["PAI_NOM"]);
           comboBox_TipoCuenta.SelectedValue = Convert.ToInt32(cuenta.Rows[0]["TIPO"]);
           textBox_TipoCuentaActual.Text = comboBox_TipoCuenta.Text;
           comboBox_TipoCuenta.SelectedIndex = 0;
           
        }

        private void comboBox_TipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
