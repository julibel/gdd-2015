using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Rol
{
    public partial class Baja : Form
    {
        private int idRol;

        private void Mensaje_OK(String mensaje, String resumen)
        {
            MessageBox.Show(mensaje, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private DialogResult Mensaje_Pregunta(String mensaje, String resumen)
        {
            var resultado = MessageBox.Show(mensaje, resumen, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;

        }

        public Baja(string id)
        {
            InitializeComponent();

            ArmarPorId(id);
        }

        private void ArmarPorId(string id)
        {
            DataTable rol = CapaDAO.DAORol.getRol(id);

            textBox_Nombre.Text = Convert.ToString(rol.Rows[0]["NOMBRE"]);

            DataTable dt = CapaDAO.DAORol.getFuncionalidades();

            for (int i = 0; i < rol.Rows.Count; i++)
            {
                dataGridView_ListaFuncionalidades.Rows.Add(Convert.ToInt32(rol.Rows[i]["FUNCIONALIDAD"]), dt.Rows[Convert.ToInt32(rol.Rows[i]["FUNCIONALIDAD"]) - 1]["NOMBRE"]);
            }

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
                CapaDAO.DAORol.eliminarRol(idRol);
                Mensaje_OK("Los datos han sido eliminados con éxito", "");
            }

        }

        private void Baja_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
