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
    public partial class Seleccion : FormBase
    {
        private FormBase caller;

        public Seleccion(FormBase caller)
        {
            InitializeComponent();
            this.caller = caller;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccion_Load(object sender, EventArgs e)
        {
            DataTable roles = DAORol.getRoles();

            dataGridView_SeleccionRol.Rows.Add(roles.Rows.Count);
            Int32 i = 0;
            foreach (DataRow rw in roles.Rows)
            {
                dataGridView_SeleccionRol.Rows[i].Cells[0].Value = rw["Indice"].ToString();
                dataGridView_SeleccionRol.Rows[i].Cells[1].Value = rw["Rol"].ToString();
                i++;
            }
        }

        private void dataGridView_SeleccionRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;

            id = Convert.ToString(dataGridView_SeleccionRol.Rows[e.RowIndex].Cells[0].Value);
            
            caller.mostrar(this.MdiParent, id);
            this.Close();
        }
    }
}
