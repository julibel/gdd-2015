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

namespace PagoElectronico.ABM_Rol
{
    public partial class Modificacion : FormBase
    {
        private int idRol;

        public override void mostrar(Form parent, params object[] values)
        {
            string id = values[0].ToString();
            ArmarPorId(id);
            base.mostrar(parent);
        }

        private bool CamposCorrectos()
        {
            return textBox_Nombre.Text != "" &&
            dataGridView_ListaFuncionalidades.Rows.Count > 0;
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox1.Controls.OfType<ComboBox>()) control.Text = "";
            foreach (var control in this.paner_Alta.Controls.OfType<TextBox>()) control.Text = "";
            dataGridView_ListaFuncionalidades.DataSource = new DataTable();
        }

        public Modificacion()
        {
            InitializeComponent();
        }

        private void ArmarPorId(string id)
        {
            DataTable rol = DAORol.getRol(id);

            textBox_Nombre.Text = Convert.ToString(rol.Rows[0]["NOMBRE"]);

            DataTable dt = DAORol.getFuncionalidades();

            comboBox_Funcionalidad.ValueMember = "FUN_ID";
            comboBox_Funcionalidad.DisplayMember = "NOMBRE";
            comboBox_Funcionalidad.DataSource = dt;

            dataGridView_ListaFuncionalidades.DataSource = DAORol.getFuncionalidades(Convert.ToInt32(id));
            dataGridView_ListaFuncionalidades.Columns["FUN_ID"].Visible = false;
            dataGridView_ListaFuncionalidades.Columns[0].DisplayIndex = 2;

            this.idRol = Convert.ToInt32(id);
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (!CamposCorrectos())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Guardar Rol");
            if (resultado == DialogResult.Yes)
            {
                DAORol.modificarRol(idRol, textBox_Nombre.Text, dataGridView_ListaFuncionalidades.Rows);

                Mensaje_OK("Los datos han sido actualizados con éxito");
            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            List<string> indices = new List<string>();

            for (int i = 0; i < dataGridView_ListaFuncionalidades.Rows.Count; i++)
            {
                indices.Add(Convert.ToString(dataGridView_ListaFuncionalidades.Rows[i].Cells["FUN_ID"].Value));
            }

            if (!indices.Contains(Convert.ToString(comboBox_Funcionalidad.SelectedValue)))
            {
                dataGridView_ListaFuncionalidades.Rows.Add(comboBox_Funcionalidad.SelectedValue, comboBox_Funcionalidad.Text);
            }
        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_ListaFuncionalidades.Rows.RemoveAt(e.RowIndex);
        }
    }
}
