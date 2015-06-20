using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico;
using PagoElectronico.Model;

namespace PagoElectronico
{
    public partial class MenuPrincipal : FormBase
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();

            login.MdiParent = this;
            login.Show();
        }

        private bool noPuedeIngresar(int idFun)
        {
            if (!puedeIngresar(idFun))
            {
                Mensaje_Error("No posee acceso a esta funcionalidad", "Funcionalidad inaccesible");
                return true;
            }
            else
                return false;
        }

        private bool puedeIngresar(int idFun)
        {
            if (Globals.tieneFuncionalidad(idFun))
            {
                return true;//Puede acceder
            }
            return false;
        }


        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(noPuedeIngresar(1)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Rol.Alta nuevo_form = new ABM_Rol.Alta();
            nuevo_form.mostrar(this);
            
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(2)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Rol.Seleccion nuevo_form = new ABM_Rol.Seleccion(new ABM_Rol.Baja());
            nuevo_form.mostrar(this);
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(3)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Rol.Seleccion nuevo_form = new ABM_Rol.Seleccion(new ABM_Rol.Modificacion());
            nuevo_form.mostrar(this); 
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(4)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cliente.Alta nuevo_form = new ABM_Cliente.Alta();
            nuevo_form.mostrar(this);
        }

        private void bajaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(5)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cliente.Seleccion nuevo_form = new ABM_Cliente.Seleccion(new ABM_Cliente.Baja(), 1);
            nuevo_form.mostrar(this);
        }

        private void modificacionToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(6)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cliente.Seleccion nuevo_form = new ABM_Cliente.Seleccion(new ABM_Cliente.Modificacion(), 0);
            nuevo_form.mostrar(this);
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(7)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.Alta nuevo_form = new ABM_Cuenta.Alta();
            nuevo_form.mostrar(this);
        }

        private void bajaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(8)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.Seleccion nuevo_form = new ABM_Cuenta.Seleccion(new ABM_Cuenta.Baja(), 1);
            nuevo_form.mostrar(this);
        }

        private void modificacionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(9)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.Seleccion nuevo_form = new ABM_Cuenta.Seleccion(new ABM_Cuenta.Modificacion(), 0);
            nuevo_form.mostrar(this);
        }

        private void modificarCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(10)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.ModificarTipoCuentas nuevo_form = new ABM_Cuenta.ModificarTipoCuentas();
            nuevo_form.mostrar(this);
        }

        private void asociarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(11)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Tarjeta_Credito.Asociar nuevo_form = new Tarjeta_Credito.Asociar();
            nuevo_form.mostrar(this);
        }

        private void crearDepositoDeDineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(14)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Depositos.DepositoNuevo nuevo_form = new Depositos.DepositoNuevo();
            nuevo_form.mostrar(this);
        }

        private void retirarEfectivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(15)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Retiros.Retiro nuevo_form = new Retiros.Retiro();
            nuevo_form.mostrar(this);
        }

        private void transferirEntreCuentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(16)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Transferencias.Transferencia nuevo_form = new Transferencias.Transferencia();
            nuevo_form.mostrar(this);
        }

        private void facturarCostosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(17)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Facturacion.Facturar nuevo_form = new Facturacion.Facturar();
            nuevo_form.mostrar(this);
        }

        private void consultaDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBase nuevo_form = null;
            if (!puedeIngresar(18) && puedeIngresar(22))
            {
                nuevo_form = new Consulta_Saldos.Seleccion();
            }
            else if (!puedeIngresar(22) && puedeIngresar(18))
            {
                nuevo_form = new Consulta_Saldos.SeleccionCliente();
            }
            if (nuevo_form == null)
            {
                noPuedeIngresar(18);
                return;
            }
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            nuevo_form.mostrar(this);
        }

        private void modificarContraseniaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(19)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Modificar_contrasenia.ModificarContrasenia nuevo_form = new Modificar_contrasenia.ModificarContrasenia();
            nuevo_form.mostrar(this);
        }

        private void modificarCategoriaDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(20)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ABM_Cuenta.ModificarCategoriaCuenta nuevo_form = new ABM_Cuenta.ModificarCategoriaCuenta();
            nuevo_form.mostrar(this);
        }

        private void listadoEstadisticoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(21)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Listados.ListadoEstadistico nuevo_form = new Listados.ListadoEstadistico();
            nuevo_form.mostrar(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desasociarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(12)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Tarjeta_Credito.Seleccion nuevo_form = new Tarjeta_Credito.Seleccion();
            nuevo_form.mostrar(this);
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(13)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Tarjeta_Credito.Seleccion nuevo_form = new Tarjeta_Credito.Seleccion();
            nuevo_form.mostrar(this);
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.userID == 0)
            {
                Mensaje_Error("¡Todavía no inicio sesión!");
                return;
            }
            var mensaje = Mensaje_Pregunta("¿Desea cerrar la sesión actual: " + Globals.username + "?", "Cerrar sesión");
            if (mensaje == DialogResult.No) return;
            
            Globals.cerrarSesion();
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Login.Login login = new Login.Login();
            login.MdiParent = this;
            login.Show();
        }
    }
}
