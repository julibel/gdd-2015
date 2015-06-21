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

namespace PagoElectronico.Tarjeta_Credito
{
    public partial class Desasociar : FormBase
    {
        public Desasociar()
        {
            InitializeComponent();
        }

        private void Desasociar_Load(object sender, EventArgs e)
        {
            comboBox_Numero_Tarjeta.ValueMember = "TAR_ID";
            comboBox_Numero_Tarjeta.DisplayMember = "NUMERO";
            comboBox_Numero_Tarjeta.DataSource = DAOTarjeta.getTarjetas();
            this.ActiveControl = comboBox_Numero_Tarjeta;
            LimpiarCampos();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (!camposCorrectos())
            {
                Mensaje_Error("No están todos los datos obligatorios completos");
                return;
            }

            if (Mensaje_Pregunta("¿Está seguro que quiere dar de baja la tarjeta?", "Desasociar Tarjeta") == DialogResult.Yes)
            {
                int tarID = Convert.ToInt32(comboBox_Numero_Tarjeta.SelectedValue);

                if (DAOTarjeta.coincideTarjeta(tarID, maskedTextBox_numeroTarjeta.Text, maskedTextBox_codigo.Text))
                {
                    DAOTarjeta.desasociarTarjeta(tarID);
                    Mensaje_OK("La tarjeta ha sido desasociada");
                    LimpiarCampos();
                }
                else
                    Mensaje_Error("No coincide los datos con la tarjeta", "Error de coincidencia");
            }
        }

        private void LimpiarCampos()
        {
            foreach (var control in groupBox1.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in groupBox1.Controls.OfType<ComboBox>())
            {
                control.Text = "";
                control.SelectedIndex = -1;
            }
            foreach (var control in groupBox1.Controls.OfType<MaskedTextBox>()) control.Text = "";
        }

        private bool camposCorrectos()
        {
            return comboBox_Numero_Tarjeta.SelectedIndex >= 0 && maskedTextBox_codigo.Text.Length == 3 && maskedTextBox_numeroTarjeta.Text.Length == 16;
        }

        private void comboBox_Numero_Tarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Numero_Tarjeta.SelectedIndex == -1) return;
            textBox_Emisor.Text = DAOTarjeta.getEmisor(Convert.ToInt32(comboBox_Numero_Tarjeta.SelectedValue));
            textBox_NombreTitular.Text = DAOTarjeta.getTitular(Convert.ToInt32(comboBox_Numero_Tarjeta.SelectedValue));
        }

        private void maskedTextBox_numeroTarjeta_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox_numeroTarjeta);
        }

        private void maskedTextBox_codigo_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox_codigo);
        }
    }
}
