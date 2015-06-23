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

namespace PagoElectronico.Facturacion
{
    public partial class Facturar : FormBase
    {
        private bool open = false;

        private List<int> comisionesID;

        public override void mostrar(Form parent, params object[] values)
        {
            if (open)
            {
                comisionesID = (List<int>)values[0];
                dataGridView_ComisionesARendir.DataSource = DAOFactura.getComisionesID(comisionesID);
                setTotal();
                this.Visible = true;
            }
            else
                base.mostrar(parent);

        }

        private void setTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView_ComisionesARendir.Rows)
            {
                total += Convert.ToDouble(row.Cells["Importe"].Value);
            }

            textBox_montoTotal.Text = total.ToString();
        }

        public Facturar()
        {
            InitializeComponent();
           
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
                Mensaje_Error("Limpie los datos de la última operación");
                return;
            }

            var resultado = Mensaje_Pregunta("¿Está seguro que desea realizar el pago?", "Generar Factura");
            if (resultado == DialogResult.Yes)
            {
                if (!Validaciones()) return;
                try
                {
                    long numFactura = DAOFactura.crearFactura(comisionesID, maskedTextBox_numeroTarjeta.Text, Convert.ToDouble(textBox_montoTotal.Text));
                    textBox_Numero.Text = Convert.ToString(numFactura);
                    revisarCuentas();
                    Mensaje_OK("Los datos han sido almacenados con éxito");
                }
                catch (Exception ex)
                {
                    Mensaje_Error("ERROR: " + ex.Message);
                }
            }

        }

        private void revisarCuentas()
        {
            foreach (DataGridViewRow comisionRow in dataGridView_ComisionesARendir.Rows)
            {
                long cuenta = Convert.ToInt64(comisionRow.Cells["Cuenta"].Value);
                if (!DAOFactura.tieneImpagas(cuenta))
                {
                    if (DAOFactura.habilitarCuenta(Convert.ToInt64(cuenta)) == 0)
                        Mensaje_OK("Se abonaron todas las comisiones adeudadas, se habilitará la cuenta: " + cuenta, "Comisiones abonadas");
                }
            }
        }

        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

           
            if (ValidarDatosCompletos() != null) listaDeErrores.Add(ValidarDatosCompletos());
            if (ValidarLong() != null) listaDeErrores.Add(ValidarLong());

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validación de datos: ", (current, error) => current + ("\n" + error.Descripcion));
            Mensaje_Error(mensaje);
            return false;
        }

        private Error ValidarLong()
        {
            return (ValidarLongitud()) ? new Error("Debe ingresar un número de tarjeta de 16 dígitos") : null;
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
            return (ValidarCamposCompletos()) ? new Error("Complete todos los campos del formulario: ") : null;
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
            if (this.groupBox2.Controls.OfType<RadioButton>().All(radio => radio.Checked == false))
                vacio = true;
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
            foreach (var panel in this.Controls.OfType<GroupBox>())
            {
                foreach (var control in panel.Controls.OfType<TextBox>()) control.Text = "";
                foreach (var control in panel.Controls.OfType<RadioButton>()) control.Checked = false;
                foreach (var control in panel.Controls.OfType<MaskedTextBox>()) control.Clear();
            }
            dataGridView_ComisionesARendir.DataSource = new DataTable();
            textBox_Numero.Text = "A generar";
            textBox_Fecha.Text = Globals.getFechaSistema();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            open = true;
            LimpiarCampos();
        }

        private void button_Seleccion_Click(object sender, EventArgs e)
        {
            if (textBox_Numero.Text != "A generar")
            {
                Mensaje_Error("Limpie los datos de la última operación");
                return;
            }

            Seleccionar_Operacion seleccionar = new Seleccionar_Operacion(this);
            this.Visible = false;
            seleccionar.mostrar(this.MdiParent);
        }

    }
}
