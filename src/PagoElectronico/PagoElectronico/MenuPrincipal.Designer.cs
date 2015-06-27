namespace PagoElectronico
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaRol = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaRol = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionRol = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCostosCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetaDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociarTarjeta = new System.Windows.Forms.ToolStripMenuItem();
            this.desasociarTarjeta = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTarjeta = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deposito = new System.Windows.Forms.ToolStripMenuItem();
            this.retiroEfectivo = new System.Windows.Forms.ToolStripMenuItem();
            this.transferencia = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaSaldo = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionContrasenia = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionCategoriaCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadistico = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.cuentaToolStripMenuItem,
            this.tarjetaDeCreditoToolStripMenuItem,
            this.operacionToolStripMenuItem,
            this.consultaDeSaldoToolStripMenuItem,
            this.listadoEstadistico,
            this.cerrarSesion,
            this.salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaRol,
            this.bajaRol,
            this.modificacionRol});
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.rolToolStripMenuItem.Text = "Rol";
            // 
            // altaRol
            // 
            this.altaRol.Name = "altaRol";
            this.altaRol.Size = new System.Drawing.Size(152, 22);
            this.altaRol.Text = "Alta";
            this.altaRol.Click += new System.EventHandler(this.altaToolStripMenuItem2_Click);
            // 
            // bajaRol
            // 
            this.bajaRol.Name = "bajaRol";
            this.bajaRol.Size = new System.Drawing.Size(152, 22);
            this.bajaRol.Text = "Baja";
            this.bajaRol.Click += new System.EventHandler(this.bajaToolStripMenuItem2_Click);
            // 
            // modificacionRol
            // 
            this.modificacionRol.Name = "modificacionRol";
            this.modificacionRol.Size = new System.Drawing.Size(152, 22);
            this.modificacionRol.Text = "Modificación";
            this.modificacionRol.Click += new System.EventHandler(this.modificacionToolStripMenuItem2_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCliente,
            this.bajaCliente,
            this.modificacionCliente});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // altaCliente
            // 
            this.altaCliente.Name = "altaCliente";
            this.altaCliente.Size = new System.Drawing.Size(152, 22);
            this.altaCliente.Text = "Alta";
            this.altaCliente.Click += new System.EventHandler(this.altaToolStripMenuItem4_Click);
            // 
            // bajaCliente
            // 
            this.bajaCliente.Name = "bajaCliente";
            this.bajaCliente.Size = new System.Drawing.Size(152, 22);
            this.bajaCliente.Text = "Baja";
            this.bajaCliente.Click += new System.EventHandler(this.bajaToolStripMenuItem4_Click);
            // 
            // modificacionCliente
            // 
            this.modificacionCliente.Name = "modificacionCliente";
            this.modificacionCliente.Size = new System.Drawing.Size(152, 22);
            this.modificacionCliente.Text = "Modificación";
            this.modificacionCliente.Click += new System.EventHandler(this.modificacionToolStripMenuItem4_Click);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCuenta,
            this.bajaCuenta,
            this.modificacionCuenta,
            this.tipoDeCuentas});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // altaCuenta
            // 
            this.altaCuenta.Name = "altaCuenta";
            this.altaCuenta.Size = new System.Drawing.Size(158, 22);
            this.altaCuenta.Text = "Alta";
            this.altaCuenta.Click += new System.EventHandler(this.altaToolStripMenuItem5_Click);
            // 
            // bajaCuenta
            // 
            this.bajaCuenta.Name = "bajaCuenta";
            this.bajaCuenta.Size = new System.Drawing.Size(158, 22);
            this.bajaCuenta.Text = "Baja";
            this.bajaCuenta.Click += new System.EventHandler(this.bajaToolStripMenuItem5_Click);
            // 
            // modificacionCuenta
            // 
            this.modificacionCuenta.Name = "modificacionCuenta";
            this.modificacionCuenta.Size = new System.Drawing.Size(158, 22);
            this.modificacionCuenta.Text = "Modificación";
            this.modificacionCuenta.Click += new System.EventHandler(this.modificacionToolStripMenuItem5_Click);
            // 
            // tipoDeCuentas
            // 
            this.tipoDeCuentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarCostosCuenta});
            this.tipoDeCuentas.Name = "tipoDeCuentas";
            this.tipoDeCuentas.Size = new System.Drawing.Size(158, 22);
            this.tipoDeCuentas.Text = "Tipo de cuentas";
            // 
            // modificarCostosCuenta
            // 
            this.modificarCostosCuenta.Name = "modificarCostosCuenta";
            this.modificarCostosCuenta.Size = new System.Drawing.Size(162, 22);
            this.modificarCostosCuenta.Text = "Modificar costos";
            this.modificarCostosCuenta.Click += new System.EventHandler(this.modificarCostosToolStripMenuItem_Click);
            // 
            // tarjetaDeCreditoToolStripMenuItem
            // 
            this.tarjetaDeCreditoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asociarTarjeta,
            this.desasociarTarjeta,
            this.modificarTarjeta});
            this.tarjetaDeCreditoToolStripMenuItem.Name = "tarjetaDeCreditoToolStripMenuItem";
            this.tarjetaDeCreditoToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.tarjetaDeCreditoToolStripMenuItem.Text = "Tarjeta de crédito";
            // 
            // asociarTarjeta
            // 
            this.asociarTarjeta.Name = "asociarTarjeta";
            this.asociarTarjeta.Size = new System.Drawing.Size(157, 22);
            this.asociarTarjeta.Text = "Asociar";
            this.asociarTarjeta.Click += new System.EventHandler(this.asociarToolStripMenuItem_Click);
            // 
            // desasociarTarjeta
            // 
            this.desasociarTarjeta.Name = "desasociarTarjeta";
            this.desasociarTarjeta.Size = new System.Drawing.Size(157, 22);
            this.desasociarTarjeta.Text = "Desasociar";
            this.desasociarTarjeta.Click += new System.EventHandler(this.desasociarToolStripMenuItem_Click);
            // 
            // modificarTarjeta
            // 
            this.modificarTarjeta.Name = "modificarTarjeta";
            this.modificarTarjeta.Size = new System.Drawing.Size(157, 22);
            this.modificarTarjeta.Text = "Modificar datos";
            this.modificarTarjeta.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // operacionToolStripMenuItem
            // 
            this.operacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deposito,
            this.retiroEfectivo,
            this.transferencia,
            this.facturacion});
            this.operacionToolStripMenuItem.Name = "operacionToolStripMenuItem";
            this.operacionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.operacionToolStripMenuItem.Text = "Operación";
            // 
            // deposito
            // 
            this.deposito.Name = "deposito";
            this.deposito.Size = new System.Drawing.Size(154, 22);
            this.deposito.Text = "Depósito";
            this.deposito.Click += new System.EventHandler(this.crearDepositoDeDineroToolStripMenuItem_Click);
            // 
            // retiroEfectivo
            // 
            this.retiroEfectivo.Name = "retiroEfectivo";
            this.retiroEfectivo.Size = new System.Drawing.Size(154, 22);
            this.retiroEfectivo.Text = "Retirar efectivo";
            this.retiroEfectivo.Click += new System.EventHandler(this.retirarEfectivoToolStripMenuItem1_Click);
            // 
            // transferencia
            // 
            this.transferencia.Name = "transferencia";
            this.transferencia.Size = new System.Drawing.Size(154, 22);
            this.transferencia.Text = "Transferencia";
            this.transferencia.Click += new System.EventHandler(this.transferirEntreCuentasToolStripMenuItem1_Click);
            // 
            // facturacion
            // 
            this.facturacion.Name = "facturacion";
            this.facturacion.Size = new System.Drawing.Size(154, 22);
            this.facturacion.Text = "Facturar costos";
            this.facturacion.Click += new System.EventHandler(this.facturarCostosToolStripMenuItem1_Click);
            // 
            // consultaDeSaldoToolStripMenuItem
            // 
            this.consultaDeSaldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaSaldo,
            this.modificacionContrasenia,
            this.modificacionCategoriaCuenta});
            this.consultaDeSaldoToolStripMenuItem.Name = "consultaDeSaldoToolStripMenuItem";
            this.consultaDeSaldoToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.consultaDeSaldoToolStripMenuItem.Text = "Administrar cuenta";
            // 
            // consultaSaldo
            // 
            this.consultaSaldo.Name = "consultaSaldo";
            this.consultaSaldo.Size = new System.Drawing.Size(232, 22);
            this.consultaSaldo.Text = "Consultar saldos";
            this.consultaSaldo.Click += new System.EventHandler(this.consultaDeSaldosToolStripMenuItem_Click);
            // 
            // modificacionContrasenia
            // 
            this.modificacionContrasenia.Name = "modificacionContrasenia";
            this.modificacionContrasenia.Size = new System.Drawing.Size(232, 22);
            this.modificacionContrasenia.Text = "Modificar contraseña ";
            this.modificacionContrasenia.Click += new System.EventHandler(this.modificarContraseniaToolStripMenuItem1_Click);
            // 
            // modificacionCategoriaCuenta
            // 
            this.modificacionCategoriaCuenta.Name = "modificacionCategoriaCuenta";
            this.modificacionCategoriaCuenta.Size = new System.Drawing.Size(232, 22);
            this.modificacionCategoriaCuenta.Text = "Modificar categoría de cuenta";
            this.modificacionCategoriaCuenta.Click += new System.EventHandler(this.modificarCategoriaDeCuentasToolStripMenuItem_Click);
            // 
            // listadoEstadistico
            // 
            this.listadoEstadistico.Name = "listadoEstadistico";
            this.listadoEstadistico.Size = new System.Drawing.Size(116, 20);
            this.listadoEstadistico.Text = "Listado estadístico";
            this.listadoEstadistico.Click += new System.EventHandler(this.listadoEstadisticoToolStripMenuItem1_Click);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesion.Text = "Cerrar sesión";
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(41, 20);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(839, 492);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Electronico";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaRol;
        private System.Windows.Forms.ToolStripMenuItem bajaRol;
        private System.Windows.Forms.ToolStripMenuItem modificacionRol;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaCliente;
        private System.Windows.Forms.ToolStripMenuItem bajaCliente;
        private System.Windows.Forms.ToolStripMenuItem modificacionCliente;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaCuenta;
        private System.Windows.Forms.ToolStripMenuItem bajaCuenta;
        private System.Windows.Forms.ToolStripMenuItem modificacionCuenta;
        private System.Windows.Forms.ToolStripMenuItem tarjetaDeCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociarTarjeta;
        private System.Windows.Forms.ToolStripMenuItem desasociarTarjeta;
        private System.Windows.Forms.ToolStripMenuItem modificarTarjeta;
        private System.Windows.Forms.ToolStripMenuItem operacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deposito;
        private System.Windows.Forms.ToolStripMenuItem retiroEfectivo;
        private System.Windows.Forms.ToolStripMenuItem transferencia;
        private System.Windows.Forms.ToolStripMenuItem facturacion;
        private System.Windows.Forms.ToolStripMenuItem consultaDeSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadistico;
        private System.Windows.Forms.ToolStripMenuItem consultaSaldo;
        private System.Windows.Forms.ToolStripMenuItem modificacionContrasenia;
        private System.Windows.Forms.ToolStripMenuItem modificacionCategoriaCuenta;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCuentas;
        private System.Windows.Forms.ToolStripMenuItem modificarCostosCuenta;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem salir;


    }
}

