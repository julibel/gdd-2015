using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAOFactura : SqlConnector
    {
        public static DataTable getComisiones()
        {
            return retrieveDataTable("COMISIONES_USUARIO", Globals.userID);
        }
    }
}
