using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Facturacion
{
    public partial class Seleccionar_Operacion : Form
    {

        private Form caller;
        

        public Seleccionar_Operacion(Form caller)
        {
            InitializeComponent();
            this.caller = caller;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            var listaDeId = new List<int>();


            //caller.lista = listaDeId;
        }
    }
}
