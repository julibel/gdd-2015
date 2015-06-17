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
    public partial class Alta : Form
    {
        private ABM_Cliente.Seleccion seleccion;

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<ComboBox>()) control.Text = "";
            comboBox_Moneda.SelectedValue = -1;
            comboBox_TipoCuenta.SelectedValue = -1;
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

        public Alta()
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
                MessageBox.Show("No están todos los datos obligatorios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = Mensaje_Pregunta("¿Esta seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cuenta");
            if (resultado == DialogResult.Yes)
            {
                CapaDAO.DAOCuenta.agregarCuenta(seleccion.id, comboBox_Pais.Text, Convert.ToInt32(comboBox_Moneda.SelectedValue), Convert.ToInt32(comboBox_TipoCuenta.SelectedValue));
                Mensaje_OK("Los datos han sido almacenados con exito", "");
                LimpiarCampos();
            }
        }

        private bool camposCorrectos()
        {
            return comboBox_Pais.Text != "" && comboBox_Moneda.Text != "" && comboBox_TipoCuenta.Text != "";
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            comboBox_Moneda.ValueMember = "MON_ID";
            comboBox_Moneda.DisplayMember = "NOMBRE";
            comboBox_Moneda.DataSource = CapaDAO.DAOCuenta.getMonedas();

            comboBox_Pais.ValueMember = "PAI_ID";
            comboBox_Pais.DisplayMember = "NOMBRE";
            comboBox_Pais.DataSource = CapaDAO.DAOCuenta.getPaises();

            comboBox_TipoCuenta.ValueMember = "TIP_ID";
            comboBox_TipoCuenta.DisplayMember = "NOMBRE";
            comboBox_TipoCuenta.DataSource = CapaDAO.DAOCuenta.getTiposCuenta();

            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seleccion = new ABM_Cliente.Seleccion(this, textBox1);
            seleccion.MdiParent = this.MdiParent;
            this.Visible = false;
            seleccion.Show();
        }
    }
}
