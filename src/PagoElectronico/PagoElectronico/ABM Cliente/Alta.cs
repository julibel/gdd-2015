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
    public partial class Alta : FormBase
    {
        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox_Alta.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox_Usuario.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox_Alta.Controls.OfType<ComboBox>()) control.Text = "";      
            dataGridView_Tarjetas.Rows.Clear();
            dateTimePicker_FechaNacimiento.Value = DateTime.Now;
            this.ActiveControl = textBox_Nombre;
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

        public Alta()
        {
            InitializeComponent();
            this.ActiveControl = textBox_Nombre;
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
                if (!Validaciones()) return;
                try
                {
                   int id = DAOCliente.AgregarCliente(GenerarCliente(),GenerarUsuario());

             

                   //lista tarjeta
                   var lista_tarjetas = new List<Tarjeta>();

                   for (int i = 0; i < dataGridView_Tarjetas.Rows.Count; i++)
                   {
                       lista_tarjetas.Add(GenerarTarjeta(dataGridView_Tarjetas.Rows[i]));
                   }


                   foreach (var tarjeta in lista_tarjetas)
                   {
                       DAOTarjeta.AgregarTarjeta(tarjeta, id);
                   }
                   Mensaje_OK("Los datos han sido almacenados con éxito");
                   LimpiarCampos();
                }
                catch (Exception ex)
                {
                    Mensaje_Error("ERROR: " + ex.Message);
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

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos: ", (current, error) => current + ("\n" + error.Descripcion));
            Mensaje_Error(mensaje);
            return false;
        }

        private Error ValidarDocumento()
        {
            return DAOCliente.existeDni(textBox_Documento.Text, comboBox_Tipo_doc.SelectedIndex + 1) ? new Error("El documento ingresado ya está asignado a un usuario registrado") : null;
        }

        private Error ValidarEmail()
        {
            return DAOCliente.existeMail(textBox_Mail.Text) ? new Error("El email ingresado ya está asignado a un cliente registrado") : null;
        }

        private Error ValidarDatosCompletos()
        {
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario"): null;
        }

        private Error ValidarNum(string campo, string texto)
        {
            return (ValidarNumeros(texto)) ? new Error("El campo "+campo+" debe ser tipo numerico") : null;
        }

        private Persona GenerarCliente()
        {
            return new Persona(
                    0,
                    textBox_Nombre.Text,
                    textBox_Apellido.Text,
                    textBox_Documento.Text,
                    (int)(comboBox_Tipo_doc.SelectedIndex + 1),
                    textBox_Calle.Text,
                    Convert.ToInt32(textBox_Piso.Text),
                    textBox_Depto.Text,
                    textBox_Localidad.Text,
                    comboBox_Pais.Text,
                    0,
                    dateTimePicker_FechaNacimiento.Value,
                    comboBox_Nacionalidad.Text,
                    0,
                    textBox_Mail.Text            
                    );
        }

        private Tarjeta GenerarTarjeta(DataGridViewRow row)
        {
            return new Tarjeta(
                Convert.ToInt64(row.Cells[0].Value),
                Convert.ToInt32(row.Cells[1].Value),
                Convert.ToString(row.Cells[3].Value)
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
                listaDeRoles
                );

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private Error ValidarTarjeta()
        {
            return (ValidarDatosTarjeta()) ? new Error("Complete todos los campos de la tarjeta") : null;
        }
        private Error ValidarLong()
        {
            return (ValidarLongitud()) ? new Error("Debe ingresar un numero de tarjeta de 16 digitos") : null;
        }


        private void button_Agregar_Click(object sender, EventArgs e)
        {
            var listaDeErrores2 = new List<Error>();
            if (ValidarTarjeta() != null) listaDeErrores2.Add(ValidarTarjeta());
            if (ValidarLong() != null) listaDeErrores2.Add(ValidarLong());

            if (listaDeErrores2.Count < 1)
            {
                string columna1 = maskedTextBox_numeroTarjeta.Text;
                string columna2 = maskedTextBox_codigo.Text;
                string columna3 = Convert.ToString(comboBox_Emisor.Text);
              
                string[] row = { columna1, columna2, columna3 };
                dataGridView_Tarjetas.Rows.Add(row);
            }
            else
            {
                var mensaje = listaDeErrores2.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
                MessageBox.Show(mensaje);
            }


        }

        private bool ValidarDatosTarjeta()
        {
            bool vacio = false;

            foreach (var control in this.groupBox_AsociarTarjetas.Controls.OfType<MaskedTextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }

            if (comboBox_Emisor.Text == String.Empty)
            {
                vacio = true;
            }

            return vacio;
        }
        private bool ValidarLongitud()
        {
            bool vacio = false;
            if (maskedTextBox_numeroTarjeta.Text.Length < 16)
            {
                vacio = true;
            }
            return vacio;
        }

        private void dataGridView_Tarjetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Tarjetas.Rows.RemoveAt(e.RowIndex);
        }
    }
}
