﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

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

        private bool ValidarNumeros()
        {
            return (!(textBox_Piso.Text.All(char.IsDigit) && textBox_Documento.Text.All(char.IsDigit)));
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
                   // DAOCliente.AgregarCliente(GenerarCliente());
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
            if (ValidarPiso() != null) listaDeErrores.Add(ValidarPiso());

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarDocumento()
        {
            //return DAOCliente.existeDni(tbDni.Text, cbTipoDoc.SelectedIndex + 1) ? new Error("El documento ingresado ya está asignado a un usuario registrado.") : null;
            return null;
        }

        private Error ValidarEmail()
        {
            //return DAOCliente.existeTelefono(tbTelefono.Text) ? new Error("El email ingresado ya está asignado a un usuario registrado.") : null;
            return null;
        }

        private Error ValidarDatosCompletos()
        {
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario."): null;
        }

        private Error ValidarPiso()
        {
            return (ValidarNumeros()) ? new Error("El campo Documento y el campo Piso deben ser un numeros") : null;
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
                    (int)(comboBox_Pais.SelectedIndex +1),
                    dateTimePicker_FechaNacimiento.Value,
                    (int)(comboBox_Nacionalidad.SelectedIndex +1),
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
