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

        public static void deshabilitarCuenta(long cuenta)
        {
            cambiarEstadoCuenta(cuenta, (int)EstadoCuenta.Deshabilitada);
        }
        public static void habilitarCuenta(long cuenta)
        {
            cambiarEstadoCuenta(cuenta, (int)EstadoCuenta.Habilitada);
        }

        public static void cambiarEstadoCuenta(long cuenta, int estado)
        {
            executeProcedure("MODIFICAR_ESTADO_CUENTA", cuenta, estado);
        }

        public static object getComisionesID(List<int> comisionesID)
        {
            return retrieveDataTable("GET_COMISIONES_ID", Globals.intsToDataTable(comisionesID));
        }
    }
}
