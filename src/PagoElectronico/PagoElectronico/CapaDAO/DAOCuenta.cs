using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;

namespace PagoElectronico.CapaDAO
{
    class DAOCuenta:SqlConnector
    {
        public static void agregarCuenta(Cuenta cuenta)
        {
            executeProcedure("agregarCuenta", cuenta.ID_Usuario, cuenta.Moneda, cuenta.Pais, cuenta.TipoCuenta);
        }

        public static void modificarCuenta(int id, int id_usuario, int moneda, int pais, int tipo_cuenta)
        {
            executeProcedure("modificarCuenta", id, id_usuario, moneda, pais, tipo_cuenta);
        }

        public static void modificarTipoCuenta(int id, int costo)
        {
            executeProcedure("modificarTipoCuenta", id, costo);
        }

        public static void bajaCuenta(int numero, int pais, int moneda, int tipoCuenta)
        {
            executeProcedure("BAJA_CUENTA", numero, pais, moneda, tipoCuenta);
        }

        public static void modificarCategoriaCuenta(int numero, int pais, int tipoCuenta)
        {
            executeProcedure("MODIFICAR_CATERGORIA_CUENTA", numero, pais, tipoCuenta);
        }
    }
}
