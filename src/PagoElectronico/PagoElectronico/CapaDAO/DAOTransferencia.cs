using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.CapaDAO
{
    class DAOTransferencia:DAOOperacion
    {

        public static string realizarTransferencia(long origen, long destino, string fecha, double importe, int moneda)
        {
            if (saldoSuficiente(origen, importe))
            {
                executeProcedure("TRASNFERIR", origen, destino, fecha, importe, moneda);
                return "";
            }
            else
                return "s";
        }
    }
}
