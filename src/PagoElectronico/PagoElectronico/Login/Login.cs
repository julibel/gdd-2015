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
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_OlvidoContrasenia_Click(object sender, EventArgs e)
        {
            string user = textBox_Username.Text;
            int rol = Convert.ToInt32(comboBox_Roles.SelectedValue);

            if (user != "" || rol <= 0)
            {
                if (CapaDAO.DAOLogin.existeUsuario(user))
                {
                    Autentificar autentificar = new Autentificar(user, rol);
                    autentificar.MdiParent = this.MdiParent;
                    autentificar.Show();
                    this.Close();
                }
                else
                    Mensaje_Error("El usuario no existe");
            }
            else
                Mensaje_Error("Ingrese el usuario y el rol antes de continuar");
        }

        private void button_IniciarSesion_Click(object sender, EventArgs e)
        {
            string user = textBox_Username.Text;
            if (!DAOLogin.existeUsuario(user))
            {
                Mensaje_Error("El usuario no existe");
                return;
            }

            if (comboBox_Roles.SelectedIndex == -1)
            {
                Mensaje_Error("No se seleccionó rol");
                return;
            }

            if (DAOLogin.iniciarSesionConPassword(user, Convert.ToInt32(comboBox_Roles.SelectedValue), textBox_password.Text))
            {
                MenuPrincipal.showControls();
                DAOCuenta.deshabilitarCuentasPorVigencia();
                this.Close();
            }
            else
                Mensaje_Error("Contraseña incorrecta");
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            DataTable roles = DAOLogin.getRolesUsuario(textBox_Username.Text);

            comboBox_Roles.ValueMember = "ROL_ID";
            comboBox_Roles.DisplayMember = "NOMBRE";
            comboBox_Roles.DataSource = roles;
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button_IniciarSesion_Click(sender, e);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_Username;
        }
    }
}
