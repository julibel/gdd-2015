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
    public partial class Seleccion : FormBase
    {
        private bool esBaja;

        private TextBox destino;

        private Form caller;

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

        public Seleccion(Form form, TextBox destino)
        {
            InitializeComponent();
            caller = form;
            caller.Visible = false;
            this.destino = destino;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            cerrar(null);
        }

        private void cerrar(DataGridViewCellEventArgs e)
        {
            if (caller != null)
            {
                destino.Text = Convert.ToString(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value);
                caller.Visible = true;
            }
            else
            {
                Form form;
                if (esBaja)
                    form = new ABM_Cuenta.Baja(Convert.ToInt64(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value));
                else
                    form = new ABM_Cuenta.Modificacion(Convert.ToInt64(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value));

                form.MdiParent = this.MdiParent;
                form.Show();
            }
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
            dataGridView_Seleccion.DataSource = CapaDAO.DAOCuenta.getCuentas(textBox_NumeroCuenta.Text, comboBox_Pais.Text, Convert.ToInt32(comboBox_TipoCuenta.SelectedValue), esBaja);
            dataGridView_Seleccion.Columns[0].Visible = true;
        }

        private void dataGridView_Seleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cerrar(e);
        }
    }
}
