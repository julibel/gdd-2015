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
    public partial class Baja : FormBase
    {
        private int idRol;

        public override void mostrar(Form parent, params object[] values)
        {
            string id = values[0].ToString();
            ArmarPorId(id);
            base.mostrar(parent);
        }

        public Baja()
        {
            InitializeComponent();
        }

        private void ArmarPorId(string id)
        {
            DataTable roles = DAORol.getRol(id);

            textBox_Nombre.Text = Convert.ToString(roles.Rows[0]["NOMBRE"]);

            dataGridView_ListaFuncionalidades.DataSource = DAORol.getFuncionalidades(Convert.ToInt32(id));
            dataGridView_ListaFuncionalidades.Columns["FUN_ID"].Visible = false;

            this.idRol = Convert.ToInt32(id);
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea eliminar el Rol del sistema?", "Eliminar Rol");
            if (resultado == DialogResult.Yes)
            {
                DAORol.eliminarRol(idRol);
                Mensaje_OK("Los datos han sido eliminados con éxito");
                this.Close();
            }
        }
    }
}
