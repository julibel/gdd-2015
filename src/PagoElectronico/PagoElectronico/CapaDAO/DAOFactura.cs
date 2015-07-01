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
            return DAOCuenta.deshabilitarCuenta(cuenta);
        }

        public static int habilitarCuenta(long cuenta)
        {
            return DAOCuenta.habilitarCuenta(cuenta);
        }

        public static object getComisionesID(List<int> comisionesID)
        {
            return retrieveDataTable("GET_COMISIONES_ID", Globals.intsToDataTable(comisionesID));
        }

        public static long crearFactura(List<int> comisionesID, string numeroTarjeta)
        {
            return executeProcedureWithLongReturnValue("CREAR_FACTURA", Globals.intsToDataTable(comisionesID), Globals.getDateFechaSistema(), Encriptacion.getSHA1(numeroTarjeta));
        }

        public static bool tieneImpagas(long cuenta)
        {
            return checkIfExists("GET_COMISIONES_CUENTA", cuenta);
        }
    }
}
