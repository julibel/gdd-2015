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
            comboBox_Funcionalidad.SelectedIndex = -1;
            DataTable funcs = (DataTable)dataGridView_ListaFuncionalidades.DataSource;
            funcs.Rows.Clear();
            dataGridView_ListaFuncionalidades.DataSource = funcs;
            checkBox1.Checked = true;
        }

        public Modificacion()
        {
            InitializeComponent();
           
           
        }

        private void ArmarPorId(string id)
        {
            DataTable rol = DAORol.getRol(id);
          
            textBox_Nombre.Text = Convert.ToString(rol.Rows[0]["NOMBRE"]);

            if (Convert.ToInt32(rol.Rows[0]["ESTADO"]) == 1)
            {
                checkBox1.Hide();
                label1.Hide();
            }

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
                int estado = 0;
                if (checkBox1.Checked == true)
                {
                    estado = 1;
                }

                DAORol.modificarRol(idRol, textBox_Nombre.Text, dataGridView_ListaFuncionalidades.Rows,estado);

                Mensaje_OK("Los datos han sido actualizados con éxito");
                this.Close();
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
                DataTable funcs = (DataTable)dataGridView_ListaFuncionalidades.DataSource;
                funcs.Rows.Add(comboBox_Funcionalidad.SelectedValue, comboBox_Funcionalidad.Text);
                dataGridView_ListaFuncionalidades.DataSource = funcs;
            }
        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0) return;
            dataGridView_ListaFuncionalidades.Rows.RemoveAt(e.RowIndex);
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            comboBox_Funcionalidad.SelectedIndex = -1;
        }
    }
}
