using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            // message box 
            const string mensaje = "¿Está seguro que desea eliminar al Cliente del sistema?";
            const string resumen = "Eliminando Cliente";

            var resultado = MessageBox.Show(mensaje, resumen,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


        }
    }
}
