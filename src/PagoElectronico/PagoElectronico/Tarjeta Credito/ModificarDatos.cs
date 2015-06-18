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
            foreach (var control in this.groupBox1.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox1.Controls.OfType<ComboBox>()) control.SelectedValue = -1;
            foreach (var control in this.groupBox1.Controls.OfType<MaskedTextBox>()) control.Clear();
         }
        public ModificarDatos()
        {
            
            InitializeComponent();
            comboBox_Numero_Tarjeta.DataSource = DAOCliente.getTarjetasCliente(CapaDAO.DAOTarjeta.getClienteId());
            comboBox_Numero_Tarjeta.ValueMember = "NUMERO_TARJETA";
            comboBox_Numero_Tarjeta.DisplayMember = "NUMERO_TARJETA";
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

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }
        private Error ValidarDatosCompletos()
        {
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario.") : null;
        }

        private bool ValidarCamposCompletos()
        {
            bool vacio = false;

            foreach (var control in this.groupBox1.Controls.OfType<TextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
            foreach (var control in this.groupBox1.Controls.OfType<MaskedTextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
           

            return vacio;

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Esta seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cliente");
            if (resultado == DialogResult.Yes)
            {
                if (!Validaciones()) return;
                try
                {
                    
                    //modificar tarjeta
                    Mensaje_OK("Los datos han sido almacenados con exito", "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR.-" + ex.Message);
                }
            }
        }

        private void ModificarDatos_Load(object sender, EventArgs e)
        {

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
