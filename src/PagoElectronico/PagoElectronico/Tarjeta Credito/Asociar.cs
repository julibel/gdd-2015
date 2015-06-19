using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.CapaDAO;
using PagoElectronico.Model;

namespace PagoElectronico.Tarjeta_Credito
{
    
    public partial class Asociar : FormBase
    {
        public Asociar()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cliente");
            if (resultado == DialogResult.Yes)
            {
                int idCli = DAOTarjeta.getClienteId();
                Tarjeta tarjeta = new Tarjeta(Convert.ToInt64(maskedTextBox_numeroTarjeta.Text),
                                              Convert.ToInt32(maskedTextBox_codigo.Text),
                                              comboBox_Emisor.Text,
                                              maskedTextBox1.Text,
                                              textBox_FechaVencimiento.Text);
                DAOTarjeta.AgregarTarjeta(tarjeta, idCli);
                Mensaje_OK("Los datos han sido almacenados con éxito");
            }
        }

        private void Asociar_Load(object sender, EventArgs e)
        {
            this.ActiveControl = maskedTextBox_numeroTarjeta;
        }

        private void maskedTextBox_numeroTarjeta_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox_numeroTarjeta);
        }

        private void maskedTextBox_codigo_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox_codigo);
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            throw new NotImplementedException();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string fecha = maskedTextBox1.Text;

            if (fecha.Length < 10)
                return;
            else
                textBox_FechaVencimiento.Text = fecha.Substring(0, 6) + (Convert.ToInt32(fecha.Substring(6, 4)) + 3).ToString();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox1);
        }
    }
}
