using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Model;

namespace PagoElectronico.CapaDAO
{
    class DAOFactura : SqlConnector
    {
        public static DataTable getComisiones()
        {
            return retrieveDataTable("COMISIONES_USUARIO", Globals.userID);
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

        public static object getComisionesID(List<int> comisionesID)
        {
            return retrieveDataTable("GET_COMISIONES_ID", Globals.intsToDataTable(comisionesID));
        }
    }
}
