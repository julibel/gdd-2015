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

namespace PagoElectronico.Login
{
    public partial class Autentificar : FormBase
    {
        private int rolID;

        public Autentificar(string user, int rolID)
        {
            InitializeComponent();
            textBox_Username.Text = user;
            textBox_PreguntaSecreta.Text = DAOLogin.getPregunta(user);
            if (textBox_PreguntaSecreta.Text == "")
            {
                textBox_RespuestaSecreta.Enabled = false;
                button_IniciarSesion.Hide();
            }
            else
            {
                
                this.ActiveControl = textBox_RespuestaSecreta;
            }
            this.rolID = rolID;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_IniciarSesion_Click(object sender, EventArgs e)
        {
            if(DAOLogin.iniciarSesionConRespuesta(textBox_Username.Text, rolID, textBox_RespuestaSecreta.Text))
            {
                MenuPrincipal.showControls();
                this.Close();
            }
            else
                Mensaje_Error("Respuesta incorrecta");
        }

        private void textBox_RespuestaSecreta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button_IniciarSesion_Click(sender, e);
        }

        private void Autentificar_Load(object sender, EventArgs e)
        {

        }
    }
}
