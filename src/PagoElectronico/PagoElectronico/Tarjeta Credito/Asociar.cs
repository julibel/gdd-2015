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
    
    public partial class Asociar : Form
    {
        private void Mensaje_OK(String mensaje, String resumen)
        {
            MessageBox.Show(mensaje, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private DialogResult Mensaje_Pregunta(String mensaje, String resumen)
        {
            var resultado = MessageBox.Show(mensaje, resumen, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;

        }

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
            var resultado = Mensaje_Pregunta("¿Esta seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cliente");
            if (resultado == DialogResult.Yes)
            {
                int id = CapaDAO.DAOTarjeta.getClienteId(Globals.userID);
                Tarjeta tarjeta = new Tarjeta(Convert.ToInt64(maskedTextBox_numeroTarjeta.Text),
                                              Convert.ToInt32(maskedTextBox_codigo.Text),
                                              comboBox_Emisor.Text);
                CapaDAO.DAOTarjeta.AgregarTarjeta(tarjeta,id);
                Mensaje_OK("Los datos han sido almacenados con exito", "");
            }
        }
    }
}
