using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Model;


namespace PagoElectronico.CapaDAO
{
    class DAOTarjeta:SqlConnector
    {
        public static int getID(string numero, string codSeg)
        {
            string encriptado = Encriptacion.getSHA1(numero.Substring(0,12));
            string limpio = numero.Substring(12,4);

            return executeProcedureWithReturnValue("GET_ID_TARJETA", encriptado, limpio, Encriptacion.getSHA1(codSeg), Globals.getFechaSistema(), Globals.userID);
        }

        public static void asociarTarjeta(Tarjeta tarjeta, int idCli)
        {
            executeProcedure("ASOCIAR_TARJETA",
                tarjeta.numero,
                idCli,
                tarjeta.titular,
                tarjeta.cod_seguridad,
                tarjeta.Emisor,
                tarjeta.Fecha_Emision,
                tarjeta.Fecha_Vencimiento
                );
        }


        public static Tarjeta dataRowToTarjetas(DataRow tarjeta)
        {
            string fechaEmision = Convert.ToString(tarjeta["FECHA_EMISION"]).Substring(0,10);
            string fechaVencimiento = Convert.ToString(tarjeta["FECHA_VENCIMIENTO"]).Substring(0, 10);
            return new Tarjeta(
                Convert.ToInt32(tarjeta["TAR_ID"]),
               Convert.ToInt32(tarjeta["CLIENTE"]),
               Convert.ToInt32(tarjeta["NUMERO_TARJETA"].ToString().Substring(12, 4)),
               tarjeta["NOMBRE"] as string,
               fechaEmision,
               fechaVencimiento
               );
        }

        public static void desasociarTarjeta(int idTarjeta)
        {
            executeProcedure("DESASOCIAR_TARJETA", idTarjeta);
        }

        private static DataTable getTarjetas(byte estado)
        {//0 deshabilitado, 1 habilitado, 2 ambos
            return retrieveDataTable("GET_TARJETAS", Globals.userID, Globals.getFechaSistema(), estado);
        }

        public static DataTable getTarjetasHabilitadas()
        {
            return getTarjetas(1);
        }

        public static DataTable getAllTarjetas()
        {
            return getTarjetas(2);
        }

        public static bool coincideTarjeta(int tarID, string numero, string codSeg)
        {
            string ultimos = numero.Substring(12, 4);
            string primeros = numero.Substring(0, 12);

            return checkIfExists("COINCIDE_TARJETA", tarID, Encriptacion.getSHA1(primeros), ultimos, Encriptacion.getSHA1(codSeg));
        }

        public static Tarjeta getTarjeta(int idTarjeta)
        {
            DataTable tarjData = retrieveDataTable("GET_TARJETA", idTarjeta);
            Tarjeta tarjeta = new Tarjeta();
            tarjeta.ID = idTarjeta;
            tarjeta.titular = tarjData.Rows[0]["TITULAR"].ToString();
            tarjeta.Emisor = tarjData.Rows[0]["NOMBRE"].ToString();
            tarjeta.estado = Convert.ToBoolean(tarjData.Rows[0]["ESTADO"]);
            tarjeta.Fecha_Emision = tarjData.Rows[0]["FECHA_EMISION"].ToString();
            tarjeta.Fecha_Vencimiento = tarjData.Rows[0]["FECHA_VENCIMIENTO"].ToString().Substring(0,10);
            return tarjeta;
        }

        public static object getEmisores()
        {
            return retrieveDataTable("GET_EMISORES");
        }

        public static void modificarTarjeta(int tarID, string numero, string titular, string codSeg, string emisor, string fechaEmision, string fechaVencimiento, bool estado)
        {
            executeProcedure("MODIFICAR_TARJETA", tarID, numero, titular, codSeg, emisor, fechaEmision, fechaVencimiento, Convert.ToInt32(estado));
        }
    }
}
