using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAOOperacion:SqlConnector
    {
        public static DataTable getCuentas()
        {
            return retrieveDataTable("GET_CUENTAS_USUARIO", Globals.userID);
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
