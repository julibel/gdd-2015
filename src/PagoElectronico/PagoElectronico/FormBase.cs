using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    public partial class FormBase : Form
    {
         void LimpiarCampos()
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                control.Text = "";
            }

        }
     
        public FormBase()
        {
            InitializeComponent();
        }

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        private bool puedeIngresar(int idFun)
        {
            return false; //Hardcodeo para poder seguir trabajando en lo demás

            if (Globals.tieneFuncionalidad(idFun))
            {
                MessageBox.Show("Tiene la funcionalidad");
                return false;
            }
            MessageBox.Show("No posee acceso a esta la funcionalidad");
            return true;
        }


        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(puedeIngresar(1)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Rol.Alta nuevo_form = new ABM_Rol.Alta();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(2)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Rol.Seleccion nuevo_form = new ABM_Rol.Seleccion(true);
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(3)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Rol.Seleccion nuevo_form = new ABM_Rol.Seleccion(false);
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(4)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cliente.Alta nuevo_form = new ABM_Cliente.Alta();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void bajaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(5)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cliente.Seleccion nuevo_form = new ABM_Cliente.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificacionToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(6)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cliente.Seleccion nuevo_form = new ABM_Cliente.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(7)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.Alta nuevo_form = new ABM_Cuenta.Alta();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void bajaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(8)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.Seleccion nuevo_form = new ABM_Cuenta.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificacionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(9)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.Seleccion nuevo_form = new ABM_Cuenta.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificarCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(10)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.ModificarTipoCuentas nuevo_form = new ABM_Cuenta.ModificarTipoCuentas();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void asociarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(11)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Tarjeta_Credito.Asociar nuevo_form = new Tarjeta_Credito.Asociar();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void crearDepositoDeDineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(12)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Depositos.DepositoNuevo nuevo_form = new Depositos.DepositoNuevo();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void retirarEfectivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(13)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Retiros.Retiro nuevo_form = new Retiros.Retiro();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void transferirEntreCuentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(14)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Transferencias.Transferencia nuevo_form = new Transferencias.Transferencia();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void facturarCostosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(15)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Facturacion.Facturar nuevo_form = new Facturacion.Facturar();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void consultaDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(16)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Consulta_Saldos.Seleccion nuevo_form = new Consulta_Saldos.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificarContraseniaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(17)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Modificar_contrasenia.ModificarContrasenia nuevo_form = new Modificar_contrasenia.ModificarContrasenia();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificarCategoriaDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(18)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.ModificarCategoriaCuenta nuevo_form = new ABM_Cuenta.ModificarCategoriaCuenta();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void listadoEstadisticoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(19)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Listados.ListadoEstadistico nuevo_form = new Listados.ListadoEstadistico();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desasociarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(20)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Tarjeta_Credito.Seleccion nuevo_form = new Tarjeta_Credito.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (puedeIngresar(21)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Tarjeta_Credito.Seleccion nuevo_form = new Tarjeta_Credito.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }
    }
}
