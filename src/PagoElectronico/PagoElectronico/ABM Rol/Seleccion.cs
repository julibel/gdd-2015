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
    public partial class Seleccion : Form
    {
        private bool esBaja;

        public Seleccion(bool esBaja)
        {
            InitializeComponent();
            this.esBaja = esBaja;

            if (esBaja)
            {
                dataGridView_SeleccionRol.Columns[2].HeaderText = "Eliminar";
            }
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccion_Load(object sender, EventArgs e)
        {
            DataTable dt = CapaDAO.DAORol.getRoles();

            dataGridView_SeleccionRol.Rows.Add(dt.Rows.Count);
            Int32 i = 0;
            foreach (DataRow rw in dt.Rows)
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
            
            if (ActiveMdiChild != null) ActiveMdiChild.Close();

            Form nuevo_form;
            
            if (esBaja)
            {
                nuevo_form = new ABM_Rol.Baja(id);
            }
            else
            {
                nuevo_form = new ABM_Rol.Modificacion(id);
            }
            
            
            nuevo_form.MdiParent = this.MdiParent;
            nuevo_form.Show();
            this.Close();
        }
    }
}
