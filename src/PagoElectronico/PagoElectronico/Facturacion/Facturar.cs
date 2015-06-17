using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.Facturacion
{
    public partial class Facturar : Form
    {
        private Seleccionar_Operacion seleccionar;

        public Facturar()
        {
            InitializeComponent();
           
        }
        private DialogResult Mensaje_Pregunta(String mensaje, String resumen)
        {
            var resultado = MessageBox.Show(mensaje, resumen, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;

        }
        private void Mensaje_OK(String mensaje, String resumen)
        {
            MessageBox.Show(mensaje, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones()) return;
            if (textBox_Numero.Text != "A generar")
            {
                MessageBox.Show("Limpie los datos de la última operación", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            var resultado = Mensaje_Pregunta("¿Esta seguro que desea guardar los datos ingresados en el formulario?", "Guardar Cliente");
            if (resultado == DialogResult.Yes)
            {
                if (!Validaciones()) return;
                try
                {
                    int num_factura =0;
                    //dao que devuelvafacura

                    textBox_Numero.Text = Convert.ToString(num_factura);
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

           
            if (ValidarDatosCompletos() != null) listaDeErrores.Add(ValidarDatosCompletos());
            if (ValidarLong() != null) listaDeErrores.Add(ValidarLong());

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarLong()
        {
            return (ValidarLongitud()) ? new Error("Debe ingresar un numero de tarjeta de 16 digitos") : null;
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

        private Error ValidarDatosCompletos()
        {
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario.") : null;
        }
        private bool ValidarCamposCompletos()
        {
            bool vacio = false;

            foreach (var control in this.groupBox3.Controls.OfType<TextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
            foreach (var control in this.groupBox2.Controls.OfType<TextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
            foreach (var control in this.groupBox2.Controls.OfType<RadioButton>())
            {
                if (control.Text == String.Empty) vacio = true;
            }
            foreach (var control in this.groupBox2.Controls.OfType<MaskedTextBox>())
            {
                if (control.Text == String.Empty) vacio = true;
            }

            return vacio;

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox3.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox2.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox2.Controls.OfType<RadioButton>()) control.Checked = false;
            foreach (var control in this.groupBox2.Controls.OfType<MaskedTextBox>()) control.Clear();
            foreach (var control in this.groupBox1.Controls.OfType<TextBox>()) control.Text = "";
            textBox_Numero.Text = "A generar";
            dataGridView_ComisionesARendir.Rows.Clear();
           
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            textBox_Fecha.Text = Globals.getFechaSistema();
        }

        private void button_Seleccion_Click(object sender, EventArgs e)
        {
            seleccionar = new Seleccionar_Operacion(this);

            seleccionar.MdiParent = this.MdiParent;

            this.Visible = false;
            seleccionar.Show();
           
        }

    }
}
