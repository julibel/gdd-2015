using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;
using System.Data;

namespace PagoElectronico.CapaDAO
{
    class DAOCuenta:SqlConnector
    {
        public static void agregarCuenta(Cuenta cuenta)
        {
            executeProcedure("AGREGAR_CUENTA", cuenta.ID_Usuario, cuenta.Moneda, cuenta.Pais, cuenta.TipoCuenta);
        }

        public static void modificarCuenta(int id, int id_usuario, int moneda, int pais, int tipo_cuenta)
        {
            executeProcedure("MODIFICAR_CUENTA", id, id_usuario, moneda, pais, tipo_cuenta);
        }

        public static void modificarTipoCuenta(int id, int costo)
        {
            executeProcedure("MODIFICAR_COSTOS_TIPO", id, costo);
        }

        public static void bajaCuenta(int numero, int pais, int moneda, int tipoCuenta)
        {
            executeProcedure("BAJA_CUENTA", numero, pais, moneda, tipoCuenta);
        }

        public static void modificarCategoriaCuenta(int numero, int pais, int tipoCuenta)
        {
            executeProcedure("MODIFICAR_CATERGORIA_CUENTA", numero, pais, tipoCuenta);
        }

        public static object getTiposCuenta()
        {
            return retrieveDataTable("GET_TIPOS_CUENTA");
        }

        public static object getCuentas(string numero, string pais, int tipo)
        {
            return retrieveDataTable("FIND_CUENTAS", numero, pais, tipo);
        }

        public static DataTable getCuenta(long cuenta)
        {
            return retrieveDataTable("GET_CUENTA", cuenta);
        }

        public static object getPaises()
        {
            return retrieveDataTable("GET_PAISES");
        }

        public static object getMonedas()
        {
            return DAOOperacion.getMonedas();
        }

        public static void eliminarCuenta(long cuenta)
        {
            executeProcedure("BAJA_CUENTA", cuenta, Globals.getFechaSistema());
        }
    }
}
