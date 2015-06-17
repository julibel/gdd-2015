using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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






                Mensaje_OK("Los datos han sido almacenados con exito", "");
            }
        }

        private void ModificarCategoriaCuenta_Load(object sender, EventArgs e)
        {
            comboBox_Cuentas.ValueMember = "CUE_ID";
            comboBox_Cuentas.DisplayMember = "CUE_ID";
            comboBox_Cuentas.DataSource = CapaDAO.DAOOperacion.getCuentas();

        }
    }
}
