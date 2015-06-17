using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.CapaDAO
{
    class DAOCuenta:SqlConnector
    {
        public static void agregarCuenta(int cliente, string pais, int moneda, int tipo)
        {
            executeProcedure("AGREGAR_CUENTA", cliente, moneda, pais, tipo, Globals.getFechaSistema());
        }

        public static void modificarCuenta(long id, int cliente, int moneda, int pais, int tipo_cuenta, int estado)
        {
            executeProcedure("MODIFICAR_CUENTA", id, cliente, moneda, pais, tipo_cuenta, estado, Globals.getFechaSistema());
        }

        public static void modificarCostosTipo(int idTipo, double costoMant, double costoTransf, int vigencia)
        {
            executeProcedure("MODIFICAR_COSTOS_TIPO", idTipo, costoMant, costoTransf,vigencia);
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

        public static DataTable getEstadosCuenta()
        {
            return retrieveDataTable("GET_ESTADOS");
        }
    }
}
