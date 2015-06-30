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
    public partial class ModificarDatos : FormBase
    {
        private void LimpiarCampos()
        {
            comboBox_Numero_Tarjeta.DataSource = DAOTarjeta.getAllTarjetas();
            foreach (var control in groupBox1.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in groupBox1.Controls.OfType<ComboBox>())
            {
                control.SelectedValue = -1;
                control.Text = "";
            }
            foreach (var control in groupBox1.Controls.OfType<MaskedTextBox>()) control.Clear();
            this.ActiveControl = comboBox_Numero_Tarjeta;
            checkBox_habilitada.Visible = false;
         }
        public ModificarDatos()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

        
            if (ValidarDatosCompletos() != null) listaDeErrores.Add(ValidarDatosCompletos());
         
            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validación de datos: ", (current, error) => current + ("\n" + error.Descripcion));
            Mensaje_Error(mensaje);
            return false;
        }
        private Error ValidarDatosCompletos()
        {
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario") : null;
        }

        private bool ValidarCamposCompletos()
        {
            bool vacio = false;

            foreach (var control in this.groupBox1.Controls.OfType<TextBox>())
                if (control.Text == String.Empty) vacio = true;
            foreach (var control in this.groupBox1.Controls.OfType<MaskedTextBox>())
                if (control.Text == String.Empty) vacio = true;
            foreach (var control in groupBox1.Controls.OfType<ComboBox>())
                if (control.SelectedIndex == -1 || control.Text == String.Empty) vacio = true;
            return vacio;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {

            if (!Validaciones()) return;
            var resultado = Mensaje_Pregunta("¿Está seguro que desea actualizar los datos de la tarjeta?", "Modificar Tarjeta");
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    DAOTarjeta.modificarTarjeta(Convert.ToInt32(comboBox_Numero_Tarjeta.SelectedValue), maskedTextBox_numeroTarjeta.Text, textBox_NombreTitular.Text, maskedTextBox_codigo.Text, comboBox_Emisores.Text, Convert.ToDateTime(maskedTextBox_fechaEmision.Text), Convert.ToDateTime( textBox_FechaVencimiento.Text), checkBox_habilitada.Checked);
                    Mensaje_OK("Los datos han sido almacenados con éxito");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    Mensaje_Error("ERROR: " + ex.Message);
                }
            }
        }

        private void ModificarDatos_Load(object sender, EventArgs e)
        {
            comboBox_Numero_Tarjeta.ValueMember = "TAR_ID";
            comboBox_Numero_Tarjeta.DisplayMember = "NUMERO";
            comboBox_Numero_Tarjeta.DataSource = DAOTarjeta.getAllTarjetas();

            comboBox_Emisores.ValueMember = "EMI_ID";
            comboBox_Emisores.DisplayMember = "NOMBRE";
            comboBox_Emisores.DataSource = DAOTarjeta.getEmisores();

            LimpiarCampos();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void comboBox_Numero_Tarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Numero_Tarjeta.SelectedIndex == -1) return;
            Tarjeta tarjeta = DAOTarjeta.getTarjeta(Convert.ToInt32(comboBox_Numero_Tarjeta.SelectedValue));
            comboBox_Emisores.Text = tarjeta.Emisor;
            textBox_NombreTitular.Text = tarjeta.titular;
            maskedTextBox_fechaEmision.Text = tarjeta.Fecha_Emision;
            textBox_FechaVencimiento.Text = tarjeta.Fecha_Vencimiento;
            verificarEstado(tarjeta.estado);
        }

        private void verificarEstado(bool estado)
        {
            checkBox_habilitada.Visible = !estado;
            checkBox_habilitada.Checked = estado;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string fecha = maskedTextBox_fechaEmision.Text;

            if (fecha.Length < 10)
                return;
            else
                textBox_FechaVencimiento.Text = fecha.Substring(0, 6) + (Convert.ToInt32(fecha.Substring(6, 4)) + 3).ToString();
        }

        private void maskedTextBox_numeroTarjeta_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox_numeroTarjeta);
        }

        private void maskedTextBox_codigo_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox_codigo);
        }

        private void maskedTextBox_fechaEmision_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox_fechaEmision);
        }
    }
}
