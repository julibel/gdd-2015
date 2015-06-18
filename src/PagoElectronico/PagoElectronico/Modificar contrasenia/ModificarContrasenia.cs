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

namespace PagoElectronico.Modificar_contrasenia
{
    public partial class ModificarContrasenia : FormBase
    {
        
        private void LimpiarCampos()
        {
            textBox_NuevaPassword.Text = "";
            textBox_PasswordActual.Text = "";
        }

        public ModificarContrasenia()
        {
            InitializeComponent();
          
        }

        private void paner_DatosCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void ModificarContrasenia_Load(object sender, EventArgs e)
        {
           textBox_Username.Text = Globals.username;

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {


            var resultado = Mensaje_Pregunta("¿Esta seguro que desea guardar los datos ingresados en el formulario?", "Guardar nueva contrasenia");
            if (resultado == DialogResult.Yes)
            {
                if (!Validaciones()) return;
                try
                {
                    DAOUsuario.modificarContrasenia(Globals.userID,
                    Encriptacion.Encriptar(textBox_NuevaPassword.Text));
                    Mensaje_OK("Los datos han sido almacenados con exito", "");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR.-" + ex.Message);
                }       

              
            }
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

            foreach (var control in this.paner_DatosCuenta.Controls.OfType<TextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
            return vacio;

        }
    }
}
