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

namespace PagoElectronico.ABM_Cliente
{
    public partial class Seleccion : Form
    {
        string nombre, apellido, doc, mail;
        int tipoDoc = 0;
        private bool esBaja;
       
        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<TextBox>()) control.Text = "";
            comboBox_TipoDocumento.Text = "";
            dataGridView_Seleccion.DataSource = new DataTable();
        }

        public Seleccion(bool esBaja)
        {
            InitializeComponent();
            this.esBaja = esBaja;

            if (esBaja)
            {
                dataGridView_Seleccion.Columns[0].HeaderText = "Eliminar";
            }
            else
            {
                dataGridView_Seleccion.Columns[0].HeaderText = "Modificar";
            }
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccion_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            nombre = textBox_Nombre.Text;
            apellido = textBox_Apellido.Text;
            mail = textBox_Mail.Text;
            tipoDoc = comboBox_TipoDocumento.SelectedIndex + 1;
            doc = textBox_Documento.Text;
            dataGridView_Seleccion.DataSource = CapaDAO.DAOCliente.getClientes(nombre, apellido, mail, tipoDoc, doc);
        }

        private void dataGridView_Seleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value);
            DataTable table = CapaDAO.DAOCliente.getCliente(id);
            DataTable tarjetas = CapaDAO.DAOCliente.getTarjetasCliente(id);
            Persona cliente = DAOCliente.dataRowToCliente(table.Rows[0]);
          

            if (ActiveMdiChild != null) ActiveMdiChild.Close();

            Form nuevo_form;

            if (esBaja)
            {
                nuevo_form = new ABM_Cliente.Baja(cliente, tarjetas);
            }
            else
            {
                nuevo_form = new ABM_Cliente.Modificacion(cliente);
            }


            nuevo_form.Show();
            this.Close();
        }
    }
}
