using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Model
{
    public class FormBase : Form
    {
        //MENSAJES GENÉRICOS
        public void Mensaje_OK(String mensaje, String resumen)
        {
            MessageBox.Show(mensaje, resumen, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void Mensaje_OK(String mensaje)
        {
            Mensaje_OK(mensaje, "");
        }

        public void Mensaje_Error(String mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult Mensaje_Pregunta(String mensaje, String resumen)
        {
            var resultado = MessageBox.Show(mensaje, resumen, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;
        }

        //MOSTRAR
        public virtual void mostrar(Form parent, params object [] values)
        {
            this.MdiParent = parent;
            this.Show();
        }
    }
}
