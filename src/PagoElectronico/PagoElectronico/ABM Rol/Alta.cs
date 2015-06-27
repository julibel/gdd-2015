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
    public partial class Alta : FormBase
    {
        private bool CamposCorrectos()
        {
            return textBox_Nombre.Text != "" &&
            dataGridView_ListaFuncionalidades.Rows.Count > 0;
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox1.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_Alta.Controls.OfType<TextBox>()) control.Text = "";
            comboBox_Funcionalidad.SelectedIndex = -1;
            dataGridView_ListaFuncionalidades.Rows.Clear();
        }

        public Alta()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            DataTable funcionalidades = DAORol.getFuncionalidades();

            comboBox_Funcionalidad.ValueMember = "FUN_ID";
            comboBox_Funcionalidad.DisplayMember = "NOMBRE";
            comboBox_Funcionalidad.DataSource = funcionalidades;
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (DAORol.existeRol(textBox_Nombre.Text))
            {
                var res = Mensaje_Pregunta("El Rol ya existe pero está desactivado ¿Desea activarlo?", "Activar Rol");
                if (res == DialogResult.Yes)
                {
                    CapaDAO.DAORol.activarRol(textBox_Nombre.Text);
                    Mensaje_OK("El Rol ha sido activado");
                }
                return;
            }

            if (!CamposCorrectos())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Guardar Rol");
            if (resultado == DialogResult.Yes)
            {
                DAORol.agregarRol(textBox_Nombre.Text, dataGridView_ListaFuncionalidades.Rows);

                Mensaje_OK("Los datos han sido almacenados con éxito");
            }
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            List<string> indices = new List<string>();

            for (int i = 0; i < dataGridView_ListaFuncionalidades.Rows.Count; i++)
            {
                indices.Add(Convert.ToString(dataGridView_ListaFuncionalidades.Rows[i].Cells[0].Value));
            }

            if (!indices.Contains(Convert.ToString(comboBox_Funcionalidad.SelectedValue)))
            {
                dataGridView_ListaFuncionalidades.Rows.Add(comboBox_Funcionalidad.SelectedValue, comboBox_Funcionalidad.Text);
            }
        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 2) return;
            dataGridView_ListaFuncionalidades.Rows.RemoveAt(e.RowIndex);
        }
    }
}
