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

        public static void modificarCuenta(long id, int cliente, int moneda, int pais, int tipo_cuenta, int estado)
        {
            executeProcedure("MODIFICAR_CUENTA", id, cliente, moneda, pais, tipo_cuenta, estado, Globals.getFechaSistema());
        }

        public static void modificarCostosTipo(int idTipo, double costoMant, double costoTransf)
        {
            executeProcedure("MODIFICAR_COSTOS_TIPO", idTipo, costoMant, costoTransf,10);
        }

        public static void bajaCuenta(long numero, int pais, int moneda, int tipoCuenta)
        {
            executeProcedure("BAJA_CUENTA", numero, pais, moneda, tipoCuenta);
        }

        public static void modificarTipoCuenta(long numero, int tipo)
        {
            executeProcedure("MODIFICAR_TIPO_CUENTA", numero, tipo, Globals.getFechaSistema());
        }

        public static DataTable getCostoTipo(int id)
        {
            return retrieveDataTable("GET_COSTOS_TIPO",id);
        }

        public static object getTiposCuenta()
        {
            return retrieveDataTable("GET_TIPOS_CUENTA");
        }


        public static object getCuentas(string numero, string pais, int tipo, bool esBaja)
        {
            int est = 0;
            if (esBaja)
                est = 1;

            return retrieveDataTable("FIND_CUENTAS", numero, pais, tipo, est);
        }

        public static DataTable getCuenta(long cuenta)
        {
            return retrieveDataTable("GET_CUENTA", cuenta);
        }

        public static DataTable getPaises()
        {
            return retrieveDataTable("GET_PAISES");
        }

        public static DataTable getMonedas()
        {
            return DAOOperacion.getMonedas();
        }

        public static void eliminarCuenta(long cuenta)
        {
            executeProcedure("BAJA_CUENTA", cuenta, Globals.getFechaSistema());
        }

        internal static DataTable getEstadosCuenta()
        {
            return retrieveDataTable("GET_ESTADOS");
        }
    }
}
