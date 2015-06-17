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
    public partial class Seleccion : Form
    {
        private bool esBaja;

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_Filtros.Controls.OfType<ComboBox>()) control.Text = "";
            dataGridView_Seleccion.DataSource = new DataTable();
            dataGridView_Seleccion.Columns[0].Visible = false;
        }


        public Seleccion(bool baja)
        {
            InitializeComponent();
            esBaja = baja;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Seleccion_Load(object sender, EventArgs e)
        {
            comboBox_TipoCuenta.ValueMember = "TIP_ID";
            comboBox_TipoCuenta.DisplayMember = "NOMBRE";
            comboBox_TipoCuenta.DataSource = CapaDAO.DAOCuenta.getTiposCuenta();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            dataGridView_Seleccion.DataSource = CapaDAO.DAOCuenta.getCuentas(textBox_NumeroCuenta.Text, comboBox_Pais.Text, Convert.ToInt32(comboBox_TipoCuenta.SelectedValue));
            dataGridView_Seleccion.Columns[0].Visible = true;
        }

        private void dataGridView_Seleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form;
            if (esBaja)
                form = new ABM_Cuenta.Baja(Convert.ToInt64(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value));
            else
                form = new ABM_Cuenta.Modificacion(Convert.ToInt64(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value));
            form.Show();
            this.Close();
        }
    }
}
