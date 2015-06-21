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
    public partial class Alta : FormBase
    {
        private int clienteID;

        private bool open = false;

        public override void mostrar(Form parent, params object[] values)
        {
            if (open == true)
            {
                this.Visible = true;
                Persona cliente = (Persona) values[0];
                clienteID = cliente.ID;
                textBox1.Text = cliente.Nombre + ' ' + cliente.Apellido;
                comboBox_Pais.Text = cliente.Pais_Actual;
                return;
            }
            else
                base.mostrar(parent);
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_DatosCuenta.Controls.OfType<ComboBox>()) control.Text = "";
            comboBox_Moneda.SelectedValue = -1;
            comboBox_TipoCuenta.SelectedValue = -1;
            this.ActiveControl = textBox1;
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
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }

            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cuenta");
            if (resultado == DialogResult.Yes)
            {
                CapaDAO.DAOCuenta.agregarCuenta(clienteID, comboBox_Pais.Text, Convert.ToInt32(comboBox_Moneda.SelectedValue), Convert.ToInt32(comboBox_TipoCuenta.SelectedValue));
                Mensaje_OK("Los datos han sido almacenados con éxito");
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
            comboBox_Moneda.DataSource = DAOCuenta.getMonedas();

            comboBox_Pais.ValueMember = "PAI_ID";
            comboBox_Pais.DisplayMember = "NOMBRE";
            comboBox_Pais.DataSource = DAOCuenta.getPaises();

            comboBox_TipoCuenta.ValueMember = "TIP_ID";
            comboBox_TipoCuenta.DisplayMember = "NOMBRE";
            comboBox_TipoCuenta.DataSource = DAOCuenta.getTiposCuenta();

            open = true;

            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM_Cliente.Seleccion seleccion = new ABM_Cliente.Seleccion(this, 0);
            this.Visible = false;
            seleccion.mostrar(this.MdiParent);
        }
    }
}
