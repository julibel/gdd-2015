using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class Seleccion : Form
    {
        string nombre, apellido, doc, mail;
        int tipoDoc;
        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<TextBox>()) control.Text = "";
            comboBox_TipoDocumento.Text = "";
            dataGridView_Seleccion.DataSource = new DataTable();
        }

        public Seleccion()
        {
            InitializeComponent();
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
    }
}
