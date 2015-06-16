using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAODeposito:DAOOperacion
    {
        public static void realizarDeposito(long cuenta, int tarjeta, double importe, int moneda)
        {
            executeProcedure("DEPOSITAR", cuenta, tarjeta, importe, moneda, Globals.getFechaSistema());
        }

        public static DataTable getTarjetas()
        {
            return retrieveDataTable("GET_TARJETAS", Globals.userID, Globals.getFechaSistema());
        }
    }
}
