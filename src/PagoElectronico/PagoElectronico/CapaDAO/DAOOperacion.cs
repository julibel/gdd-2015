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

    }
}
