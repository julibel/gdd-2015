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
    public partial class Baja : FormBase
    {
        private int id_cliente;

        public override void mostrar(Form parent, params object[] values)
        {
            Persona cliente = (Persona) values[0];
            DataTable tarjetas = (DataTable)values[1];

            id_cliente = cliente.ID;
            textBox_Calle.Text = cliente.Calle;
            textBox_Apellido.Text = cliente.Apellido;
            textBox_Depto.Text = cliente.Departamento;
            textBox_Documento.Text = cliente.Documento;
            textBox_Fecha_Nacimiento.Text = cliente.FechaDeNacimiento.ToString();
            textBox_Localidad.Text = cliente.Localidad;
            textBox_Mail.Text = cliente.Mail;
            textBox_Nacionalidad.Text = cliente.Pais_Nacionalidad;
            textBox_Nombre.Text = cliente.Nombre;
            textBox_Pais.Text = cliente.Pais_Actual;
            textBox_Piso.Text = cliente.Piso.ToString();
            comboBox_Tipo_doc.SelectedIndex = cliente.TipoDoc - 1;
            dataGridView_Tarjetas.DataSource = tarjetas; 

            base.mostrar(parent);
        }


        public Baja()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {

            var resultado = Mensaje_Pregunta("¿Está seguro que desea eliminar al cliente del sistema?", "Eliminar Cliente");
            if (resultado == DialogResult.Yes)
            {

                DAOCliente.bajarCliente(id_cliente);
                Mensaje_OK("Los datos han sido eliminados con éxito");
                this.Close();
            }
        }

        private void Baja_Load(object sender, EventArgs e)
        {

        }
    }
}
