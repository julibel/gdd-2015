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

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Rol.Alta nuevo_form = new ABM_Rol.Alta();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Rol.Seleccion nuevo_form = new ABM_Rol.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Rol.Seleccion nuevo_form = new ABM_Rol.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cliente.Alta nuevo_form = new ABM_Cliente.Alta();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void bajaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cliente.Seleccion nuevo_form = new ABM_Cliente.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificacionToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cliente.Seleccion nuevo_form = new ABM_Cliente.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.Alta nuevo_form = new ABM_Cuenta.Alta();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void bajaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.Seleccion nuevo_form = new ABM_Cuenta.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificacionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.Seleccion nuevo_form = new ABM_Cuenta.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificarCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.ModificarTipoCuentas nuevo_form = new ABM_Cuenta.ModificarTipoCuentas();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void asociarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearDepositoDeDineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Depositos.DepositoNuevo nuevo_form = new Depositos.DepositoNuevo();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void retirarEfectivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Retiros.Retiro nuevo_form = new Retiros.Retiro();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void transferirEntreCuentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Transferencias.Transferencia nuevo_form = new Transferencias.Transferencia();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void facturarCostosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Facturacion.Facturar nuevo_form = new Facturacion.Facturar();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void consultaDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Consulta_Saldos.Seleccion nuevo_form = new Consulta_Saldos.Seleccion();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificarContraseniaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Modificar_contrasenia.ModificarContrasenia nuevo_form = new Modificar_contrasenia.ModificarContrasenia();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void modificarCategoriaDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.ModificarCategoriaCuenta nuevo_form = new ABM_Cuenta.ModificarCategoriaCuenta();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void listadoEstadisticoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Listados.ListadoEstadistico nuevo_form = new Listados.ListadoEstadistico();
            nuevo_form.MdiParent = this;
            nuevo_form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
