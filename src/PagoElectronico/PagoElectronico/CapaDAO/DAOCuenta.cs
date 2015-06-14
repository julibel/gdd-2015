using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.CapaDAO
{
    class DAOCuenta:SqlConnector
    {
        public static void agregarCuenta(int id_usuario, int moneda, int pais, int tipo_cuenta)
        {
            executeProcedure("agregarCuenta", id_usuario, moneda, pais, tipo_cuenta);
        }

        public static void modificarTipoCuenta(int id, int costo)
        {
            executeProcedure("modificarTipoCuenta", id, costo);
        }
    }
}
