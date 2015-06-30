using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAORetiro:DAOOperacion
    {
        public static DataTable getBancos()
        {
            return retrieveDataTable("GET_BANCOS");
        }

        public static string realizarRetiro(long cuenta, DateTime fecha, double importe, int moneda, string banco, string acreedor)
        {
            if (acreedor == " ") 
                acreedor = "Al portador";
            if (saldoSuficiente(cuenta, importe))
                return Convert.ToString(executeProcedureWithReturnValue("RETIRAR_EFECTIVO", cuenta, fecha, importe, moneda, banco, acreedor));
            else
                return "s";
        }

    }
}
