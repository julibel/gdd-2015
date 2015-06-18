using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Login
{
    public partial class Autentificar : Form
    {
        private int rolID;

        public Autentificar(string user, int rolID)
        {
            InitializeComponent();
            textBox_Username.Text = user;
            textBox_PreguntaSecreta.Text = CapaDAO.DAOLogin.getPregunta(user);
            this.rolID = rolID;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_IniciarSesion_Click(object sender, EventArgs e)
        {
            if(CapaDAO.DAOLogin.iniciarSesionConRespuesta(textBox_Username.Text, rolID, textBox_RespuestaSecreta.Text))
            {
                new MenuPrincipal().Show();
                this.Close();
            }
            else
                MessageBox.Show("Respuesta incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox_RespuestaSecreta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button_IniciarSesion_Click(sender, e);
        }
    }
}
