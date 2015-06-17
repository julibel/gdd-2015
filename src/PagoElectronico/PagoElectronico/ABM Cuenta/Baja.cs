using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class Baja : Form
    {
        private long cuenta;

        public Baja(long cuentaID)
        {
            InitializeComponent();
            cuenta = cuentaID;
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

        private void paner_DatosCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void Baja_Load(object sender, EventArgs e)
        {

        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea eliminar la Cuenta del sistema?", "Eliminar Cuenta");
            if (resultado == DialogResult.Yes)
            {






                Mensaje_OK("Los datos han sido eliminados con exito", "");
            }
        }
    }
}
