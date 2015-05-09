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
        public Baja()
        {
            InitializeComponent();
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
            // message box 
            const string mensaje = "¿Está seguro que desea eliminar la Cuenta del sistema?";
            const string resumen = "Eliminando Cuenta";

            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
        }
    }
}
