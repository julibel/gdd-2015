using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.CapaDAO
{
    class DAOCuenta:SqlConnector
    {
        public static long agregarCuenta(int cliente, string pais, int moneda, int tipo)
        {
            return executeProcedureWithLongReturnValue("AGREGAR_CUENTA", cliente, moneda, pais, tipo, Globals.getFechaSistema());
        }

        public static void modificarCuenta(long id, int cliente, int moneda, int pais, int tipo_cuenta, int estado)
        {
            executeProcedure("MODIFICAR_CUENTA", id, cliente, moneda, pais, tipo_cuenta, estado, Globals.getFechaSistema());
        }

        public static void modificarCostosTipo(int idTipo, double costoMant, double costoTransf, int vigencia)
        {
            executeProcedure("MODIFICAR_COSTOS_TIPO", idTipo, costoMant, costoTransf,vigencia);
        }

        public static void eliminarCuenta(long cuenta)
        {
            executeProcedure("BAJA_CUENTA", cuenta, Globals.getFechaSistema());
        }

        public static void modificarTipoCuenta(long numero, int tipo, int periodos)
        {
            executeProcedure("MODIFICAR_TIPO_CUENTA", numero, tipo, periodos, Globals.getFechaSistema());
        }

        public static int deshabilitarCuenta(long cuenta)
        {
            return cambiarEstadoCuenta(cuenta, (int)EstadoCuenta.Deshabilitada);
        }

        public static int habilitarCuenta(long cuenta)
        {
            return cambiarEstadoCuenta(cuenta, (int)EstadoCuenta.Habilitada);
        }

        public static int cambiarEstadoCuenta(long cuenta, int estado)
        {
            return executeProcedureWithReturnValue("MODIFICAR_ESTADO_CUENTA", cuenta, estado);
        }

        public static DataTable getCostoTipo(int id)
        {
            return retrieveDataTable("GET_COSTOS_TIPO",id);
        }

        public static object getTiposCuenta()
        {
            return retrieveDataTable("GET_TIPOS_CUENTA");
        }

        public static DataTable getCuenta(long cuenta)
        {
            return retrieveDataTable("GET_CUENTA", cuenta);
        }

        public static DataTable getPaises()
        {
            return retrieveDataTable("GET_PAISES");
        }

        public static DataTable getMonedas()
        {
            return DAOOperacion.getMonedas();
        }

        public static DataTable getEstadosCuenta()
        {
            return retrieveDataTable("GET_ESTADOS");
        }

        public static object getCuentas(string numero, string pais, int tipo, List<int> estados)
        {   
            return retrieveDataTable("FIND_CUENTAS", numero, pais, tipo, Globals.intsToDataTable(estados));
        }

        public static bool tieneDeudas(long cuenta)
        {
            return checkIfExists("GET_COMISIONES_CUENTA", cuenta);
        }

        public static void deshabilitarCuentasPorVigencia()
        {
            DataTable cuentas = DAOOperacion.getCuentas();

            foreach (DataRow cuenta in cuentas.Rows)
                if ((DateTime)cuenta["FECHA_EXPIRACION"] < Convert.ToDateTime(Globals.getFechaSistema()))
                {
                    long cuentaID = Convert.ToInt64(cuenta["CUE_ID"]);
                    if (deshabilitarCuenta(cuentaID) == 0)
                        MessageBox.Show("La cuenta " + cuentaID.ToString() + " se ha deshabilitado porque se superó la fecha de expiración. Para habilitarla nuevamente realice un cambio de categoría y abone los gastos necesarios", "Expiración Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
