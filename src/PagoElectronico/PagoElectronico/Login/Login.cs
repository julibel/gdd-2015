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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    MessageBox.Show("El usuario no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingrese el usuario y el rol antes de continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_IniciarSesion_Click(object sender, EventArgs e)
        {
            string user = textBox_Username.Text;
            if (!CapaDAO.DAOLogin.existeUsuario(user))
            {
                MessageBox.Show("El usuario no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CapaDAO.DAOLogin.iniciarSesionConPassword(user, Convert.ToInt32(comboBox_Roles.SelectedValue), textBox_password.Text))
            {
                this.Close();
            }
            else
                MessageBox.Show("Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            DataTable roles = CapaDAO.DAOLogin.getRolesUsuario(textBox_Username.Text);

            comboBox_Roles.ValueMember = "ROL_ID";
            comboBox_Roles.DisplayMember = "NOMBRE";
            comboBox_Roles.DataSource = roles;
        }
    }
}
