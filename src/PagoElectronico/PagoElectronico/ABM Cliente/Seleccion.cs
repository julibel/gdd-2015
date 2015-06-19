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
    public partial class Seleccion : FormBase
    {
        private FormBase caller;

        private string clienteNom;

        string nombre, apellido, doc, mail;
        int tipoDoc = 0;
       
        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<TextBox>()) control.Text = "";
            comboBox_TipoDocumento.Text = "";
            dataGridView_Seleccion.DataSource = new DataTable();
        }

        public Seleccion(FormBase caller)
        {
            InitializeComponent();
            this.caller = caller;
            this.ActiveControl = textBox_Nombre;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void cerrar()
        {
            this.Close();
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
            DataTable table = DAOCliente.getCliente(id);
            DataTable tarjetas = DAOCliente.getTarjetasCliente(id);
            Persona cliente = DAOCliente.dataRowToCliente(table.Rows[0]);

            clienteNom = cliente.Nombre + ' ' + cliente.Apellido;
 
            List<Tarjeta> listaTarjetas = new List<Tarjeta>();
            foreach (DataRow row in tarjetas.Rows)
            {
                Tarjeta tarjeta = DAOTarjeta.dataRowToTarjetas(row);
                listaTarjetas.Add(tarjeta);
            }

            caller.mostrar(this.MdiParent, cliente, tarjetas, listaTarjetas);

            cerrar();
        }

        private void textBox_Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Buscar_Click(sender, e);
        }
    }
}
