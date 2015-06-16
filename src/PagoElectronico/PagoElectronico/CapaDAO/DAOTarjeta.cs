using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.CapaDAO
{
    class DAOTarjeta:SqlConnector
    {
        public static int getID(string numero, string codSeg)
        {
            string encriptado = Globals.getHashSHA1(numero.Substring(0,12));
            string limpio = numero.Substring(12,4);

            return executeProcedureWithReturnValue("GET_ID_TARJETA", encriptado, limpio, Globals.getHashSHA1(codSeg));
        }
    }
}
