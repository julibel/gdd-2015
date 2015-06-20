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

        public static void AgregarTarjeta(Tarjeta tarjeta, int id)
        {
            executeProcedure("ASOCIAR_TARJETA",
                tarjeta.numero,
                id,
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

        public static void BajarTarjeta(int idTarjeta)
        {
            executeProcedure("DESASOCIAR_TARJETA", idTarjeta);
        }

        public static int getClienteId()
        {
            return executeProcedureWithReturnValue("GET_CLIENTE_ID", Globals.userID);
        }
    }
}
