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
        private Form caller = null;

        private TextBox text;

        public int id;

        private string clienteNom;

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

        public Seleccion(Form caller, TextBox textbox)
        {
            InitializeComponent();
            this.caller = caller;
            this.text = textbox;
            caller.Visible = false;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void cerrar()
        {
            if (caller == null)
                this.Close();
            else
            {
                text.Text = clienteNom;
                caller.Visible = true;
            }
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

            this.id = cliente.ID;
            clienteNom = cliente.Nombre + ' ' + cliente.Apellido;

            if (ActiveMdiChild != null) ActiveMdiChild.Close();

            if (caller == null)
            {
                Form nuevo_form;
                
                if (esBaja)
                {
                    nuevo_form = new ABM_Cliente.Baja(cliente, tarjetas);
                }
                else
                {
                    List<Tarjeta> listaTarjetas = new List<Tarjeta>();
                    foreach (DataRow row in tarjetas.Rows)
                    {
                        Tarjeta tarjeta = DAOTarjeta.dataRowToTarjetas(row);
                        listaTarjetas.Add(tarjeta);
                    }
                    nuevo_form = new ABM_Cliente.Modificacion(cliente, listaTarjetas);
                }


                nuevo_form.Show();
            }
            cerrar();
        }
    }
}
