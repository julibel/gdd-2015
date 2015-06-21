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

namespace PagoElectronico.Facturacion
{
    public partial class Seleccionar_Operacion : FormBase
    {

        private FormBase caller;

        public Seleccionar_Operacion(FormBase caller)
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

            foreach (DataGridViewRow row in dataGridView_ListadoOperaciones.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                    listaDeId.Add(Convert.ToInt32(row.Cells["ID"].Value));
            }

            caller.mostrar(this.MdiParent, listaDeId);
            this.Close();
        }

        private void setDataGrid()
        {
            foreach (DataGridViewColumn columna in dataGridView_ListadoOperaciones.Columns)
                columna.ReadOnly = true;

            dataGridView_ListadoOperaciones.Columns["Seleccionar"].ReadOnly = false;
        }

        private void Seleccionar_Operacion_Load(object sender, EventArgs e)
        {
            dataGridView_ListadoOperaciones.DataSource = DAOFactura.getComisiones();

            revisarCuentas();

            setDataGrid();
        }

        private void revisarCuentas()
        {
            DataTable cuentasUsuario = DAOOperacion.getCuentas();

            foreach (DataRow cuentaRow in cuentasUsuario.Rows)
            {
                string cuenta = cuentaRow["CUE_ID"].ToString();
                if (contarImpagas(cuenta) > 5)
                {
                    if (DAOFactura.deshabilitarCuenta(Convert.ToInt64(cuenta)) == 0)
                        Mensaje_Error("Se superaron las 5 comisiones, se inhabilitará la cuenta: " + cuenta + ". Para darla de alta abone los costos adeudados", "Comisiones máximas superadas");
                }
            }
        }

        private int contarImpagas(string cuenta)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView_ListadoOperaciones.Rows)
            {
                string cuentaCom = row.Cells["Cuenta"].Value.ToString();
                if (cuentaCom == cuenta) count += 1;
            }
            return count;
        }
    }
}
