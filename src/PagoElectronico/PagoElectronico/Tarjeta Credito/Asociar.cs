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
            int idCli = DAOCliente.getClienteId();

            try
            {
                if (!camposCorrectos(idCli))
                {
                    Mensaje_Error("No están todos los datos obligatorios");
                    return;
                }
                var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Asociar Tarjeta");
                if (resultado == DialogResult.Yes)
                {
                    Tarjeta tarjeta = new Tarjeta(textBox_NombreTitular.Text,
                                                  Convert.ToInt64(maskedTextBox_numeroTarjeta.Text),
                                                  Convert.ToInt32(maskedTextBox_codigo.Text),
                                                  comboBox_Emisor.Text,
                                                  maskedTextBox1.Text,
                                                  textBox_FechaVencimiento.Text);
                    
                    DAOTarjeta.asociarTarjeta(tarjeta, idCli);
                    LimpiarCampos();
                 }
            }
            catch (Exception)
            {
                Mensaje_Error("La fecha debe ser una fecha válida");
                return;
            }
                Mensaje_OK("Los datos han sido almacenados con éxito");
        }

        private bool camposCorrectos(int idCli)
        {
            if (Convert.ToDateTime(Globals.getFechaSistema()) > Convert.ToDateTime(textBox_FechaVencimiento.Text))
            {
                Mensaje_Error("La tarjeta se encuentra vencida");
                return false;
            }

            if (idCli == 0)
            {
                Mensaje_Error("Debe tener rol cliente para realizar esta acción");
                return false;
            }

            return maskedTextBox_numeroTarjeta.Text != "" && maskedTextBox_codigo.Text != "" && textBox_NombreTitular.Text != "" && comboBox_Emisor.SelectedIndex >= 0 && maskedTextBox1.Text != "";
        }

        private void Asociar_Load(object sender, EventArgs e)
        {
            comboBox_Emisor.ValueMember = "EMI_ID";
            comboBox_Emisor.DisplayMember = "NOMBRE";
            comboBox_Emisor.DataSource = DAOTarjeta.getEmisores();
            this.ActiveControl = maskedTextBox_numeroTarjeta;
            LimpiarCampos();
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
            foreach (var control in this.groupBox1.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox1.Controls.OfType<MaskedTextBox>()) control.Text = "";
            foreach (var control in this.groupBox1.Controls.OfType<ComboBox>()) control.SelectedIndex = -1;
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
