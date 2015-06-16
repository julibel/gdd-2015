using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAODeposito:SqlConnector
    {
        internal static DataTable getCuentas()
        {
            return retrieveDataTable("GET_CUENTAS_USUARIO", Globals.userID);
        }

        internal static DataTable getMonedas()
        {
            return retrieveDataTable("GET_MONEDAS");
        }
    }
}
