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
        private FormBase caller;

        private List<int> estados;

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_Filtros.Controls.OfType<ComboBox>()) control.Text = "";
            comboBox_TipoCuenta.SelectedIndex = -1;
            dataGridView_Seleccion.DataSource = new DataTable();
            dataGridView_Seleccion.Columns[0].Visible = false;
            this.ActiveControl = textBox_NumeroCuenta;
        }

        public Seleccion(FormBase form, int baja)
        {
            InitializeComponent();
            caller = form;
            if (baja == 1)
                estados = new List<int>(new int[] {(int)EstadoCuenta.Habilitada, (int)EstadoCuenta.Deshabilitada, (int)EstadoCuenta.PendienteDeActivacion});
            else
                estados = new List<int>(new int[] {(int)EstadoCuenta.Habilitada, (int)EstadoCuenta.Deshabilitada, (int)EstadoCuenta.PendienteDeActivacion, (int)EstadoCuenta.Cerrada});
        }

        public Seleccion(FormBase form, List<int> estados)
        {
            InitializeComponent();
            caller = form;
            this.estados = estados;
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
            comboBox_TipoCuenta.DataSource = DAOCuenta.getTiposCuenta();

            comboBox_Pais.ValueMember = "PAI_ID";
            comboBox_Pais.DisplayMember = "NOMBRE";
            comboBox_Pais.DataSource = DAOCuenta.getPaises();

            LimpiarCampos();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            dataGridView_Seleccion.DataSource = DAOCuenta.getCuentas(textBox_NumeroCuenta.Text, comboBox_Pais.Text, Convert.ToInt32(comboBox_TipoCuenta.SelectedValue), estados);
            dataGridView_Seleccion.Columns[0].Visible = true;
        }

        private void dataGridView_Seleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 || e.RowIndex < 0) return;

            string cuenta = Convert.ToString(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value);

            caller.mostrar(this.MdiParent, cuenta);
            this.Close();
        }

        private void textBox_NumeroCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Buscar_Click(sender, e);
        }
    }
}
