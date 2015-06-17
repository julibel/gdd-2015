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
            string encriptado = Globals.getHashSHA1(numero.Substring(0,12));
            string limpio = numero.Substring(12,4);

            return executeProcedureWithReturnValue("GET_ID_TARJETA", encriptado, limpio, Globals.getHashSHA1(codSeg), Globals.getFechaSistema(), Globals.userID);
        }

        public static void AgregarTarjeta(Tarjeta tarjeta,int id)
        {

            //CREATE PROCEDURE BOBBY_TABLES.ASOCIAR_TARJETA(@NUMERO NUMERIC(16,0),@CLIENTE INT,@CODIGO_SEG NUMERIC(4,0),
            //@EMISOR VARCHAR(60),@FECHA_EMISION_APP VARCHAR(30)

            executeProcedure("ASOCIAR_TARJETA", 
                tarjeta.numero,
                id,
                tarjeta.cod_seguridad,
                tarjeta.Emisor,
                Globals.getFechaSistema(),
                Globals.getFechaSistema() 
                );
        }

        public static Tarjeta dataRowToTarjetas(DataRow tarjeta)
        {
            return new Tarjeta(
                Convert.ToInt32(tarjeta["TAR_ID"]),
               Convert.ToInt32(tarjeta["CLIENTE"]),
               Convert.ToInt32(tarjeta["LIMPIO"]),
               tarjeta["EMISOR"] as string
               );
        }

        public static void BajarTarjeta(int idTarjeta)
        {
            executeProcedure("DESASOCIAR_TARJETA", idTarjeta);
        }

        public static int getClienteId(int idUsuario)
        {
            return executeProcedureWithReturnValue("GET_CLIENTE_ID", idUsuario);
        }
    }
}
