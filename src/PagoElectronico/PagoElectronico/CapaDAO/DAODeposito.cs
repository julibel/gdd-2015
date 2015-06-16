using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAODeposito:SqlConnector
    {
        public static DataTable getCuentas()
        {
            return retrieveDataTable("GET_CUENTAS_USUARIO", Globals.userID);
        }

        public static DataTable getMonedas()
        {
            return retrieveDataTable("GET_MONEDAS");
        }

        public static void realizarDeposito(long cuenta, int tarjeta, double importe, int moneda)
        {
            executeProcedure("DEPOSITAR", cuenta, tarjeta, importe, moneda, Globals.getFechaSistema());
        }
    }
}
