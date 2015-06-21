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
            foreach (var panel in this.Controls.OfType<GroupBox>())
            {
                foreach (var control in panel.Controls.OfType<TextBox>()) control.Text = "";
                foreach (var control in panel.Controls.OfType<ComboBox>()) control.SelectedIndex = -1;
                foreach (var control in panel.Controls.OfType<MaskedTextBox>()) control.Text = "";
            }
            comboBox_Nacionalidad.Text = "";
            comboBox_Pais.Text = "";
            dataGridView_Tarjetas.Rows.Clear();
            dateTimePicker_FechaNacimiento.Value = Convert.ToDateTime(Globals.getFechaSistema());
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
                       lista_tarjetas.Add(GenerarTarjeta(dataGridView_Tarjetas.Rows[i], textBox_Nombre.Text + " " + textBox_Apellido.Text));
                   }


                   foreach (var tarjeta in lista_tarjetas)
                   {
                       DAOTarjeta.asociarTarjeta(tarjeta, id);
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

        private Tarjeta GenerarTarjeta(DataGridViewRow row, string titular)
        {
            return new Tarjeta(
                titular,
                Convert.ToInt64(row.Cells["Numero"].Value),
                Convert.ToInt32(row.Cells["Codigo"].Value),
                Convert.ToString(row.Cells["Emisor"].Value),
                Convert.ToString(row.Cells["FechaEmision"].Value),
                Convert.ToString(row.Cells["FechaVencimiento"].Value)
                );
        }

        private Usuario GenerarUsuario()
        {
            var listaDeRoles = new List<int>();
            return new Usuario(
                0,
                textBox_Username.Text,
                Encriptacion.getSHA256(textBox_Password.Text),
                textBox_PreguntaSecreta.Text,
                Encriptacion.getSHA256(textBox_RespuestaSecreta.Text),
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
                string numero = maskedTextBox_numeroTarjeta.Text;
                string codSeg = maskedTextBox_codigo.Text;
                string emisor = Convert.ToString(comboBox_Emisor.Text);
                string fechaEmision = maskedTextBox1.Text;
                string fechaVencimiento = calcularVencimiento();

                if (fechaVencimiento == "") return;

                string[] row = {numero, codSeg, emisor, fechaEmision, fechaVencimiento};
                dataGridView_Tarjetas.Rows.Add(row);
            }
            else
            {
                var mensaje = listaDeErrores2.Aggregate("Error en la validación de datos: ", (current, error) => current + ("\n" + error.Descripcion));
                Mensaje_Error(mensaje);
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

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox1);
        }

        private string calcularVencimiento()
        {
            string fecha = maskedTextBox1.Text;

            if (fecha.Length < 10)
                Mensaje_Error("Fecha inválida");
            else
                return fecha.Substring(0, 6) + (Convert.ToInt32(fecha.Substring(6, 4)) + 3).ToString();
            return "";
        }

        private void maskedTextBox_codigo_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox_codigo);
        }

        private void maskedTextBox_numeroTarjeta_Click(object sender, EventArgs e)
        {
            maskedStart(maskedTextBox_numeroTarjeta);
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            comboBox_Pais.ValueMember = "PAI_ID";
            comboBox_Pais.DisplayMember = "NOMBRE";
            comboBox_Pais.DataSource = DAOCuenta.getPaises();

            comboBox_Nacionalidad.ValueMember = "PAI_ID";
            comboBox_Nacionalidad.DisplayMember = "NOMBRE";
            comboBox_Nacionalidad.DataSource = DAOCuenta.getPaises();

            LimpiarCampos();
        }
    }
}