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
    public partial class Modificacion : FormBase
    {
        private Persona cliente;
        private List<int> tarjetasEliminadas = new List<int>();

        public override void mostrar(Form parent, params object[] values)
        {
            Persona cliente = (Persona)values[0];
            List<Tarjeta> tarjetas = (List<Tarjeta>)values[2];

            this.cliente = cliente;
            textBox_Calle.Text = cliente.Calle;
            textBox_Apellido.Text = cliente.Apellido;
            textBox_Depto.Text = cliente.Departamento;
            textBox_Documento.Text = cliente.Documento;
            dateTimePicker_FechaNacimiento.Text = cliente.FechaDeNacimiento.ToString();
            textBox_Localidad.Text = cliente.Localidad;
            textBox_Mail.Text = cliente.Mail;
            comboBox_Nacionalidad.Text = cliente.Pais_Nacionalidad;
            textBox_Nombre.Text = cliente.Nombre;
            comboBox_Pais.Text = cliente.Pais_Actual;
            textBox_Piso.Text = cliente.Piso.ToString();
            comboBox_Tipo_doc.SelectedIndex = cliente.TipoDoc - 1;
            checkBox_Estado.Checked = Convert.ToBoolean(cliente.Activo);

            if (checkBox_Estado.Checked) //Si está habilitado no permitir deshabilitar
            {
                checkBox_Estado.Visible = false;
                label2.Visible = false;
            }

            foreach (Tarjeta tarjeta in tarjetas)
            {
                string id = tarjeta.ID.ToString();
                string codSeg = tarjeta.cod_seguridad.ToString();
                string encriptado = "************";
                string codSegEnc = "***";
                string emisor = tarjeta.Emisor;
                string fechaEmision = tarjeta.Fecha_Emision;
                string fechaVencimiento = tarjeta.Fecha_Vencimiento;

                string[] row = {id, codSeg, encriptado, codSegEnc, emisor, fechaEmision, fechaVencimiento};
                dataGridView_Tarjetas.Rows.Add(row);
            }

            base.mostrar(parent);
        }


        public Modificacion()
        {
            InitializeComponent();
        }

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

        
        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            comboBox_Pais.ValueMember = "PAI_ID";
            comboBox_Pais.DisplayMember = "NOMBRE";
            comboBox_Pais.DataSource = DAOCuenta.getPaises();

            comboBox_Nacionalidad.ValueMember = "PAI_ID";
            comboBox_Nacionalidad.DisplayMember = "NOMBRE";
            comboBox_Nacionalidad.DataSource = DAOCuenta.getPaises();

            this.ActiveControl = textBox_Nombre;
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
            Mensaje_Error(mensaje);
            return false;
        }

        private Error ValidarDocumento()
        {
            if (DAOCliente.existeDni(textBox_Documento.Text, comboBox_Tipo_doc.SelectedIndex + 1) && textBox_Documento.Text != cliente.Documento)
            {
                 return new Error("El documento ingresado ya está asignado a un usuario registrado.");
            }
            else 
            {
                return null;
            }
        }

        private Error ValidarEmail()
        {
            if (DAOCliente.existeMail(textBox_Mail.Text) && textBox_Mail.Text != cliente.Mail)
            {
                return new Error("El email ingresado ya está asignado a un usuario registrado.");
            }
            else
            {
                return null;
            }
        }

        private Error ValidarDatosCompletos()
        {
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario.") : null;
        }

        private Error ValidarNum(string campo, string texto)
        {
            return (ValidarNumeros(texto)) ? new Error("El campo " + campo + " debe ser tipo numerico") : null;
        }

        private bool ValidarCamposCompletos()
        {
            bool vacio = false;

            foreach (var control in this.paner_Alta.Controls.OfType<TextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
            foreach (var control in this.paner_Alta.Controls.OfType<ComboBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }

            return vacio;

        }

        private bool ValidarNumeros(string texto)
        {
            return (!texto.All(char.IsDigit));
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cliente");
            if (resultado == DialogResult.Yes)
            {
                if (!Validaciones()) return;
                try
                {
                    DAOCliente.ModificarCliente(GenerarCliente(), cliente.ID);

                    //lista tarjeta
                    var lista_tarjetas = new List<Tarjeta>();

                    for (int i = 0; i < dataGridView_Tarjetas.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dataGridView_Tarjetas.Rows[i].Cells[0].Value) == 0)
                        {
                            MessageBox.Show(dataGridView_Tarjetas.Rows[i].Cells[0].Value.ToString());
                            lista_tarjetas.Add(GenerarTarjeta(dataGridView_Tarjetas.Rows[i]));
                        }
                    }


                    foreach (var tarjeta in lista_tarjetas)
                    {
                        DAOTarjeta.AgregarTarjeta(tarjeta, cliente.ID);
                    }

                    foreach (int idTarjeta in tarjetasEliminadas)
                    {
                        DAOTarjeta.BajarTarjeta(idTarjeta);
                    }

                    Mensaje_OK("Los datos han sido almacenados con éxito");
                }
                catch (Exception ex)
                {
                    Mensaje_Error("ERROR.-" + ex.Message);
                }
            }
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
                    textBox_Mail.Text,
                    Convert.ToInt32(checkBox_Estado.Checked)
                    );
        }

        private Tarjeta GenerarTarjeta(DataGridViewRow row)
        {
            return new Tarjeta(
                Convert.ToInt64(row.Cells["Numero"].Value),
                Convert.ToInt32(row.Cells["Codigo"].Value),
                Convert.ToString(row.Cells["Emisor"].Value),
                Convert.ToString(row.Cells["FechaEmision"].Value),
                Convert.ToString(row.Cells["FechaVencimiento"].Value)
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
                string id = "0";
                string ultimos4 = maskedTextBox_numeroTarjeta.Text.Substring(12, 4);
                string numero = maskedTextBox_numeroTarjeta.Text;
                string codSeg = maskedTextBox_codigo.Text;
                string emisor = Convert.ToString(comboBox_Emisor.Text);
                string fechaEmision = maskedTextBox1.Text;
                string fechaVencimiento = calcularVencimiento();

                string[] row = {id, ultimos4, numero, codSeg, emisor, fechaEmision, fechaVencimiento};
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

        private void dataGridView_Tarjetas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5) return;

            tarjetasEliminadas.Add(Convert.ToInt32(dataGridView_Tarjetas.Rows[e.RowIndex].Cells[0].Value));
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
