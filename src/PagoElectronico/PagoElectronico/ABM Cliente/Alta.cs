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
    public partial class Alta : Form
    {
        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox_Alta.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox_Usuario.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox_Alta.Controls.OfType<ComboBox>()) control.Text = "";      
            dataGridView_Tarjetas.Rows.Clear();
            dateTimePicker_FechaNacimiento.Value = DateTime.Now;
        }
        private bool ValidarCamposCompletos()
        {
            bool vacio = false;

            foreach (var control in this.groupBox_Alta.Controls.OfType<TextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
            foreach (var control in this.groupBox_Usuario.Controls.OfType<TextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
            foreach (var control in this.groupBox_Alta.Controls.OfType<ComboBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }

            return vacio;

        }

        private bool ValidarNumeros(string texto)
        {
            return (!texto.All(char.IsDigit));
        }

        private void Mensaje_OK(String mensaje, String resumen)
        {
            MessageBox.Show(mensaje, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private DialogResult Mensaje_Pregunta(String mensaje, String resumen)
        {
            var resultado = MessageBox.Show(mensaje, resumen, MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            return resultado;

        }


        public Alta()
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
                if (!Validaciones()) return;
                try
                {
                   DAOCliente.AgregarCliente(GenerarCliente(),GenerarUsuario());
                   Mensaje_OK("Los datos han sido almacenados con exito", "");
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

            if (ValidarDocumento() != null) listaDeErrores.Add(ValidarDocumento());
            if (ValidarEmail() != null) listaDeErrores.Add(ValidarEmail());
            if (ValidarDatosCompletos() != null) listaDeErrores.Add(ValidarDatosCompletos());
            if (ValidarNum("Piso", textBox_Piso.Text) != null) listaDeErrores.Add(ValidarNum("Piso", textBox_Piso.Text));
            if (ValidarNum("Documento", textBox_Documento.Text) != null) listaDeErrores.Add(ValidarNum("Documento", textBox_Documento.Text));

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarDocumento()
        {
            return DAOCliente.existeDni(textBox_Documento.Text, comboBox_Tipo_doc.SelectedIndex + 1) ? new Error("El documento ingresado ya está asignado a un usuario registrado.") : null;
        }

        private Error ValidarEmail()
        {
            return DAOCliente.existeMail(textBox_Mail.Text) ? new Error("El email ingresado ya está asignado a un usuario registrado.") : null;
        }

        private Error ValidarDatosCompletos()
        {
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario."): null;
        }

        private Error ValidarNum(string campo, string texto)
        {
            return (ValidarNumeros(texto)) ? new Error("El campo "+campo+" debe ser tipo numerico") : null;
        }

        private Persona GenerarCliente()
        {
            return new Persona(
                    0,//id??
                    textBox_Nombre.Text,
                    textBox_Apellido.Text,
                    textBox_Documento.Text,
                    (int)(comboBox_Tipo_doc.SelectedIndex + 1),
                    textBox_Calle.Text,
                    Convert.ToInt32(textBox_Piso.Text),
                    textBox_Depto.Text,
                    textBox_Localidad.Text,
                    comboBox_Pais.Text,
                    dateTimePicker_FechaNacimiento.Value,
                    comboBox_Nacionalidad.Text,
                    textBox_Mail.Text            
                    );
        }

        private Usuario GenerarUsuario()
        {
            var listaDeRoles = new List<int>();
            return new Usuario(
                0,
                textBox_Username.Text,
                Encriptacion.Encriptar(textBox_Password.Text),
                textBox_PreguntaSecreta.Text,
                Encriptacion.Encriptar(textBox_RespuestaSecreta.Text),
                listaDeRoles//listaDeRoles.Add(DAOCliente.ObtenerRoles())
                );

        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
