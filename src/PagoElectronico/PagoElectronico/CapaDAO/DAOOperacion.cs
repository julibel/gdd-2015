using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Model;

namespace PagoElectronico.CapaDAO
{
    class DAOOperacion:SqlConnector
    {
        public static DataTable getCuentas()
        {
            return getCuentasPorEstado(0);
        }

        private static DataTable getCuentasPorEstado(int estado)
        {
            return retrieveDataTable("GET_CUENTAS_USUARIO", Globals.userID, estado);
        }

        public static DataTable getCuentasHabilitadas()
        {
            return getCuentasPorEstado((int)EstadoCuenta.Habilitada);
        }

        public static DataTable getMonedas()
        {
            return retrieveDataTable("GET_MONEDAS");
        }

        public static bool saldoSuficiente(long cuenta, double importe)
        {
            return getSaldo(cuenta) >= importe;
        }

        public static double getSaldo(long cuenta)
        {
            return Convert.ToDouble(retrieveDataTable("GET_SALDO", cuenta).Rows[0][0]);
        }

    }
}
